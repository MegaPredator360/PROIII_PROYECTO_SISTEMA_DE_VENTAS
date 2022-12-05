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
	public partial class frm_proveedores_agregar : Form
	{

		Proveedores Prov;
		frm_proveedores FormProveedores;

		public frm_proveedores_agregar(frm_proveedores FrmProveedores)
		{
			InitializeComponent();
			txt_add_cedula.Select();
			Prov = new Proveedores();
			FormProveedores = FrmProveedores;
		}

		private void btn_add_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_add_agregar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_add_cedula.Text == "" || txt_add_nombre.Text == "" || txt_add_correo.Text == "" || txt_add_telefono.Text == "" || txt_add_direccion.Text == "")
				{
					MessageBox.Show("Hay uno o más espacios vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Prov = new Proveedores()
					{
						ID = int.Parse(txt_add_cedula.Text),
						NOMBRE = txt_add_nombre.Text,
						CORREO = txt_add_correo.Text,
						TELEFONO = int.Parse(txt_add_telefono.Text),
						DIRECCION = txt_add_direccion.Text
					};

					Prov.InsertarProveedores();
					FormProveedores.ActualizarProveedores();
					frm_facturacion FormFacturacion = new frm_facturacion();
					FormFacturacion.OpcionesDefecto();
					LimpiarCampos();
					MessageBox.Show("El proveedor ha sido añadido con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			txt_add_telefono.Text = "";
			txt_add_direccion.Text = "";
			txt_add_cedula.Focus();
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
				txt_add_telefono.Focus();
			}
		}

		private void txt_add_telefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_add_telefono_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				txt_add_direccion.Focus();
			}
		}

		private void txt_add_direccion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_add_agregar_Click(this, new EventArgs());
			}
		}
	}
}
