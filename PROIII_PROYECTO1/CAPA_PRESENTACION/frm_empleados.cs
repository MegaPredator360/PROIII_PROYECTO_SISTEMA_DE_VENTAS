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
	public partial class frm_empleados : Form
	{

		Empleados Empl;

		public frm_empleados()
		{
			InitializeComponent();
			Empl = new Empleados();
			dgv_empleados.DataSource = Empl.DgvEmpleados();
			DataGridViewWidth();
			CantidadEmpleados();
		}

		public void DataGridViewWidth()
		{
			dgv_empleados.Columns[0].Width = 125;
			dgv_empleados.Columns[1].Width = 200;
			dgv_empleados.Columns[2].Width = 285;
			dgv_empleados.Columns[3].Width = 125;
			dgv_empleados.Columns[4].Width = 200;
		}

		private void CantidadEmpleados()
		{
			lbl_empleados_registrados.Text = dgv_empleados.Rows.Count.ToString();
		}

		public void ActualizarEmpleados()
		{
			dgv_empleados.DataSource = Empl.DgvEmpleados();
			lbl_empleados_registrados.Text = dgv_empleados.Rows.Count.ToString();
		}

		private void frm_empleados_Load(object sender, EventArgs e)
		{
			dgv_empleados.ReadOnly = true;
		}

		private void btn_empl_agregar_Click(object sender, EventArgs e)
		{
			frm_empleados_agregar FormEmpleadosAgregar = new frm_empleados_agregar(this);
			FormEmpleadosAgregar.txt_add_cedula.Select();
			FormEmpleadosAgregar.cbx_add_tipo_usuario.SelectedIndex = 0;
			FormEmpleadosAgregar.Show();
		}

		private void btn_empl_editar_Click(object sender, EventArgs e)
		{
			frm_empleados_editar FormEmpleadosEditar = new frm_empleados_editar(this);
			FormEmpleadosEditar.txt_edit_cedula.Text = this.dgv_empleados.CurrentRow.Cells[0].Value.ToString();
			FormEmpleadosEditar.lbl_edit_cedula.Text = this.dgv_empleados.CurrentRow.Cells[0].Value.ToString();
			FormEmpleadosEditar.txt_edit_nombre.Text = this.dgv_empleados.CurrentRow.Cells[1].Value.ToString();
			FormEmpleadosEditar.txt_edit_correo.Text = this.dgv_empleados.CurrentRow.Cells[2].Value.ToString();
			FormEmpleadosEditar.txt_edit_usuario.Text = this.dgv_empleados.CurrentRow.Cells[3].Value.ToString();
			FormEmpleadosEditar.cbx_edit_tipo_usuario.Text = this.dgv_empleados.CurrentRow.Cells[4].Value.ToString();
			FormEmpleadosEditar.txt_edit_cedula.Select();
			FormEmpleadosEditar.Show();
		}

		private void btn_empl_buscar_Click(object sender, EventArgs e)
		{
			String buscarNombre = txt_buscar_empleados.Text;
			if (buscarNombre != "")
			{
				DataGridViewRow row = dgv_empleados.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => Convert.ToString(r.Cells[0].Value).Equals(buscarNombre));

				if (row != null)
				{
					dgv_empleados.ClearSelection();
					dgv_empleados.FirstDisplayedScrollingRowIndex = row.Index;

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

		private void txt_buscar_empleados_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_buscar_empleados_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_empl_buscar_Click(this, new EventArgs());
			}
		}

		private void dgv_empleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_empl_editar_Click(this, new EventArgs());
		}
	}
}
