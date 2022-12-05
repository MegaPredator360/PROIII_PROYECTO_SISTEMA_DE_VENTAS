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
	public partial class frm_empleados_editar : Form
	{
		Empleados Empl;
		frm_empleados FormEmpleados;

		public frm_empleados_editar(frm_empleados FrmEmpleados)
		{
			InitializeComponent();
			Empl = new Empleados();
			FormEmpleados = FrmEmpleados;
			OpcionesCbxEmpleados();

		}

		public void OpcionesCbxEmpleados()
		{
			cbx_edit_tipo_usuario.Items.Add("Administrador");
			cbx_edit_tipo_usuario.Items.Add("Cajero");
			cbx_edit_tipo_usuario.Items.Add("Oficinas");
		}

		private void btn_edit_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_edit_eliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Empl = new Empleados()
				{
					IDCONFIRMACIONEMPLEADO = int.Parse(lbl_edit_cedula.Text)
				};

				Empl.EliminarEmpleados();
				FormEmpleados.ActualizarEmpleados();
				frm_facturacion FormFacturacion = new frm_facturacion();
				FormFacturacion.OpcionesDefecto();
				MessageBox.Show("El empleado ha sido eliminado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void btn_edit_guardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_edit_cedula.Text == "" || txt_edit_nombre.Text == "" || txt_edit_correo.Text == "" || txt_edit_usuario.Text == "" || txt_edit_contrasena.Text == "")
				{
					MessageBox.Show("Hay uno o más casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Empl = new Empleados()
					{
						ID = int.Parse(txt_edit_cedula.Text),
						IDCONFIRMACIONEMPLEADO = int.Parse(lbl_edit_cedula.Text),
						NOMBRE = txt_edit_nombre.Text,
						CORREO = txt_edit_correo.Text,
						USUARIO = txt_edit_usuario.Text,
						CONTRASENA = txt_edit_contrasena.Text,
						TIPO_USUARIO = cbx_edit_tipo_usuario.Text
					};

					Empl.ModificarEmpleados();
					FormEmpleados.ActualizarEmpleados();
					frm_facturacion FormFacturacion = new frm_facturacion();
					FormFacturacion.OpcionesDefecto();
					MessageBox.Show("El empleado ha sido actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txt_edit_cedula_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_edit_cedula_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_nombre.Focus();
			}
		}

		private void txt_edit_nombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_correo.Focus();
			}
		}

		private void txt_edit_correo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_usuario.Focus();
			}
		}

		private void txt_edit_usuario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_contrasena.Focus();
			}
		}

		private void txt_edit_contrasena_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				cbx_edit_tipo_usuario.Focus();
			}
		}

		private void cbx_edit_tipo_usuario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_edit_guardar_Click(this, new EventArgs());
			}
		}
	}
}
