using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA
{
	public class Proveedores
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

		public void InsertarProveedores()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "INSERT INTO PROVEEDORES VALUES(" + this.id + ",'" + this.nombre + "','" + this.correo + "', " + this.telefono + ",'" + this.direccion + "' )";
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void EliminarProveedores()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "DELETE PROVEEDORES WHERE PROV_ID = " + this.idconfirmacion;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void ModificarProveedores()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "UPDATE PROVEEDORES SET PROV_ID = " + this.id + ", PROV_NOMBRE = '" + this.nombre + "', PROV_CORREO = '" + this.correo + "', PROV_TELEFONO = " + this.telefono + ", PROV_DIRECCION = '" + this.direccion + "' WHERE PROV_ID = " + this.idconfirmacion;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public DataTable DgvProveedores()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT PROV_ID AS 'Cedula', PROV_NOMBRE AS 'Nombre', PROV_CORREO AS 'Correo', PROV_TELEFONO AS 'Telefono', PROV_DIRECCION AS 'Dirección' FROM PROVEEDORES";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}
	}
}
