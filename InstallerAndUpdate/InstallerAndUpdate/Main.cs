using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;

namespace InstallerAndUpdate
{
    public partial class Main : Form
    {
        Readme readme = new Readme();
        public Resultados respuesta = new Resultados();
        private string baseurl = "http://localhost/installandupdate/";
        private string urlconfig = "config.json";
        private string json = "";
        private WebClient wc = new WebClient();
        private BackgroundWorker Downloader;

        public Main()
        {
            InitializeComponent();
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
            TimerLoader.Start();
            TimerAccept.Start();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            showreadme();
            TimerLoader.Stop();
        }

        private void showreadme()
        {
            TimerLoader.Stop();
            try
            {
                json = wc.DownloadString(baseurl+urlconfig);
                respuesta = JsonConvert.DeserializeObject<Resultados>(json);
                loadertxt.Text = respuesta.configuracion.version;
                readme.TextBoxText = respuesta.configuracion.readme;
                readme.Show();
            }
            catch (Exception error)
            {
                
                if (DialogResult.Yes == MessageBox.Show("Ocurrio un error al momento de descargar el archivo de configuracion\n" + error.Message + "\n\n Reintentar?", "Reintentar", MessageBoxButtons.YesNo))
                {
                    showreadme();
                }else
                {
                    Close();
                }
            }
        }

        private void TimerAccept_Tick(object sender, EventArgs e)
        {
            if (readme.aceptar)
            {
                TimerAccept.Stop();
                download();
            }
        }
        private void download()
        {
            foreach (Filename file in respuesta.filename)
            {
                Uri URI = new Uri(baseurl + file.url, UriKind.Absolute);
                string path = AppDomain.CurrentDomain.BaseDirectory + file.path + "\\";
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                if (File.Exists(path + file.archivo))
                {
                    if(Checksum(path + file.archivo) != file.checksum)
                    {
                        File.Delete(path + file.archivo);
                        wc.DownloadFile(URI, path + file.archivo);
                    }
                }else
                {
                    wc.DownloadFile(URI, path + file.archivo);
                }
                
            }
        }
        private string Checksum(string archivo)
        {
            HashAlgorithm aloritmo = new SHA1CryptoServiceProvider();
            string result = string.Empty;
            using (FileStream fs = File.OpenRead(archivo))
            {
                result = BitConverter.ToString(aloritmo.ComputeHash(fs)).ToLower().Replace("-", "");
            }
            return result;
        }

    }
}
