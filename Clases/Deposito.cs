using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Prog_3
{
    [Serializable]
    class Deposito
    {
        private string Codigo;
        private string Descripcion;
        private int Alto;
        private int Ancho;
        private int Largo;

        private double LargoSector;
        private double AnchoSector;
        private double AltoSector;

        private double TotalPaletsLargo;
        private double TotalPaletsAncho;
        private double TotalPaletsAlto;

        private SortedDictionary<string, Sectores> Sectores = new SortedDictionary<string, Sectores>();

        public Deposito(string codigo, string descripcion, int Alto, int Ancho, int Largo) {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Alto = Alto;
            this.Ancho = Ancho;
            this.Largo = Largo;

            this.LargoSector = 1.2; //Si llegamos, el usuario ingresará el tamaño de los palets.
            this.AnchoSector = 1; //1 x 1.2 son las dimensiones estandard de un palet.
            this.AltoSector = 3;

            this.TotalPaletsLargo = Largo / this.LargoSector;
            this.TotalPaletsAncho = Ancho / this.AnchoSector;
            this.TotalPaletsAlto = Alto / this.AltoSector;

            int NumeracionFilas = 1; //Largo
            int NumeracionColumnas = 1; //Ancho

            for (int k = 0; k < this.TotalPaletsAlto; k++)
            {
                for (int i = 0; i < this.TotalPaletsLargo; i++)
                {
                    for (int j = 0; j < this.TotalPaletsAncho; j++)
                    {
                        string CodigoSector = NumeracionFilas.ToString("D3") + "-" + NumeracionColumnas.ToString("D3");

                        Sectores.Add(CodigoSector, new Sectores(CodigoSector));

                        NumeracionColumnas++;
                    }

                    NumeracionFilas++;
                    NumeracionColumnas = 1;
                }
            }
        }

        public string getStringListaDescripcion 
        {
            get
            {
                return this.Codigo + " - " + this.Descripcion;
            }
        }

        public Deposito getDeposito
        {
            get
            {
                return this;
            }
        }

        public List<string> IngresarMercaderia(Mercaderia ingreso)
        {
            int[] dimensionesMercaderia = ingreso.getDimensiones(); //dimensiones esta en Mercaderia.cs
            double anchoSectoresRequeridos = dimensionesMercaderia[1] / this.AnchoSector; // Valor 1 es ancho
            double largoSectoresRequeridos = dimensionesMercaderia[2] / this.LargoSector; // Valor 2 es largo
            double altoSectoresRequeridos = dimensionesMercaderia[0] / this.AltoSector; // Valor 0 es alto
            List<string> codigosSectoresAsignados = new List<string>(); //Devolvemos código de Sector y no instancias para que la interfaz no tenga acceso a los Sectores.
            List<Sectores> sectoresAsignados = new List<Sectores>();

            if (largoSectoresRequeridos > this.TotalPaletsLargo || anchoSectoresRequeridos > this.TotalPaletsAncho || altoSectoresRequeridos > this.TotalPaletsAlto) //Verificacion tamaño mercaderia en relacion al deposito
            {
                return codigosSectoresAsignados;
            }

            foreach (KeyValuePair<string, Sectores> kvp in Sectores)
            {
                
                if (kvp.Value.SectorVacio()) 
                {
                    bool mercaderiaAceptada = true;

                    string[] codigosFilaColumna = kvp.Key.Split('-');
                    int NumeracionFilas = Convert.ToInt32(codigosFilaColumna[0]);
                    int NumeracionColumnas = Convert.ToInt32(codigosFilaColumna[1]);
                    int pisoActual = (int) ((NumeracionFilas / this.TotalPaletsLargo) + 1); //Calculo del piso del sector actual

                    // El for exterior controla el alto, el for intermedio controla el largo, y el for interior controla el ancho

                    for (int k = 0; k < altoSectoresRequeridos && mercaderiaAceptada; k++) //comienza verificacion de espacio suficiente...
                    {
                        if (NumeracionFilas > (this.TotalPaletsLargo * this.TotalPaletsAlto))
                        {
                            mercaderiaAceptada = false;
                            break;
                        }

                        codigosSectoresAsignados.Add($"\nPiso {pisoActual}:");

                        for (int j = 0; j < largoSectoresRequeridos && mercaderiaAceptada; j++)
                        {
                            if (NumeracionFilas > (this.TotalPaletsLargo * pisoActual))
                            {
                                mercaderiaAceptada = false;
                                break;
                            }

                            codigosSectoresAsignados.Add("\n");

                            for (int i = 0; i < anchoSectoresRequeridos && mercaderiaAceptada; i++)
                            {
                                if (NumeracionColumnas > this.TotalPaletsAncho)
                                {
                                    mercaderiaAceptada = false;
                                    break;
                                }

                                string CodigoFila = NumeracionFilas.ToString("D3") + "-" + NumeracionColumnas.ToString("D3");

                                if (Sectores[CodigoFila].SectorVacio())
                                {
                                    codigosSectoresAsignados.Add(CodigoFila);
                                    sectoresAsignados.Add(Sectores[CodigoFila]);
                                }
                                else
                                {
                                    mercaderiaAceptada = false;
                                }

                                NumeracionColumnas++;
                            }
                            NumeracionFilas++;
                            NumeracionColumnas = Convert.ToInt32(codigosFilaColumna[1]);
                        }

                        NumeracionColumnas = Convert.ToInt32(codigosFilaColumna[1]);
                        NumeracionFilas = Convert.ToInt32(Convert.ToDouble(codigosFilaColumna[0]) + this.TotalPaletsLargo);
                        pisoActual++;
                    }
                    
                    if (mercaderiaAceptada) {
                        foreach (Sectores s in sectoresAsignados)
                        {
                            s.GuardarMercaderia(ingreso); //si cargo todo bien, se guarda la mercaderia
                        }
                        return codigosSectoresAsignados;
                    } else {
                        codigosSectoresAsignados.Clear(); //Si la mercaderia no entra, limpia todo lo hecho y continua buscando espacio con el bucle for
                    }
                }
            }
            return codigosSectoresAsignados;
        }

        public void BorrarMercaderia(string aBorrarCodigo)
        {
            foreach(KeyValuePair<string, Sectores> kvp in Sectores)
            {
                kvp.Value.BorrarMercaderia(aBorrarCodigo); //Sectores se encarga de borrar la mercaderia seleccionada si la encuentra
            }
        }

        public List<string> BuscarMercaderiaDeposito(string encontrarCodigo)
        {
            List<string> sectoresMercaderia = new List<string>();

            foreach (KeyValuePair<string, Sectores> kvp in Sectores)
            {
                if (kvp.Value.CodigoMercaderiaEsIgualA(encontrarCodigo)) //llama al metodo en sectores para revisar la existencia
                {
                    sectoresMercaderia.Add(kvp.Key);
                }
            }

            return sectoresMercaderia;
        } 
    }
}
