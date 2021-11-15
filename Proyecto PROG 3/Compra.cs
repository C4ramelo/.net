using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PROG_3
{
    public partial class Compra : Form
    {
        private Ingreso ingreso;
        private Sistema dato;
        

        public Compra(Ingreso inicio, Sistema data)
        {
            ingreso = inicio;
            InitializeComponent();
            dato = data;
            InicializarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingreso.Show();
            this.Hide();
        }

        private void listaproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productos.Text != "")
            {
                nup_cantidad.Enabled = true;
                cbox_factura.Enabled = true;
                txt_precioUnit.Text = dato.SolicitarPrecioDeProducto(productos.Text);
                txt_codArt.Text = dato.SolicitarCodigoDeProducto(productos.Text);
                
            }
            else
            {
                nup_cantidad.Enabled = false;
                cbox_factura.Enabled = false;
            }            
        }

        public void AccesoDeUsuario(string user)
        {
            lbl_usuarioActual.Text = user;
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            decimal codigoArt = decimal.Parse(txt_codArt.Text.Trim());
            decimal cant = nup_cantidad.Value;
            decimal precioArt = decimal.Parse(txt_precioUnit.Text.Trim());

        //Se envia los datos ingresados por el usuario comprador al sistema
            dato.AgregarProductoAUsuario(user: lbl_usuarioActual.Text, producto: productos.Text, codArt: codigoArt, precio: precioArt, cantidad: cant);
        //registramos la venta en el historial (para el "admin")
            dato.RegistrarVenta(productos.Text, nup_cantidad.Value);           
            nup_cantidad.Enabled = false;
            ConfirmaciondeCompra();
            LimpiarCampos();
        }        

        private void nup_cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (productos.Text != "")
            {
                CalcularPrecioFinal();
            }
            else nup_cantidad.Enabled = false;
        }

        private void cbox_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productos.Text != "")
            {
                CalcularPrecioFinal();
            }
        }

        private void CalcularPrecioFinal()
        {
            decimal precioFinal, subTotal = (decimal.Parse(txt_precioUnit.Text) * nup_cantidad.Value);
            txt_subtotal.Text = subTotal.ToString();


            if (cbox_factura.Text == "Tipo A")
            {
                precioFinal = subTotal + ((subTotal * 21) / 100);

                txt_precioFinal.Text = precioFinal.ToString();
            }
            if (cbox_factura.Text == "Tipo B")
            {
                precioFinal = subTotal;
                txt_precioFinal.Text = precioFinal.ToString();
            }
        }
        
        private void InicializarLista()
        {
            foreach(Producto art in dato.SolicitarHistorialDeVentas())
            {
                productos.Items.Add(art.Nombre);
            }
        }

        private void LimpiarCampos()
        {
            productos.Text = "";
            nup_cantidad.Value = 0;
            cbox_factura.Text = "";
            txt_codArt.Text = "";
            txt_subtotal.Text = "";
            txt_fecha.Text = "";
            txt_precioUnit.Text = "";
            txt_codArt.Text = "";
        }


        public void ConfirmaciondeCompra()
        {
            this.Hide();
            Confirmacion FormFinal = new Confirmacion(ingreso, productos.Text, txt_precioFinal.Text );
            FormFinal.Show();


        }
    }
}
