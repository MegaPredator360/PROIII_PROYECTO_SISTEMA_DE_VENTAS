namespace CAPA_PRESENTACION
{
	partial class frm_facturacion_facturas_detalles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturacion_facturas_detalles));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgv_detalle_factura = new System.Windows.Forms.DataGridView();
			this.lbl_total = new System.Windows.Forms.Label();
			this.lbl_fecha = new System.Windows.Forms.Label();
			this.lbl_nombre_cliente = new System.Windows.Forms.Label();
			this.lbl_numero_factura = new System.Windows.Forms.Label();
			this.btn_add_salir = new ePOSOne.btnProduct.Button_WOC();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_factura)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(415, 41);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(131, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Detalle de Factura";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(24, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "N° Factura:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(24, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre Cliente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(24, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Fecha:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dgv_detalle_factura);
			this.panel1.Controls.Add(this.lbl_total);
			this.panel1.Controls.Add(this.lbl_fecha);
			this.panel1.Controls.Add(this.lbl_nombre_cliente);
			this.panel1.Controls.Add(this.lbl_numero_factura);
			this.panel1.Controls.Add(this.btn_add_salir);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(441, 561);
			this.panel1.TabIndex = 3;
			// 
			// dgv_detalle_factura
			// 
			this.dgv_detalle_factura.AllowUserToAddRows = false;
			this.dgv_detalle_factura.AllowUserToDeleteRows = false;
			this.dgv_detalle_factura.AllowUserToResizeColumns = false;
			this.dgv_detalle_factura.AllowUserToResizeRows = false;
			this.dgv_detalle_factura.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_detalle_factura.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_detalle_factura.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_detalle_factura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_detalle_factura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_detalle_factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_detalle_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_detalle_factura.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_detalle_factura.EnableHeadersVisualStyles = false;
			this.dgv_detalle_factura.Location = new System.Drawing.Point(12, 206);
			this.dgv_detalle_factura.MultiSelect = false;
			this.dgv_detalle_factura.Name = "dgv_detalle_factura";
			this.dgv_detalle_factura.RowHeadersVisible = false;
			this.dgv_detalle_factura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_detalle_factura.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_detalle_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_detalle_factura.Size = new System.Drawing.Size(415, 294);
			this.dgv_detalle_factura.TabIndex = 21;
			// 
			// lbl_total
			// 
			this.lbl_total.AutoSize = true;
			this.lbl_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_total.Location = new System.Drawing.Point(156, 184);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(86, 18);
			this.lbl_total.TabIndex = 20;
			this.lbl_total.Text = "N° Factura:";
			// 
			// lbl_fecha
			// 
			this.lbl_fecha.AutoSize = true;
			this.lbl_fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_fecha.Location = new System.Drawing.Point(156, 146);
			this.lbl_fecha.Name = "lbl_fecha";
			this.lbl_fecha.Size = new System.Drawing.Size(86, 18);
			this.lbl_fecha.TabIndex = 19;
			this.lbl_fecha.Text = "N° Factura:";
			// 
			// lbl_nombre_cliente
			// 
			this.lbl_nombre_cliente.AutoSize = true;
			this.lbl_nombre_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nombre_cliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_nombre_cliente.Location = new System.Drawing.Point(156, 107);
			this.lbl_nombre_cliente.Name = "lbl_nombre_cliente";
			this.lbl_nombre_cliente.Size = new System.Drawing.Size(86, 18);
			this.lbl_nombre_cliente.TabIndex = 18;
			this.lbl_nombre_cliente.Text = "N° Factura:";
			// 
			// lbl_numero_factura
			// 
			this.lbl_numero_factura.AutoSize = true;
			this.lbl_numero_factura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numero_factura.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_numero_factura.Location = new System.Drawing.Point(156, 67);
			this.lbl_numero_factura.Name = "lbl_numero_factura";
			this.lbl_numero_factura.Size = new System.Drawing.Size(86, 18);
			this.lbl_numero_factura.TabIndex = 17;
			this.lbl_numero_factura.Text = "N° Factura:";
			// 
			// btn_add_salir
			// 
			this.btn_add_salir.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_add_salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_add_salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add_salir.Location = new System.Drawing.Point(148, 506);
			this.btn_add_salir.Name = "btn_add_salir";
			this.btn_add_salir.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_add_salir.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.Size = new System.Drawing.Size(142, 39);
			this.btn_add_salir.TabIndex = 15;
			this.btn_add_salir.Text = "Salir";
			this.btn_add_salir.TextColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.UseVisualStyleBackColor = true;
			this.btn_add_salir.Click += new System.EventHandler(this.btn_add_salir_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(24, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 19);
			this.label5.TabIndex = 10;
			this.label5.Text = "Total:";
			// 
			// frm_facturacion_facturas_detalles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 585);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_facturacion_facturas_detalles";
			this.Text = "Detalles de Factura - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_facturacion_facturas_detalles_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_factura)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private ePOSOne.btnProduct.Button_WOC btn_add_salir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label lbl_total;
		public System.Windows.Forms.Label lbl_fecha;
		public System.Windows.Forms.Label lbl_nombre_cliente;
		public System.Windows.Forms.Label lbl_numero_factura;
		public System.Windows.Forms.DataGridView dgv_detalle_factura;
	}
}