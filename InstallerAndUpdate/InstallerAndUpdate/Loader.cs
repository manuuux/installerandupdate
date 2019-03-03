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
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            var url = "http://localhost/installandupdate/config.json";
            var json = "";
           
            WebClient wc = new WebClient();
            try {
                json = wc.DownloadString(url);
                var respuesta = JsonConvert.DeserializeObject<Resultados>(json);
                loadertxt.Text = respuesta.configuracion.imagen;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                Close();
            }
            
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
