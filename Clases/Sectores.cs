using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Prog_3
{
    [Serializable]
    class Sectores
    {
        private string Codigo;
        private Mercaderia Mercaderia;

        public Sectores(string codigo)
        {
            this.Codigo = codigo;
        }

        public bool SectorVacio ()
        {
            if (Mercaderia == null) { return true; }
            return false;
        }

        public bool GuardarMercaderia(Mercaderia mercaderia)
        {
            this.Mercaderia = mercaderia;
            return true;
        }

        public void BorrarMercaderia(string codigo)
        {
            if (this.Mercaderia != null)
            {
                if (this.Mercaderia.CodigoBarrasIgual(codigo)) //si es el mismo codigo de barras, limpia todo
                {
                    Mercaderia = null;
                }
            }
        }

        public bool CodigoMercaderiaEsIgualA(string encontrarCodigo) //devuelve si encuentra el mismo codigo de barras dentro de lo guardado
        {
            if (this.Mercaderia != null)
            {
                if (this.Mercaderia.CodigoBarrasIgual(encontrarCodigo))
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
    }
}
