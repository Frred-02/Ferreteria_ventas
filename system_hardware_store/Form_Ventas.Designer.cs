namespace system_hardware_store
{
    partial class Form_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cerrar_venta = new System.Windows.Forms.PictureBox();
            this.listaventa = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkeliminar = new System.Windows.Forms.CheckBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txt_igv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_enlace_cli = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.PRECIO = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnombrecli = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_enlace_prod = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.btncomprar = new System.Windows.Forms.Button();
            this.btnanulacompra = new System.Windows.Forms.Button();
            this.cbTipo_Comprobante = new System.Windows.Forms.ComboBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Ventas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.cerrar_venta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(924, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 786);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btneditar.FlatAppearance.BorderSize = 2;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btneditar.Location = new System.Drawing.Point(61, 585);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(264, 46);
            this.btneditar.TabIndex = 18;
            this.btneditar.Text = "Modificar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(59, 514);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(266, 37);
            this.btneliminar.TabIndex = 19;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnnuevo.FlatAppearance.BorderSize = 2;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(59, 451);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(266, 37);
            this.btnnuevo.TabIndex = 21;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btn_guardar.FlatAppearance.BorderSize = 2;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_guardar.Location = new System.Drawing.Point(59, 380);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(266, 42);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cerrar_venta
            // 
            this.cerrar_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar_venta.Image = ((System.Drawing.Image)(resources.GetObject("cerrar_venta.Image")));
            this.cerrar_venta.Location = new System.Drawing.Point(352, 3);
            this.cerrar_venta.Name = "cerrar_venta";
            this.cerrar_venta.Size = new System.Drawing.Size(15, 15);
            this.cerrar_venta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_venta.TabIndex = 12;
            this.cerrar_venta.TabStop = false;
            this.cerrar_venta.Click += new System.EventHandler(this.cerrar_venta_Click);
            // 
            // listaventa
            // 
            this.listaventa.AllowUserToAddRows = false;
            this.listaventa.AllowUserToDeleteRows = false;
            this.listaventa.AllowUserToOrderColumns = true;
            this.listaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.listaventa.Location = new System.Drawing.Point(8, 585);
            this.listaventa.Name = "listaventa";
            this.listaventa.RowHeadersWidth = 62;
            this.listaventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaventa.Size = new System.Drawing.Size(736, 149);
            this.listaventa.TabIndex = 17;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 150;
            // 
            // checkeliminar
            // 
            this.checkeliminar.AutoSize = true;
            this.checkeliminar.BackColor = System.Drawing.Color.Maroon;
            this.checkeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkeliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkeliminar.Location = new System.Drawing.Point(8, 492);
            this.checkeliminar.Name = "checkeliminar";
            this.checkeliminar.Size = new System.Drawing.Size(84, 24);
            this.checkeliminar.TabIndex = 18;
            this.checkeliminar.Text = "Eliminar";
            this.checkeliminar.UseVisualStyleBackColor = false;
            this.checkeliminar.CheckedChanged += new System.EventHandler(this.checkeliminar_CheckedChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(594, 220);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(200, 20);
            this.txt_fecha.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "PRECIO";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(464, 273);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(50, 20);
            this.txtprecio.TabIndex = 68;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(161, 266);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(50, 20);
            this.txtcantidad.TabIndex = 67;
            // 
            // txt_igv
            // 
            this.txt_igv.Location = new System.Drawing.Point(594, 146);
            this.txt_igv.Name = "txt_igv";
            this.txt_igv.Size = new System.Drawing.Size(100, 20);
            this.txt_igv.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "IGV";
            // 
            // btn_enlace_cli
            // 
            this.btn_enlace_cli.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_enlace_cli.Image = ((System.Drawing.Image)(resources.GetObject("btn_enlace_cli.Image")));
            this.btn_enlace_cli.Location = new System.Drawing.Point(303, 82);
            this.btn_enlace_cli.Name = "btn_enlace_cli";
            this.btn_enlace_cli.Size = new System.Drawing.Size(41, 32);
            this.btn_enlace_cli.TabIndex = 64;
            this.btn_enlace_cli.UseVisualStyleBackColor = false;
            this.btn_enlace_cli.Click += new System.EventHandler(this.btn_enlace_cli_Click);
            // 
            // txtstock
            // 
            this.txtstock.Enabled = false;
            this.txtstock.Location = new System.Drawing.Point(312, 269);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(50, 20);
            this.txtstock.TabIndex = 63;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(345, 212);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 20);
            this.txtproducto.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "NU:DOCUMENTO";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(44, 38);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(48, 20);
            this.txtidcliente.TabIndex = 60;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(161, 205);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(50, 20);
            this.txtidproducto.TabIndex = 59;
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSize = true;
            this.PRECIO.Location = new System.Drawing.Point(52, 266);
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Size = new System.Drawing.Size(62, 13);
            this.PRECIO.TabIndex = 58;
            this.PRECIO.Text = "CANTIDAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "STOCK";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "PRODUCTO";
            // 
            // txtnombrecli
            // 
            this.txtnombrecli.Location = new System.Drawing.Point(135, 89);
            this.txtnombrecli.Name = "txtnombrecli";
            this.txtnombrecli.Size = new System.Drawing.Size(132, 20);
            this.txtnombrecli.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "IDPRODUCTO";
            // 
            // btn_enlace_prod
            // 
            this.btn_enlace_prod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_enlace_prod.Image = ((System.Drawing.Image)(resources.GetObject("btn_enlace_prod.Image")));
            this.btn_enlace_prod.Location = new System.Drawing.Point(485, 208);
            this.btn_enlace_prod.Name = "btn_enlace_prod";
            this.btn_enlace_prod.Size = new System.Drawing.Size(45, 32);
            this.btn_enlace_prod.TabIndex = 52;
            this.btn_enlace_prod.UseVisualStyleBackColor = false;
            this.btn_enlace_prod.Click += new System.EventHandler(this.btn_enlace_prod_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "CLIENTE";
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.AllowUserToAddRows = false;
            this.dataListadoDetalle.AllowUserToDeleteRows = false;
            this.dataListadoDetalle.AllowUserToOrderColumns = true;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(12, 367);
            this.dataListadoDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.RowHeadersWidth = 62;
            this.dataListadoDetalle.RowTemplate.Height = 24;
            this.dataListadoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoDetalle.Size = new System.Drawing.Size(714, 104);
            this.dataListadoDetalle.TabIndex = 71;
            // 
            // btncomprar
            // 
            this.btncomprar.Image = ((System.Drawing.Image)(resources.GetObject("btncomprar.Image")));
            this.btncomprar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncomprar.Location = new System.Drawing.Point(749, 367);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(128, 38);
            this.btncomprar.TabIndex = 73;
            this.btncomprar.Text = "AGREGAR";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnanulacompra
            // 
            this.btnanulacompra.Image = ((System.Drawing.Image)(resources.GetObject("btnanulacompra.Image")));
            this.btnanulacompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnanulacompra.Location = new System.Drawing.Point(749, 433);
            this.btnanulacompra.Name = "btnanulacompra";
            this.btnanulacompra.Size = new System.Drawing.Size(128, 38);
            this.btnanulacompra.TabIndex = 72;
            this.btnanulacompra.Text = "ELIMINAR";
            this.btnanulacompra.UseVisualStyleBackColor = true;
            // 
            // cbTipo_Comprobante
            // 
            this.cbTipo_Comprobante.FormattingEnabled = true;
            this.cbTipo_Comprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "GUIA REMISION"});
            this.cbTipo_Comprobante.Location = new System.Drawing.Point(175, 138);
            this.cbTipo_Comprobante.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo_Comprobante.Name = "cbTipo_Comprobante";
            this.cbTipo_Comprobante.Size = new System.Drawing.Size(92, 21);
            this.cbTipo_Comprobante.TabIndex = 74;
            this.cbTipo_Comprobante.Text = "TICKET";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(380, 143);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(98, 20);
            this.txtserie.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "N.SERIE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(196, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 28);
            this.label2.TabIndex = 78;
            this.label2.Text = "LISTA DE COMPRAS ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(760, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 97);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 80;
            this.button1.Text = "Comprobante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(15, 551);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(200, 20);
            this.fecha1.TabIndex = 81;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(267, 551);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(200, 20);
            this.fecha2.TabIndex = 82;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(532, 545);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 36);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Fecha Fin";
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 786);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.cbTipo_Comprobante);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.btnanulacompra);
            this.Controls.Add(this.dataListadoDetalle);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txt_igv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_enlace_cli);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.PRECIO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtnombrecli);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_enlace_prod);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkeliminar);
            this.Controls.Add(this.listaventa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Ventas";
            this.Text = "Form_Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Form_Ventas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar_venta;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView listaventa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.CheckBox checkeliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.TextBox txt_igv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_enlace_cli;
        public System.Windows.Forms.TextBox txtstock;
        public System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtidcliente;
        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label PRECIO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtnombrecli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_enlace_prod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.Button btnanulacompra;
        private System.Windows.Forms.ComboBox cbTipo_Comprobante;
        public System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}