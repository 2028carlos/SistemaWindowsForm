namespace Delaval.sis.Win
{
    partial class ListArticulos
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
            this.txtFiltar = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.dgArticulos = new System.Windows.Forms.DataGridView();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.idArticulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltar
            // 
            this.txtFiltar.Location = new System.Drawing.Point(12, 12);
            this.txtFiltar.Multiline = true;
            this.txtFiltar.Name = "txtFiltar";
            this.txtFiltar.Size = new System.Drawing.Size(304, 26);
            this.txtFiltar.TabIndex = 0;
            this.txtFiltar.TextChanged += new System.EventHandler(this.txtFiltar_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(322, 12);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 30);
            this.btnFiltro.TabIndex = 1;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dgArticulos
            // 
            this.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulos,
            this.codigo,
            this.descripcion,
            this.unidadmedida,
            this.unidad,
            this.programa,
            this.precio,
            this.Nombre,
            this.NombreModelo});
            this.dgArticulos.Location = new System.Drawing.Point(12, 44);
            this.dgArticulos.Name = "dgArticulos";
            this.dgArticulos.RowTemplate.Height = 24;
            this.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArticulos.Size = new System.Drawing.Size(973, 306);
            this.dgArticulos.TabIndex = 4;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(863, 356);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(122, 30);
            this.btnSeleccion.TabIndex = 5;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // idArticulos
            // 
            this.idArticulos.HeaderText = "ID";
            this.idArticulos.Name = "idArticulos";
            this.idArticulos.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // unidadmedida
            // 
            this.unidadmedida.HeaderText = "Unidad Medida";
            this.unidadmedida.Name = "unidadmedida";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // programa
            // 
            this.programa.HeaderText = "Programa";
            this.programa.Name = "programa";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio Unitario";
            this.precio.Name = "precio";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Equipo";
            this.Nombre.Name = "Nombre";
            // 
            // NombreModelo
            // 
            this.NombreModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreModelo.HeaderText = "Modelo";
            this.NombreModelo.Name = "NombreModelo";
            // 
            // ListArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 392);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.dgArticulos);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltar);
            this.MaximizeBox = false;
            this.Name = "ListArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListArticulos";
            this.Load += new System.EventHandler(this.ListArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridView dgArticulos;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreModelo;
    }
}