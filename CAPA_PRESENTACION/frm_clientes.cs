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
	public partial class frm_clientes : Form
	{

		Clientes Clie;

		public frm_clientes()
		{
			InitializeComponent();
			Clie = new Clientes();
			dgv_clientes.DataSource = Clie.DgvClientes();
			DataGridViewWidth();
			CantidadClientes();
		}

		public void DataGridViewWidth()
		{
			dgv_clientes.Columns[0].Width = 125;
			dgv_clientes.Columns[1].Width = 200;
			dgv_clientes.Columns[2].Width = 285;
			dgv_clientes.Columns[3].Width = 125;
			dgv_clientes.Columns[4].Width = 200;
		}

		private void btn_agregar_Click(object sender, EventArgs e)
		{
			frm_clientes_agregar FormClientesAgregar = new frm_clientes_agregar(this);
			FormClientesAgregar.txt_add_cedula.Select();
			FormClientesAgregar.Show();
		}

		public void RefreshGrid()
		{
			dgv_clientes.DataSource = Clie.DgvClientes();
			lbl_clientes_registrados.Text = dgv_clientes.Rows.Count.ToString();
		}

		private void frm_clientes_Load(object sender, EventArgs e)
		{
			dgv_clientes.ReadOnly = true;
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			String buscarNombre = txt_buscar_clientes.Text;
			if (buscarNombre != "")
			{
				DataGridViewRow row = dgv_clientes.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => Convert.ToString(r.Cells[0].Value).Equals(buscarNombre));

				if (row != null)
				{
					dgv_clientes.ClearSelection();
					dgv_clientes.FirstDisplayedScrollingRowIndex = row.Index;

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

		private void btn_editar_Click(object sender, EventArgs e)
		{
			frm_clientes_editar FormClientesEditar = new frm_clientes_editar(this);
			FormClientesEditar.txt_edit_cedula.Text = this.dgv_clientes.CurrentRow.Cells[0].Value.ToString();
			FormClientesEditar.lbl_edit_cedula.Text = this.dgv_clientes.CurrentRow.Cells[0].Value.ToString();
			FormClientesEditar.txt_edit_nombre.Text = this.dgv_clientes.CurrentRow.Cells[1].Value.ToString();
			FormClientesEditar.txt_edit_correo.Text = this.dgv_clientes.CurrentRow.Cells[2].Value.ToString();
			FormClientesEditar.txt_edit_telefono.Text = this.dgv_clientes.CurrentRow.Cells[3].Value.ToString();
			FormClientesEditar.txt_edit_direccion.Text = this.dgv_clientes.CurrentRow.Cells[4].Value.ToString();
			FormClientesEditar.txt_edit_cedula.Select();
			FormClientesEditar.Show();
		}

		private void CantidadClientes()
		{
			lbl_clientes_registrados.Text = dgv_clientes.Rows.Count.ToString();
		}

		private void txt_buscar_clientes_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void txt_buscar_clientes_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_buscar_Click(this, new EventArgs());
			}
		}

		private void dgv_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_editar_Click(this, new EventArgs());
		}
	}
}
