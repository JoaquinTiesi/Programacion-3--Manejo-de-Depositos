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
    public partial class IngresoMercaderia : Form
    {
        private Form FrmPrincipal;
        public IngresoMercaderia(Form FrmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (CodigoBarras.Text == "" || Descripcion.Text == "" || Peso.Text == "" || Alto.Text == "" || Largo.Text == "" || Ancho.Text == "")
            {
                MessageBox.Show("Por favor, ingrese todos los campos.");
            }
            else
            {
                Mercaderia nuevoIngreso = new Mercaderia(alto: Convert.ToInt32(Alto.Text), largo: Convert.ToInt32(Largo.Text), ancho: Convert.ToInt32(Ancho.Text), descripcion: Descripcion.Text, peso: Convert.ToInt32(Peso.Text), fechaIngreso: new DateTime(), codigoBarras: CodigoBarras.Text);

                Deposito depositoSeleccionado = (Deposito)ComboDeposito.SelectedItem;

                List<string> mercaderiaIngresada = depositoSeleccionado.IngresarMercaderia(ingreso: nuevoIngreso);

                if (mercaderiaIngresada.Count() == 0)
                {
                    MessageBox.Show("El depósito no puede albergar la mercadería!");
                }
                else
                {
                    string mensajeSalida = "La mercadería fue ingresada satisfactoriamente en los siguientes sectores: ";

                    foreach (string s in mercaderiaIngresada)
                    {
                        mensajeSalida += s + " ";
                    }

                    MessageBox.Show(mensajeSalida);
                }
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CodigoBarras.Text = "";
            Descripcion.Text = "";
            Peso.Text = "";
            Alto.Text = "";
            Largo.Text = "";
            Ancho.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CodigoBarras.Text = "";
            Descripcion.Text = "";
            Peso.Text = "";
            Alto.Text = "";
            Largo.Text = "";
            Ancho.Text = "";
            this.Hide();
            FrmPrincipal.Show();
        }

        private void RecargarListaDepositos()
        {
            List<Deposito> listaDepositos;
            listaDepositos = Program.getSistema().ListaDepositos();

            BindingSource binding = new BindingSource();
            binding.DataSource = listaDepositos;
            ComboDeposito.DataSource = null;
            ComboDeposito.Items.Clear();
            ComboDeposito.DataSource = binding.DataSource;
            ComboDeposito.DisplayMember = "getStringListaDescripcion";
            ComboDeposito.ValueMember = "getDeposito";
        }

        private void ComboDeposito_VisibleChanged(object sender, EventArgs e)
        {
            this.RecargarListaDepositos();
        }

        private void IngresoMercaderia_Load(object sender, EventArgs e)
        {

        }
    }
}
