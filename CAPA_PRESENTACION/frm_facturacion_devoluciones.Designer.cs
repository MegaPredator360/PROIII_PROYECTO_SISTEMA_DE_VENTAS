namespace CAPA_PRESENTACION
{
	partial class frm_facturacion_devoluciones
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturacion_devoluciones));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_cantidad_devolver = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_nombre_producto = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgv_buscar_producto = new System.Windows.Forms.DataGridView();
			this.dgv_buscar_factura = new System.Windows.Forms.DataGridView();
			this.txt_buscar_factura = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_salir = new ePOSOne.btnProduct.Button_WOC();
			this.btn_guardar_cambios = new ePOSOne.btnProduct.Button_WOC();
			this.btn_seleccionar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_buscar = new ePOSOne.btnProduct.Button_WOC();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_producto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_factura)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btn_salir);
			this.panel1.Controls.Add(this.btn_guardar_cambios);
			this.panel1.Controls.Add(this.txt_cantidad_devolver);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lbl_nombre_producto);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dgv_buscar_producto);
			this.panel1.Controls.Add(this.btn_seleccionar);
			this.panel1.Controls.Add(this.dgv_buscar_factura);
			this.panel1.Controls.Add(this.btn_buscar);
			this.panel1.Controls.Add(this.txt_buscar_factura);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(441, 637);
			this.panel1.TabIndex = 3;
			// 
			// txt_cantidad_devolver
			// 
			this.txt_cantidad_devolver.BackColor = System.Drawing.SystemColors.Control;
			this.txt_cantidad_devolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cantidad_devolver.Location = new System.Drawing.Point(191, 535);
			this.txt_cantidad_devolver.Name = "txt_cantidad_devolver";
			this.txt_cantidad_devolver.Size = new System.Drawing.Size(236, 26);
			this.txt_cantidad_devolver.TabIndex = 42;
			this.txt_cantidad_devolver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cantidad_devolver_KeyDown);
			this.txt_cantidad_devolver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_devolver_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(18, 538);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 19);
			this.label5.TabIndex = 41;
			this.label5.Text = "Cantidad a Devolver:";
			// 
			// lbl_nombre_producto
			// 
			this.lbl_nombre_producto.AutoSize = true;
			this.lbl_nombre_producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nombre_producto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_nombre_producto.Location = new System.Drawing.Point(198, 506);
			this.lbl_nombre_producto.Name = "lbl_nombre_producto";
			this.lbl_nombre_producto.Size = new System.Drawing.Size(157, 18);
			this.lbl_nombre_producto.TabIndex = 40;
			this.lbl_nombre_producto.Text = "Nombre de Producto:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(18, 506);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 19);
			this.label4.TabIndex = 39;
			this.label4.Text = "Nombre de Producto:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(125, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 19);
			this.label3.TabIndex = 38;
			this.label3.Text = "Seleccionar Producto:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(129, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 19);
			this.label2.TabIndex = 37;
			this.label2.Text = "Seleccionar Factura:";
			// 
			// dgv_buscar_producto
			// 
			this.dgv_buscar_producto.AllowUserToAddRows = false;
			this.dgv_buscar_producto.AllowUserToDeleteRows = false;
			this.dgv_buscar_producto.AllowUserToResizeColumns = false;
			this.dgv_buscar_producto.AllowUserToResizeRows = false;
			this.dgv_buscar_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_buscar_producto.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_buscar_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_buscar_producto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_buscar_producto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_buscar_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_buscar_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_buscar_producto.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_buscar_producto.EnableHeadersVisualStyles = false;
			this.dgv_buscar_producto.Location = new System.Drawing.Point(12, 387);
			this.dgv_buscar_producto.MultiSelect = false;
			this.dgv_buscar_producto.Name = "dgv_buscar_producto";
			this.dgv_buscar_producto.RowHeadersVisible = false;
			this.dgv_buscar_producto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_buscar_producto.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_buscar_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_buscar_producto.Size = new System.Drawing.Size(415, 108);
			this.dgv_buscar_producto.TabIndex = 36;
			this.dgv_buscar_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_buscar_producto_CellClick);
			// 
			// dgv_buscar_factura
			// 
			this.dgv_buscar_factura.AllowUserToAddRows = false;
			this.dgv_buscar_factura.AllowUserToDeleteRows = false;
			this.dgv_buscar_factura.AllowUserToResizeColumns = false;
			this.dgv_buscar_factura.AllowUserToResizeRows = false;
			this.dgv_buscar_factura.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_buscar_factura.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_buscar_factura.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_buscar_factura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_buscar_factura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_buscar_factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_buscar_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_buscar_factura.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_buscar_factura.EnableHeadersVisualStyles = false;
			this.dgv_buscar_factura.Location = new System.Drawing.Point(12, 217);
			this.dgv_buscar_factura.MultiSelect = false;
			this.dgv_buscar_factura.Name = "dgv_buscar_factura";
			this.dgv_buscar_factura.RowHeadersVisible = false;
			this.dgv_buscar_factura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_buscar_factura.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_buscar_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_buscar_factura.Size = new System.Drawing.Size(415, 70);
			this.dgv_buscar_factura.TabIndex = 34;
			this.dgv_buscar_factura.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_buscar_factura_CellContentDoubleClick);
			// 
			// txt_buscar_factura
			// 
			this.txt_buscar_factura.BackColor = System.Drawing.SystemColors.Control;
			this.txt_buscar_factura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_buscar_factura.Location = new System.Drawing.Point(185, 80);
			this.txt_buscar_factura.Name = "txt_buscar_factura";
			this.txt_buscar_factura.Size = new System.Drawing.Size(236, 26);
			this.txt_buscar_factura.TabIndex = 32;
			this.txt_buscar_factura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_factura_KeyDown);
			this.txt_buscar_factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_factura_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(18, 83);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(161, 19);
			this.label7.TabIndex = 29;
			this.label7.Text = "Numero de Factura:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 13);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(415, 41);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(121, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Realizar Devolución";
			// 
			// btn_salir
			// 
			this.btn_salir.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_salir.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_salir.Location = new System.Drawing.Point(222, 577);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_salir.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_salir.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_salir.Size = new System.Drawing.Size(165, 39);
			this.btn_salir.TabIndex = 44;
			this.btn_salir.Text = "Salir";
			this.btn_salir.TextColor = System.Drawing.SystemColors.Control;
			this.btn_salir.UseVisualStyleBackColor = true;
			this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
			// 
			// btn_guardar_cambios
			// 
			this.btn_guardar_cambios.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_guardar_cambios.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_guardar_cambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_guardar_cambios.Location = new System.Drawing.Point(51, 577);
			this.btn_guardar_cambios.Name = "btn_guardar_cambios";
			this.btn_guardar_cambios.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_guardar_cambios.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.Size = new System.Drawing.Size(165, 39);
			this.btn_guardar_cambios.TabIndex = 43;
			this.btn_guardar_cambios.Text = "Guardar Cambios";
			this.btn_guardar_cambios.TextColor = System.Drawing.SystemColors.Control;
			this.btn_guardar_cambios.UseVisualStyleBackColor = true;
			this.btn_guardar_cambios.Click += new System.EventHandler(this.btn_guardar_cambios_Click);
			// 
			// btn_seleccionar
			// 
			this.btn_seleccionar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_seleccionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_seleccionar.Location = new System.Drawing.Point(147, 297);
			this.btn_seleccionar.Name = "btn_seleccionar";
			this.btn_seleccionar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_seleccionar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.Size = new System.Drawing.Size(132, 39);
			this.btn_seleccionar.TabIndex = 35;
			this.btn_seleccionar.Text = "Seleccionar";
			this.btn_seleccionar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_seleccionar.UseVisualStyleBackColor = true;
			this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
			// 
			// btn_buscar
			// 
			this.btn_buscar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_buscar.Location = new System.Drawing.Point(147, 122);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_buscar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.Size = new System.Drawing.Size(132, 39);
			this.btn_buscar.TabIndex = 33;
			this.btn_buscar.Text = "Buscar";
			this.btn_buscar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
			// 
			// frm_facturacion_devoluciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 661);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_facturacion_devoluciones";
			this.Text = "Devolucion de Productos - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_facturacion_devoluciones_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_producto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_factura)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private ePOSOne.btnProduct.Button_WOC btn_buscar;
		private System.Windows.Forms.TextBox txt_buscar_factura;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.DataGridView dgv_buscar_producto;
		private ePOSOne.btnProduct.Button_WOC btn_seleccionar;
		public System.Windows.Forms.DataGridView dgv_buscar_factura;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_cantidad_devolver;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_nombre_producto;
		private System.Windows.Forms.Label label4;
		private ePOSOne.btnProduct.Button_WOC btn_salir;
		private ePOSOne.btnProduct.Button_WOC btn_guardar_cambios;
	}
}