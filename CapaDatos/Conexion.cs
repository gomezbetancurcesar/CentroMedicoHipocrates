using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Conexion
    {
        string conexionString = "DATA SOURCE=CENTRO;USER ID=CENTROM;PASSWORD=123456;";
        private OracleConnection conexion;
        
        public string tabla = "";

        public Conexion()
        {
            this.conexion = new OracleConnection(this.conexionString);
        }

        public OracleDataReader consultar(string query)
        {
            this.conexion.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = this.conexion;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void cerrarConexion()
        {
            this.conexion.Close();
        }
        
    }
}
