namespace CAPA_PRESENTACION
{
	partial class frm_proveedores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_proveedores));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_proveedores_registrados = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_editar = new ePOSOne.btnProduct.Button_WOC();
			this.dgv_proveedores = new System.Windows.Forms.DataGridView();
			this.btn_buscar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_agregar = new ePOSOne.btnProduct.Button_WOC();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_proveedores = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_buscar_proveedores = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_buscar_proveedores);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lbl_proveedores_registrados);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_editar);
			this.panel1.Controls.Add(this.dgv_proveedores);
			this.panel1.Controls.Add(this.btn_buscar);
			this.panel1.Controls.Add(this.btn_agregar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(965, 573);
			this.panel1.TabIndex = 2;
			// 
			// lbl_proveedores_registrados
			// 
			this.lbl_proveedores_registrados.AutoSize = true;
			this.lbl_proveedores_registrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_proveedores_registrados.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_proveedores_registrados.Location = new System.Drawing.Point(270, 128);
			this.lbl_proveedores_registrados.Name = "lbl_proveedores_registrados";
			this.lbl_proveedores_registrados.Size = new System.Drawing.Size(72, 18);
			this.lbl_proveedores_registrados.TabIndex = 7;
			this.lbl_proveedores_registrados.Text = "Cantidad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(61, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Proveedores Registrados:";
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
			// dgv_proveedores
			// 
			this.dgv_proveedores.AllowUserToAddRows = false;
			this.dgv_proveedores.AllowUserToDeleteRows = false;
			this.dgv_proveedores.AllowUserToResizeColumns = false;
			this.dgv_proveedores.AllowUserToResizeRows = false;
			this.dgv_proveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_proveedores.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_proveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_proveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_proveedores.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_proveedores.EnableHeadersVisualStyles = false;
			this.dgv_proveedores.Location = new System.Drawing.Point(12, 162);
			this.dgv_proveedores.MultiSelect = false;
			this.dgv_proveedores.Name = "dgv_proveedores";
			this.dgv_proveedores.RowHeadersVisible = false;
			this.dgv_proveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_proveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_proveedores.Size = new System.Drawing.Size(936, 396);
			this.dgv_proveedores.TabIndex = 5;
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
			this.panel2.Controls.Add(this.lbl_proveedores);
			this.panel2.Location = new System.Drawing.Point(12, 13);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(936, 41);
			this.panel2.TabIndex = 0;
			// 
			// lbl_proveedores
			// 
			this.lbl_proveedores.AutoSize = true;
			this.lbl_proveedores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_proveedores.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_proveedores.Location = new System.Drawing.Point(331, 12);
			this.lbl_proveedores.Name = "lbl_proveedores";
			this.lbl_proveedores.Size = new System.Drawing.Size(266, 19);
			this.lbl_proveedores.TabIndex = 0;
			this.lbl_proveedores.Text = "Proveedores - Fresh Supermarket";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(64, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(355, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Ingresa la Cedula del Proveedor para Buscar:";
			// 
			// txt_buscar_proveedores
			// 
			this.txt_buscar_proveedores.BackColor = System.Drawing.SystemColors.Control;
			this.txt_buscar_proveedores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_buscar_proveedores.Location = new System.Drawing.Point(64, 95);
			this.txt_buscar_proveedores.Name = "txt_buscar_proveedores";
			this.txt_buscar_proveedores.Size = new System.Drawing.Size(526, 26);
			this.txt_buscar_proveedores.TabIndex = 9;
			this.txt_buscar_proveedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_proveedores_KeyDown);
			this.txt_buscar_proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_proveedores_KeyPress);
			// 
			// frm_proveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 597);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_proveedores";
			this.Text = "Mantenimiento de Proveedores - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_proveedores_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_proveedores_registrados;
		private System.Windows.Forms.Label label1;
		private ePOSOne.btnProduct.Button_WOC btn_editar;
		private System.Windows.Forms.DataGridView dgv_proveedores;
		private ePOSOne.btnProduct.Button_WOC btn_buscar;
		private ePOSOne.btnProduct.Button_WOC btn_agregar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_proveedores;
		private System.Windows.Forms.TextBox txt_buscar_proveedores;
		private System.Windows.Forms.Label label2;
	}
}