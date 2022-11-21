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
    public class MPPaguasAbiertas : Igestor<BEaguasAbiertas>
    {
        public MPPaguasAbiertas()
        {
            acceso = new Acceso();
        }

        Acceso acceso;
        List<SqlParameter> parameters;


        public bool Eliminar(BEaguasAbiertas obj)
        {
            parameters = new List<SqlParameter>();
            string query = "CompetenciaAA_Eliminar";

            SqlParameter param1 = new SqlParameter("@ID", obj.ID);
            param1.SqlDbType = SqlDbType.Int;
            parameters.Add(param1);

            return acceso.Escribir(query, parameters);
        }

        public bool Guardar(BEaguasAbiertas obj)
        {
            parameters = new List<SqlParameter>();
            string query = "CompetenciaAA_Agregar";

            #region(DefinoParametros)

            SqlParameter param1 = new SqlParameter("@Nom",obj.Nombre);
            param1.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@Desc",obj.descripcion);
            param2.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@Fecha", obj.Fecha);
            param3.SqlDbType = SqlDbType.Date;
            parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@Ubi", obj.Ubicacion);
            param4.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@Precio", obj.PrecioEntrada);
            param5.SqlDbType = SqlDbType.Int;
            parameters.Add(param5);

            SqlParameter param6 = new SqlParameter("@Premio", obj.Premio);
            param6.SqlDbType = SqlDbType.Int;
            parameters.Add(param6);

            SqlParameter param7 = new SqlParameter("@Dist", obj.Distancia);
            param7.SqlDbType = SqlDbType.VarChar;
            parameters.Add(param7);

            #endregion


            return acceso.Escribir(query, parameters);
        }
    

        public List<BEaguasAbiertas> ListarObjs()
        {
            DataTable tabla = acceso.Leer("CompetenciaAA_Listar", null);
            List<BEaguasAbiertas> ListaComp = new List<BEaguasAbiertas>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BEaguasAbiertas comp = new BEaguasAbiertas();
                    comp.ID = Convert.ToInt32(fila["ID"]);
                    comp.Nombre = fila["Nombre"].ToString();
                    comp.descripcion = fila["Descripcion"].ToString();
                    comp.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    comp.Ubicacion = fila["Ubicacion"].ToString();
                    comp.PrecioEntrada = Convert.ToInt32(fila["PrecioEntrada"]);
                    comp.Premio = Convert.ToInt32(fila["Premio"]);
                    comp.Distancia = fila["Distancia"].ToString();

                    ListaComp.Add(comp);
                }

                return ListaComp;
            }
            else
            {
                return null;
            }
        }


        /*-----------------------------------------------------------------------------------------*/
        public BEaguasAbiertas BuscarObj(BEaguasAbiertas obj)
        {
            throw new NotImplementedException();
        }

    }
}
