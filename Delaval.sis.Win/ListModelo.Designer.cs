namespace Delaval.sis.Win
{
    partial class ListModelo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtFiltroModelo = new System.Windows.Forms.TextBox();
            this.dgModelo = new System.Windows.Forms.DataGridView();
            this.idModelos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltroModelo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.txtFiltroModelo);
            this.groupBox1.Controls.Add(this.dgModelo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiltroModelo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 315);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(354, 274);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(123, 29);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtFiltroModelo
            // 
            this.txtFiltroModelo.Location = new System.Drawing.Point(68, 27);
            this.txtFiltroModelo.Name = "txtFiltroModelo";
            this.txtFiltroModelo.Size = new System.Drawing.Size(269, 22);
            this.txtFiltroModelo.TabIndex = 0;
            this.txtFiltroModelo.TextChanged += new System.EventHandler(this.txtFiltroModelo_TextChanged);
            // 
            // dgModelo
            // 
            this.dgModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModelos,
            this.NombreModelo});
            this.dgModelo.Location = new System.Drawing.Point(6, 66);
            this.dgModelo.Name = "dgModelo";
            this.dgModelo.RowTemplate.Height = 24;
            this.dgModelo.Size = new System.Drawing.Size(471, 202);
            this.dgModelo.TabIndex = 3;
            // 
            // idModelos
            // 
            this.idModelos.HeaderText = "Id";
            this.idModelos.Name = "idModelos";
            this.idModelos.Width = 50;
            // 
            // NombreModelo
            // 
            this.NombreModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreModelo.HeaderText = "Nombre";
            this.NombreModelo.Name = "NombreModelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo:";
            // 
            // btnFiltroModelo
            // 
            this.btnFiltroModelo.Location = new System.Drawing.Point(354, 24);
            this.btnFiltroModelo.Name = "btnFiltroModelo";
            this.btnFiltroModelo.Size = new System.Drawing.Size(123, 29);
            this.btnFiltroModelo.TabIndex = 2;
            this.btnFiltroModelo.Text = "Buscar";
            this.btnFiltroModelo.UseVisualStyleBackColor = true;
            this.btnFiltroModelo.Click += new System.EventHandler(this.btnFiltroModelo_Click);
            // 
            // ListModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 335);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ListModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListModelo";
            this.Load += new System.EventHandler(this.ListModelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltroModelo;
        private System.Windows.Forms.DataGridView dgModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltroModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreModelo;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}