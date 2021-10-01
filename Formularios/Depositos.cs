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
    public partial class Depositos : Form
    {
        private Form FrmPrincipal;
        private Form FrmCrearDeposito;
        private Form FrmBorrarDeposito;
        public Depositos(Form FrmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = FrmPrincipal;
            this.FrmCrearDeposito = new CrearDeposito(this);
            this.FrmBorrarDeposito = new boxBorrado(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCrearDeposito.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBorrarDeposito.Show();
        }

        public void RecargarListaDepositos() //Carga en el combobox la lista de depositos
        {
            List<Deposito> listaDepositos;
            listaDepositos = Program.getSistema().ListaDepositos();

            BindingSource binding = new BindingSource();
            binding.DataSource = listaDepositos;
            listaDepositosActuales.DataSource = null;
            listaDepositosActuales.Items.Clear();
            listaDepositosActuales.DataSource = binding.DataSource;
            listaDepositosActuales.DisplayMember = "getStringListaDescripcion";
            listaDepositosActuales.ValueMember = "getDeposito";
        }

        private void Depositos_VisibleChanged(object sender, EventArgs e)
        {
            RecargarListaDepositos();
        }
    }
}
