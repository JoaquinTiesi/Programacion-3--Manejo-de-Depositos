using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Prog_3
{
    public partial class Usuarios : Form
    {
        private Form FrmPrincipal;
        public Usuarios(Form FrmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            nUsuario.Text = "";
            nContrasenia.Text = "";
        }

        private void btnCargarUsuario_Click(object sender, EventArgs e) //Llamado a la base de datos para agregar nuevos usuarios
        {
            DatosUsuariosEntities nu = new DatosUsuariosEntities();
            AdminLogin UsuarioNuevo = new AdminLogin();
            UsuarioNuevo.identificacion = nUsuario.Text;
            UsuarioNuevo.contrasenia = nContrasenia.Text;
            nu.AdminLogin.Add(UsuarioNuevo);
            nu.SaveChanges();
            MessageBox.Show("Nuevo usuario creado!");
            nUsuario.Text = "";
            nContrasenia.Text = "";
        }
    }
}
