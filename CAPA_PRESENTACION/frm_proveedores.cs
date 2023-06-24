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
	public partial class frm_proveedores : Form
	{

		Proveedores Prov;

		public frm_proveedores()
		{
			InitializeComponent();
			Prov = new Proveedores();
			dgv_proveedores.DataSource = Prov.DgvProveedores();
			DataGridViewWidth();
			CantidadProveedores();
		}

		public void DataGridViewWidth()
		{
			dgv_proveedores.Columns[0].Width = 125;
			dgv_proveedores.Columns[1].Width = 200;
			dgv_proveedores.Columns[2].Width = 285;
			dgv_proveedores.Columns[3].Width = 125;
			dgv_proveedores.Columns[4].Width = 200;
		}

		private void CantidadProveedores()
		{
			lbl_proveedores_registrados.Text = dgv_proveedores.Rows.Count.ToString();
		}

		private void frm_proveedores_Load(object sender, EventArgs e)
		{
			dgv_proveedores.ReadOnly = true;
		}

		public void ActualizarProveedores()
		{
			dgv_proveedores.DataSource = Prov.DgvProveedores();
			lbl_proveedores_registrados.Text = dgv_proveedores.Rows.Count.ToString();
		}

		private void btn_agregar_Click(object sender, EventArgs e)
		{
			frm_proveedores_agregar FormProveedoresAgregar = new frm_proveedores_agregar(this);
			FormProveedoresAgregar.Show();
		}

		private void btn_editar_Click(object sender, EventArgs e)
		{
			frm_proveedores_editar FormProveedoresEditar = new frm_proveedores_editar(this);
			FormProveedoresEditar.txt_edit_cedula.Text = this.dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
			FormProveedoresEditar.lbl_edit_cedula.Text = this.dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
			FormProveedoresEditar.txt_edit_nombre.Text = this.dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
			FormProveedoresEditar.txt_edit_correo.Text = this.dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
			FormProveedoresEditar.txt_edit_telefono.Text = this.dgv_proveedores.CurrentRow.Cells[3].Value.ToString();
			FormProveedoresEditar.txt_edit_direccion.Text = this.dgv_proveedores.CurrentRow.Cells[4].Value.ToString();
			FormProveedoresEditar.Show();
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			String buscarNombre = txt_buscar_proveedores.Text;
			if (buscarNombre != "")
			{
				DataGridViewRow row = dgv_proveedores.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => Convert.ToString(r.Cells[0 + 1].Value).Equals(buscarNombre));

				if (row != null)
				{
					dgv_proveedores.ClearSelection();
					dgv_proveedores.FirstDisplayedScrollingRowIndex = row.Index;

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

		private void txt_buscar_proveedores_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_buscar_proveedores_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_buscar_Click(this, new EventArgs());
			}
		}
	}
}
