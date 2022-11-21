using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using ABS;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace MAPPER
{
    public class MPPnadador : Igestor<BEnadador>
    {
        Acceso acceso;
        List<SqlParameter> parameters;

        public List<BEnadador> ListarXCategoria(string categoria)
        {
            acceso = new Acceso();
            parameters = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@Cat", categoria);
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            DataTable tabla = acceso.Leer("Nadador_Listar_Categoria", parameters);

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
                    //nad.tiempo = Convert.ToDouble(fila["Tiempos"]);
                    //nad.categoria = fila["Categoria"].ToString();

                    ListaNadadores.Add(nad);
                }

                return ListaNadadores;
            }
            else
            {
                return null;
            }
        }

        public bool Eliminar(BEnadador obj)
        {
            parameters = new List<SqlParameter>();
            string query = "Nadador_Eliminar";

            SqlParameter param1 = new SqlParameter("@ID", obj.ID);
            param1.SqlDbType = SqlDbType.Int;
            parameters.Add(param1);

            return acceso.Escribir(query, parameters);
        }

        public bool GuardarAA(BEnadador obj, int idcomp)
        {
            acceso = new Acceso();
            parameters = new List<SqlParameter>();
            string query = "Nadador_Agregar_Competencia";

            if (obj.ID != 0)
            {
                SqlParameter paramE = new SqlParameter();
                paramE.ParameterName = "@ID";
                paramE.Value = obj.ID;
                paramE.SqlDbType = SqlDbType.VarChar;
                parameters.Add(paramE);
                query = "Nadador_Modificar";
            }

            #region(DefinoParametros)
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Nombre";
            param1.Value = obj.nombre;
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Apellido";
            param2.Value = obj.apellido;
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            SqlParameter param6 = new SqlParameter();
            param6.ParameterName = "@DNI";
            param6.Value = obj.dni;
            param6.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param6);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@Telefono";
            param3.Value = obj.telefono;
            param3.SqlDbType = SqlDbType.Int;
            parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@EDAD";
            param4.Value = obj.edad;
            param4.SqlDbType = SqlDbType.Int;
            parameters.Add(param4);

            SqlParameter param5 = new SqlParameter();
            param5.ParameterName = "@CATEGORIA";
            param5.Value = obj.categoria;
            param5.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param5);

            SqlParameter param7 = new SqlParameter();
            param7.ParameterName = "IDcomp";
            param7.Value = idcomp;
            param7.SqlDbType = SqlDbType.Int;
            parameters.Add(param7);

            #endregion

            if (ExistenciaNadadorXDNI(obj) == false)
            { return acceso.Escribir(query, parameters); }
            else
            { return false; }
        
        }

        public bool GuardarEquip(BEnadador obj, int idEquip)
        {
            acceso = new Acceso();
            parameters = new List<SqlParameter>();
            string query = "Nadador_Agregar_Equipo";


            #region(DefinoParametros)
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Nombre";
            param1.Value = obj.nombre;
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Apellido";
            param2.Value = obj.apellido;
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            SqlParameter param6 = new SqlParameter();
            param6.ParameterName = "@DNI";
            param6.Value = obj.dni;
            param6.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param6);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@Telefono";
            param3.Value = obj.telefono;
            param3.SqlDbType = SqlDbType.Int;
            parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@EDAD";
            param4.Value = obj.edad;
            param4.SqlDbType = SqlDbType.Int;
            parameters.Add(param4);

            SqlParameter param5 = new SqlParameter();
            param5.ParameterName = "@CATEGORIA";
            param5.Value = obj.categoria;
            param5.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param5);

            SqlParameter param7 = new SqlParameter();
            param7.ParameterName = "IDequip";
            param7.Value = idEquip;
            param7.SqlDbType = SqlDbType.Int;
            parameters.Add(param7);

            #endregion
            if (obj.ID != 0)
            {
                SqlParameter paramE = new SqlParameter();
                paramE.ParameterName = "@ID";
                paramE.Value = obj.ID;
                paramE.SqlDbType = SqlDbType.VarChar;
                parameters.Add(paramE);
                query = "Nadador_Modificar";

                return acceso.Escribir(query, parameters);
            }
            else
            {
                if (ExistenciaNadadorXDNI(obj) == false)
                { return acceso.Escribir(query, parameters); }
                else
                { return false; }
            }
            

        }

        bool ExistenciaNadadorXDNI(BEnadador obj)
        {
            List<SqlParameter> parametersList = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter();

            if (obj.ID == 0)
            {
                param1.ParameterName = "@Dni";
                param1.Value = obj.dni;
                param1.SqlDbType = SqlDbType.VarChar;
                parametersList.Add(param1);

                return acceso.LeerScalar("Nadador_Verificar_Dni", parametersList);
            }
            else
            {
                return false;
            }

        }


        /*--------------------------------------------------------------------------------------------------*/

        public bool Guardar(BEnadador obj) 
        {
            throw new NotImplementedException();
        }
        public List<BEnadador> ListarObjs()
        {
            acceso = new Acceso();
            parameters = new List<SqlParameter>();

            DataTable tabla = acceso.Leer("Nadador_traerTodo", parameters);

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
                    //nad.tiempo = Convert.ToDouble(fila["Tiempos"]);
                    //nad.categoria = fila["Categoria"].ToString();

                    ListaNadadores.Add(nad);
                }

                return ListaNadadores;
            }
            else
            {
                return null;
            }
        }
        public BEnadador BuscarObj(BEnadador obj)
        {
            throw new NotImplementedException();
        }



    }
}
