using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA
{
	public class Productos
	{
		int id;
		String nombre;
		String descripcion;
		int cantidad;
		int precio;
		int idconfirmacion;

		public int ID { get => id; set => id = value; }
		public string NOMBRE { get => nombre; set => nombre = value; }
		public string DESCRIPCION { get => descripcion; set => descripcion = value; }
		public int CANTIDAD { get => cantidad; set => cantidad = value; }
		public int PRECIO { get => precio; set => precio = value; }
		public int IDCONFIRMACION { get => idconfirmacion; set => idconfirmacion = value; }

		public void InsertarProductos()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "INSERT INTO PRODUCTOS VALUES(" + this.id + ",'" + this.nombre + "','" + this.descripcion + "', " + this.cantidad + "," + this.precio + " )";
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void EliminarProductos()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "DELETE PRODUCTOS WHERE PROD_ID = " + this.idconfirmacion;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void ModificarProductos()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "UPDATE PRODUCTOS SET PROD_ID = " + this.id + ", PROD_NOMBRE = '" + this.nombre + "', PROD_DESCRIPCION = '" + this.descripcion + "', PROD_CANTIDAD = " + this.cantidad + ", PROD_PRECIO = " + this.precio + " WHERE PROD_ID = " + this.idconfirmacion;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public DataTable DgvProductos()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT PROD_ID AS 'Codigo', PROD_NOMBRE AS 'Nombre', PROD_DESCRIPCION AS 'Descripción', PROD_CANTIDAD AS 'Cantidad', PROD_PRECIO AS 'Precio' FROM PRODUCTOS";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}
	}
}
