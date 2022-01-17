namespace system_hardware_store
{
    partial class FormulariolistaCATEGORIA
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
            this.listadocategoria = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadocategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // listadocategoria
            // 
            this.listadocategoria.AllowUserToAddRows = false;
            this.listadocategoria.AllowUserToDeleteRows = false;
            this.listadocategoria.AllowUserToOrderColumns = true;
            this.listadocategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadocategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.listadocategoria.Location = new System.Drawing.Point(79, 42);
            this.listadocategoria.MultiSelect = false;
            this.listadocategoria.Name = "listadocategoria";
            this.listadocategoria.ReadOnly = true;
            this.listadocategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadocategoria.Size = new System.Drawing.Size(538, 322);
            this.listadocategoria.TabIndex = 3;
            this.listadocategoria.DoubleClick += new System.EventHandler(this.listadocategoria_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FormulariolistaCATEGORIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadocategoria);
            this.Name = "FormulariolistaCATEGORIA";
            this.Text = "FormulariolistaCATEGORIA";
            this.Load += new System.EventHandler(this.FormulariolistaCATEGORIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadocategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadocategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}