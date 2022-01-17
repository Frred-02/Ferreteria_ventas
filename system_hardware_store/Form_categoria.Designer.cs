namespace system_hardware_store
{
    partial class Form_categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_categoria));
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.listadocat = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkeliminar = new System.Windows.Forms.CheckBox();
            this.lbregistro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadocat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(771, 217);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 1;
            // 
            // listadocat
            // 
            this.listadocat.AllowUserToAddRows = false;
            this.listadocat.AllowUserToDeleteRows = false;
            this.listadocat.AllowUserToOrderColumns = true;
            this.listadocat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadocat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.listadocat.Location = new System.Drawing.Point(65, 148);
            this.listadocat.MultiSelect = false;
            this.listadocat.Name = "listadocat";
            this.listadocat.ReadOnly = true;
            this.listadocat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadocat.Size = new System.Drawing.Size(538, 322);
            this.listadocat.TabIndex = 2;
            this.listadocat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadocat_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(715, 311);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(156, 34);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Registrar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre categoria";
            // 
            // checkeliminar
            // 
            this.checkeliminar.AutoSize = true;
            this.checkeliminar.Location = new System.Drawing.Point(51, 107);
            this.checkeliminar.Name = "checkeliminar";
            this.checkeliminar.Size = new System.Drawing.Size(62, 17);
            this.checkeliminar.TabIndex = 5;
            this.checkeliminar.Text = "Eliminar";
            this.checkeliminar.UseVisualStyleBackColor = true;
            this.checkeliminar.CheckedChanged += new System.EventHandler(this.checkeliminar_CheckedChanged);
            // 
            // lbregistro
            // 
            this.lbregistro.AutoSize = true;
            this.lbregistro.Location = new System.Drawing.Point(85, 484);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(35, 13);
            this.lbregistro.TabIndex = 6;
            this.lbregistro.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btneliminar.Location = new System.Drawing.Point(715, 368);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(156, 35);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "button1";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnuevo.FlatAppearance.BorderSize = 2;
            this.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuevo.ForeColor = System.Drawing.Color.White;
            this.btnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnuevo.Image")));
            this.btnuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnuevo.Location = new System.Drawing.Point(704, 418);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(167, 52);
            this.btnuevo.TabIndex = 17;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = false;
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnimprimir.FlatAppearance.BorderSize = 2;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnimprimir.Location = new System.Drawing.Point(562, 56);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(217, 39);
            this.btnimprimir.TabIndex = 24;
            this.btnimprimir.Text = "Nuevo";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // Form_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 541);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lbregistro);
            this.Controls.Add(this.checkeliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.listadocat);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_categoria";
            this.Text = "Form_categoria";
            this.Load += new System.EventHandler(this.Form_categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadocat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.DataGridView listadocat;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.CheckBox checkeliminar;
        private System.Windows.Forms.Label lbregistro;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btnimprimir;
    }
}