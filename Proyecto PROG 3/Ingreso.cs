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
    public partial class Ingreso : Form
    {
        private Compra compra;
        
        private Registro registro;
        private Sistema datos;

        public Ingreso(Sistema sistema)
        {
            InitializeComponent();
            datos = sistema;
            compra = new Compra(this, sistema);            
            registro = new Registro(this, sistema);
            user.MaxLength = 10;
            password.PasswordChar = '*';
            password.MaxLength = 10;

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            registro.Show();
            this.Hide();
            user.Text = "";
            password.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario intentoDeIngreso = datos.BuscarUsuario(user.Text.Trim());

            if (user.Text == "admin" && password.Text == "1234")
            {
                Historial historial = new Historial(this, datos);
                historial.Show();
                this.Hide();
                user.Text = "";
                password.Text = "";                                
                return;
            }

            if (user.Text == "" || password.Text == "")
            {
                MessageBox.Show("No ha ingresado un nombre de usuario y/o contraseña", "Informacion");
                user.Text = "";
                password.Text = "";
                return;
            }

            if (intentoDeIngreso != null && intentoDeIngreso.Contraseña == password.Text.Trim())
            {
                compra.AccesoDeUsuario(user.Text.Trim());
                user.Text = "";
                password.Text = "";
                compra.Show();                
                this.Hide();
                return;
            }

            if (intentoDeIngreso == null)
            {
                MessageBox.Show("El nombre de usuario ingresado no existe.", "Usuario incorrecto");
                user.SelectAll();
                user.Focus();
                return;
            }

            if (intentoDeIngreso.Contraseña != password.Text.Trim())
            {
                MessageBox.Show("La contraseña ingresada es incorrecta.", "Contraseña incorrecta");
                password.SelectAll();
                password.Focus();
                return;
            }
            
            
        }
    }
}
