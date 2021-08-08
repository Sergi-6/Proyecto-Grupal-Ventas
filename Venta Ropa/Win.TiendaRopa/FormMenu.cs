using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaRopa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: " + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Caja")
                {
                    productosToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = false;
                    nuevaventaToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    administraciondeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeProductosToolStripMenuItem.Visible = false;
                    reporteDeClientesToolStripMenuItem.Visible = false;
                    reporteDeVentasToolStripMenuItem.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;   
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Venta")
                {
                    productosToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = true;
                    nuevaventaToolStripMenuItem.Visible = false;
                    facturasToolStripMenuItem.Visible = false;
                    administraciondeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeProductosToolStripMenuItem.Visible = false;
                    reporteDeClientesToolStripMenuItem.Visible = true;
                    reporteDeVentasToolStripMenuItem.Visible = false;
                    reporteDeFacturasToolStripMenuItem.Visible = false;
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
                {
                    productosToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    nuevaventaToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    administraciondeUsuariosToolStripMenuItem.Visible = true;
                    reporteDeProductosToolStripMenuItem.Visible = true;
                    reporteDeClientesToolStripMenuItem.Visible = true;
                    reporteDeVentasToolStripMenuItem.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void nuevaventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNuevaventa = new FormNuevaventa();
            formNuevaventa.MdiParent = this;
            formNuevaventa.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
       {
           //Login();
       }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void AdministraciondeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();
        }
    }
}
