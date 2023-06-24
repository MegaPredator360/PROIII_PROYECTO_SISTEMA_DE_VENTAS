using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA
{
	public class Empleados
	{
		int id;
		String nombre;
		String correo;
		String usuario;
		String contrasena;
		String tipo_usuario;
		int idconfirmacionempleado;

		public int ID { get => id; set => id = value; }
		public string NOMBRE { get => nombre; set => nombre = value; }
		public string CORREO { get => correo; set => correo = value; }
		public string USUARIO { get => usuario; set => usuario = value; }
		public string CONTRASENA { get => contrasena; set => contrasena = value; }
		public string TIPO_USUARIO { get => tipo_usuario; set => tipo_usuario = value; }
		public int IDCONFIRMACIONEMPLEADO { get => idconfirmacionempleado; set => idconfirmacionempleado = value; }

		public void InsertarEmpleados()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "INSERT INTO EMPLEADOS VALUES(" + this.id + ",'" + this.nombre + "','" + this.correo + "', '" + this.usuario + "', '" + this.contrasena +"','" + this.tipo_usuario + "' )";
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void EliminarEmpleados()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "DELETE EMPLEADOS WHERE EMPL_ID = " + this.idconfirmacionempleado;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public void ModificarEmpleados()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "UPDATE EMPLEADOS SET EMPL_ID = " + this.id + ", EMPL_NOMBRE = '" + this.nombre + "', EMPL_CORREO = '" + this.correo + "', EMPL_USUARIO = '" + this.usuario + "', EMPL_CONTRASENA = '" + this.contrasena + "', EMPL_TIPO_USUARIO = '" + this.tipo_usuario + "' WHERE EMPL_ID = " + this.idconfirmacionempleado;
			conex.SQLConsulta(consulta);
			conex.desConectar();
		}

		public string IniciarSesion()
		{
			Conexion conex = new Conexion();
			return conex.IniciarSesion(this.usuario, this.contrasena);
		}

		public DataTable DgvEmpleados()
		{
			Conexion conex = new Conexion();
			conex.conectar();
			String consulta = "SELECT EMPL_ID AS 'Cedula', EMPL_NOMBRE AS 'Nombre', EMPL_CORREO AS 'Correo', EMPL_USUARIO AS 'Usuario', EMPL_TIPO_USUARIO AS 'Tipo Usuario'  FROM EMPLEADOS";
			DataTable tabla = conex.cargarGrid(consulta);
			conex.desConectar();
			return tabla;
		}
	}
}
