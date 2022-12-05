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
	public partial class frm_facturacion_facturas_detalles : Form
	{
		public frm_facturacion_facturas_detalles()
		{
			InitializeComponent();
		}

		private void frm_facturacion_facturas_detalles_Load(object sender, EventArgs e)
		{
			dgv_detalle_factura.ReadOnly = true;
		}

		private void btn_add_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
