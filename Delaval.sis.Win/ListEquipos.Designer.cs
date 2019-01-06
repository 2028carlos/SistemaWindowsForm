namespace Delaval.sis.Win
{
    partial class ListEquipos
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
            this.txtFiltroEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltroEquipo = new System.Windows.Forms.Button();
            this.dgEquipo = new System.Windows.Forms.DataGridView();
            this.idEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionEquipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltroEquipo
            // 
            this.txtFiltroEquipo.Location = new System.Drawing.Point(68, 27);
            this.txtFiltroEquipo.Name = "txtFiltroEquipo";
            this.txtFiltroEquipo.Size = new System.Drawing.Size(269, 22);
            this.txtFiltroEquipo.TabIndex = 0;
            this.txtFiltroEquipo.TextChanged += new System.EventHandler(this.txtFiltroEquipo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipo:";
            // 
            // btnFiltroEquipo
            // 
            this.btnFiltroEquipo.Location = new System.Drawing.Point(354, 24);
            this.btnFiltroEquipo.Name = "btnFiltroEquipo";
            this.btnFiltroEquipo.Size = new System.Drawing.Size(123, 29);
            this.btnFiltroEquipo.TabIndex = 2;
            this.btnFiltroEquipo.Text = "Buscar";
            this.btnFiltroEquipo.UseVisualStyleBackColor = true;
            this.btnFiltroEquipo.Click += new System.EventHandler(this.btnFiltroEquipo_Click);
            // 
            // dgEquipo
            // 
            this.dgEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEquipo,
            this.Nombre});
            this.dgEquipo.Location = new System.Drawing.Point(6, 66);
            this.dgEquipo.Name = "dgEquipo";
            this.dgEquipo.RowHeadersVisible = false;
            this.dgEquipo.RowTemplate.Height = 24;
            this.dgEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipo.Size = new System.Drawing.Size(471, 202);
            this.dgEquipo.TabIndex = 3;
            // 
            // idEquipo
            // 
            this.idEquipo.HeaderText = "Id";
            this.idEquipo.Name = "idEquipo";
            this.idEquipo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionEquipo);
            this.groupBox1.Controls.Add(this.txtFiltroEquipo);
            this.groupBox1.Controls.Add(this.dgEquipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiltroEquipo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSeleccionEquipo
            // 
            this.btnSeleccionEquipo.Location = new System.Drawing.Point(354, 282);
            this.btnSeleccionEquipo.Name = "btnSeleccionEquipo";
            this.btnSeleccionEquipo.Size = new System.Drawing.Size(123, 29);
            this.btnSeleccionEquipo.TabIndex = 4;
            this.btnSeleccionEquipo.Text = "Seleccionar";
            this.btnSeleccionEquipo.UseVisualStyleBackColor = true;
            this.btnSeleccionEquipo.Click += new System.EventHandler(this.btnSeleccionEquipo_Click);
            // 
            // ListEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 341);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ListEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListEquipos";
            this.Load += new System.EventHandler(this.ListEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltroEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltroEquipo;
        private System.Windows.Forms.DataGridView dgEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionEquipo;
    }
}