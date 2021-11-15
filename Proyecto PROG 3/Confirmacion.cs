using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PROG_3
{
    public partial class Confirmacion : Form
    {
        private Ingreso iniciologin;
        private string productocompra, preciofinal;

        public Confirmacion(Ingreso Login, string producto, string precio)
        {
            iniciologin = Login;
            InitializeComponent();
            textBox1.Text = producto;
            preciofinal = precio;

        }

        private void Confirmacion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciologin.Show();

        }

        private void checkBoxefectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxefectivo.Enabled == true)
            {
                decimal preciocondescuento;
                preciocondescuento = decimal.Parse(preciofinal);
                preciofinal = ((decimal.Parse(preciofinal) * 10) / 100).ToString();
                preciocondescuento = preciocondescuento - decimal.Parse(preciofinal);
                textBox2.Text = preciocondescuento.ToString();
                checkBoxefectivo.Enabled = false;


            }
        }
    }
}
