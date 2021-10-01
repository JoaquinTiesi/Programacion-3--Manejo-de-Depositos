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
    public partial class boxBorrado : Form
    {
        private Depositos FrmDepositos;
        public boxBorrado(Depositos FrmDepositos)
        {
            InitializeComponent();
            this.FrmDepositos = FrmDepositos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDepositos.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Deposito selected = (Deposito) boxaborrar.SelectedItem;
            Program.getSistema().BorrarDepositos(selected); //llama al metodo en sistema y elimina el deposito
            RecargarListaDepositos();
        }

        private void RecargarListaDepositos ()
        {
            List<Deposito> listaDepositos;
            listaDepositos = Program.getSistema().ListaDepositos();

            BindingSource binding = new BindingSource();
            binding.DataSource = listaDepositos;
            boxaborrar.DataSource = null;
            boxaborrar.Items.Clear();
            boxaborrar.DataSource = binding.DataSource;
            boxaborrar.DisplayMember = "getStringListaDescripcion";
            boxaborrar.ValueMember = "getDeposito";
        }

        private void boxBorrado_VisibleChanged(object sender, EventArgs e)
        {
            RecargarListaDepositos();
            FrmDepositos.RecargarListaDepositos();
        }

        private void boxBorrado_Load(object sender, EventArgs e)
        {

        }
    }
}
