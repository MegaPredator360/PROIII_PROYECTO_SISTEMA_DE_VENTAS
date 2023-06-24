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
	public partial class frm_proveedores_editar : Form
	{
		Proveedores Prov;
		frm_proveedores FormProveedores;

		public frm_proveedores_editar(frm_proveedores FrmProveedores)
		{
			InitializeComponent();
			Prov = new Proveedores();
			FormProveedores = FrmProveedores;
		}

		private void btn_edit_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_edit_eliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Prov = new Proveedores()
				{
					IDCONFIRMACION = Int32.Parse(lbl_edit_cedula.Text)
				};
				Prov.EliminarProveedores();
				FormProveedores.ActualizarProveedores();
				frm_facturacion FormFacturacion = new frm_facturacion();
				FormFacturacion.OpcionesDefecto();
				MessageBox.Show("El proveedor ha sido eliminado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				if (txt_edit_cedula.Text == "" || txt_edit_nombre.Text == "" || txt_edit_correo.Text == "" || txt_edit_telefono.Text == "" || txt_edit_direccion.Text == "")
				{
					MessageBox.Show("Hay uno o más espacios vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Prov = new Proveedores()
					{
						ID = int.Parse(txt_edit_cedula.Text),
						NOMBRE = txt_edit_nombre.Text,
						CORREO = txt_edit_correo.Text,
						TELEFONO = int.Parse(txt_edit_telefono.Text),
						DIRECCION = txt_edit_direccion.Text,
						IDCONFIRMACION = Int32.Parse(lbl_edit_cedula.Text)
					};

					Prov.ModificarProveedores();
					FormProveedores.ActualizarProveedores();
					frm_facturacion FormFacturacion = new frm_facturacion();
					FormFacturacion.OpcionesDefecto();
					lbl_edit_cedula.Text = txt_edit_cedula.Text;
					MessageBox.Show("El proveedor ha sido actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				txt_edit_telefono.Focus();
			}
		}

		private void txt_edit_telefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_edit_telefono_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_direccion.Focus();
			}
		}

		private void txt_edit_direccion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_edit_guardar_Click(this, new EventArgs());
			}
		}
	}
}
