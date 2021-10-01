using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Prog_3
{
    [Serializable]
    class Mercaderia
    {
        private int Alto;
        private int Largo;
        private int Ancho;
        private string Descripcion;
        private int Peso;
        private DateTime FechaIngreso;
        private string CodigoBarras;

        public Mercaderia (int alto, int largo, int ancho, string descripcion, int peso, DateTime fechaIngreso, string codigoBarras)
        {
            this.Alto = alto;
            this.Largo = largo;
            this.Ancho = ancho;
            this.Descripcion = descripcion;
            this.Peso = peso;
            this.FechaIngreso = fechaIngreso;
            this.CodigoBarras = codigoBarras;
        }

        public int[] getDimensiones ()
        {
            int[] dimensionesMercaderia = new int[3];
            dimensionesMercaderia[0] = (this.Alto);
            dimensionesMercaderia[1] = (this.Ancho);
            dimensionesMercaderia[2] = (this.Largo);
            return dimensionesMercaderia;
        }

        public bool CodigoBarrasIgual(string codigo)
        {
            if (this.CodigoBarras == codigo) return true;
            return false;
        }
    }
}
