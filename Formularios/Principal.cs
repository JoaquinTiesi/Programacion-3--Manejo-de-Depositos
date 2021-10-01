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
    public partial class Principal : Form
    {
        private Form FrmIngresos;
        private Form FrmIngresoMercaderia;
        private Form FrmEgresoMercaderia;
        private Form FrmDepositos;
        private Form FrmBusqueda;
        private Form FrmUsuarios;
        public Principal(Form FrmIngresos) //Inicializacion de formularios
        {
            InitializeComponent();
            this.FrmIngresos = FrmIngresos;
            FrmIngresoMercaderia = new IngresoMercaderia(this);
            FrmEgresoMercaderia = new EgresoMercaderia(this);
            FrmDepositos = new Depositos(this);
            FrmBusqueda = new Busqueda(this);
            FrmUsuarios = new Usuarios(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIngresos.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIngresoMercaderia.Show();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEgresoMercaderia.Show();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDepositos.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusqueda.Show();
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuarios.Show();
        }
    }
}
