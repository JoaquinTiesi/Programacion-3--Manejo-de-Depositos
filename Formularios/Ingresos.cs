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

    public partial class Ingresos : Form
    {
        private Principal FrmPrincipal;
        public Ingresos()
        {
            InitializeComponent();
            FrmPrincipal = new Principal(this);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Indentificacion.Text = "";
            Contrasenia.Text = "";
        }

        private void Ingreso_Click(object sender, EventArgs e) //Verificacion de Usuarios por medio de la base de datos
        {
            DatosUsuariosEntities context = new DatosUsuariosEntities();
            if(Indentificacion.Text!=string.Empty || Contrasenia.Text != string.Empty)
            {
                var iden = context.AdminLogin.Where(a => a.identificacion.Equals(Indentificacion.Text)).FirstOrDefault();
                if (iden != null)
                {
                    if (iden.contrasenia.Equals(Contrasenia.Text))
                    {
                        Indentificacion.Text = "";
                        Contrasenia.Text = "";
                        this.Hide();
                        FrmPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
