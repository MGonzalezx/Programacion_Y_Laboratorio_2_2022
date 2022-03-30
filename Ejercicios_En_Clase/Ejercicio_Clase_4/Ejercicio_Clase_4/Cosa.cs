using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_4
{
    class Cosa
    {
        private int valor;
        private string cadena;
        private DateTime fecha;

        #region PARTE 1
        public void EstablecerValor(int valor)
        {
            this.valor = valor;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
       

        private string Mostrar()
        {
            return "Entero: " + this.valor + " - String: " + this.cadena + " - Fecha: " + this.fecha;
        }

        public static  string Mostrar( Cosa miCosa)
        {
            return miCosa.Mostrar();
        }
        #endregion

        #region PARTE 2
        public Cosa(DateTime fecha, int valor, string cadena): this(valor,cadena)
        {
            this.fecha = fecha;
           
        }

        public Cosa(int valor, string cadena): this(cadena)
        {
           
            this.valor = valor;
           
        }

        public Cosa(string cadena): this()
        {
            
            this.cadena = cadena;
        }

        public Cosa()
        {
            this.fecha = DateTime.Now;
            this.valor = 10;
            this.cadena = "Sin valor";
        }

        #endregion

    }
}
