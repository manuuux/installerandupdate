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

namespace InstallerAndUpdate
{
    public partial class Main : Form
    {
        Readme readme = new Readme();
        public Resultados respuesta = new Resultados();
        private string url = "http://localhost/installandupdate/config.json";
        private string json = "";
        private WebClient wc = new WebClient();

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
                json = wc.DownloadString(url);
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
                MessageBox.Show("win");
            }
        }
        
    }
}
