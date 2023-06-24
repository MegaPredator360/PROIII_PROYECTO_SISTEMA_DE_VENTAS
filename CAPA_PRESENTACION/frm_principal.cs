using CAPA_LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAPA_PRESENTACION
{
	public partial class frm_principal : Form
	{
		Empleados Empl;
		public String UsuarioSesion;

		public frm_principal()
		{
			InitializeComponent();
			txt_usuario.Select();
			Empl = new Empleados();
		}

		private void btn_iniciar_Click(object sender, EventArgs e)
		{
			if (txt_usuario.Text == "" || txt_contrasena.Text == "")
			{
				MessageBox.Show("Hay uno o más campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_usuario.Focus();
			}
			else
			{
				Empl = new Empleados()
				{
					USUARIO = txt_usuario.Text,
					CONTRASENA = txt_contrasena.Text
				};
				frm_facturacion FormFacturacion = new frm_facturacion();
				FormFacturacion.lbl_nombre_usuario.Text = Empl.IniciarSesion();
				if (FormFacturacion.lbl_nombre_usuario.Text == "Null")
				{
					MessageBox.Show("Usuario o Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_usuario.Focus();
				}
				else
				{
					FormFacturacion.Show();
					this.Hide();
				}

			}
			/*
			if (txt_usuario.Text == "admin" && txt_contrasena.Text == "1234")
			{
				frm_facturacion formFacturacion = new frm_facturacion();
				formFacturacion.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("El usuario o la contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_usuario.Focus();
			}
			*/
		}

		private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_contrasena.Focus();
			}
		}

		private void txt_contrasena_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_iniciar_Click(this, new EventArgs());
			}
		}
	}
}
