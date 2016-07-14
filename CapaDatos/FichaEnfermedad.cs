using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class FichaEnfermedad
    {
        private int id;
        private int ficha_id;
        private string enfermedad_id;
        private Fichas Ficha;
        private Enfermedad Enfermedad;

        public FichaEnfermedad()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioFichaId
        {
            set { this.ficha_id = value; }
            get { return this.ficha_id; }
        }

        public string ioEnfermedadId
        {
            set { this.enfermedad_id = value; }
            get { return this.enfermedad_id; }
        }

        public Fichas ioFicha
        {
            set { this.Ficha = value; }
            get { return this.Ficha; }
        }

        public Enfermedad ioEnfermedad
        {
            set { this.Enfermedad = value; }
            get { return this.Enfermedad; }
        }

        public FichaEnfermedad buscarPorId(int id, Boolean fullData = false)
        {
            FichaEnfermedad fichaEnfermedad = new FichaEnfermedad();
            //Buscar las isapres
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from ficha_enfermedad where id = " + id);
            if (dr.Read())
            {
                fichaEnfermedad.ioId = Int32.Parse(dr["id"].ToString());
                fichaEnfermedad.ioFichaId = Int32.Parse(dr["ficha_id"].ToString());
                fichaEnfermedad.ioEnfermedadId = dr["enfermedad_id"].ToString();
                if (fullData)
                {

                }
            }
            conexion.cerrarConexion();
            return fichaEnfermedad;
        }

        public List<FichaEnfermedad> buscarTodos()
        {
            List<FichaEnfermedad> fichaEnfermedades = new List<FichaEnfermedad>();
            FichaEnfermedad fichaEnfermedad;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from ficha_enfermedad");
            while (dr.Read())
            {
                fichaEnfermedad = new FichaEnfermedad();
                fichaEnfermedad.ioId = Int32.Parse(dr["id"].ToString());
                fichaEnfermedad.ioFichaId = Int32.Parse(dr["ficha_id"].ToString());
                fichaEnfermedad.ioEnfermedadId = dr["enfermedad_id"].ToString();
                fichaEnfermedades.Add(fichaEnfermedad);
            }
            conexion.cerrarConexion();
            return fichaEnfermedades;
        }

        public List<FichaEnfermedad> buscarPor(int fichaId = 0, string enfermedadId = "")
        {
            List<FichaEnfermedad> fichaEnfermedades = new List<FichaEnfermedad>();
            FichaEnfermedad fichaEnfermedad;
            Conexion conexion = new Conexion();
            string query = "select * from ficha_enfermedad";

            if(!fichaId.Equals(0) || !enfermedadId.Equals(""))
            {
                query += " where";
                if (!fichaId.Equals(0))
                {
                    query += " ficha_id = " + fichaId;
                    if (!enfermedadId.Equals(""))
                    {
                        query += " and enfermedad_id = '" + enfermedadId + "'";
                    }
                }else
                {
                    query += " enfermedad_id = '" + enfermedadId + "'";
                }
                
            }
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                fichaEnfermedad = new FichaEnfermedad();
                fichaEnfermedad.ioId = Int32.Parse(dr["id"].ToString());
                fichaEnfermedad.ioFichaId = Int32.Parse(dr["ficha_id"].ToString());
                fichaEnfermedad.ioEnfermedadId = dr["enfermedad_id"].ToString();
                fichaEnfermedades.Add(fichaEnfermedad);
            }
            conexion.cerrarConexion();
            return fichaEnfermedades;
        }

        public Boolean guardar(FichaEnfermedad fichaEnfermedad)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            int id = conexion.getSequenceValor("SEQ_FICHA_ENFERMEDAD", 1);
            conexion.cerrarConexion();

            string query = "insert into ficha_enfermedad (id, ficha_id, enfermedad_id) values (";
            query += id +",";
            query += "'" + fichaEnfermedad.ioFichaId + "',";
            query += "'" + fichaEnfermedad.ioEnfermedadId + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }

        public Boolean actualizar(FichaEnfermedad fichaEnfermedad)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update ficha_enfermedad set";
            query += " ficha_id=" + fichaEnfermedad.ioFichaId + ",";
            query += " enfermedad_id =" + fichaEnfermedad.ioFichaId;
            query += " where id=" + fichaEnfermedad.ioId;

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
