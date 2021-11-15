using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PROG_3
{
    public partial class Historial : Form
    {
        private Ingreso ingreso;
        private Sistema datos;


        public Historial(Ingreso inicio, Sistema data)
        {
            InitializeComponent();
            ingreso = inicio;
            datos = data;
            ActualizarDatos();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            ingreso.Show();
            this.Hide();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            foreach(Producto articulo in datos.SolicitarHistorialDeVentas())
            {
                int numDeRenglon= dgv_listaVentas.Rows.Add();
                dgv_listaVentas[0, numDeRenglon].Value = articulo.Nombre;
                dgv_listaVentas[1, numDeRenglon].Value = articulo.CodigoDeArticulo.ToString();
                dgv_listaVentas[2, numDeRenglon].Value = articulo.Cantidad.ToString();
                dgv_listaVentas[3, numDeRenglon].Value = (articulo.Precio * articulo.Cantidad).ToString();
            }
        }
    }
}
