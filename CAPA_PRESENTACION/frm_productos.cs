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
	public partial class frm_productos : Form
	{
		Productos Prod;

		public frm_productos()
		{
			InitializeComponent();
			Prod = new Productos();
			dgv_productos.DataSource = Prod.DgvProductos();
			DataGridViewWidth();
			CantidadProductos();
		}

		public void DataGridViewWidth()
		{
			dgv_productos.Columns[0].Width = 125;
			dgv_productos.Columns[1].Width = 200;
			dgv_productos.Columns[2].Width = 285;
			dgv_productos.Columns[3].Width = 125;
			dgv_productos.Columns[4].Width = 200;
		}

		private void CantidadProductos()
		{
			lbl_productos_registrados.Text = dgv_productos.Rows.Count.ToString();
		}

		private void frm_productos_Load(object sender, EventArgs e)
		{
			dgv_productos.ReadOnly = true;
		}

		public void ActualizarProductos()
		{
			dgv_productos.DataSource = Prod.DgvProductos();
			lbl_productos_registrados.Text = dgv_productos.Rows.Count.ToString();
		}

		private void btn_agregar_Click(object sender, EventArgs e)
		{
			frm_productos_agregar FormProductosAgregar = new frm_productos_agregar(this);
			FormProductosAgregar.txt_add_codigo.Select();
			FormProductosAgregar.Show();
		}

		private void btn_editar_Click(object sender, EventArgs e)
		{
			frm_productos_editar FormProductosEditar = new frm_productos_editar(this);
			FormProductosEditar.txt_edit_codigo.Text = this.dgv_productos.CurrentRow.Cells[0].Value.ToString();
			FormProductosEditar.lbl_edit_codigo.Text = this.dgv_productos.CurrentRow.Cells[0].Value.ToString();
			FormProductosEditar.txt_edit_nombre.Text = this.dgv_productos.CurrentRow.Cells[1].Value.ToString();
			FormProductosEditar.txt_edit_descripcion.Text = this.dgv_productos.CurrentRow.Cells[2].Value.ToString();
			FormProductosEditar.txt_edit_cantidad.Text = this.dgv_productos.CurrentRow.Cells[3].Value.ToString();
			FormProductosEditar.txt_edit_precio.Text = this.dgv_productos.CurrentRow.Cells[4].Value.ToString();
			FormProductosEditar.txt_edit_codigo.Select();
			FormProductosEditar.Show();
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			String buscarNombre = txt_buscar_productos.Text;
			if (buscarNombre != "")
			{
				DataGridViewRow row = dgv_productos.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => Convert.ToString(r.Cells[0].Value).Equals(buscarNombre));

				if (row != null)
				{
					dgv_productos.ClearSelection();
					dgv_productos.FirstDisplayedScrollingRowIndex = row.Index;

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

		private void txt_buscar_productos_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_buscar_productos_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_buscar_Click(this, new EventArgs());
			}
		}

		private void dgv_productos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_editar_Click(this, new EventArgs());
		}
	}
}
