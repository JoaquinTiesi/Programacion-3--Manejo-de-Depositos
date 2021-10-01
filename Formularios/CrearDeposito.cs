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
    public partial class CrearDeposito : Form
    {
        private Form FrmDepositos;
        public CrearDeposito(Form depositos)
        {
            InitializeComponent();
            this.FrmDepositos = depositos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(boxAlto.Text=="" || boxAncho.Text=="" || boxLargo.Text == "" || DescripcionDeposito.Text=="")
            {
                MessageBox.Show("Por favor, ingrese todos los campos.");
            }
            else
            {
                string descripcion = DescripcionDeposito.Text;
                int alto = int.Parse(boxAlto.Text);
                int ancho = int.Parse(boxAncho.Text);
                int largo = int.Parse(boxLargo.Text);
                Program.getSistema().CrearDeposito(descripcion, alto, ancho, largo); //se crea y guarda el nuevo deposito
                DescripcionDeposito.Text = "";
                boxAlto.Text = "";
                boxLargo.Text = "";
                boxAncho.Text = "";
                MessageBox.Show("Deposito creado con exito!");
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDepositos.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DescripcionDeposito.Text = "";
            boxAlto.Text = "";
            boxLargo.Text = "";
            boxAncho.Text = "";
        }
    }
}
