namespace CAPA_PRESENTACION
{
	partial class frm_productos_editar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productos_editar));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_edit_codigo = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_edit_eliminar = new ePOSOne.btnProduct.Button_WOC();
			this.btn_edit_salir = new ePOSOne.btnProduct.Button_WOC();
			this.btn_edit_guardar = new ePOSOne.btnProduct.Button_WOC();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_edit_codigo = new System.Windows.Forms.TextBox();
			this.txt_edit_nombre = new System.Windows.Forms.TextBox();
			this.txt_edit_descripcion = new System.Windows.Forms.TextBox();
			this.txt_edit_cantidad = new System.Windows.Forms.TextBox();
			this.txt_edit_precio = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_edit_precio);
			this.panel1.Controls.Add(this.txt_edit_cantidad);
			this.panel1.Controls.Add(this.txt_edit_descripcion);
			this.panel1.Controls.Add(this.txt_edit_nombre);
			this.panel1.Controls.Add(this.txt_edit_codigo);
			this.panel1.Controls.Add(this.lbl_edit_codigo);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btn_edit_eliminar);
			this.panel1.Controls.Add(this.btn_edit_salir);
			this.panel1.Controls.Add(this.btn_edit_guardar);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(441, 374);
			this.panel1.TabIndex = 3;
			// 
			// lbl_edit_codigo
			// 
			this.lbl_edit_codigo.AutoSize = true;
			this.lbl_edit_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_edit_codigo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_edit_codigo.Location = new System.Drawing.Point(217, 83);
			this.lbl_edit_codigo.Name = "lbl_edit_codigo";
			this.lbl_edit_codigo.Size = new System.Drawing.Size(117, 18);
			this.lbl_edit_codigo.TabIndex = 30;
			this.lbl_edit_codigo.Text = "Numero Cedula";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(18, 83);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(194, 19);
			this.label7.TabIndex = 29;
			this.label7.Text = "Producto Seleccionado:";
			// 
			// btn_edit_eliminar
			// 
			this.btn_edit_eliminar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_edit_eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_edit_eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_edit_eliminar.Location = new System.Drawing.Point(160, 318);
			this.btn_edit_eliminar.Name = "btn_edit_eliminar";
			this.btn_edit_eliminar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_edit_eliminar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.Size = new System.Drawing.Size(129, 39);
			this.btn_edit_eliminar.TabIndex = 28;
			this.btn_edit_eliminar.Text = "Eliminar";
			this.btn_edit_eliminar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_edit_eliminar.UseVisualStyleBackColor = true;
			this.btn_edit_eliminar.Click += new System.EventHandler(this.btn_edit_eliminar_Click);
			// 
			// btn_edit_salir
			// 
			this.btn_edit_salir.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_edit_salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_edit_salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_edit_salir.Location = new System.Drawing.Point(295, 318);
			this.btn_edit_salir.Name = "btn_edit_salir";
			this.btn_edit_salir.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_edit_salir.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.Size = new System.Drawing.Size(126, 39);
			this.btn_edit_salir.TabIndex = 27;
			this.btn_edit_salir.Text = "Salir";
			this.btn_edit_salir.TextColor = System.Drawing.SystemColors.Control;
			this.btn_edit_salir.UseVisualStyleBackColor = true;
			this.btn_edit_salir.Click += new System.EventHandler(this.btn_edit_salir_Click);
			// 
			// btn_edit_guardar
			// 
			this.btn_edit_guardar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_edit_guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_edit_guardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_edit_guardar.Location = new System.Drawing.Point(22, 318);
			this.btn_edit_guardar.Name = "btn_edit_guardar";
			this.btn_edit_guardar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_edit_guardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.Size = new System.Drawing.Size(132, 39);
			this.btn_edit_guardar.TabIndex = 26;
			this.btn_edit_guardar.Text = "Guardar";
			this.btn_edit_guardar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_edit_guardar.UseVisualStyleBackColor = true;
			this.btn_edit_guardar.Click += new System.EventHandler(this.btn_edit_guardar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(18, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 19);
			this.label6.TabIndex = 24;
			this.label6.Text = "Precio:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(18, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 19);
			this.label5.TabIndex = 22;
			this.label5.Text = "Cantidad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(18, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 19);
			this.label2.TabIndex = 20;
			this.label2.Text = "Descripción:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(18, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 19);
			this.label4.TabIndex = 17;
			this.label4.Text = "Nombre Producto:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(18, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 19);
			this.label3.TabIndex = 16;
			this.label3.Text = "Codigo:";
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
			this.label1.Location = new System.Drawing.Point(129, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Editar Productos";
			// 
			// txt_edit_codigo
			// 
			this.txt_edit_codigo.BackColor = System.Drawing.SystemColors.Control;
			this.txt_edit_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_edit_codigo.Location = new System.Drawing.Point(179, 122);
			this.txt_edit_codigo.Name = "txt_edit_codigo";
			this.txt_edit_codigo.Size = new System.Drawing.Size(242, 26);
			this.txt_edit_codigo.TabIndex = 31;
			this.txt_edit_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_edit_codigo_KeyDown);
			this.txt_edit_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edit_codigo_KeyPress);
			// 
			// txt_edit_nombre
			// 
			this.txt_edit_nombre.BackColor = System.Drawing.SystemColors.Control;
			this.txt_edit_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_edit_nombre.Location = new System.Drawing.Point(179, 161);
			this.txt_edit_nombre.Name = "txt_edit_nombre";
			this.txt_edit_nombre.Size = new System.Drawing.Size(242, 26);
			this.txt_edit_nombre.TabIndex = 32;
			this.txt_edit_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_edit_nombre_KeyDown);
			// 
			// txt_edit_descripcion
			// 
			this.txt_edit_descripcion.BackColor = System.Drawing.SystemColors.Control;
			this.txt_edit_descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_edit_descripcion.Location = new System.Drawing.Point(179, 200);
			this.txt_edit_descripcion.Name = "txt_edit_descripcion";
			this.txt_edit_descripcion.Size = new System.Drawing.Size(242, 26);
			this.txt_edit_descripcion.TabIndex = 33;
			this.txt_edit_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_edit_descripcion_KeyDown);
			// 
			// txt_edit_cantidad
			// 
			this.txt_edit_cantidad.BackColor = System.Drawing.SystemColors.Control;
			this.txt_edit_cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_edit_cantidad.Location = new System.Drawing.Point(179, 239);
			this.txt_edit_cantidad.Name = "txt_edit_cantidad";
			this.txt_edit_cantidad.Size = new System.Drawing.Size(242, 26);
			this.txt_edit_cantidad.TabIndex = 34;
			this.txt_edit_cantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_edit_cantidad_KeyDown);
			this.txt_edit_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edit_cantidad_KeyPress);
			// 
			// txt_edit_precio
			// 
			this.txt_edit_precio.BackColor = System.Drawing.SystemColors.Control;
			this.txt_edit_precio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_edit_precio.Location = new System.Drawing.Point(179, 278);
			this.txt_edit_precio.Name = "txt_edit_precio";
			this.txt_edit_precio.Size = new System.Drawing.Size(242, 26);
			this.txt_edit_precio.TabIndex = 35;
			this.txt_edit_precio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_edit_precio_KeyDown);
			this.txt_edit_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edit_precio_KeyPress);
			// 
			// frm_productos_editar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 398);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_productos_editar";
			this.Text = "Editar Productos - Fresh Supermarket";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lbl_edit_codigo;
		private System.Windows.Forms.Label label7;
		private ePOSOne.btnProduct.Button_WOC btn_edit_eliminar;
		private ePOSOne.btnProduct.Button_WOC btn_edit_salir;
		private ePOSOne.btnProduct.Button_WOC btn_edit_guardar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txt_edit_precio;
		public System.Windows.Forms.TextBox txt_edit_cantidad;
		public System.Windows.Forms.TextBox txt_edit_descripcion;
		public System.Windows.Forms.TextBox txt_edit_nombre;
		public System.Windows.Forms.TextBox txt_edit_codigo;
	}
}