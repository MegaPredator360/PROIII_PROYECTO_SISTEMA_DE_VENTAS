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
	public partial class frm_facturacion_facturas : Form
	{
		Facturas Fact;

		public frm_facturacion_facturas()
		{
			InitializeComponent();
			Fact = new Facturas();
			dgv_facturas.DataSource = Fact.DgvFacturas();
			DataGridViewWidth();
		}

		public void DataGridViewWidth()
		{
			dgv_facturas.Columns[0].Width = 100;
			dgv_facturas.Columns[1].Width = 150;
			dgv_facturas.Columns[2].Width = 200;
			dgv_facturas.Columns[3].Width = 285;
			dgv_facturas.Columns[4].Width = 200;
		}

		private void frm_facturacion_facturas_Load(object sender, EventArgs e)
		{
			dgv_facturas.ReadOnly = true;
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			String buscarNombre = txt_buscar_factura.Text;
			if (buscarNombre != "")
			{
				DataGridViewRow row = dgv_facturas.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => Convert.ToString(r.Cells[0].Value).Equals(buscarNombre));

				if (row != null)
				{
					dgv_facturas.ClearSelection();
					dgv_facturas.FirstDisplayedScrollingRowIndex = row.Index;

					row.Selected = true;
				}
				else
				{
					MessageBox.Show("No se ha encontrado ninguna coincidencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Debe ingresar un criterio de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_detalles_Click(object sender, EventArgs e)
		{
			frm_facturacion_facturas_detalles FormFacturacionFacturasDetalles = new frm_facturacion_facturas_detalles();
			FormFacturacionFacturasDetalles.lbl_numero_factura.Text = this.dgv_facturas.CurrentRow.Cells[0].Value.ToString();
			Fact = new Facturas()
			{
				ID = int.Parse(this.dgv_facturas.CurrentRow.Cells[0].Value.ToString())
			};
			FormFacturacionFacturasDetalles.lbl_nombre_cliente.Text = this.dgv_facturas.CurrentRow.Cells[3].Value.ToString();
			FormFacturacionFacturasDetalles.lbl_fecha.Text = this.dgv_facturas.CurrentRow.Cells[2].Value.ToString();
			FormFacturacionFacturasDetalles.lbl_total.Text = this.dgv_facturas.CurrentRow.Cells[4].Value.ToString();
			FormFacturacionFacturasDetalles.dgv_detalle_factura.DataSource = Fact.DgvDetalleFactura();
			FormFacturacionFacturasDetalles.dgv_detalle_factura.Columns[0].Width = 200;
			FormFacturacionFacturasDetalles.dgv_detalle_factura.Columns[1].Width = 100;
			FormFacturacionFacturasDetalles.dgv_detalle_factura.Columns[2].Width = 110;
			FormFacturacionFacturasDetalles.Show();
		}

		private void txt_buscar_factura_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_buscar_factura_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_buscar_Click(this, new EventArgs());
			}
		}

		private void dgv_facturas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_detalles_Click(this, new EventArgs());
		}
	}
}
