namespace CAPA_PRESENTACION
{
	partial class frm_empleados_agregar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empleados_agregar));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbx_add_tipo_usuario = new System.Windows.Forms.ComboBox();
			this.txt_add_usuario = new System.Windows.Forms.TextBox();
			this.txt_add_correo = new System.Windows.Forms.TextBox();
			this.txt_add_nombre = new System.Windows.Forms.TextBox();
			this.txt_add_cedula = new System.Windows.Forms.TextBox();
			this.btn_add_salir = new ePOSOne.btnProduct.Button_WOC();
			this.btn_add_agregar = new ePOSOne.btnProduct.Button_WOC();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_add_contrasena = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txt_add_contrasena);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.cbx_add_tipo_usuario);
			this.panel1.Controls.Add(this.txt_add_usuario);
			this.panel1.Controls.Add(this.txt_add_correo);
			this.panel1.Controls.Add(this.txt_add_nombre);
			this.panel1.Controls.Add(this.txt_add_cedula);
			this.panel1.Controls.Add(this.btn_add_salir);
			this.panel1.Controls.Add(this.btn_add_agregar);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(441, 396);
			this.panel1.TabIndex = 2;
			// 
			// cbx_add_tipo_usuario
			// 
			this.cbx_add_tipo_usuario.BackColor = System.Drawing.SystemColors.Control;
			this.cbx_add_tipo_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_add_tipo_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_add_tipo_usuario.FormattingEnabled = true;
			this.cbx_add_tipo_usuario.Location = new System.Drawing.Point(185, 295);
			this.cbx_add_tipo_usuario.Name = "cbx_add_tipo_usuario";
			this.cbx_add_tipo_usuario.Size = new System.Drawing.Size(242, 26);
			this.cbx_add_tipo_usuario.TabIndex = 21;
			this.cbx_add_tipo_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_add_tipo_usuario_KeyDown);
			// 
			// txt_add_usuario
			// 
			this.txt_add_usuario.BackColor = System.Drawing.SystemColors.Control;
			this.txt_add_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_add_usuario.Location = new System.Drawing.Point(185, 206);
			this.txt_add_usuario.Name = "txt_add_usuario";
			this.txt_add_usuario.Size = new System.Drawing.Size(242, 26);
			this.txt_add_usuario.TabIndex = 20;
			this.txt_add_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_add_usuario_KeyDown);
			// 
			// txt_add_correo
			// 
			this.txt_add_correo.BackColor = System.Drawing.SystemColors.Control;
			this.txt_add_correo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_add_correo.Location = new System.Drawing.Point(185, 167);
			this.txt_add_correo.Name = "txt_add_correo";
			this.txt_add_correo.Size = new System.Drawing.Size(242, 26);
			this.txt_add_correo.TabIndex = 19;
			this.txt_add_correo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_add_correo_KeyDown);
			// 
			// txt_add_nombre
			// 
			this.txt_add_nombre.BackColor = System.Drawing.SystemColors.Control;
			this.txt_add_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_add_nombre.Location = new System.Drawing.Point(185, 128);
			this.txt_add_nombre.Name = "txt_add_nombre";
			this.txt_add_nombre.Size = new System.Drawing.Size(242, 26);
			this.txt_add_nombre.TabIndex = 18;
			this.txt_add_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_add_nombre_KeyDown);
			// 
			// txt_add_cedula
			// 
			this.txt_add_cedula.BackColor = System.Drawing.SystemColors.Control;
			this.txt_add_cedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_add_cedula.Location = new System.Drawing.Point(185, 89);
			this.txt_add_cedula.Name = "txt_add_cedula";
			this.txt_add_cedula.Size = new System.Drawing.Size(242, 26);
			this.txt_add_cedula.TabIndex = 17;
			this.txt_add_cedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_add_cedula_KeyDown);
			this.txt_add_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_add_cedula_KeyPress);
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
			this.btn_add_salir.Location = new System.Drawing.Point(224, 335);
			this.btn_add_salir.Name = "btn_add_salir";
			this.btn_add_salir.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_add_salir.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.Size = new System.Drawing.Size(141, 39);
			this.btn_add_salir.TabIndex = 15;
			this.btn_add_salir.Text = "Salir";
			this.btn_add_salir.TextColor = System.Drawing.SystemColors.Control;
			this.btn_add_salir.UseVisualStyleBackColor = true;
			this.btn_add_salir.Click += new System.EventHandler(this.btn_add_salir_Click);
			// 
			// btn_add_agregar
			// 
			this.btn_add_agregar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_add_agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_add_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add_agregar.Location = new System.Drawing.Point(57, 335);
			this.btn_add_agregar.Name = "btn_add_agregar";
			this.btn_add_agregar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_add_agregar.OnHoverTextColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.Size = new System.Drawing.Size(141, 39);
			this.btn_add_agregar.TabIndex = 14;
			this.btn_add_agregar.Text = "Agregar";
			this.btn_add_agregar.TextColor = System.Drawing.SystemColors.Control;
			this.btn_add_agregar.UseVisualStyleBackColor = true;
			this.btn_add_agregar.Click += new System.EventHandler(this.btn_add_agregar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(24, 298);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 19);
			this.label6.TabIndex = 12;
			this.label6.Text = "Tipo de Usuario:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(24, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 19);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nombre de Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(24, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Correo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(24, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre Empleado:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(24, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cedula:";
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
			this.label1.Location = new System.Drawing.Point(117, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Agregar Empleados";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(24, 253);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 19);
			this.label7.TabIndex = 22;
			this.label7.Text = "Contraseña:";
			// 
			// txt_add_contrasena
			// 
			this.txt_add_contrasena.BackColor = System.Drawing.SystemColors.Control;
			this.txt_add_contrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_add_contrasena.Location = new System.Drawing.Point(185, 250);
			this.txt_add_contrasena.Name = "txt_add_contrasena";
			this.txt_add_contrasena.Size = new System.Drawing.Size(242, 26);
			this.txt_add_contrasena.TabIndex = 23;
			this.txt_add_contrasena.UseSystemPasswordChar = true;
			this.txt_add_contrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_add_contrasena_KeyDown);
			// 
			// frm_empleados_agregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 424);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_empleados_agregar";
			this.Text = "Agregar Empleados - Fresh Supermarket";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private ePOSOne.btnProduct.Button_WOC btn_add_salir;
		private ePOSOne.btnProduct.Button_WOC btn_add_agregar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox cbx_add_tipo_usuario;
		private System.Windows.Forms.TextBox txt_add_usuario;
		private System.Windows.Forms.TextBox txt_add_correo;
		private System.Windows.Forms.TextBox txt_add_nombre;
		public System.Windows.Forms.TextBox txt_add_cedula;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_add_contrasena;
	}
}