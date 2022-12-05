namespace CAPA_PRESENTACION
{
	partial class frm_clientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_clientes));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_buscar_clientes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_clientes_registrados = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_editar = new ePOSOne.btnProduct.Button_WOC();
			this.dgv_clientes = new System.Windows.Forms.DataGridView();
			this.btn_buscar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_agregar = new ePOSOne.btnProduct.Button_WOC();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_clientes = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_buscar_clientes);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lbl_clientes_registrados);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_editar);
			this.panel1.Controls.Add(this.dgv_clientes);
			this.panel1.Controls.Add(this.btn_buscar);
			this.panel1.Controls.Add(this.btn_agregar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(965, 573);
			this.panel1.TabIndex = 1;
			// 
			// txt_buscar_clientes
			// 
			this.txt_buscar_clientes.BackColor = System.Drawing.SystemColors.Control;
			this.txt_buscar_clientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_buscar_clientes.Location = new System.Drawing.Point(63, 95);
			this.txt_buscar_clientes.Name = "txt_buscar_clientes";
			this.txt_buscar_clientes.Size = new System.Drawing.Size(531, 26);
			this.txt_buscar_clientes.TabIndex = 9;
			this.txt_buscar_clientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_clientes_KeyDown);
			this.txt_buscar_clientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_clientes_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(60, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(300, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Ingresa el número de cedula a buscar:";
			// 
			// lbl_clientes_registrados
			// 
			this.lbl_clientes_registrados.AutoSize = true;
			this.lbl_clientes_registrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_clientes_registrados.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_clientes_registrados.Location = new System.Drawing.Point(240, 129);
			this.lbl_clientes_registrados.Name = "lbl_clientes_registrados";
			this.lbl_clientes_registrados.Size = new System.Drawing.Size(72, 18);
			this.lbl_clientes_registrados.TabIndex = 7;
			this.lbl_clientes_registrados.Text = "Cantidad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(60, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Clientes Registrados:";
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
			this.btn_editar.Location = new System.Drawing.Point(733, 92);
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
			// dgv_clientes
			// 
			this.dgv_clientes.AllowUserToAddRows = false;
			this.dgv_clientes.AllowUserToDeleteRows = false;
			this.dgv_clientes.AllowUserToResizeColumns = false;
			this.dgv_clientes.AllowUserToResizeRows = false;
			this.dgv_clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_clientes.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_clientes.EnableHeadersVisualStyles = false;
			this.dgv_clientes.Location = new System.Drawing.Point(12, 162);
			this.dgv_clientes.MultiSelect = false;
			this.dgv_clientes.Name = "dgv_clientes";
			this.dgv_clientes.RowHeadersVisible = false;
			this.dgv_clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_clientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_clientes.Size = new System.Drawing.Size(936, 396);
			this.dgv_clientes.TabIndex = 5;
			this.dgv_clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentDoubleClick);
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
			this.btn_buscar.Location = new System.Drawing.Point(615, 92);
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
			this.btn_agregar.Location = new System.Drawing.Point(842, 92);
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
			this.pictureBox1.Location = new System.Drawing.Point(26, 95);
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
			this.lbl_clientes.Size = new System.Drawing.Size(230, 19);
			this.lbl_clientes.TabIndex = 0;
			this.lbl_clientes.Text = "Clientes - Fresh Supermarket";
			// 
			// frm_clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 597);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_clientes";
			this.Text = "Mantenimiento de Clientes - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_clientes_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_clientes;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ePOSOne.btnProduct.Button_WOC btn_agregar;
		private ePOSOne.btnProduct.Button_WOC btn_buscar;
		private ePOSOne.btnProduct.Button_WOC btn_editar;
		private System.Windows.Forms.DataGridView dgv_clientes;
		private System.Windows.Forms.Label lbl_clientes_registrados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_buscar_clientes;
	}
}