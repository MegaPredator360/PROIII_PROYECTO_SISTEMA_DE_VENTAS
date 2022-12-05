namespace CAPA_PRESENTACION
{
	partial class frm_principal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
			this.pbx_logo1 = new System.Windows.Forms.PictureBox();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.lbl_contrasena = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_contrasena = new System.Windows.Forms.TextBox();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.btn_iniciar = new ePOSOne.btnProduct.Button_WOC();
			((System.ComponentModel.ISupportInitialize)(this.pbx_logo1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbx_logo1
			// 
			this.pbx_logo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbx_logo1.Image = global::CAPA_PRESENTACION.Properties.Resources.logo_fresh_supermarket;
			this.pbx_logo1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_logo1.InitialImage")));
			this.pbx_logo1.Location = new System.Drawing.Point(66, 17);
			this.pbx_logo1.Name = "pbx_logo1";
			this.pbx_logo1.Size = new System.Drawing.Size(203, 187);
			this.pbx_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbx_logo1.TabIndex = 0;
			this.pbx_logo1.TabStop = false;
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.AutoSize = true;
			this.lbl_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_usuario.Location = new System.Drawing.Point(131, 218);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(54, 20);
			this.lbl_usuario.TabIndex = 1;
			this.lbl_usuario.Text = "Usuario";
			this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_contrasena
			// 
			this.lbl_contrasena.AutoSize = true;
			this.lbl_contrasena.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_contrasena.Location = new System.Drawing.Point(118, 293);
			this.lbl_contrasena.Name = "lbl_contrasena";
			this.lbl_contrasena.Size = new System.Drawing.Size(76, 20);
			this.lbl_contrasena.TabIndex = 3;
			this.lbl_contrasena.Text = "Contraseña";
			this.lbl_contrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_contrasena);
			this.panel1.Controls.Add(this.txt_usuario);
			this.panel1.Controls.Add(this.btn_iniciar);
			this.panel1.Controls.Add(this.pbx_logo1);
			this.panel1.Controls.Add(this.lbl_usuario);
			this.panel1.Controls.Add(this.lbl_contrasena);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 426);
			this.panel1.TabIndex = 7;
			// 
			// txt_contrasena
			// 
			this.txt_contrasena.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_contrasena.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_contrasena.BackColor = System.Drawing.SystemColors.Control;
			this.txt_contrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_contrasena.Location = new System.Drawing.Point(37, 323);
			this.txt_contrasena.Name = "txt_contrasena";
			this.txt_contrasena.Size = new System.Drawing.Size(250, 26);
			this.txt_contrasena.TabIndex = 32;
			this.txt_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_contrasena.UseSystemPasswordChar = true;
			this.txt_contrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contrasena_KeyDown);
			// 
			// txt_usuario
			// 
			this.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txt_usuario.BackColor = System.Drawing.SystemColors.Control;
			this.txt_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_usuario.Location = new System.Drawing.Point(37, 247);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(250, 26);
			this.txt_usuario.TabIndex = 31;
			this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usuario_KeyDown);
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_iniciar.ButtonColor = System.Drawing.SystemColors.Highlight;
			this.btn_iniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btn_iniciar.FlatAppearance.BorderSize = 0;
			this.btn_iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.btn_iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_iniciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_iniciar.Location = new System.Drawing.Point(78, 355);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.OnHoverBorderColor = System.Drawing.SystemColors.Control;
			this.btn_iniciar.OnHoverButtonColor = System.Drawing.SystemColors.GrayText;
			this.btn_iniciar.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_iniciar.Size = new System.Drawing.Size(164, 45);
			this.btn_iniciar.TabIndex = 8;
			this.btn_iniciar.Text = "Iniciar Sesión";
			this.btn_iniciar.TextColor = System.Drawing.Color.White;
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
			// 
			// frm_principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 450);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frm_principal";
			this.Text = "Inicio de Sesion - Fresh Supermarket";
			((System.ComponentModel.ISupportInitialize)(this.pbx_logo1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbx_logo1;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.Label lbl_contrasena;
		private System.Windows.Forms.Panel panel1;
		private ePOSOne.btnProduct.Button_WOC btn_iniciar;
		public System.Windows.Forms.TextBox txt_usuario;
		public System.Windows.Forms.TextBox txt_contrasena;
	}
}

