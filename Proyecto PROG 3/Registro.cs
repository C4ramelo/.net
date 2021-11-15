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
    public partial class Registro : Form
    {
        private Ingreso ingreso;
        private Sistema almacenamientoDeDatos;

        public Registro(Ingreso inicio, Sistema sistema)
        {
            InitializeComponent();
            ingreso = inicio;
            almacenamientoDeDatos = sistema;            
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            ingreso.Show();
            this.Hide();
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CamposVacios())
            {
                string nom = usuario.Text.Trim(), contr = pass.Text.Trim(), email = mail.Text.Trim(), prov = provincia.Text.Trim(), dire = direccion.Text.Trim(), cPostal = codigoPostal.Text.Trim();                

                if (!almacenamientoDeDatos.ExisteUsuario(usuario.Text.Trim()) && pass.Text.Trim() == confPass.Text.Trim())
                {
                    almacenamientoDeDatos.AgregarUsuarioAlRegistro(nom, contr, email, prov, dire, cPostal);
                    LimpiarCampos();
                    MessageBox.Show("Los datos se han cargado correctamente", "Informacion");
                }
                else
                {
                    MessageBox.Show("El usuario que intenta ingresar ya existe o las contraseñas no coinciden", "Error al intentar registrarse!");
                    pass.SelectAll();
                    pass.Focus();
                }
            }
            else MessageBox.Show("Completar todos los campos es obligatorio para registrarse","Informacion");
            
        }
        
        private bool CamposVacios()
        {
            if (usuario.Text == "")
            {
                usuario.Focus();
                return true;
            }
            if (pass.Text =="")
            {
                pass.Focus();
                return true;
            }
            if (confPass.Text == "")
            {
                return true;
            }
            if (mail.Text == "")
            {
                return true;
            }
            if (provincia.Text== "")
            {
                return true;
            }
            if (codigoPostal.Text == "")
            {
                return true;
            }
            if (direccion.Text =="")
            {
                return true;
            }
            return false;
        }

        private void LimpiarCampos()
        {
            usuario.Text = "";
            pass.Text = "";
            confPass.Text = "";
            mail.Text = "";
            provincia.Text = "";
            codigoPostal.Text = "";
            direccion.Text = "";
            provincia.Text = "";
        }

    }
}
