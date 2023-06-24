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
	public partial class frm_productos_agregar : Form
	{
		Productos Prod;
		frm_productos FormProductos;

		public frm_productos_agregar(frm_productos FrmProductos)
		{
			InitializeComponent();
			Prod = new Productos();
			FormProductos = FrmProductos;
		}

		private void btn_add_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_add_agregar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_add_codigo.Text == "" || txt_add_nombre.Text == "" || txt_add_descripcion.Text == "" || txt_add_cantidad.Text == "" || txt_add_precio.Text == "")
				{
					MessageBox.Show("Hay uno o más campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Prod = new Productos()
					{
						ID = int.Parse(txt_add_codigo.Text),
						NOMBRE = txt_add_nombre.Text,
						DESCRIPCION = txt_add_descripcion.Text,
						CANTIDAD = int.Parse(txt_add_cantidad.Text),
						PRECIO = int.Parse(txt_add_precio.Text)
					};

					Prod.InsertarProductos();
					FormProductos.ActualizarProductos();
					frm_facturacion FormFacturacion = new frm_facturacion();
					FormFacturacion.OpcionesDefecto();
					LimpiarCampos();
					MessageBox.Show("El proudcto ha sido añadido con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void LimpiarCampos()
		{
			txt_add_codigo.Text = "";
			txt_add_nombre.Text = "";
			txt_add_descripcion.Text = "";
			txt_add_cantidad.Text = "";
			txt_add_precio.Text = "";
		}

		private void txt_add_codigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_add_codigo_KeyDown(object sender, KeyEventArgs e)
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
				txt_add_descripcion.Focus();
			}
		}

		private void txt_add_descripcion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_cantidad.Focus();
			}
		}

		private void txt_add_cantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_add_cantidad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_precio.Focus();
			}
		}

		private void txt_add_precio_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_add_precio_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_add_agregar_Click(this, new EventArgs());
			}
		}
	}
}
