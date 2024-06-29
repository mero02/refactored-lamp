using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views
{
    public partial class FrmAcercaDe : FormBase
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            string textoAcercaDe = "Acerca de Grupo 4\n\n" +
                                   "TurGest es un software de gestión integral para empresas de turismo.\n\n" +
                                   "Versión: 1.0\n\n" +
                                   "Desarrollado por:\n" +
                                   "- Gonzalo Bustamante\n" +
                                   "- Carolina López Delgado\n" +
                                   "- Agustín Porello\n" +
                                   "- Maximiliano Ruiz\n" +
                                   "- Mauro San Pedro\n\n" +
                                   "© 2024 Equipo TurGest. Todos los derechos reservados.\n\n" +
                                   "Para más información o soporte, contacte a nuestro equipo de desarrollo.";
            textBoxAcercaDe.Text = textoAcercaDe;
            textBoxAcercaDe.ReadOnly = true;
            textBoxAcercaDe.Multiline = true;
        }
    }
}
