using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurApp.Views
{
    public partial class CtlCargaInfo : UserControl
    {
        public CtlCargaInfo()
        {
            InitializeComponent();
        }

        private void CtlCargaInfo_Load(object sender, EventArgs e)
        {

        }
        
        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { this.lblEtiqueta.Text = value; }
        }
        public string Texto { get {
            return this.txtTexto.Text;
        }
            set {
                this.txtTexto.Text = value;
            }
        }

    }
}
