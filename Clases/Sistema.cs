using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Prog_3
{
    [Serializable]
    class Sistema
    {
        private List<Deposito> depositos = new List<Deposito>();
        private int UltimoCodigo = 1;

        public Sistema ()
        {

        }

        public void CrearDeposito (string descripcion, int alto, int ancho, int largo)
        {
            string codigoAutomatico = "P" + Convert.ToString(UltimoCodigo);
            Deposito NuevoDeposito = new Deposito(codigo: codigoAutomatico, descripcion: descripcion, Alto: alto, Ancho: ancho, Largo: largo);

            depositos.Add(NuevoDeposito);

            UltimoCodigo++;
        }
        public void BorrarDepositos(Deposito deposito)
        {
            depositos.Remove(deposito);
        }

        public List<Deposito> ListaDepositos ()
        {
            return this.depositos;
        }

    }
}
