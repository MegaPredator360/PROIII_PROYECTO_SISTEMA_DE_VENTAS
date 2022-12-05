namespace CAPA_PRESENTACION
{
	partial class frm_facturacion_facturas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturacion_facturas));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgv_facturas = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_clientes = new System.Windows.Forms.Label();
			this.txt_buscar_factura = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_buscar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_detalles = new ePOSOne.btnProduct.Button_WOC();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_facturas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txt_buscar_factura);
			this.panel1.Controls.Add(this.dgv_facturas);
			this.panel1.Controls.Add(this.btn_buscar);
			this.panel1.Controls.Add(this.btn_detalles);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(965, 573);
			this.panel1.TabIndex = 2;
			// 
			// dgv_facturas
			// 
			this.dgv_facturas.AllowUserToAddRows = false;
			this.dgv_facturas.AllowUserToDeleteRows = false;
			this.dgv_facturas.AllowUserToResizeColumns = false;
			this.dgv_facturas.AllowUserToResizeRows = false;
			this.dgv_facturas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_facturas.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_facturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_facturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_facturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_facturas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_facturas.EnableHeadersVisualStyles = false;
			this.dgv_facturas.Location = new System.Drawing.Point(12, 131);
			this.dgv_facturas.MultiSelect = false;
			this.dgv_facturas.Name = "dgv_facturas";
			this.dgv_facturas.RowHeadersVisible = false;
			this.dgv_facturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_facturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_facturas.Size = new System.Drawing.Size(936, 427);
			this.dgv_facturas.TabIndex = 5;
			this.dgv_facturas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_facturas_CellContentDoubleClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.icon_lupa;
			this.pictureBox1.Location = new System.Drawing.Point(27, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Controls.Add(this.lbl_clientes);
			this.panel2.Location = new System.Drawing.Point(12, 13);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(936, 41);
			this.panel2.TabIndex = 0;
			// 
			// lbl_clientes
			// 
			this.lbl_clientes.AutoSize = true;
			this.lbl_clientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_clientes.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_clientes.Location = new System.Drawing.Point(302, 10);
			this.lbl_clientes.Name = "lbl_clientes";
			this.lbl_clientes.Size = new System.Drawing.Size(323, 19);
			this.lbl_clientes.TabIndex = 0;
			this.lbl_clientes.Text = "Facturas Realizadas - Fresh Supermarket";
			// 
			// txt_buscar_factura
			// 
			this.txt_buscar_factura.BackColor = System.Drawing.SystemColors.Control;
			this.txt_buscar_factura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_buscar_factura.Location = new System.Drawing.Point(64, 96);
			this.txt_buscar_factura.Name = "txt_buscar_factura";
			this.txt_buscar_factura.Size = new System.Drawing.Size(583, 26);
			this.txt_buscar_factura.TabIndex = 6;
			this.txt_buscar_factura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_factura_KeyDown);
			this.txt_buscar_factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_factura_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(60, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingresar el número de Factura a Buscar:";
			// 
			// btn_buscar
			// 
			this.btn_buscar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.FlatAppearance.BorderSize = 0;
			this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_buscar.Location = new System.Drawing.Point(659, 92);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_buscar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.Size = new System.Drawing.Size(140, 33);
			this.btn_buscar.TabIndex = 4;
			this.btn_buscar.Text = "Buscar";
			this.btn_buscar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
			// 
			// btn_detalles
			// 
			this.btn_detalles.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_detalles.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.FlatAppearance.BorderSize = 0;
			this.btn_detalles.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_detalles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_detalles.Location = new System.Drawing.Point(805, 92);
			this.btn_detalles.Name = "btn_detalles";
			this.btn_detalles.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_detalles.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.Size = new System.Drawing.Size(140, 33);
			this.btn_detalles.TabIndex = 3;
			this.btn_detalles.Text = "Detalles";
			this.btn_detalles.TextColor = System.Drawing.SystemColors.Control;
			this.btn_detalles.UseVisualStyleBackColor = true;
			this.btn_detalles.Click += new System.EventHandler(this.btn_detalles_Click);
			// 
			// frm_facturacion_facturas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 597);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_facturacion_facturas";
			this.Text = "Facturas Realizadas - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_facturacion_facturas_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_facturas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgv_facturas;
		private ePOSOne.btnProduct.Button_WOC btn_buscar;
		private ePOSOne.btnProduct.Button_WOC btn_detalles;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_clientes;
		private System.Windows.Forms.TextBox txt_buscar_factura;
		private System.Windows.Forms.Label label1;
	}
}