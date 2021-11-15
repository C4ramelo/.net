using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PROG_3
{
    [Serializable]
    public class Sistema
    {
        private List<Usuario> listaDeUsuariosRegistrados;
        private Store articulosParaVenta;


        public Sistema()
        {
            listaDeUsuariosRegistrados = new List<Usuario>();
            articulosParaVenta = new Store();
        }

        public void AgregarUsuarioAlRegistro(string agregarNombre, string agregarContraseña, string agregarEmail, string agregarProvincia, string agregarDireccion, string agregarCodigoPostal)
        {
            Usuario nuevo = new Usuario(nombre: agregarNombre, contraseña: agregarContraseña, email: agregarEmail, provincia: agregarProvincia, direccion: agregarDireccion, codigoPostal: agregarCodigoPostal);

            listaDeUsuariosRegistrados.Add(nuevo);
        }

        public Usuario BuscarUsuario(string userName)//Metodo que busca y retorna un usuario de la lista
        {
            foreach (Usuario user in listaDeUsuariosRegistrados)
            {
                if (user.Nombre == userName)
                {
                    return user;
                }
            }
            return null;
        }

        public bool ExisteUsuario(String existe)
        {
            foreach (Usuario user in listaDeUsuariosRegistrados)
            {
                if (user.Nombre == existe)
                {
                    return true;
                }
            }
            return false;
        }

    //Funcion encargada de Buscar al usuario que realizo la compra y le agrega ,al mismo, la compra realizada
        public void AgregarProductoAUsuario(string user, string producto, decimal codArt, decimal precio, decimal cantidad)
        {
        //Buscamos al usuario
            Usuario comprador = BuscarUsuario(user);

        //Agregamos el producto al usuario indicado
            comprador.AgregarProducto(producto, codArt, precio, cantidad);
        }

        public List<Producto> SolicitarHistorialDeVentas()
        {
            return articulosParaVenta.SocitarHistorialDeVentas;
        }

        public string SolicitarPrecioDeProducto(string nombreDeProducto)
        {
            return articulosParaVenta.SolicitarPrecio(nombreDeProducto);
        }

        public string SolicitarCodigoDeProducto(string nombreDeProducto)
        {
            return articulosParaVenta.SolicitarCodigo(nombreDeProducto);
        }

        public void RegistrarVenta(string productoVendido, decimal cantVendida)
        {
            articulosParaVenta.RegistrarVenta(productoVendido, cantVendida);
        }
    }
}
