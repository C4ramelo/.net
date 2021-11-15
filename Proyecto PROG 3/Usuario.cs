using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PROG_3
{
    [Serializable]
    public class Usuario
    {
        private string nombreDeUsuario, contraseñaDeUsuario, emailDeUsuario, provinciaDeUsuario, direccionDeUsuario, codigoPostalDeUsuario;
        private List<Producto> comprasRealizadas;

        public Usuario(string nombre, string contraseña, string email, string provincia, string direccion, string codigoPostal)
        {
            nombreDeUsuario = nombre;
            contraseñaDeUsuario = contraseña;
            emailDeUsuario = email;
            provinciaDeUsuario = provincia;
            direccionDeUsuario = direccion;
            codigoPostalDeUsuario = codigoPostal;
            comprasRealizadas = new List<Producto>();
        }

        public string Nombre
        {
            get
            {
                return nombreDeUsuario;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseñaDeUsuario;
            }
        }

        public void AgregarProducto(string nombre, decimal codProducto, decimal precio, decimal cantidad)
        {
            if (!(comprasRealizadas == null))
            {
                foreach (Producto articulo in comprasRealizadas)
                {
                    if (articulo.CodigoDeArticulo == codProducto)
                    {
                        articulo.Cantidad = articulo.Cantidad + cantidad;
                        return;
                    }
                }
            }           
            Producto nuevo = new Producto(nombre, codProducto, precio, cantidad);
            comprasRealizadas.Add(nuevo); 
        }


    }
}
