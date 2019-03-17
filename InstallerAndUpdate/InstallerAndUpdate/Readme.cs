using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstallerAndUpdate
{
    public partial class Readme : Form
    {
        private bool aceptarvar = false;

        public Readme()
        {
            InitializeComponent();
        }
        public string TextBoxText
        {
            get { return ReadmeTxt.Text; }
            set { ReadmeTxt.Text = value; }
        }
        public bool aceptar
        {
            get { return aceptarvar; }
            set { aceptarvar = value; }
        }
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            aceptar = true;
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea cancelar la operacion", "Cancelar instalacion", MessageBoxButtons.YesNo))
            {
                Environment.Exit(1);
            }
        }
    }
}
