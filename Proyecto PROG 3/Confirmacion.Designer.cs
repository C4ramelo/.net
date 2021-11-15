namespace Proyecto_PROG_3
{
    partial class Confirmacion
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
            this.checkBoxefectivo = new System.Windows.Forms.CheckBox();
            this.SuProducto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirme método de pago:";
            // 
            // checkBoxefectivo
            // 
            this.checkBoxefectivo.AutoSize = true;
            this.checkBoxefectivo.Location = new System.Drawing.Point(176, 32);
            this.checkBoxefectivo.Name = "checkBoxefectivo";
            this.checkBoxefectivo.Size = new System.Drawing.Size(111, 17);
            this.checkBoxefectivo.TabIndex = 1;
            this.checkBoxefectivo.Text = "Efectivo (10% Off)";
            this.checkBoxefectivo.UseVisualStyleBackColor = true;
            this.checkBoxefectivo.CheckedChanged += new System.EventHandler(this.checkBoxefectivo_CheckedChanged);
            // 
            // SuProducto
            // 
            this.SuProducto.AutoSize = true;
            this.SuProducto.Location = new System.Drawing.Point(19, 57);
            this.SuProducto.Name = "SuProducto";
            this.SuProducto.Size = new System.Drawing.Size(69, 13);
            this.SuProducto.TabIndex = 3;
            this.SuProducto.Text = "Su Producto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "nombreproducto";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(23, 101);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(65, 13);
            this.total.TabIndex = 5;
            this.total.Text = "Precio Final:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "PrecioFinal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(26, 147);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(126, 36);
            this.volver.TabIndex = 8;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 203);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SuProducto);
            this.Controls.Add(this.checkBoxefectivo);
            this.Controls.Add(this.label1);
            this.Name = "Confirmacion";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Confirmacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxefectivo;
        private System.Windows.Forms.Label SuProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button volver;
    }
}