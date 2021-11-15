namespace Proyecto_PROG_3
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.confPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.provincia = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provincia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(148, 34);
            this.usuario.Margin = new System.Windows.Forms.Padding(2);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(128, 20);
            this.usuario.TabIndex = 1;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(148, 96);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(128, 20);
            this.pass.TabIndex = 2;
            // 
            // confPass
            // 
            this.confPass.Location = new System.Drawing.Point(148, 159);
            this.confPass.Margin = new System.Windows.Forms.Padding(2);
            this.confPass.Name = "confPass";
            this.confPass.PasswordChar = '*';
            this.confPass.Size = new System.Drawing.Size(128, 20);
            this.confPass.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Código postal:";
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(377, 118);
            this.codigoPostal.Margin = new System.Windows.Forms.Padding(2);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(170, 20);
            this.codigoPostal.TabIndex = 6;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(377, 34);
            this.mail.Margin = new System.Windows.Forms.Padding(2);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(170, 20);
            this.mail.TabIndex = 4;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(377, 159);
            this.direccion.Margin = new System.Windows.Forms.Padding(2);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(170, 20);
            this.direccion.TabIndex = 7;
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.Location = new System.Drawing.Point(429, 225);
            this.btn_registrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(117, 28);
            this.btn_registrarse.TabIndex = 14;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.UseVisualStyleBackColor = true;
            this.btn_registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // provincia
            // 
            this.provincia.Cursor = System.Windows.Forms.Cursors.Default;
            this.provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provincia.FormattingEnabled = true;
            this.provincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego, Antártida e Isla del Atlántico Sur",
            "Tucumán"});
            this.provincia.Location = new System.Drawing.Point(377, 74);
            this.provincia.Margin = new System.Windows.Forms.Padding(2);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(170, 21);
            this.provincia.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 279);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confPass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.ComboBox provincia;
        private System.Windows.Forms.Button button2;
    }
}