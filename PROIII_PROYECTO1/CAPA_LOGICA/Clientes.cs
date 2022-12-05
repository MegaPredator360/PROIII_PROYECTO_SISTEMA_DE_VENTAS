using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;

namespace CAPA_LOGICA
{
	public class Clientes
	{
		int id;
		String nombre;
		String correo;
		int telefono;
		String direccion;
		int idconfirmacion;

		public int ID { get => id; set => id = value; }
		public string NOMBRE { get => nombre; set => nombre = value; }
		public string CORREO { get => correo; set => correo = value; }
		public int TELEFONO { get => telefono; set => telefono = value; }
		public string DIRECCION { get => direccion; set => direccion = value; }
		public int IDCONFIRMACION { get => idconfirmacion; set => idconfirmacion = value; }

		public void InsertarClientes()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "INSERT INTO CLIENTES VALUES(" + this.id + ",'" + this.nombre + "','" + this.correo + "', " + this.telefono + ",'" + this.direccion + "' )";
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void EliminarClientes()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "DELETE CLIENTES WHERE CLIE_ID = " + this.idconfirmacion;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void ModificarClientes()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "UPDATE CLIENTES SET CLIE_ID = " + this.id + ", CLIE_NOMBRE = '" + this.nombre + "', CLIE_CORREO = '" + this.correo + "', CLIE_TELEFONO = " + this.telefono + ", CLIE_DIRECCION = '" + this.direccion + "' WHERE CLIE_ID = " + this.idconfirmacion;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public DataTable DgvClientes()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT CLIE_ID AS 'Cedula', CLIE_NOMBRE AS 'Nombre', CLIE_CORREO AS 'Correo', CLIE_TELEFONO AS 'Telefono', CLIE_DIRECCION AS 'Dirección' FROM CLIENTES WHERE CLIE_ID NOT LIKE 0";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}
	}
}
