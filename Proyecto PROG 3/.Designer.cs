﻿namespace Proyecto_PROG_3
{
    partial class Ingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(109, 57);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(111, 20);
            this.user.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(109, 93);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(111, 20);
            this.password.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(156, 173);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(93, 31);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(34, 173);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(93, 31);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 217);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}

