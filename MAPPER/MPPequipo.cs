using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;
using BE;
using DAL;
using System.Data.SqlClient;
using System.Data;


namespace MAPPER
{
    public class MPPequipo : Igestor<BEequipo>
    {
        public MPPequipo()
        {
            acceso = new Acceso();
        }

        Acceso acceso;
        List<SqlParameter> parameters;

        public BEequipo BuscarObj(BEequipo obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEequipo obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Equipo_Eliminar";

            SqlParameter param1 = new SqlParameter("@ID", obj.ID);
            param1.SqlDbType = SqlDbType.Int;
            parameters.Add(param1);

            return acceso.Escribir(query, parameters);
        }

        public bool Guardar(BEequipo obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Equipo_Agregar";

            #region(DefinoParametros)
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Nom";
            param1.Value = obj.nombre;
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Cat";
            param2.Value = obj.categoria;
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            if (obj.entrenador != null)
            {
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@CodEntrenador";
                param3.Value = obj.entrenador.ID;
                param3.SqlDbType = SqlDbType.Int;
                parameters.Add(param3);
            }
            else
            {
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@CodEntrenador";
                param3.Value = 0;
                param3.SqlDbType = SqlDbType.Int;
                parameters.Add(param3);
            }
            
            #endregion


            return acceso.Escribir(query, parameters);
        }

        public List<BEequipo> ListarObjs()
        {
            DataTable tabla = acceso.Leer("Equipo_Listar", null);
            List<BEequipo> ListaEquipos = new List<BEequipo>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BEequipo equip = new BEequipo();
                    equip.ID = Convert.ToInt32(fila["ID"]);
                    equip.nombre = fila["Nombre"].ToString();
                    equip.categoria = fila["Categoria"].ToString();
                    

                    ListaEquipos.Add(equip);
                }

                return ListaEquipos;
            }
            else
            {
                return null;
            }
        }

        public List<BEnadador> ListarNadadores(BEequipo obj)
        {
            parameters = new List<SqlParameter>();

            SqlParameter paramE = new SqlParameter();
            paramE.ParameterName = "@ID";
            paramE.Value = obj.ID;
            paramE.SqlDbType = SqlDbType.Int;
            parameters.Add(paramE);

            DataTable tabla = acceso.Leer("Equipo_Listar_Nadadores", parameters);
            List<BEnadador> ListaNadadores = new List<BEnadador>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BEnadador nad = new BEnadador();
                    nad.ID = Convert.ToInt32(fila["ID"]);
                    nad.nombre = fila["Nombre"].ToString();
                    nad.apellido = fila["Apellido"].ToString();
                    nad.dni = fila["Dni"].ToString();
                    nad.telefono = Convert.ToInt32(fila["Telefono"]);
                    nad.edad = Convert.ToInt32(fila["Edad"]);
                    nad.categoria = fila["Categoria"].ToString();

                    ListaNadadores.Add(nad);
                }

                return ListaNadadores;
            }
            else
            {
                return null;
            }
        }

        public int CantIntegrantes()
        {
            throw new NotImplementedException();
        }
    }
}
