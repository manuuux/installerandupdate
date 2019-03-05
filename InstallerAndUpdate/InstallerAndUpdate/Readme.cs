using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallerAndUpdate
{
    public partial class Readme : Form
    {
        public Readme()
        {
            InitializeComponent();
        }
        public string TextBoxText
        {
            get { return ReadmeTxt.Text; }
            set { ReadmeTxt.Text = value; }
        }
        private void Readme_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();
        }
    }
}
