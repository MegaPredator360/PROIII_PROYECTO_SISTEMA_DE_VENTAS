using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_LOGICA
{
	public class Facturas
	{
		int id;
		String clie_nombre;
		String empl_nombre;
		int prod_id;
		int prod_cantidad;
		String prod_nombre;
		int subtotal;
		int descuento;
		int total;
		String metodo_pago;
		int pago;
		int vuelto;

		public int ID { get => id; set => id = value; }
		public string CLIE_NOMBRE { get => clie_nombre; set => clie_nombre = value; }
		public string EMPL_NOMBRE { get => empl_nombre; set => empl_nombre = value; }
		public int PROD_ID { get => prod_id; set => prod_id = value; }
		public int PROD_CANTIDAD { get => prod_cantidad; set => prod_cantidad = value; }
		public string PROD_NOMBRE { get => prod_nombre; set => prod_nombre = value; }
		public int SUBTOTAL { get => subtotal; set => subtotal = value; }
		public int DESCUENTO { get => descuento; set => descuento = value; }
		public int TOTAL { get => total; set => total = value; }
		public string METODO_PAGO { get => metodo_pago; set => metodo_pago = value; }
		public int PAGO { get => pago; set => pago = value; }
		public int VUELTO { get => vuelto; set => vuelto = value; }

		public DataTable DevolucionProductos()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SP_DEVOLUCION " + this.id + ", '" + this.prod_nombre + "', " + this.prod_cantidad;
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public DataTable DevolucionFacturaVacia()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT FACT_ID AS Factura, FACT_FECHA AS Fecha, FACT_TOTAL AS 'Monto de Compra' FROM FACTURAS WHERE FACT_ID = 0";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}
		
		public DataTable DevolucionProductoVacia()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT P.PROD_NOMBRE AS Producto, DF.DEFA_CANTIDAD AS Cantidad, DF.DEFA_TOTAL AS Total FROM DETALLE_FACTURA AS DF INNER JOIN PRODUCTOS AS P ON DF.DEFA_PROD_ID = P.PROD_ID WHERE DEFA_FACT_ID = 0";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public DataTable DevolucionBuscarProducto()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT P.PROD_NOMBRE AS Producto, DF.DEFA_CANTIDAD AS Cantidad, DF.DEFA_TOTAL AS Total FROM DETALLE_FACTURA AS DF INNER JOIN PRODUCTOS AS P ON DF.DEFA_PROD_ID = P.PROD_ID WHERE DEFA_FACT_ID = " + this.id;
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public DataTable DevolucionBuscarFactura()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT FACT_ID AS Factura, FACT_FECHA AS Fecha, FACT_TOTAL AS 'Monto de Compra' FROM FACTURAS WHERE FACT_ID = " + this.id;
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public void InsertarDetalleFacturaCOD()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SP_INSERT_DEFA_COD " + this.id + ", " + this.prod_id + ", " + this.prod_cantidad;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void InsertarFactura()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SP_INSERT_FACTURA " + this.id + ", '" + this.clie_nombre + "', '" + this.empl_nombre + "', " + this.subtotal + ", " + this.descuento + ", " + this.total + ", '" + this.metodo_pago + "', " + this.pago + ", " + this.vuelto;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void InsertarDetalleFacturaNom()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SP_INSERT_DEFA_NOM " + this.id + ", '" + this.prod_nombre + "', " + this.prod_cantidad;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void BorrarDetalleFactura()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SP_DELETE_DEFA " + this.id + ", " + this.prod_id;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public DataTable DgvFacturas()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT F.FACT_ID AS 'N° Factura', F.FACT_METODO_PAGO AS 'Metodo de Pago', F.FACT_FECHA AS 'Fecha', C.CLIE_NOMBRE AS 'Cliente', F.FACT_TOTAL AS 'Total' FROM FACTURAS AS F INNER JOIN CLIENTES AS C ON FACT_CLIE_ID = C.CLIE_ID";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public DataTable DgvDetalleFactura()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT P.PROD_NOMBRE AS 'Producto', DF.DEFA_CANTIDAD AS 'Cantidad', DF.DEFA_TOTAL AS 'Total' FROM DETALLE_FACTURA AS DF INNER JOIN PRODUCTOS AS P ON DF.DEFA_PROD_ID = P.PROD_ID WHERE DF.DEFA_FACT_ID = " + this.id;
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public DataTable DgvDetalleFacturaFacturacion()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT P.PROD_ID AS 'Codigo', P.PROD_NOMBRE AS 'Producto', DF.DEFA_CANTIDAD AS 'Cantidad', DF.DEFA_TOTAL AS 'Total' FROM DETALLE_FACTURA AS DF INNER JOIN PRODUCTOS AS P ON DF.DEFA_PROD_ID = P.PROD_ID WHERE DF.DEFA_FACT_ID = " + this.id;
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}

		public string ObtenerIdFactura()
		{
			Conexion conex = new Conexion();
			return conex.ObtenerFactID();
		}

		public string ObtenerIdProducto()
		{
			Conexion conex = new Conexion();
			return conex.ObtenerProdID(this.prod_nombre);
		}

		public string ObtenerNombreProducto()
		{
			Conexion conex = new Conexion();
			return conex.ObtenerProdNombre(this.prod_id);
		}

		public AutoCompleteStringCollection AutoCompletarClientes(AutoCompleteStringCollection lstClientes)
		{
			Conexion conex = new Conexion();
			return conex.AutoCompletarClientes(lstClientes);

		}

		public AutoCompleteStringCollection AutoCompletarCodigo(AutoCompleteStringCollection lstCodigo)
		{
			Conexion conex = new Conexion();
			return conex.AutoCompletarCodigo(lstCodigo);
		}

		public AutoCompleteStringCollection AutoCompletarProducto(AutoCompleteStringCollection lstProducto)
		{
			Conexion conex = new Conexion();
			return conex.AutoCompletarProducto(lstProducto);
		}
	}
}
