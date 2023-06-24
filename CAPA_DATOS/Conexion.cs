using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DATOS
{
	public class Conexion
	{
		String conexionString;
		SqlConnection conexion;

		public Conexion()
		{
			this.conexionString = "server=localhost; database=FRESH_SUPERMARKET; integrated security=true";
			this.conexion = new SqlConnection(conexionString);
		}

		public void conectar()
		{
			conexion.Open();
		}

		public void desConectar()
		{
			conexion.Close();
		}

		public void SQLConsulta(String consulta)
		{
			SqlCommand comando = new SqlCommand(consulta, this.conexion);
			comando.ExecuteNonQuery();
		}

		public string ObtenerFactID()
		{
			conexion.Open();
			string consulta = "SELECT (SELECT DISTINCT TOP 1 FACT_ID FROM FACTURAS ORDER BY FACT_ID DESC) + 1 AS FACT_ID";
			SqlCommand comando = new SqlCommand(consulta, this.conexion);
			SqlDataReader reg = comando.ExecuteReader();
			if (reg.Read())
			{
				return reg["FACT_ID"].ToString();
			}
			else
			{
				return "Null";
			}
			conexion.Close();
		}

		public string ObtenerProdID(string prod_nombre)
		{
			conexion.Open();
			string consulta = "SELECT PROD_ID FROM PRODUCTOS WHERE PROD_NOMBRE = '" + prod_nombre + "'";
			SqlCommand comando = new SqlCommand(consulta, this.conexion);
			SqlDataReader reg = comando.ExecuteReader();
			if (reg.Read())
			{
				return reg["PROD_ID"].ToString();
			}
			else
			{
				return "Null";
			}
			conexion.Close();
		}

		public string ObtenerProdNombre(int prod_id)
		{
			conexion.Open();
			string consulta = "SELECT PROD_NOMBRE FROM PRODUCTOS WHERE PROD_ID = " + prod_id;
			SqlCommand comando = new SqlCommand(consulta, this.conexion);
			SqlDataReader reg = comando.ExecuteReader();
			if (reg.Read())
			{
				return reg["PROD_NOMBRE"].ToString();
			}
			else
			{
				return "Null";
			}
			conexion.Close();
		}

		public string IniciarSesion(string usuario, string contrasena)
		{
			conexion.Open();
			string consulta = "SELECT EMPL_NOMBRE FROM EMPLEADOS WHERE EMPL_USUARIO = '" + usuario + "' AND EMPL_CONTRASENA = '" + contrasena + "'";
			SqlCommand comando = new SqlCommand(consulta, this.conexion);
			SqlDataReader reg = comando.ExecuteReader();
			if (reg.Read())
			{
				return reg["EMPL_NOMBRE"].ToString();
			}
			else
			{
				return "Null";
			}
			conexion.Close();
		}

		public DataTable cargarGrid(String consulta)
		{
			SqlCommand comando = new SqlCommand(consulta, this.conexion);
			SqlDataAdapter datos = new SqlDataAdapter(comando);
			DataTable tabla = new DataTable();
			datos.Fill(tabla);
			return tabla;
		}

		public AutoCompleteStringCollection AutoCompletarClientes(AutoCompleteStringCollection lstClientes)
		{
			DataTable dtClientes = new DataTable();
			SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM CLIENTES", conexion);
			adaptador.Fill(dtClientes);
			for (int i = 0; i < dtClientes.Rows.Count; i++)
			{
				lstClientes.Add(dtClientes.Rows[i]["CLIE_NOMBRE"].ToString());
			}

			return lstClientes;
		}

		public AutoCompleteStringCollection AutoCompletarCodigo(AutoCompleteStringCollection lstCodigo)
		{
			DataTable dtCodigo = new DataTable();
			SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM PRODUCTOS", conexion);
			adaptador.Fill(dtCodigo);
			for (int i = 0; i < dtCodigo.Rows.Count; i++)
			{
				lstCodigo.Add(dtCodigo.Rows[i]["PROD_ID"].ToString());
			}
			return lstCodigo;
		}

		public AutoCompleteStringCollection AutoCompletarProducto(AutoCompleteStringCollection lstProducto)
		{
			DataTable dtProducto = new DataTable();
			SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM PRODUCTOS", conexion);
			adaptador.Fill(dtProducto);
			for (int i = 0; i < dtProducto.Rows.Count; i++)
			{
				lstProducto.Add(dtProducto.Rows[i]["PROD_NOMBRE"].ToString());
			}
			return lstProducto;
		}
	}
}
