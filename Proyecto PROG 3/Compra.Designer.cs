namespace Proyecto_PROG_3
{
    partial class Compra
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
            this.txt_codArt = new System.Windows.Forms.TextBox();
            this.productos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nup_cantidad = new System.Windows.Forms.NumericUpDown();
            this.cbox_factura = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_usuarioActual = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_precioFinal = new System.Windows.Forms.TextBox();
            this.lbl_precioUnit = new System.Windows.Forms.Label();
            this.txt_precioUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. articulo:";
            // 
            // txt_codArt
            // 
            this.txt_codArt.Location = new System.Drawing.Point(488, 61);
            this.txt_codArt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codArt.Name = "txt_codArt";
            this.txt_codArt.ReadOnly = true;
            this.txt_codArt.Size = new System.Drawing.Size(54, 20);
            this.txt_codArt.TabIndex = 1;
            // 
            // productos
            // 
            this.productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productos.FormattingEnabled = true;
            this.productos.Location = new System.Drawing.Point(102, 61);
            this.productos.Margin = new System.Windows.Forms.Padding(2);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(296, 21);
            this.productos.TabIndex = 2;
            this.productos.SelectedIndexChanged += new System.EventHandler(this.listaproducto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // nup_cantidad
            // 
            this.nup_cantidad.Enabled = false;
            this.nup_cantidad.Location = new System.Drawing.Point(102, 107);
            this.nup_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nup_cantidad.Name = "nup_cantidad";
            this.nup_cantidad.Size = new System.Drawing.Size(154, 20);
            this.nup_cantidad.TabIndex = 7;
            this.nup_cantidad.ValueChanged += new System.EventHandler(this.nup_cantidad_ValueChanged);
            // 
            // cbox_factura
            // 
            this.cbox_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_factura.FormattingEnabled = true;
            this.cbox_factura.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B"});
            this.cbox_factura.Location = new System.Drawing.Point(102, 192);
            this.cbox_factura.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_factura.Name = "cbox_factura";
            this.cbox_factura.Size = new System.Drawing.Size(155, 21);
            this.cbox_factura.TabIndex = 8;
            this.cbox_factura.SelectedIndexChanged += new System.EventHandler(this.cbox_factura_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(371, 106);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(151, 20);
            this.txt_fecha.TabIndex = 11;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(371, 150);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(151, 20);
            this.txt_subtotal.TabIndex = 1;
            this.txt_subtotal.Visible = false;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(321, 154);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(46, 13);
            this.lbl_subtotal.TabIndex = 13;
            this.lbl_subtotal.Text = "Subtotal";
            this.lbl_subtotal.Visible = false;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(414, 256);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(128, 31);
            this.btn_comprar.TabIndex = 14;
            this.btn_comprar.Text = "Realizar compra";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_usuarioActual
            // 
            this.lbl_usuarioActual.AutoSize = true;
            this.lbl_usuarioActual.Location = new System.Drawing.Point(281, 9);
            this.lbl_usuarioActual.Name = "lbl_usuarioActual";
            this.lbl_usuarioActual.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioActual.TabIndex = 16;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(306, 200);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 13);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "Precio final:";
            // 
            // txt_precioFinal
            // 
            this.txt_precioFinal.Enabled = false;
            this.txt_precioFinal.Location = new System.Drawing.Point(375, 197);
            this.txt_precioFinal.Name = "txt_precioFinal";
            this.txt_precioFinal.ReadOnly = true;
            this.txt_precioFinal.Size = new System.Drawing.Size(147, 20);
            this.txt_precioFinal.TabIndex = 18;
            // 
            // lbl_precioUnit
            // 
            this.lbl_precioUnit.AutoSize = true;
            this.lbl_precioUnit.Location = new System.Drawing.Point(21, 150);
            this.lbl_precioUnit.Name = "lbl_precioUnit";
            this.lbl_precioUnit.Size = new System.Drawing.Size(77, 13);
            this.lbl_precioUnit.TabIndex = 19;
            this.lbl_precioUnit.Text = "Precio unitario:";
            // 
            // txt_precioUnit
            // 
            this.txt_precioUnit.Location = new System.Drawing.Point(102, 150);
            this.txt_precioUnit.Name = "txt_precioUnit";
            this.txt_precioUnit.ReadOnly = true;
            this.txt_precioUnit.Size = new System.Drawing.Size(155, 20);
            this.txt_precioUnit.TabIndex = 20;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 298);
            this.ControlBox = false;
            this.Controls.Add(this.txt_precioUnit);
            this.Controls.Add(this.lbl_precioUnit);
            this.Controls.Add(this.txt_precioFinal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_usuarioActual);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_factura);
            this.Controls.Add(this.nup_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productos);
            this.Controls.Add(this.txt_codArt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Compra";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codArt;
        private System.Windows.Forms.ComboBox productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nup_cantidad;
        private System.Windows.Forms.ComboBox cbox_factura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_usuarioActual;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_precioFinal;
        private System.Windows.Forms.Label lbl_precioUnit;
        private System.Windows.Forms.TextBox txt_precioUnit;
    }
}