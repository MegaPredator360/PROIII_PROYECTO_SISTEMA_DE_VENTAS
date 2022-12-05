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

namespace CAPA_PRESENTACION
{
	public partial class frm_empleados_agregar : Form
	{

		Empleados Empl;
		frm_empleados FormEmpleados;

		public frm_empleados_agregar(frm_empleados FrmEmpleados)
		{
			InitializeComponent();
			Empl = new Empleados();
			FormEmpleados = FrmEmpleados;
			OpcionesCbxEmpleados();
		}

		public void OpcionesCbxEmpleados()
		{
			cbx_add_tipo_usuario.Items.Add("Administrador");
			cbx_add_tipo_usuario.Items.Add("Cajero");
			cbx_add_tipo_usuario.Items.Add("Oficinas");
		}

		private void btn_add_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_add_agregar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_add_cedula.Text == "" || txt_add_nombre.Text == "" || txt_add_correo.Text == "" || txt_add_usuario.Text == "" || txt_add_contrasena.Text == "")
				{
					MessageBox.Show("Hay uno o más campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Empl = new Empleados()
					{
						ID = int.Parse(txt_add_cedula.Text),
						NOMBRE = txt_add_nombre.Text,
						CORREO = txt_add_correo.Text,
						USUARIO = txt_add_usuario.Text,
						CONTRASENA= txt_add_contrasena.Text,
						TIPO_USUARIO = cbx_add_tipo_usuario.Text
					};

					Empl.InsertarEmpleados();
					FormEmpleados.ActualizarEmpleados();
					frm_facturacion FormFacturacion = new frm_facturacion();
					FormFacturacion.OpcionesDefecto();
					LimpiarCampos();
					MessageBox.Show("El empleado ha sido añadido con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void LimpiarCampos()
		{
			txt_add_cedula.Text = "";
			txt_add_nombre.Text = "";
			txt_add_correo.Text = "";
			txt_add_usuario.Text = "";
			txt_add_contrasena.Text = "";
			cbx_add_tipo_usuario.SelectedIndex = 0;
		}

		private void txt_add_cedula_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_add_cedula_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_nombre.Focus();
			}
		}

		private void txt_add_nombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_correo.Focus();
			}
		}

		private void txt_add_correo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_usuario.Focus();
			}
		}

		private void txt_add_usuario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_contrasena.Focus();
			}
		}

		private void txt_add_contrasena_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				cbx_add_tipo_usuario.Focus();
			}
		}

		private void cbx_add_tipo_usuario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_add_agregar_Click(this, new EventArgs());
			}
		}
	}
}
