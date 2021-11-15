using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PROG_3
{
    [Serializable]
    public class Store
    {
        private List<Producto> productosALaVenta;        


        public Store()
        {
            productosALaVenta = new List<Producto>();
            Producto articulo1 = new Producto("Epson-Impresora multifuncion-", Convert.ToDecimal(1179), Convert.ToDecimal(15950), 0);
            Producto articulo2 = new Producto("Hp-Monitor 18' negro-", Convert.ToDecimal(2165), Convert.ToDecimal(11850), 0);
            Producto articulo3 = new Producto("evga-Targeta grafica gtx_1050ti-", Convert.ToDecimal(915), Convert.ToDecimal(25450), 0);
            Producto articulo4 = new Producto("Wacom-Tableta grafica 16' black-", Convert.ToDecimal(15689), Convert.ToDecimal(149175), 0);
            Producto articulo5 = new Producto("Teclado para pc HyperX", Convert.ToDecimal(65628), Convert.ToDecimal(5899), 0);
            Producto articulo6 = new Producto("Notebook Dell I5 1035 10° Gen 4gb 128gb Ssd 14 Windows 10 C", Convert.ToDecimal(3493), Convert.ToDecimal(89999), 0);
            Producto articulo7 = new Producto("Auriculares gamer Razer Kraken razer green", Convert.ToDecimal(65468), Convert.ToDecimal(16999), 0);
            Producto articulo8 = new Producto("Mouse Razer Mamba Wireless negro", Convert.ToDecimal(225874), Convert.ToDecimal(14999), 0);
            Producto articulo9 = new Producto("Procesador AMD Ryzen 5 2600", Convert.ToDecimal(15689), Convert.ToDecimal(149175), 0);


            productosALaVenta.Add(articulo1);
            productosALaVenta.Add(articulo2);
            productosALaVenta.Add(articulo3);
            productosALaVenta.Add(articulo4);
            productosALaVenta.Add(articulo5);
            productosALaVenta.Add(articulo6);
            productosALaVenta.Add(articulo7);
            productosALaVenta.Add(articulo8);
            productosALaVenta.Add(articulo9);


        }

        public void RegistrarVenta(string producto , decimal productosVendidos)
        {
            foreach (Producto art in productosALaVenta)
            {
                if (producto == art.Nombre)
                {                    
                    art.Cantidad = (art.Cantidad + productosVendidos);
                }
            }
        }

        public List<Producto> SocitarHistorialDeVentas
        {
            get { return productosALaVenta; }
        }

        public string SolicitarPrecio(string nomProducto)
        {
            foreach (Producto art in productosALaVenta)
            {
                if (art.Nombre == nomProducto)
                {
                    return art.Precio.ToString();
                }
            }
            return "No existe el Art.";
        }

        public string SolicitarCodigo(string nomProducto)
        {
            foreach (Producto art in productosALaVenta)
            {
                if (art.Nombre == nomProducto)
                {
                    return art.CodigoDeArticulo.ToString();
                }
            }
            return "No existe el Art.";
        }
    }
}
