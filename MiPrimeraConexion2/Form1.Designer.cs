namespace MiPrimeraConexion2
{
    partial class Form1
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
            this.dgvDatospersonales = new System.Windows.Forms.DataGridView();
            this.IdAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatospersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatospersonales
            // 
            this.dgvDatospersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatospersonales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumnos,
            this.Apellido,
            this.Nombre,
            this.Edad});
            this.dgvDatospersonales.Location = new System.Drawing.Point(0, 97);
            this.dgvDatospersonales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatospersonales.Name = "dgvDatospersonales";
            this.dgvDatospersonales.RowTemplate.Height = 28;
            this.dgvDatospersonales.Size = new System.Drawing.Size(517, 130);
            this.dgvDatospersonales.TabIndex = 0;
            this.dgvDatospersonales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatospersonales_CellContentClick);
            // 
            // IdAlumnos
            // 
            this.IdAlumnos.HeaderText = "IdAlumnos";
            this.IdAlumnos.Name = "IdAlumnos";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dgvDatospersonales);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Mario Alejandro Chaj Sipáque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatospersonales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatospersonales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
    }
}

