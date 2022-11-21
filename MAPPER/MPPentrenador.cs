using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS;
using BE;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace MAPPER
{
    public class MPPentrenador : Igestor<BEentrenador>
    {
        Acceso acceso;
        List<SqlParameter> parameters;

        public MPPentrenador()
        {
            acceso = new Acceso();
        }

        public bool Eliminar(BEentrenador obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Entrenador_Eliminar";

            SqlParameter param1 = new SqlParameter("@ID", obj.ID);
            param1.SqlDbType = SqlDbType.Int;
            parameters.Add(param1);

            return acceso.Escribir(query, parameters);
        }

        public bool Guardar(BEentrenador obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Entrenador_Agregar";

            if (obj.ID != 0)
            {
                SqlParameter paramE = new SqlParameter();
                paramE.ParameterName = "@ID";
                paramE.Value = obj.ID;
                paramE.SqlDbType = SqlDbType.VarChar;
                parameters.Add(paramE);
                query = "Entrenador_Modificar";
            }
            #region(DefinoParametros)
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Nom";
            param1.Value = obj.nombre;
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Ape";
            param2.Value = obj.apellido;
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            SqlParameter param6 = new SqlParameter();
            param6.ParameterName = "@Dni";
            param6.Value = obj.dni;
            param6.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param6);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@Tel";
            param3.Value = obj.telefono;
            param3.SqlDbType = SqlDbType.Int;
            parameters.Add(param3);

            SqlParameter param5 = new SqlParameter();
            param5.ParameterName = "@Club";
            param5.Value = obj.club;
            param5.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param5);
            #endregion

            if (ExistenciaEntrenadorXDNI(obj) == false)
            { return acceso.Escribir(query, parameters); }
            else
            { return false; }
        }

        public List<BEentrenador> ListarObjs()
        {

            DataTable tabla = acceso.Leer("Entrenador_Listar", null);
            List<BEentrenador> ListaEntrenadores = new List<BEentrenador>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BEentrenador ent = new BEentrenador();
                    ent.ID = Convert.ToInt32(fila["ID"]);
                    ent.nombre = fila["Nombre"].ToString();
                    ent.apellido = fila["Apellido"].ToString();
                    ent.dni = fila["Dni"].ToString();
                    ent.telefono = Convert.ToInt32(fila["Telefono"]);
                    ent.club = fila["Club"].ToString();

                    ListaEntrenadores.Add(ent);
                }

                return ListaEntrenadores;
            }
            else
            {
                return null;
            }

        }

        public DataTable tablaEntrenadores()
        {
            DataTable tabla = acceso.Leer("Entrenador_Listar", null);
            if (tabla.Rows.Count > 0)
            {
                return tabla;
            }
            else
            {
                return null;
            }
        }

        bool ExistenciaEntrenadorXDNI(BEentrenador obj)
        {
            List<SqlParameter> parametersList = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter();

            if (obj.ID == 0)
            {
                param1.ParameterName = "@Dni";
                param1.Value = obj.dni;
                param1.SqlDbType = SqlDbType.VarChar;
                parametersList.Add(param1);

                return acceso.LeerScalar("Entrenador_Verificar_Dni", parametersList);
            }
            else
            {
                return false;
            }

        }
        
        public BEentrenador BuscarObj(BEentrenador obj)
        {
            throw new NotImplementedException();
        }
    }
}
