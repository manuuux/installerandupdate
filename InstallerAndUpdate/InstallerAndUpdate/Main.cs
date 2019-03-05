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
        public Resultados respuesta = new Resultados();

        public Main()
        {
            InitializeComponent();
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
            var url = "http://localhost/installandupdate/config.json";
            var json = "";
           
            WebClient wc = new WebClient();
            try {
                json = wc.DownloadString(url);
                respuesta = JsonConvert.DeserializeObject<Resultados>(json);
                loadertxt.Text = respuesta.configuracion.version;
                Readme readme = new Readme();
                readme.TextBoxText = respuesta.configuracion.readme;
                readme.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error al momento de descargar el archivo de configuracion\n" + error.Message);
                Close();
            }
            
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
