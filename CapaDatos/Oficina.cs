using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Oficina
    {
        private int id;
        private int piso;
        private string numero;

        public Oficina()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioPiso
        {
            set { this.piso = value; }
            get { return this.piso; }
        }

        public string ioNumero
        {
            set { this.numero = value; }
            get { return this.numero; }
        }

        public List<Oficina> buscarTodos()
        {
            List<Oficina> oficinas = new List<Oficina>();
            Oficina oficina;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from oficinas");
            while (dr.Read())
            {
                oficina = new Oficina();
                oficina.id = Int32.Parse(dr["id"].ToString());
                oficina.piso = Int32.Parse(dr["piso"].ToString());
                oficina.numero = dr["numero"].ToString();
                oficinas.Add(oficina);
            }
            conexion.cerrarConexion();
            return oficinas;
        }

        public Oficina buscarPorNumero(string numero)
        {
            Oficina oficina = new Oficina();
            Conexion conexion = new Conexion();
            string query = "select * from oficinas where numero='" + numero + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                oficina.ioId = Int32.Parse(dr["id"].ToString());
                oficina.ioNumero = dr["numero"].ToString();
            }
            conexion.cerrarConexion();
            return oficina;
        }

        public Oficina buscarPorId(int id)
        {
            Oficina oficina = new Oficina();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from oficinas where id = " + id);
            if (dr.Read())
            {
                oficina.id = Int32.Parse(dr["id"].ToString());
                oficina.piso = Int32.Parse(dr["piso"].ToString());
                oficina.numero = dr["numero"].ToString();
            }
            conexion.cerrarConexion();
            return oficina;
        }

        public Boolean guardar(Oficina oficina)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            int id = conexion.getSequenceValor("SEQ_OFICINAS", 1);
            conexion.cerrarConexion();

            string query = "insert into OFICINAS (id, piso, numero) values (";
            query += id + ",";
            query += oficina.ioPiso + ",";
            query += "'" + oficina.ioNumero+ "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }

        public Boolean actualizar(Oficina oficina)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update OFICINAS set";
            query +=" id=" + oficina.ioId.ToString() + ",";
            query += " piso=" + oficina.ioPiso.ToString() + ",";
            query += " numero='" + oficina.ioNumero + "'";
            query += " where id=" + oficina.ioId.ToString();

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }
    }
}
