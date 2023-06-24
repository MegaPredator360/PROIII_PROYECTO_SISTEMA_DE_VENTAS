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
	public partial class frm_facturacion_pago : Form
	{

		Facturas Fact;
		frm_facturacion FormFacturacion;

		public frm_facturacion_pago(frm_facturacion FrmFacturacion)
		{
			InitializeComponent();
			FormFacturacion = FrmFacturacion;
			Fact = new Facturas();
			OpcionesCbxPago();
			PagoInicio();
		}

		public void OpcionesCbxPago()
		{
			cbx_metodo_pago.Items.Add("Efectivo");
			cbx_metodo_pago.Items.Add("Tarjeta");
			cbx_metodo_pago.Items.Add("Deposito");
		}

		private void btn_terminar_compra_Click(object sender, EventArgs e)
		{
			try
			{
				int monto = int.Parse(txt_monto_pago.Text);
				CalcularVuelto(monto);
				int tarjeta = txt_tarjeta.Text.Length;
				int deposito = txt_deposito.Text.Length;

				if (int.Parse(lbl_valor_vuelto.Text) >= 0 && tarjeta == 4 && deposito == 9 && cbx_metodo_pago.Text == "Efectivo")
				{
					Fact = new Facturas()
					{
						ID = int.Parse(FormFacturacion.lbl_numero_factura.Text),
						CLIE_NOMBRE = FormFacturacion.txt_nombre_cliente.Text,
						EMPL_NOMBRE = FormFacturacion.lbl_nombre_usuario.Text,
						SUBTOTAL = int.Parse(FormFacturacion.lbl_subtotal.Text),
						DESCUENTO = int.Parse(FormFacturacion.lbl_descuento.Text),
						TOTAL = int.Parse(FormFacturacion.lbl_total.Text),
						METODO_PAGO = cbx_metodo_pago.Text,
						PAGO = int.Parse(txt_monto_pago.Text),
						VUELTO = int.Parse(lbl_valor_vuelto.Text)
					};
					Fact.InsertarFactura();
					FormFacturacion.OpcionesDefecto();
					MessageBox.Show("Compra Realizada Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else if (int.Parse(lbl_valor_vuelto.Text) >= 0 && tarjeta == 4 && deposito == 9 && cbx_metodo_pago.Text == "Tarjeta")
				{
					Fact = new Facturas()
					{
						ID = int.Parse(FormFacturacion.lbl_numero_factura.Text),
						CLIE_NOMBRE = FormFacturacion.txt_nombre_cliente.Text,
						EMPL_NOMBRE = FormFacturacion.lbl_nombre_usuario.Text,
						SUBTOTAL = int.Parse(FormFacturacion.lbl_subtotal.Text),
						DESCUENTO = int.Parse(FormFacturacion.lbl_descuento.Text),
						TOTAL = int.Parse(FormFacturacion.lbl_total.Text),
						METODO_PAGO = cbx_metodo_pago.Text,
						PAGO = int.Parse(txt_tarjeta.Text),
						VUELTO = int.Parse(lbl_valor_vuelto.Text)
					};
					Fact.InsertarFactura();
					FormFacturacion.OpcionesDefecto();
					MessageBox.Show("Compra Realizada Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else if (int.Parse(lbl_valor_vuelto.Text) >= 0 && tarjeta == 4 && deposito == 9 && cbx_metodo_pago.Text == "Deposito")
				{
					Fact = new Facturas()
					{
						ID = int.Parse(FormFacturacion.lbl_numero_factura.Text),
						CLIE_NOMBRE = FormFacturacion.txt_nombre_cliente.Text,
						EMPL_NOMBRE = FormFacturacion.lbl_nombre_usuario.Text,
						SUBTOTAL = int.Parse(FormFacturacion.lbl_subtotal.Text),
						DESCUENTO = int.Parse(FormFacturacion.lbl_descuento.Text),
						TOTAL = int.Parse(FormFacturacion.lbl_total.Text),
						METODO_PAGO = cbx_metodo_pago.Text,
						PAGO = int.Parse(txt_deposito.Text),
						VUELTO = int.Parse(lbl_valor_vuelto.Text)
					};
					Fact.InsertarFactura();
					FormFacturacion.OpcionesDefecto();
					MessageBox.Show("Compra Realizada Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else if (cbx_metodo_pago.Text == "Efectivo")
				{
					MessageBox.Show("El valor de monto de Pago es menor al costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (cbx_metodo_pago.Text == "Tarjeta" || cbx_metodo_pago.Text == "Deposito")
				{
					MessageBox.Show("Los cantidad de digitos ingresados no son los correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void PagoInicio()
		{
			lbl_paga_con.Visible = false;
			txt_monto_pago.Visible = false;
			lbl_vuelto.Visible = false;
			lbl_valor_vuelto.Visible = false;
			lbl_tarjeta.Visible = false;
			txt_tarjeta.Visible = false;
			lbl_deposito.Visible = false;
			txt_deposito.Visible = false;
			btn_terminar_compra.Visible = false;
			txt_monto_pago.Text = lbl_costo_total.Text;
			lbl_valor_vuelto.Text = "0";
			txt_tarjeta.Text = "0000";
			txt_deposito.Text = "000000000";
			cbx_metodo_pago.SelectedIndex = 0;
		}

		private void cbx_metodo_pago_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_metodo_pago.Text == "Efectivo")
			{
				lbl_paga_con.Visible = true;
				txt_monto_pago.Visible = true;
				lbl_vuelto.Visible = true;
				lbl_valor_vuelto.Visible = true;
				lbl_tarjeta.Visible = false;
				txt_tarjeta.Visible = false;
				lbl_deposito.Visible = false;
				txt_deposito.Visible = false;
				btn_terminar_compra.Visible = true;
				txt_monto_pago.Text = lbl_costo_total.Text;
				lbl_valor_vuelto.Text = "0";
				txt_tarjeta.Text = "0000";
				txt_deposito.Text = "000000000";
			}
			else if (cbx_metodo_pago.Text == "Tarjeta")
			{
				lbl_paga_con.Visible = false;
				txt_monto_pago.Visible = false;
				lbl_vuelto.Visible = false;
				lbl_valor_vuelto.Visible = false;
				lbl_tarjeta.Visible = true;
				txt_tarjeta.Visible = true;
				lbl_deposito.Visible = false;
				txt_deposito.Visible = false;
				btn_terminar_compra.Visible = true;
				txt_monto_pago.Text = lbl_costo_total.Text;
				lbl_valor_vuelto.Text = "0";
				txt_tarjeta.Text = "0000";
				txt_deposito.Text = "000000000";
			}
			else if (cbx_metodo_pago.Text == "Deposito")
			{
				lbl_paga_con.Visible = false;
				txt_monto_pago.Visible = false;
				lbl_vuelto.Visible = false;
				lbl_valor_vuelto.Visible = false;
				lbl_tarjeta.Visible = false;
				txt_tarjeta.Visible = false;
				lbl_deposito.Visible = true;
				txt_deposito.Visible = true;
				btn_terminar_compra.Visible = true;
				txt_monto_pago.Text = lbl_costo_total.Text;
				lbl_valor_vuelto.Text = "0";
				txt_tarjeta.Text = "0000";
				txt_deposito.Text = "000000000";
			}
			else
			{
				lbl_paga_con.Visible = false;
				txt_monto_pago.Visible = false;
				lbl_vuelto.Visible = false;
				lbl_valor_vuelto.Visible = false;
				lbl_tarjeta.Visible = false;
				txt_tarjeta.Visible = false;
				lbl_deposito.Visible = false;
				txt_deposito.Visible = false;
				btn_terminar_compra.Visible = false;
				txt_monto_pago.Text = lbl_costo_total.Text;
				lbl_valor_vuelto.Text = "0";
				txt_tarjeta.Text = "0000";
				txt_deposito.Text = "000000000";
			}
		}

		public void CalcularVuelto(int monto)
		{
			int vuelto;
			int total;
			total = int.Parse(lbl_costo_total.Text);
			vuelto = monto - total;
			lbl_valor_vuelto.Text = vuelto.ToString();
		}

		private void txt_monto_pago_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int monto = int.Parse(txt_monto_pago.Text);
				CalcularVuelto(monto);
			}
		}
	}
}
