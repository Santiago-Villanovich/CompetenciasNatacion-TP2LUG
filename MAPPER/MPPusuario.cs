using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ABS;
using BE;
using System.Data.SqlClient;
using System.Data;

namespace MAPPER
{
    public class MPPusuario:Igestor<BEusuario>
    {
        public MPPusuario()
        {
            acceso = new Acceso();
        }

        Acceso acceso;
        List<SqlParameter> parameters;

        public bool Guardar(BEusuario obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Usuario_Agregar";

            #region(DefinoParametros)
            SqlParameter param1 = new SqlParameter("@Nom", obj.nombreUsuario);
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@PW", obj.password);
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            #endregion


            return acceso.Escribir(query, parameters);
        }

        public bool VerificarExistencia(BEusuario obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Usuario_Verificar";

            SqlParameter param1 = new SqlParameter("@Nom", obj.nombreUsuario);
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@PW", obj.password);
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            return acceso.LeerScalar(query, parameters);
        }

        public bool VerificarExistenciaNombre(BEusuario obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Usuario_Verificar_NombreUsuario";

            SqlParameter param2 = new SqlParameter("@Nom", obj.nombreUsuario);
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            return acceso.LeerScalar(query, parameters);
        }

        public bool Eliminar(BEusuario obj)
        {
            throw new NotImplementedException();
        }

        public List<BEusuario> ListarObjs()
        {
            throw new NotImplementedException();
        }

        public BEusuario BuscarObj(BEusuario obj)
        {
            throw new NotImplementedException();
        }

    }
}
