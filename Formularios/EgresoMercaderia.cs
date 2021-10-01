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
    public partial class EgresoMercaderia : Form
    {
        private Form FrmPrincipal;
        public EgresoMercaderia(Form FrmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CodigoBarrasEgreso.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(CodigoBarrasEgreso.Text != "")
            {
                Deposito depositoSeleccionado = (Deposito)ComboDeposito.SelectedItem;
                string CodigoBarrasIngresado = CodigoBarrasEgreso.Text;
                depositoSeleccionado.BorrarMercaderia(CodigoBarrasIngresado);
                MessageBox.Show("Mercaderia borrada con exito!");
                CodigoBarrasEgreso.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un codigo valido");
            }
        }

        private void RecargarListaDepositos() //Carga en el combobox la lista de depositos
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

        private void EgresoMercaderia_VisibleChanged(object sender, EventArgs e)
        {
            this.RecargarListaDepositos();
        }
    }
}
