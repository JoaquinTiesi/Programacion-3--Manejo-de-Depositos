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
    public partial class Busqueda : Form
    {
        private Form FrmPrincipal;
        public Busqueda(Form FrmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CodigoBarrasBusqueda.Text = "";
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

        private void Busqueda_Load(object sender, EventArgs e)
        {
            this.RecargarListaDepositos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CodigoBarrasBusqueda.Text=="")
            {
                MessageBox.Show("Por favor, ingrese todos los campos.");
            }
            else
            {
                string codigo = CodigoBarrasBusqueda.Text;
                List<string> listSectores;

                Deposito depositoSeleccionado = (Deposito)ComboDeposito.SelectedItem;

                listSectores = depositoSeleccionado.BuscarMercaderiaDeposito(codigo); //llamado al metodo en deposito llevando el codigo ingresado

                //si el codigo se encuentra, muestra los sectores
                if (listSectores.Count == 0)
                {
                    MessageBox.Show("La mercaderia no fue encontrada");
                }
                else
                {
                    string ResultadoBusqueda = "La mercaderia se encuentra en los sectores: \n";

                    foreach (String s in listSectores)
                    {
                        ResultadoBusqueda += s + " ";
                    }

                    MessageBox.Show(ResultadoBusqueda);
                }
            }
            
        }
    }
}
