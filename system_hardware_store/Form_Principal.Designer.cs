namespace system_hardware_store
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.panel_menu_vertical = new System.Windows.Forms.Panel();
            this.btncategoria = new System.Windows.Forms.Button();
            this.btn_ventafialnl = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_barra_titulo = new System.Windows.Forms.Panel();
            this.icon_restaurar = new System.Windows.Forms.PictureBox();
            this.icon_minimizar = new System.Windows.Forms.PictureBox();
            this.icon_maximizar = new System.Windows.Forms.PictureBox();
            this.icon_cerrar = new System.Windows.Forms.PictureBox();
            this.menuslide = new System.Windows.Forms.PictureBox();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuslide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu_vertical
            // 
            this.panel_menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_menu_vertical.Controls.Add(this.btncategoria);
            this.panel_menu_vertical.Controls.Add(this.btn_ventafialnl);
            this.panel_menu_vertical.Controls.Add(this.btn_registro);
            this.panel_menu_vertical.Controls.Add(this.btn_reportes);
            this.panel_menu_vertical.Controls.Add(this.btn_empleados);
            this.panel_menu_vertical.Controls.Add(this.btn_clientes);
            this.panel_menu_vertical.Controls.Add(this.btn_ventas);
            this.panel_menu_vertical.Controls.Add(this.btn_productos);
            this.panel_menu_vertical.Controls.Add(this.pictureBox1);
            this.panel_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.panel_menu_vertical.Name = "panel_menu_vertical";
            this.panel_menu_vertical.Size = new System.Drawing.Size(250, 650);
            this.panel_menu_vertical.TabIndex = 0;
            this.panel_menu_vertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_vertical_Paint);
            // 
            // btncategoria
            // 
            this.btncategoria.FlatAppearance.BorderSize = 0;
            this.btncategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.ForeColor = System.Drawing.Color.White;
            this.btncategoria.Image = global::system_hardware_store.Properties.Resources.ventas;
            this.btncategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategoria.Location = new System.Drawing.Point(3, 320);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(250, 45);
            this.btncategoria.TabIndex = 8;
            this.btncategoria.Text = "Categorias";
            this.btncategoria.UseVisualStyleBackColor = true;
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
            // 
            // btn_ventafialnl
            // 
            this.btn_ventafialnl.FlatAppearance.BorderSize = 0;
            this.btn_ventafialnl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ventafialnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventafialnl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventafialnl.ForeColor = System.Drawing.Color.White;
            this.btn_ventafialnl.Image = global::system_hardware_store.Properties.Resources.clientes;
            this.btn_ventafialnl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventafialnl.Location = new System.Drawing.Point(-3, 383);
            this.btn_ventafialnl.Name = "btn_ventafialnl";
            this.btn_ventafialnl.Size = new System.Drawing.Size(250, 45);
            this.btn_ventafialnl.TabIndex = 7;
            this.btn_ventafialnl.Text = "VENTA FINAL";
            this.btn_ventafialnl.UseVisualStyleBackColor = true;
            this.btn_ventafialnl.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_registro
            // 
            this.btn_registro.FlatAppearance.BorderSize = 0;
            this.btn_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.Color.White;
            this.btn_registro.Image = global::system_hardware_store.Properties.Resources.clientes;
            this.btn_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registro.Location = new System.Drawing.Point(-3, 514);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(250, 45);
            this.btn_registro.TabIndex = 6;
            this.btn_registro.Text = "REGISTRAR";
            this.btn_registro.UseVisualStyleBackColor = true;
            this.btn_registro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Image = global::system_hardware_store.Properties.Resources.reporte;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(3, 447);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(250, 45);
            this.btn_reportes.TabIndex = 5;
            this.btn_reportes.Text = "REPORTES";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.Color.White;
            this.btn_empleados.Image = global::system_hardware_store.Properties.Resources.empleados;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 575);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(250, 45);
            this.btn_empleados.TabIndex = 4;
            this.btn_empleados.Text = "EMPLEADOS";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_clientes.Image = global::system_hardware_store.Properties.Resources.clientes;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(0, 250);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(250, 45);
            this.btn_clientes.TabIndex = 3;
            this.btn_clientes.Text = "CLIENTES";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_ventas.Image = global::system_hardware_store.Properties.Resources.ventas;
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(0, 178);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(250, 45);
            this.btn_ventas.TabIndex = 2;
            this.btn_ventas.Text = "VENTAS";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = global::system_hardware_store.Properties.Resources.productos;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(0, 107);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(250, 45);
            this.btn_productos.TabIndex = 1;
            this.btn_productos.Text = "PRODUCTOS";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::system_hardware_store.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(1, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_barra_titulo
            // 
            this.panel_barra_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_barra_titulo.Controls.Add(this.icon_restaurar);
            this.panel_barra_titulo.Controls.Add(this.icon_minimizar);
            this.panel_barra_titulo.Controls.Add(this.icon_maximizar);
            this.panel_barra_titulo.Controls.Add(this.icon_cerrar);
            this.panel_barra_titulo.Controls.Add(this.menuslide);
            this.panel_barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra_titulo.Location = new System.Drawing.Point(250, 0);
            this.panel_barra_titulo.Name = "panel_barra_titulo";
            this.panel_barra_titulo.Size = new System.Drawing.Size(1050, 50);
            this.panel_barra_titulo.TabIndex = 1;
            this.panel_barra_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_barra_titulo_Paint);
            this.panel_barra_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barra_titulo_MouseDown);
            // 
            // icon_restaurar
            // 
            this.icon_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("icon_restaurar.Image")));
            this.icon_restaurar.Location = new System.Drawing.Point(987, 7);
            this.icon_restaurar.Name = "icon_restaurar";
            this.icon_restaurar.Size = new System.Drawing.Size(25, 25);
            this.icon_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_restaurar.TabIndex = 2;
            this.icon_restaurar.TabStop = false;
            this.icon_restaurar.Visible = false;
            this.icon_restaurar.Click += new System.EventHandler(this.icon_restaurar_Click);
            // 
            // icon_minimizar
            // 
            this.icon_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("icon_minimizar.Image")));
            this.icon_minimizar.Location = new System.Drawing.Point(956, 7);
            this.icon_minimizar.Name = "icon_minimizar";
            this.icon_minimizar.Size = new System.Drawing.Size(25, 25);
            this.icon_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_minimizar.TabIndex = 4;
            this.icon_minimizar.TabStop = false;
            this.icon_minimizar.Click += new System.EventHandler(this.icon_minimizar_Click);
            // 
            // icon_maximizar
            // 
            this.icon_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("icon_maximizar.Image")));
            this.icon_maximizar.Location = new System.Drawing.Point(987, 7);
            this.icon_maximizar.Name = "icon_maximizar";
            this.icon_maximizar.Size = new System.Drawing.Size(25, 25);
            this.icon_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_maximizar.TabIndex = 3;
            this.icon_maximizar.TabStop = false;
            this.icon_maximizar.Click += new System.EventHandler(this.icon_maximizar_Click);
            // 
            // icon_cerrar
            // 
            this.icon_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("icon_cerrar.Image")));
            this.icon_cerrar.Location = new System.Drawing.Point(1018, 7);
            this.icon_cerrar.Name = "icon_cerrar";
            this.icon_cerrar.Size = new System.Drawing.Size(25, 25);
            this.icon_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_cerrar.TabIndex = 1;
            this.icon_cerrar.TabStop = false;
            this.icon_cerrar.Click += new System.EventHandler(this.icon_cerrar_Click);
            // 
            // menuslide
            // 
            this.menuslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuslide.Image = global::system_hardware_store.Properties.Resources.Mobile_Menu_Icon;
            this.menuslide.Location = new System.Drawing.Point(7, 7);
            this.menuslide.Name = "menuslide";
            this.menuslide.Size = new System.Drawing.Size(35, 35);
            this.menuslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuslide.TabIndex = 0;
            this.menuslide.TabStop = false;
            this.menuslide.Click += new System.EventHandler(this.menuslide_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(250, 50);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1050, 600);
            this.panel_contenedor.TabIndex = 2;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_barra_titulo);
            this.Controls.Add(this.panel_menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Principal";
            this.Text = "Form1";
            this.panel_menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuslide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu_vertical;
        private System.Windows.Forms.Panel panel_barra_titulo;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.PictureBox menuslide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icon_minimizar;
        private System.Windows.Forms.PictureBox icon_maximizar;
        private System.Windows.Forms.PictureBox icon_restaurar;
        private System.Windows.Forms.PictureBox icon_cerrar;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_ventafialnl;
        private System.Windows.Forms.Button btncategoria;
    }
}

