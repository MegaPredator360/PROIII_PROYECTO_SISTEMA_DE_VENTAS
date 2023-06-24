namespace CAPA_PRESENTACION
{
	partial class frm_productos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_buscar_productos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_productos_registrados = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_editar = new ePOSOne.btnProduct.Button_WOC();
			this.dgv_productos = new System.Windows.Forms.DataGridView();
			this.btn_buscar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_agregar = new ePOSOne.btnProduct.Button_WOC();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_clientes = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_buscar_productos);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lbl_productos_registrados);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_editar);
			this.panel1.Controls.Add(this.dgv_productos);
			this.panel1.Controls.Add(this.btn_buscar);
			this.panel1.Controls.Add(this.btn_agregar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(965, 573);
			this.panel1.TabIndex = 3;
			// 
			// txt_buscar_productos
			// 
			this.txt_buscar_productos.BackColor = System.Drawing.SystemColors.Control;
			this.txt_buscar_productos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_buscar_productos.Location = new System.Drawing.Point(64, 95);
			this.txt_buscar_productos.Name = "txt_buscar_productos";
			this.txt_buscar_productos.Size = new System.Drawing.Size(544, 26);
			this.txt_buscar_productos.TabIndex = 9;
			this.txt_buscar_productos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_productos_KeyDown);
			this.txt_buscar_productos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_productos_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(61, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(313, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Ingresa el codigo de producto a buscar:";
			// 
			// lbl_productos_registrados
			// 
			this.lbl_productos_registrados.AutoSize = true;
			this.lbl_productos_registrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_productos_registrados.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_productos_registrados.Location = new System.Drawing.Point(250, 128);
			this.lbl_productos_registrados.Name = "lbl_productos_registrados";
			this.lbl_productos_registrados.Size = new System.Drawing.Size(72, 18);
			this.lbl_productos_registrados.TabIndex = 7;
			this.lbl_productos_registrados.Text = "Cantidad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(61, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Productos Registrados:";
			// 
			// btn_editar
			// 
			this.btn_editar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_editar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_editar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_editar.FlatAppearance.BorderSize = 0;
			this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editar.Location = new System.Drawing.Point(733, 91);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_editar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_editar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_editar.Size = new System.Drawing.Size(103, 33);
			this.btn_editar.TabIndex = 6;
			this.btn_editar.Text = "Editar";
			this.btn_editar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
			// 
			// dgv_productos
			// 
			this.dgv_productos.AllowUserToAddRows = false;
			this.dgv_productos.AllowUserToDeleteRows = false;
			this.dgv_productos.AllowUserToResizeColumns = false;
			this.dgv_productos.AllowUserToResizeRows = false;
			this.dgv_productos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_productos.EnableHeadersVisualStyles = false;
			this.dgv_productos.Location = new System.Drawing.Point(12, 162);
			this.dgv_productos.MultiSelect = false;
			this.dgv_productos.Name = "dgv_productos";
			this.dgv_productos.RowHeadersVisible = false;
			this.dgv_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_productos.Size = new System.Drawing.Size(936, 396);
			this.dgv_productos.TabIndex = 5;
			this.dgv_productos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentDoubleClick);
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
			this.btn_buscar.Location = new System.Drawing.Point(615, 91);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_buscar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.Size = new System.Drawing.Size(112, 33);
			this.btn_buscar.TabIndex = 4;
			this.btn_buscar.Text = "Buscar";
			this.btn_buscar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
			// 
			// btn_agregar
			// 
			this.btn_agregar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.ButtonColor = System.Drawing.Color.Orange;
			this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.FlatAppearance.BorderSize = 0;
			this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_agregar.Location = new System.Drawing.Point(842, 91);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_agregar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.Size = new System.Drawing.Size(106, 33);
			this.btn_agregar.TabIndex = 3;
			this.btn_agregar.Text = "Agregar";
			this.btn_agregar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
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
			this.lbl_clientes.Location = new System.Drawing.Point(327, 11);
			this.lbl_clientes.Name = "lbl_clientes";
			this.lbl_clientes.Size = new System.Drawing.Size(248, 19);
			this.lbl_clientes.TabIndex = 0;
			this.lbl_clientes.Text = "Productos - Fresh Supermarket";
			// 
			// frm_productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 597);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_productos";
			this.Text = "Productos - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_productos_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_productos_registrados;
		private System.Windows.Forms.Label label1;
		private ePOSOne.btnProduct.Button_WOC btn_editar;
		private System.Windows.Forms.DataGridView dgv_productos;
		private ePOSOne.btnProduct.Button_WOC btn_buscar;
		private ePOSOne.btnProduct.Button_WOC btn_agregar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_clientes;
		private System.Windows.Forms.TextBox txt_buscar_productos;
		private System.Windows.Forms.Label label2;
	}
}