namespace CAPA_PRESENTACION
{
	partial class frm_facturacion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturacion));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_cantidad = new System.Windows.Forms.TextBox();
			this.dgv_facturacion_productos = new System.Windows.Forms.DataGridView();
			this.txt_prod_nombre = new System.Windows.Forms.TextBox();
			this.txt_prod_codigo = new System.Windows.Forms.TextBox();
			this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
			this.btn_agregar_producto = new ePOSOne.btnProduct.Button_WOC();
			this.lbl_nombre_usuario = new System.Windows.Forms.Label();
			this.btn_devoluciones = new ePOSOne.btnProduct.Button_WOC();
			this.btn_ver_facturas = new ePOSOne.btnProduct.Button_WOC();
			this.btn_eliminar_producto = new ePOSOne.btnProduct.Button_WOC();
			this.label13 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_numero_factura = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_descuento = new System.Windows.Forms.TextBox();
			this.btn_facturar = new ePOSOne.btnProduct.Button_WOC();
			this.lbl_total = new System.Windows.Forms.Label();
			this.lbl_descuento = new System.Windows.Forms.Label();
			this.lbl_subtotal = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion_productos)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mantenimientoToolStripMenuItem
			// 
			this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
			this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
			this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.productosToolStripMenuItem.Text = "Productos";
			this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_cantidad);
			this.panel1.Controls.Add(this.dgv_facturacion_productos);
			this.panel1.Controls.Add(this.txt_prod_nombre);
			this.panel1.Controls.Add(this.txt_prod_codigo);
			this.panel1.Controls.Add(this.txt_nombre_cliente);
			this.panel1.Controls.Add(this.btn_agregar_producto);
			this.panel1.Controls.Add(this.lbl_nombre_usuario);
			this.panel1.Controls.Add(this.btn_devoluciones);
			this.panel1.Controls.Add(this.btn_ver_facturas);
			this.panel1.Controls.Add(this.btn_eliminar_producto);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lbl_numero_factura);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new System.Drawing.Point(12, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(759, 557);
			this.panel1.TabIndex = 5;
			// 
			// txt_cantidad
			// 
			this.txt_cantidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_cantidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_cantidad.BackColor = System.Drawing.SystemColors.Control;
			this.txt_cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cantidad.Location = new System.Drawing.Point(492, 236);
			this.txt_cantidad.Name = "txt_cantidad";
			this.txt_cantidad.Size = new System.Drawing.Size(106, 26);
			this.txt_cantidad.TabIndex = 36;
			this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
			// 
			// dgv_facturacion_productos
			// 
			this.dgv_facturacion_productos.AllowUserToAddRows = false;
			this.dgv_facturacion_productos.AllowUserToDeleteRows = false;
			this.dgv_facturacion_productos.AllowUserToResizeColumns = false;
			this.dgv_facturacion_productos.AllowUserToResizeRows = false;
			this.dgv_facturacion_productos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_facturacion_productos.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_facturacion_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_facturacion_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_facturacion_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_facturacion_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_facturacion_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_facturacion_productos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_facturacion_productos.EnableHeadersVisualStyles = false;
			this.dgv_facturacion_productos.Location = new System.Drawing.Point(12, 309);
			this.dgv_facturacion_productos.MultiSelect = false;
			this.dgv_facturacion_productos.Name = "dgv_facturacion_productos";
			this.dgv_facturacion_productos.RowHeadersVisible = false;
			this.dgv_facturacion_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_facturacion_productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_facturacion_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_facturacion_productos.Size = new System.Drawing.Size(733, 233);
			this.dgv_facturacion_productos.TabIndex = 35;
			// 
			// txt_prod_nombre
			// 
			this.txt_prod_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_prod_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_prod_nombre.BackColor = System.Drawing.SystemColors.Control;
			this.txt_prod_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_prod_nombre.Location = new System.Drawing.Point(174, 236);
			this.txt_prod_nombre.Name = "txt_prod_nombre";
			this.txt_prod_nombre.Size = new System.Drawing.Size(312, 26);
			this.txt_prod_nombre.TabIndex = 31;
			this.txt_prod_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_prod_nombre_KeyDown);
			// 
			// txt_prod_codigo
			// 
			this.txt_prod_codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_prod_codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_prod_codigo.BackColor = System.Drawing.SystemColors.Control;
			this.txt_prod_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_prod_codigo.Location = new System.Drawing.Point(25, 236);
			this.txt_prod_codigo.Name = "txt_prod_codigo";
			this.txt_prod_codigo.Size = new System.Drawing.Size(143, 26);
			this.txt_prod_codigo.TabIndex = 30;
			this.txt_prod_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_prod_codigo_KeyDown);
			this.txt_prod_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prod_codigo_KeyPress);
			// 
			// txt_nombre_cliente
			// 
			this.txt_nombre_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_nombre_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_nombre_cliente.BackColor = System.Drawing.SystemColors.Control;
			this.txt_nombre_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nombre_cliente.Location = new System.Drawing.Point(58, 116);
			this.txt_nombre_cliente.Name = "txt_nombre_cliente";
			this.txt_nombre_cliente.Size = new System.Drawing.Size(387, 26);
			this.txt_nombre_cliente.TabIndex = 29;
			// 
			// btn_agregar_producto
			// 
			this.btn_agregar_producto.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_agregar_producto.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_agregar_producto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_agregar_producto.FlatAppearance.BorderSize = 0;
			this.btn_agregar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_agregar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_agregar_producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_agregar_producto.Location = new System.Drawing.Point(102, 267);
			this.btn_agregar_producto.Name = "btn_agregar_producto";
			this.btn_agregar_producto.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_agregar_producto.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_agregar_producto.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_agregar_producto.Size = new System.Drawing.Size(255, 36);
			this.btn_agregar_producto.TabIndex = 28;
			this.btn_agregar_producto.Text = "Agregar Producto";
			this.btn_agregar_producto.TextColor = System.Drawing.Color.White;
			this.btn_agregar_producto.UseVisualStyleBackColor = true;
			this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
			// 
			// lbl_nombre_usuario
			// 
			this.lbl_nombre_usuario.AutoSize = true;
			this.lbl_nombre_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nombre_usuario.Location = new System.Drawing.Point(460, 74);
			this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
			this.lbl_nombre_usuario.Size = new System.Drawing.Size(66, 18);
			this.lbl_nombre_usuario.TabIndex = 27;
			this.lbl_nombre_usuario.Text = "Usuario:";
			// 
			// btn_devoluciones
			// 
			this.btn_devoluciones.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_devoluciones.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.FlatAppearance.BorderSize = 0;
			this.btn_devoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_devoluciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_devoluciones.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.Location = new System.Drawing.Point(606, 113);
			this.btn_devoluciones.Name = "btn_devoluciones";
			this.btn_devoluciones.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_devoluciones.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_devoluciones.Size = new System.Drawing.Size(139, 32);
			this.btn_devoluciones.TabIndex = 26;
			this.btn_devoluciones.Text = "Devoluciones";
			this.btn_devoluciones.TextColor = System.Drawing.Color.White;
			this.btn_devoluciones.UseVisualStyleBackColor = true;
			this.btn_devoluciones.Click += new System.EventHandler(this.btn_devolucines_Click);
			// 
			// btn_ver_facturas
			// 
			this.btn_ver_facturas.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_ver_facturas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.FlatAppearance.BorderSize = 0;
			this.btn_ver_facturas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_ver_facturas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ver_facturas.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.Location = new System.Drawing.Point(464, 112);
			this.btn_ver_facturas.Name = "btn_ver_facturas";
			this.btn_ver_facturas.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_ver_facturas.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.Size = new System.Drawing.Size(139, 32);
			this.btn_ver_facturas.TabIndex = 25;
			this.btn_ver_facturas.Text = "Ver Facturas";
			this.btn_ver_facturas.TextColor = System.Drawing.SystemColors.Control;
			this.btn_ver_facturas.UseVisualStyleBackColor = true;
			this.btn_ver_facturas.Click += new System.EventHandler(this.btn_ver_facturas_Click);
			// 
			// btn_eliminar_producto
			// 
			this.btn_eliminar_producto.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_eliminar_producto.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_eliminar_producto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_eliminar_producto.FlatAppearance.BorderSize = 0;
			this.btn_eliminar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_eliminar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_eliminar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_eliminar_producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_eliminar_producto.Location = new System.Drawing.Point(373, 267);
			this.btn_eliminar_producto.Name = "btn_eliminar_producto";
			this.btn_eliminar_producto.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_eliminar_producto.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_eliminar_producto.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_eliminar_producto.Size = new System.Drawing.Size(255, 36);
			this.btn_eliminar_producto.TabIndex = 24;
			this.btn_eliminar_producto.Text = "Eliminar Producto";
			this.btn_eliminar_producto.TextColor = System.Drawing.Color.White;
			this.btn_eliminar_producto.UseVisualStyleBackColor = true;
			this.btn_eliminar_producto.Click += new System.EventHandler(this.btn_eliminar_producto_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(386, 74);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 19);
			this.label13.TabIndex = 16;
			this.label13.Text = "Usuario:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(489, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 19);
			this.label7.TabIndex = 9;
			this.label7.Text = "Cantidad:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(171, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 19);
			this.label6.TabIndex = 8;
			this.label6.Text = "Articulo:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 19);
			this.label5.TabIndex = 7;
			this.label5.Text = "Código:";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label4);
			this.panel5.Location = new System.Drawing.Point(12, 151);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(733, 40);
			this.panel5.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(286, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "Detalle de Factura";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.icon_cliente;
			this.pictureBox1.Location = new System.Drawing.Point(12, 105);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// lbl_numero_factura
			// 
			this.lbl_numero_factura.AutoSize = true;
			this.lbl_numero_factura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numero_factura.ForeColor = System.Drawing.Color.Red;
			this.lbl_numero_factura.Location = new System.Drawing.Point(141, 74);
			this.lbl_numero_factura.Name = "lbl_numero_factura";
			this.lbl_numero_factura.Size = new System.Drawing.Size(50, 18);
			this.lbl_numero_factura.TabIndex = 2;
			this.lbl_numero_factura.Text = "label4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "N° Factura:";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(12, 13);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(733, 44);
			this.panel4.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(189, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(338, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Facturacion de Ventas - Fresh Supermarket";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txt_descuento);
			this.panel2.Controls.Add(this.btn_facturar);
			this.panel2.Controls.Add(this.lbl_total);
			this.panel2.Controls.Add(this.lbl_descuento);
			this.panel2.Controls.Add(this.lbl_subtotal);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(786, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(289, 557);
			this.panel2.TabIndex = 6;
			// 
			// txt_descuento
			// 
			this.txt_descuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_descuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_descuento.BackColor = System.Drawing.SystemColors.Control;
			this.txt_descuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_descuento.Location = new System.Drawing.Point(114, 205);
			this.txt_descuento.Name = "txt_descuento";
			this.txt_descuento.Size = new System.Drawing.Size(161, 26);
			this.txt_descuento.TabIndex = 37;
			this.txt_descuento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descuento_KeyDown);
			this.txt_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descuento_KeyPress);
			// 
			// btn_facturar
			// 
			this.btn_facturar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_facturar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_facturar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_facturar.FlatAppearance.BorderSize = 0;
			this.btn_facturar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_facturar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_facturar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_facturar.Location = new System.Drawing.Point(79, 387);
			this.btn_facturar.Name = "btn_facturar";
			this.btn_facturar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_facturar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_facturar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_facturar.Size = new System.Drawing.Size(133, 45);
			this.btn_facturar.TabIndex = 23;
			this.btn_facturar.Text = "Facturar";
			this.btn_facturar.TextColor = System.Drawing.Color.White;
			this.btn_facturar.UseVisualStyleBackColor = true;
			this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
			// 
			// lbl_total
			// 
			this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_total.Location = new System.Drawing.Point(115, 340);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(160, 20);
			this.lbl_total.TabIndex = 22;
			this.lbl_total.Text = "0";
			this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_descuento
			// 
			this.lbl_descuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_descuento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_descuento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_descuento.Location = new System.Drawing.Point(115, 309);
			this.lbl_descuento.Name = "lbl_descuento";
			this.lbl_descuento.Size = new System.Drawing.Size(160, 20);
			this.lbl_descuento.TabIndex = 21;
			this.lbl_descuento.Text = "0";
			this.lbl_descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_subtotal
			// 
			this.lbl_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_subtotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_subtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_subtotal.Location = new System.Drawing.Point(115, 279);
			this.lbl_subtotal.Name = "lbl_subtotal";
			this.lbl_subtotal.Size = new System.Drawing.Size(160, 20);
			this.lbl_subtotal.TabIndex = 20;
			this.lbl_subtotal.Text = "0";
			this.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(14, 340);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 19);
			this.label12.TabIndex = 19;
			this.label12.Text = "TOTAL:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(14, 309);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(93, 20);
			this.label11.TabIndex = 18;
			this.label11.Text = "DESCUENTO:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(14, 279);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 20);
			this.label10.TabIndex = 17;
			this.label10.Text = "SUBTOTAL:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(10, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 19);
			this.label9.TabIndex = 16;
			this.label9.Text = "Descuento:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(14, 13);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(261, 44);
			this.panel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(44, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Desglose de Factura";
			// 
			// frm_facturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 609);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm_facturacion";
			this.Text = "Facturación Ventas - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_facturacion_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion_productos)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lbl_numero_factura;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label13;
		private ePOSOne.btnProduct.Button_WOC btn_facturar;
		public System.Windows.Forms.Label lbl_total;
		public System.Windows.Forms.Label lbl_descuento;
		public System.Windows.Forms.Label lbl_subtotal;
		private ePOSOne.btnProduct.Button_WOC btn_eliminar_producto;
		private ePOSOne.btnProduct.Button_WOC btn_devoluciones;
		private ePOSOne.btnProduct.Button_WOC btn_ver_facturas;
		public System.Windows.Forms.Label lbl_nombre_usuario;
		private ePOSOne.btnProduct.Button_WOC btn_agregar_producto;
		public System.Windows.Forms.TextBox txt_nombre_cliente;
		private System.Windows.Forms.TextBox txt_prod_nombre;
		private System.Windows.Forms.TextBox txt_prod_codigo;
		public System.Windows.Forms.DataGridView dgv_facturacion_productos;
		private System.Windows.Forms.TextBox txt_cantidad;
		private System.Windows.Forms.TextBox txt_descuento;
	}
}