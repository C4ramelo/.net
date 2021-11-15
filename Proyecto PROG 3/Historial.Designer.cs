namespace Proyecto_PROG_3
{
    partial class Historial
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dgv_listaVentas = new System.Windows.Forms.DataGridView();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaTotalProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(562, 258);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(128, 31);
            this.btn_modificar.TabIndex = 15;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(289, 258);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(128, 31);
            this.btn_imprimir.TabIndex = 16;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 258);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(128, 31);
            this.btn_volver.TabIndex = 17;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dgv_listaVentas
            // 
            this.dgv_listaVentas.AllowUserToAddRows = false;
            this.dgv_listaVentas.AllowUserToDeleteRows = false;
            this.dgv_listaVentas.AllowUserToOrderColumns = true;
            this.dgv_listaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomProducto,
            this.codProducto,
            this.cantProducto,
            this.ventaTotalProduc});
            this.dgv_listaVentas.Location = new System.Drawing.Point(12, 12);
            this.dgv_listaVentas.MultiSelect = false;
            this.dgv_listaVentas.Name = "dgv_listaVentas";
            this.dgv_listaVentas.ReadOnly = true;
            this.dgv_listaVentas.Size = new System.Drawing.Size(678, 210);
            this.dgv_listaVentas.TabIndex = 18;
            // 
            // nomProducto
            // 
            this.nomProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomProducto.HeaderText = "Nombre";
            this.nomProducto.Name = "nomProducto";
            this.nomProducto.ReadOnly = true;
            this.nomProducto.Width = 69;
            // 
            // codProducto
            // 
            this.codProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codProducto.HeaderText = "Codigo de producto";
            this.codProducto.Name = "codProducto";
            this.codProducto.ReadOnly = true;
            this.codProducto.Width = 114;
            // 
            // cantProducto
            // 
            this.cantProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantProducto.HeaderText = "Productos vendidos";
            this.cantProducto.Name = "cantProducto";
            this.cantProducto.ReadOnly = true;
            this.cantProducto.Width = 115;
            // 
            // ventaTotalProduc
            // 
            this.ventaTotalProduc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ventaTotalProduc.HeaderText = "Ingreso generado por producto";
            this.ventaTotalProduc.Name = "ventaTotalProduc";
            this.ventaTotalProduc.ReadOnly = true;
            this.ventaTotalProduc.Width = 124;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 322);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_listaVentas);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_modificar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Historial";
            this.Text = "Historial de compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_listaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaTotalProduc;
    }
}