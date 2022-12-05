namespace CAPA_PRESENTACION
{
	partial class frm_facturacion_pago
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturacion_pago));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_deposito = new System.Windows.Forms.TextBox();
			this.lbl_deposito = new System.Windows.Forms.Label();
			this.txt_tarjeta = new System.Windows.Forms.TextBox();
			this.lbl_tarjeta = new System.Windows.Forms.Label();
			this.txt_monto_pago = new System.Windows.Forms.TextBox();
			this.lbl_valor_vuelto = new System.Windows.Forms.Label();
			this.lbl_vuelto = new System.Windows.Forms.Label();
			this.lbl_paga_con = new System.Windows.Forms.Label();
			this.cbx_metodo_pago = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_costo_total = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_terminar_compra = new ePOSOne.btnProduct.Button_WOC();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_deposito);
			this.panel1.Controls.Add(this.lbl_deposito);
			this.panel1.Controls.Add(this.txt_tarjeta);
			this.panel1.Controls.Add(this.lbl_tarjeta);
			this.panel1.Controls.Add(this.txt_monto_pago);
			this.panel1.Controls.Add(this.lbl_valor_vuelto);
			this.panel1.Controls.Add(this.lbl_vuelto);
			this.panel1.Controls.Add(this.lbl_paga_con);
			this.panel1.Controls.Add(this.cbx_metodo_pago);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lbl_costo_total);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btn_terminar_compra);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(441, 374);
			this.panel1.TabIndex = 3;
			// 
			// txt_deposito
			// 
			this.txt_deposito.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_deposito.Location = new System.Drawing.Point(160, 252);
			this.txt_deposito.Name = "txt_deposito";
			this.txt_deposito.Size = new System.Drawing.Size(113, 29);
			this.txt_deposito.TabIndex = 41;
			// 
			// lbl_deposito
			// 
			this.lbl_deposito.AutoSize = true;
			this.lbl_deposito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_deposito.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_deposito.Location = new System.Drawing.Point(132, 224);
			this.lbl_deposito.Name = "lbl_deposito";
			this.lbl_deposito.Size = new System.Drawing.Size(172, 19);
			this.lbl_deposito.TabIndex = 40;
			this.lbl_deposito.Text = "Numero de Deposito:";
			// 
			// txt_tarjeta
			// 
			this.txt_tarjeta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_tarjeta.Location = new System.Drawing.Point(159, 252);
			this.txt_tarjeta.Name = "txt_tarjeta";
			this.txt_tarjeta.Size = new System.Drawing.Size(113, 29);
			this.txt_tarjeta.TabIndex = 39;
			// 
			// lbl_tarjeta
			// 
			this.lbl_tarjeta.AutoSize = true;
			this.lbl_tarjeta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tarjeta.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_tarjeta.Location = new System.Drawing.Point(110, 224);
			this.lbl_tarjeta.Name = "lbl_tarjeta";
			this.lbl_tarjeta.Size = new System.Drawing.Size(232, 19);
			this.lbl_tarjeta.TabIndex = 38;
			this.lbl_tarjeta.Text = "Ultimos 4 numeros de tarjeta:";
			// 
			// txt_monto_pago
			// 
			this.txt_monto_pago.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_monto_pago.Location = new System.Drawing.Point(66, 252);
			this.txt_monto_pago.Name = "txt_monto_pago";
			this.txt_monto_pago.Size = new System.Drawing.Size(113, 29);
			this.txt_monto_pago.TabIndex = 37;
			this.txt_monto_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_monto_pago_KeyDown);
			// 
			// lbl_valor_vuelto
			// 
			this.lbl_valor_vuelto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_valor_vuelto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_valor_vuelto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_valor_vuelto.Location = new System.Drawing.Point(236, 252);
			this.lbl_valor_vuelto.Name = "lbl_valor_vuelto";
			this.lbl_valor_vuelto.Size = new System.Drawing.Size(129, 31);
			this.lbl_valor_vuelto.TabIndex = 36;
			this.lbl_valor_vuelto.Text = "00000";
			this.lbl_valor_vuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_vuelto
			// 
			this.lbl_vuelto.AutoSize = true;
			this.lbl_vuelto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_vuelto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_vuelto.Location = new System.Drawing.Point(269, 224);
			this.lbl_vuelto.Name = "lbl_vuelto";
			this.lbl_vuelto.Size = new System.Drawing.Size(63, 19);
			this.lbl_vuelto.TabIndex = 35;
			this.lbl_vuelto.Text = "Vuelto:";
			// 
			// lbl_paga_con
			// 
			this.lbl_paga_con.AutoSize = true;
			this.lbl_paga_con.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_paga_con.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_paga_con.Location = new System.Drawing.Point(82, 224);
			this.lbl_paga_con.Name = "lbl_paga_con";
			this.lbl_paga_con.Size = new System.Drawing.Size(87, 19);
			this.lbl_paga_con.TabIndex = 33;
			this.lbl_paga_con.Text = "Paga con:";
			// 
			// cbx_metodo_pago
			// 
			this.cbx_metodo_pago.BackColor = System.Drawing.SystemColors.Control;
			this.cbx_metodo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_metodo_pago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_metodo_pago.FormattingEnabled = true;
			this.cbx_metodo_pago.Location = new System.Drawing.Point(153, 170);
			this.cbx_metodo_pago.Name = "cbx_metodo_pago";
			this.cbx_metodo_pago.Size = new System.Drawing.Size(129, 26);
			this.cbx_metodo_pago.TabIndex = 32;
			this.cbx_metodo_pago.SelectedIndexChanged += new System.EventHandler(this.cbx_metodo_pago_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(149, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 19);
			this.label2.TabIndex = 31;
			this.label2.Text = "Metodo de Pago:";
			// 
			// lbl_costo_total
			// 
			this.lbl_costo_total.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_costo_total.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_costo_total.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_costo_total.Location = new System.Drawing.Point(153, 97);
			this.lbl_costo_total.Name = "lbl_costo_total";
			this.lbl_costo_total.Size = new System.Drawing.Size(129, 31);
			this.lbl_costo_total.TabIndex = 30;
			this.lbl_costo_total.Text = "00000";
			this.lbl_costo_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(191, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 29;
			this.label7.Text = "Total:";
			// 
			// btn_terminar_compra
			// 
			this.btn_terminar_compra.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_terminar_compra.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_terminar_compra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_terminar_compra.Location = new System.Drawing.Point(153, 319);
			this.btn_terminar_compra.Name = "btn_terminar_compra";
			this.btn_terminar_compra.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_terminar_compra.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.Size = new System.Drawing.Size(129, 39);
			this.btn_terminar_compra.TabIndex = 28;
			this.btn_terminar_compra.Text = "Aceptar";
			this.btn_terminar_compra.TextColor = System.Drawing.SystemColors.Control;
			this.btn_terminar_compra.UseVisualStyleBackColor = true;
			this.btn_terminar_compra.Click += new System.EventHandler(this.btn_terminar_compra_Click);
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
			this.label1.Location = new System.Drawing.Point(143, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Completar Pago";
			// 
			// frm_facturacion_pago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 399);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_facturacion_pago";
			this.Text = "Completar Pago - Fresh Supermarket";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbx_metodo_pago;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label lbl_costo_total;
		private System.Windows.Forms.Label label7;
		private ePOSOne.btnProduct.Button_WOC btn_terminar_compra;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txt_monto_pago;
		public System.Windows.Forms.Label lbl_valor_vuelto;
		private System.Windows.Forms.Label lbl_vuelto;
		private System.Windows.Forms.Label lbl_paga_con;
		private System.Windows.Forms.TextBox txt_tarjeta;
		private System.Windows.Forms.Label lbl_tarjeta;
		private System.Windows.Forms.TextBox txt_deposito;
		private System.Windows.Forms.Label lbl_deposito;
	}
}