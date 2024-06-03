using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using Npgsql; // Libreria para conectar con PostgreSQL
using TurApp.db; // incluir libreria para poder acceder a los objetos de negocios.

namespace TurApp.Views
{    
    public partial class MainView : FormBase
    {
        private Usuario _usuarioActual = null;
        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowUsuario()
        {
            _usuarioActual = Usuario.UsuarioSys;
            StatusInfoUser.Text = String.Format("Usuario: {0} - {1}", _usuarioActual.UsuarioName, _usuarioActual.FechaLogin); ;
            // mostrar los permisos del usuario en base a los roles, leer cada permiso.
            // Recorrer cada item de Menu, para verificar primero los grupos  y luego cada opcion.
            var list = this.menuStrip1.Items.Cast < ToolStripMenuItem>().ToList().Where(t=> t.Name.IndexOf("mnu_top") != -1);
            List<Funcion> listFuncUser = UsuarioActual.ListadoFunciones;
            bool prmOK=false;
            foreach (var item in list)
	        {
                // verificar el permiso puede incluir listado hacer split.
                prmOK = false;
                string perm = item.Tag.ToString();
                string[] listFunciones = perm.Split(',');
                for (int i = 0; i < listFunciones.Length; i++)
                {
                    prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFunciones[i])!=null;
                }
                item.Enabled = prmOK;
                //por cada ItemPrincipal, verificar los SubItems por debajo si tiene permiso.

                var list_subitm = item.DropDownItems.Cast<ToolStripMenuItem>().ToList();
                                
                foreach (var subitm in list_subitm)
                {
                    prmOK = false;
                    string permsub = subitm.Tag.ToString();
                    string[] listFuncionesSub = permsub.Split(',');
                    for (int i = 0; i < listFuncionesSub.Length; i++)
                    {
                        prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFuncionesSub[i]) != null;
                    }                    
                    subitm.Enabled = prmOK;
                }
            }
            // aplicar permiso a cada submenu.
            
            this.Visible = true;
        }
        private static readonly MainView instance = new MainView();
        static MainView()
        {
            
        }
        private MainView()
        {
            InitializeComponent();
        }
        // Implementacion de Patron Singleton
        public static MainView Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMain(FrmLogin loginFrm, Usuario user)
        {
            loginFrm.Dispose();
            loginFrm= null;
            _usuarioActual = user;
            this.Show();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin;
            if (_usuarioActual == null)
            {
                this.Visible = false;
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (_usuarioActual == null)
                {
                    Application.Exit();
                    return;
                }
                this.Visible = true;
            }
        }

        private void IngresoEspecialidadMnu_Click(object sender, EventArgs e)
        {
            
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente " , "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje,"Error...",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }             

        private void IngresoTuristaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTuristaAM frm = new FrmTuristaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoTurista(this);
        }

        private void BuscarTuristaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTuristaBusq frm = new FrmTuristaBusq();
            frm.ShowBuscar();
        }

        private void ListadoTuristaMnu_Click(object sender, EventArgs e)
        {
            FrmListadoTuristas frmListPac = new FrmListadoTuristas();
            frmListPac.Show();
        }

        private void ListadoAgencias_Click(object sender, EventArgs e)
        {
            //FrmListadoAgencias frm = new FrmListadoAgencias();
            //frm.Show();
        }

        private void IngresoAgencia_Click(object sender, EventArgs e)
        {
            FrmAgenciaAM frm = new FrmAgenciaAM();
            frm.ShowIngresoAgencia();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenciaBusq frmba = new FrmAgenciaBusq();
            frmba.ShowBuscar();
        }

        
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "salida..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
                return;
            }
            e.Cancel = true;
        }

        private void ActividadAM_mnu_Click(object sender, EventArgs e)
        {
            //new FrmActividad().Show();
        }

        private void Turistas_mnu_top_Click(object sender, EventArgs e)
        {

        }       
        
    }
}
