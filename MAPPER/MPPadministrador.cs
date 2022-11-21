using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using ABS;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace MAPPER
{
    public class MPPadministrador : Igestor<BEadminstrador>
    {
        public MPPadministrador()
        {
            acceso = new Acceso();
        }

        Acceso acceso;
        List<SqlParameter> parameters;

        public BEadminstrador BuscarObj(BEadminstrador obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEadminstrador obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEadminstrador obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Administrador_Agregar";

            #region(DefinoParametros)
            SqlParameter param1 = new SqlParameter("@Nom", obj.nombre);
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@Ape", obj.apellido);
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@Dni", obj.dni);
            param3.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@Tel", obj.telefono);
            param4.SqlDbType = SqlDbType.Int;
            parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@PW", obj.password);
            param5.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param5);

            #endregion


            return acceso.Escribir(query, parameters);
        }

        public List<BEadminstrador> ListarObjs()
        {
            throw new NotImplementedException();
        }
    }
}
