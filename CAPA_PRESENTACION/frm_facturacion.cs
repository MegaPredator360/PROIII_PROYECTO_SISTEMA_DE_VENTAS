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
	public partial class frm_facturacion : Form
	{
		Facturas Fact;

		public frm_facturacion()
		{
			InitializeComponent();
			Fact = new Facturas();
			OpcionesDefecto();
			DetalleFactura();
			DataGridViewWidth();
			CalcularTotal();
			AutoCompletarClientes();
			AutoCompletarCodigo();
			AutoCompletarProducto();
		}

		public void DataGridViewWidth()
		{
			dgv_facturacion_productos.Columns[0].Width = 140;
			dgv_facturacion_productos.Columns[1].Width = 342;
			dgv_facturacion_productos.Columns[2].Width = 100;
			dgv_facturacion_productos.Columns[3].Width = 150;
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool abierto = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Clientes")
				{
					abierto = true;
					f.Focus();
					break;
				}
			}

			if (abierto == false)
			{
				frm_clientes FormClientes = new frm_clientes();
				FormClientes.Show();
			}
		}

		private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool abierto = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Empleados")
				{
					abierto = true;
					f.Focus();
					break;
				}
			}

			if (abierto == false)
			{
				frm_empleados FormEmpleados = new frm_empleados();
				FormEmpleados.Show();
			}
		}

		private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool abierto = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Proveedores")
				{
					abierto = true;
					f.Focus();
					break;
				}
			}

			if (abierto == false)
			{
				frm_proveedores FormProveedores = new frm_proveedores();
				FormProveedores.Show();
			}
		}

		private void productosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool abierto = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Productos")
				{
					abierto = true;
					f.Focus();
					break;
				}
			}

			if (abierto == false)
			{
				frm_productos FormProductos = new frm_productos();
				FormProductos.Show();
			}
		}

		private void btn_ver_facturas_Click(object sender, EventArgs e)
		{
			frm_facturacion_facturas FormFacturacionFacturas = new frm_facturacion_facturas();
			FormFacturacionFacturas.Show();
		}

		public void AutoCompletarClientes()
		{
			AutoCompleteStringCollection lstClientes = new AutoCompleteStringCollection();
			txt_nombre_cliente.AutoCompleteCustomSource = Fact.AutoCompletarClientes(lstClientes);
		}

		public void AutoCompletarCodigo()
		{ 
			AutoCompleteStringCollection lstCodigo = new AutoCompleteStringCollection();
			txt_prod_codigo.AutoCompleteCustomSource = Fact.AutoCompletarCodigo(lstCodigo);
		}

		public void AutoCompletarProducto()
		{
			AutoCompleteStringCollection lstProducto = new AutoCompleteStringCollection();
			txt_prod_nombre.AutoCompleteCustomSource = Fact.AutoCompletarProducto(lstProducto);
		}

		public void DetalleFactura()
		{
			Fact = new Facturas()
			{
				ID = int.Parse(lbl_numero_factura.Text)
			};

		}

		private void btn_agregar_producto_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_prod_codigo.Text != "" && txt_prod_nombre.Text == "" && txt_cantidad.Text != "")
				{
					Fact = new Facturas()
					{
						ID = int.Parse(lbl_numero_factura.Text),
						PROD_ID = int.Parse(txt_prod_codigo.Text),
						PROD_CANTIDAD = int.Parse(txt_cantidad.Text)
					};
					Fact.InsertarDetalleFacturaCOD();
					dgv_facturacion_productos.DataSource = Fact.DgvDetalleFacturaFacturacion();
					CalcularTotal();
				}
				else if (txt_prod_codigo.Text == "" && txt_prod_nombre.Text != "" && txt_cantidad.Text != "")
				{
					Fact = new Facturas()
					{
						ID = int.Parse(lbl_numero_factura.Text),
						PROD_NOMBRE = txt_prod_nombre.Text,
						PROD_CANTIDAD = int.Parse(txt_cantidad.Text)
					};
					Fact.InsertarDetalleFacturaNom();
					dgv_facturacion_productos.DataSource = Fact.DgvDetalleFacturaFacturacion();
					CalcularTotal();
				}
				else if (txt_prod_codigo.Text != "" && txt_prod_nombre.Text != "" && txt_cantidad.Text != "")
				{
					Fact = new Facturas()
					{
						ID = int.Parse(lbl_numero_factura.Text),
						PROD_ID = int.Parse(txt_prod_codigo.Text),
						PROD_CANTIDAD = int.Parse(txt_cantidad.Text)
					};
					Fact.InsertarDetalleFacturaCOD();
					dgv_facturacion_productos.DataSource = Fact.DgvDetalleFacturaFacturacion();
					CalcularTotal();
				}
				else if (txt_prod_codigo.Text == "" && txt_prod_nombre.Text == "" && txt_cantidad.Text == "1")
				{
					MessageBox.Show("Debes de llenar datos antes de agregar un producto a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_eliminar_producto_Click(object sender, EventArgs e)
		{
			if (dgv_facturacion_productos.Rows.Count == 0)
			{
				MessageBox.Show("No hay productos en la lista para Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Fact = new Facturas()
				{
					ID = int.Parse(lbl_numero_factura.Text),
					PROD_ID = int.Parse(this.dgv_facturacion_productos.CurrentRow.Cells[0].Value.ToString())
				};
				Fact.BorrarDetalleFactura();
				dgv_facturacion_productos.DataSource = Fact.DgvDetalleFacturaFacturacion();
				CalcularTotal();
			}
		}

		private void frm_facturacion_Load(object sender, EventArgs e)
		{
			dgv_facturacion_productos.ReadOnly = true;
		}

		public void CalcularTotal()
		{
			int subtotal = 0;
			int descuento = 0;
			for (int i = 0; i < dgv_facturacion_productos.Rows.Count; ++i)
			{
				subtotal += Convert.ToInt32(dgv_facturacion_productos.Rows[i].Cells[3].Value);
			}
			lbl_subtotal.Text = subtotal.ToString();
			descuento = int.Parse(txt_descuento.Text);
			descuento = (subtotal * descuento) / 100;
			lbl_descuento.Text = descuento.ToString();
			lbl_total.Text = (subtotal - descuento).ToString();
		}

		private void txt_descuento_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				CalcularTotal();
			}
		}

		public void OpcionesDefecto()
		{
			txt_prod_codigo.Select();
			txt_descuento.Text = "0";
			lbl_numero_factura.Text = Fact.ObtenerIdFactura();
			Fact = new Facturas()
			{
				ID = int.Parse(lbl_numero_factura.Text)
			};
			dgv_facturacion_productos.DataSource = Fact.DgvDetalleFacturaFacturacion();
			txt_cantidad.Text = "1";
			txt_nombre_cliente.Text = "Cliente Contado";
			CalcularTotal();
			AutoCompletarClientes();
			AutoCompletarCodigo();
			AutoCompletarProducto();
			txt_prod_codigo.Text = "";
			txt_prod_nombre.Text = "";
		}

		public void ActualizarFacturacion()
		{
			lbl_numero_factura.Text = Fact.ObtenerIdFactura();
			dgv_facturacion_productos.DataSource = Fact.DgvDetalleFacturaFacturacion();
		}

		private void btn_facturar_Click(object sender, EventArgs e)
		{
			if (dgv_facturacion_productos.Rows.Count == 0)
			{
				MessageBox.Show("No hay productos en la lista para Facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				CalcularTotal();
				frm_facturacion_pago FormFacturacionPago = new frm_facturacion_pago(this);
				FormFacturacionPago.lbl_costo_total.Text = this.lbl_total.Text;
				FormFacturacionPago.txt_monto_pago.Text = this.lbl_total.Text;
				FormFacturacionPago.Show();
			}
		}

		private void btn_devolucines_Click(object sender, EventArgs e)
		{
			frm_facturacion_devoluciones FormFacturacionDevolucion = new frm_facturacion_devoluciones();
			FormFacturacionDevolucion.Show();
		}

		private void txt_prod_codigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_prod_codigo_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					e.SuppressKeyPress = true;
					Fact = new Facturas()
					{
						PROD_ID = int.Parse(txt_prod_codigo.Text)
					};
					txt_prod_nombre.Text = Fact.ObtenerNombreProducto();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txt_prod_nombre_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					e.SuppressKeyPress = true;
					Fact = new Facturas()
					{
						PROD_NOMBRE = txt_prod_nombre.Text
					};
					txt_prod_codigo.Text = Fact.ObtenerIdProducto();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
