﻿namespace CAPA_PRESENTACION
{
	partial class frm_empleados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empleados));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgv_empleados = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_buscar_empleados = new System.Windows.Forms.TextBox();
			this.lbl_empleados_registrados = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_empl_editar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_empl_buscar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_empl_agregar = new ePOSOne.btnProduct.Button_WOC();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_empleados = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dgv_empleados);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txt_buscar_empleados);
			this.panel1.Controls.Add(this.lbl_empleados_registrados);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_empl_editar);
			this.panel1.Controls.Add(this.btn_empl_buscar);
			this.panel1.Controls.Add(this.btn_empl_agregar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(965, 573);
			this.panel1.TabIndex = 2;
			// 
			// dgv_empleados
			// 
			this.dgv_empleados.AllowUserToAddRows = false;
			this.dgv_empleados.AllowUserToDeleteRows = false;
			this.dgv_empleados.AllowUserToResizeColumns = false;
			this.dgv_empleados.AllowUserToResizeRows = false;
			this.dgv_empleados.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_empleados.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_empleados.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_empleados.EnableHeadersVisualStyles = false;
			this.dgv_empleados.Location = new System.Drawing.Point(12, 160);
			this.dgv_empleados.MultiSelect = false;
			this.dgv_empleados.Name = "dgv_empleados";
			this.dgv_empleados.RowHeadersVisible = false;
			this.dgv_empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_empleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_empleados.Size = new System.Drawing.Size(936, 396);
			this.dgv_empleados.TabIndex = 10;
			this.dgv_empleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellContentDoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(65, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Ingresa la Cedula del Empleado:";
			// 
			// txt_buscar_empleados
			// 
			this.txt_buscar_empleados.BackColor = System.Drawing.SystemColors.Control;
			this.txt_buscar_empleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_buscar_empleados.Location = new System.Drawing.Point(69, 96);
			this.txt_buscar_empleados.Name = "txt_buscar_empleados";
			this.txt_buscar_empleados.Size = new System.Drawing.Size(529, 26);
			this.txt_buscar_empleados.TabIndex = 8;
			this.txt_buscar_empleados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_empleados_KeyDown);
			this.txt_buscar_empleados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_empleados_KeyPress);
			// 
			// lbl_empleados_registrados
			// 
			this.lbl_empleados_registrados.AutoSize = true;
			this.lbl_empleados_registrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_empleados_registrados.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_empleados_registrados.Location = new System.Drawing.Point(263, 132);
			this.lbl_empleados_registrados.Name = "lbl_empleados_registrados";
			this.lbl_empleados_registrados.Size = new System.Drawing.Size(72, 18);
			this.lbl_empleados_registrados.TabIndex = 7;
			this.lbl_empleados_registrados.Text = "Cantidad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(65, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Empleados Registrados:";
			// 
			// btn_empl_editar
			// 
			this.btn_empl_editar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_empl_editar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.FlatAppearance.BorderSize = 0;
			this.btn_empl_editar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_empl_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_empl_editar.Location = new System.Drawing.Point(733, 92);
			this.btn_empl_editar.Name = "btn_empl_editar";
			this.btn_empl_editar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_empl_editar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.Size = new System.Drawing.Size(103, 33);
			this.btn_empl_editar.TabIndex = 6;
			this.btn_empl_editar.Text = "Editar";
			this.btn_empl_editar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_empl_editar.UseVisualStyleBackColor = true;
			this.btn_empl_editar.Click += new System.EventHandler(this.btn_empl_editar_Click);
			// 
			// btn_empl_buscar
			// 
			this.btn_empl_buscar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_empl_buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.FlatAppearance.BorderSize = 0;
			this.btn_empl_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_empl_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_empl_buscar.Location = new System.Drawing.Point(615, 92);
			this.btn_empl_buscar.Name = "btn_empl_buscar";
			this.btn_empl_buscar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_empl_buscar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.Size = new System.Drawing.Size(112, 33);
			this.btn_empl_buscar.TabIndex = 4;
			this.btn_empl_buscar.Text = "Buscar";
			this.btn_empl_buscar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_empl_buscar.UseVisualStyleBackColor = true;
			this.btn_empl_buscar.Click += new System.EventHandler(this.btn_empl_buscar_Click);
			// 
			// btn_empl_agregar
			// 
			this.btn_empl_agregar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.ButtonColor = System.Drawing.Color.Orange;
			this.btn_empl_agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.FlatAppearance.BorderSize = 0;
			this.btn_empl_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_empl_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_empl_agregar.Location = new System.Drawing.Point(842, 92);
			this.btn_empl_agregar.Name = "btn_empl_agregar";
			this.btn_empl_agregar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_empl_agregar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.Size = new System.Drawing.Size(106, 33);
			this.btn_empl_agregar.TabIndex = 3;
			this.btn_empl_agregar.Text = "Agregar";
			this.btn_empl_agregar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_empl_agregar.UseVisualStyleBackColor = true;
			this.btn_empl_agregar.Click += new System.EventHandler(this.btn_empl_agregar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.icon_lupa;
			this.pictureBox1.Location = new System.Drawing.Point(27, 92);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Controls.Add(this.lbl_empleados);
			this.panel2.Location = new System.Drawing.Point(12, 13);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(936, 41);
			this.panel2.TabIndex = 0;
			// 
			// lbl_empleados
			// 
			this.lbl_empleados.AutoSize = true;
			this.lbl_empleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_empleados.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_empleados.Location = new System.Drawing.Point(327, 11);
			this.lbl_empleados.Name = "lbl_empleados";
			this.lbl_empleados.Size = new System.Drawing.Size(254, 19);
			this.lbl_empleados.TabIndex = 0;
			this.lbl_empleados.Text = "Empleados - Fresh Supermarket";
			// 
			// frm_empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 597);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_empleados";
			this.Text = "Mantenimiento de Empleados - Fresh Supermarket";
			this.Load += new System.EventHandler(this.frm_empleados_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_empleados_registrados;
		private System.Windows.Forms.Label label1;
		private ePOSOne.btnProduct.Button_WOC btn_empl_editar;
		private ePOSOne.btnProduct.Button_WOC btn_empl_buscar;
		private ePOSOne.btnProduct.Button_WOC btn_empl_agregar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_empleados;
		private System.Windows.Forms.TextBox txt_buscar_empleados;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgv_empleados;
	}
}