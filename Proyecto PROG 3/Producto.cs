using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PROG_3
{
    [Serializable]
    public class Producto
    {
        private string nombre;
        private decimal codigoArticulo, precio;
        decimal cantidad;


       public Producto(string nom, decimal CodArticulo, decimal valor, decimal cant)
        {
            nombre = nom;            
            codigoArticulo = CodArticulo;
            precio = valor;
            cantidad = cant;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public decimal Cantidad
        {            
            get { return cantidad; }
            set { cantidad =  value; }
        }        

        public decimal CodigoDeArticulo
        {
            get { return codigoArticulo; }
        }

        public decimal Precio
        {
            get { return precio; }
        }

    }
}
