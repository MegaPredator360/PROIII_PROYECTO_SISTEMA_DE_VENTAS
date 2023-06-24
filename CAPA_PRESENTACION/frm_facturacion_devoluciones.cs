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
	public partial class frm_facturacion_devoluciones : Form
	{

		Facturas Fact;

		public frm_facturacion_devoluciones()
		{
			InitializeComponent();
			Fact = new Facturas();
			lbl_nombre_producto.Text = "";
			dgv_buscar_factura.DataSource = Fact.DevolucionFacturaVacia();
			dgv_buscar_producto.DataSource = Fact.DevolucionProductoVacia();
			DataGridViewWidth();
		}

		public void DataGridViewWidth()
		{
			dgv_buscar_factura.Columns[0].Width = 100;
			dgv_buscar_factura.Columns[1].Width = 140;
			dgv_buscar_factura.Columns[2].Width = 170;
			dgv_buscar_producto.Columns[0].Width = 170;
			dgv_buscar_producto.Columns[1].Width = 100;
			dgv_buscar_producto.Columns[2].Width = 140;
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			if (txt_buscar_factura.Text == "")
			{
				MessageBox.Show("El campo de busqueda esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Fact = new Facturas()
				{
					ID = int.Parse(txt_buscar_factura.Text)
				};
				dgv_buscar_factura.DataSource = Fact.DevolucionBuscarFactura();
			}
		}

		private void frm_facturacion_devoluciones_Load(object sender, EventArgs e)
		{
			dgv_buscar_factura.ReadOnly = true;
			dgv_buscar_producto.ReadOnly = true;
		}

		private void txt_buscar_factura_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_buscar_Click(this, new EventArgs());
			}
		}

		private void btn_seleccionar_Click(object sender, EventArgs e)
		{
			Fact = new Facturas()
			{
				ID = int.Parse(this.dgv_buscar_factura.CurrentRow.Cells[0].Value.ToString())
			};
			dgv_buscar_producto.DataSource = Fact.DevolucionBuscarProducto();
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgv_buscar_producto_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			DataGridViewRow selectedRow = dgv_buscar_producto.Rows[index];
			lbl_nombre_producto.Text = selectedRow.Cells[0].Value.ToString();
		}

		private void btn_guardar_cambios_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_cantidad_devolver.Text == "" && lbl_nombre_producto.Text == "")
				{
					MessageBox.Show("No se ha seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (txt_cantidad_devolver.Text == "" && lbl_nombre_producto.Text != "")
				{
					MessageBox.Show("Debes ingresar la cantidad a devolver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					int CantidadDevolver = int.Parse(txt_cantidad_devolver.Text);
					int CantidadVendido = int.Parse(this.dgv_buscar_producto.CurrentRow.Cells[1].Value.ToString());

					if (lbl_nombre_producto.Text != "" && CantidadDevolver > CantidadVendido)
					{
						MessageBox.Show("La cantidad a devolver es mayor a la cantidad vendida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else if (lbl_nombre_producto.Text != "" && CantidadDevolver <= CantidadVendido)
					{
						Fact = new Facturas()
						{
							ID = int.Parse(txt_buscar_factura.Text),
							PROD_NOMBRE = lbl_nombre_producto.Text,
							PROD_CANTIDAD = int.Parse(txt_cantidad_devolver.Text)
						};
						Fact.DevolucionProductos();
						dgv_buscar_factura.DataSource = Fact.DevolucionBuscarFactura();
						dgv_buscar_producto.DataSource = Fact.DevolucionBuscarProducto();
						MessageBox.Show("La devolucion se realizo con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void dgv_buscar_factura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_seleccionar_Click(this, new EventArgs());
		}

		private void txt_cantidad_devolver_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_cantidad_devolver_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_guardar_cambios_Click(this, new EventArgs());
			}
		}

		private void txt_buscar_factura_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
