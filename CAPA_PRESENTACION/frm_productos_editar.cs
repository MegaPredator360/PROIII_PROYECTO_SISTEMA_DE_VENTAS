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
	public partial class frm_productos_editar : Form
	{
		Productos Prod;
		frm_productos FormProductos;

		public frm_productos_editar(frm_productos FrmProductos)
		{
			InitializeComponent();
			Prod = new Productos();
			FormProductos = FrmProductos;
		}

		private void btn_edit_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_edit_eliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Prod = new Productos()
				{
					IDCONFIRMACION = Int32.Parse(lbl_edit_codigo.Text)
				};
				Prod.EliminarProductos();
				FormProductos.ActualizarProductos();
				frm_facturacion FormFacturacion = new frm_facturacion();
				FormFacturacion.OpcionesDefecto();
				MessageBox.Show("El producto ha sido eliminado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				if (txt_edit_codigo.Text == "" || txt_edit_nombre.Text == "" || txt_edit_descripcion.Text == "" || txt_edit_cantidad.Text == "" || txt_edit_precio.Text == "")
				{
					MessageBox.Show("Hay uno o más campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Prod = new Productos()
					{
						ID = int.Parse(txt_edit_codigo.Text),
						NOMBRE = txt_edit_nombre.Text,
						DESCRIPCION = txt_edit_descripcion.Text,
						CANTIDAD = int.Parse(txt_edit_cantidad.Text),
						PRECIO = int.Parse(txt_edit_precio.Text),
						IDCONFIRMACION = Int32.Parse(lbl_edit_codigo.Text)
					};

					Prod.ModificarProductos();
					FormProductos.ActualizarProductos();
					frm_facturacion FormFacturacion = new frm_facturacion();
					FormFacturacion.OpcionesDefecto();
					lbl_edit_codigo.Text = txt_edit_codigo.Text;
					MessageBox.Show("El producto ha sido actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txt_edit_codigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_edit_codigo_KeyDown(object sender, KeyEventArgs e)
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
				txt_edit_descripcion.Focus();
			}
		}

		private void txt_edit_descripcion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_cantidad.Focus();
			}
		}

		private void txt_edit_cantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_edit_cantidad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_edit_precio.Focus();
			}
		}

		private void txt_edit_precio_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_edit_precio_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_edit_guardar_Click(this, new EventArgs());
			}
		}
	}
}
