using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections; //para el arraylist

namespace DAL
{
    public class Acceso
    {
        string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CompetenciaNatTP;Integrated Security=True";
        private SqlConnection conex = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CompetenciaNatTP;Integrated Security=True");
        private SqlTransaction tranx;
        private SqlCommand command;

        public DataTable Leer (string query, List<SqlParameter> parameters)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter;

            command = new SqlCommand(query, conex);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                adapter = new SqlDataAdapter(command);

                if (parameters != null)
                {
                    foreach (SqlParameter dato in parameters)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }
            }
            catch (SqlException ex)
            {throw ex;}
            catch (Exception ex)
            { throw ex; }

            adapter.Fill(table);
            return table;
        }

        public bool LeerScalar(string query, List<SqlParameter> parameters)
        {
            conex.Open();
            command = new SqlCommand(query, conex);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter dato in parameters)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = Convert.ToInt32(command.ExecuteScalar());
                conex.Close();
                if (respuesta >0)
                {
                    return true; // Se encontraron objetos iguales
                }
                else
                {
                    return false; // no hay objetos similares
                }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

        }

        public bool Escribir(string query, List<SqlParameter> parameters)
        {
            if (conex.State == ConnectionState.Closed)
            {
                conex.ConnectionString = connectString;
                conex.Open();
            }

            try
            {
                tranx = conex.BeginTransaction();
                command = new SqlCommand(query, conex, tranx);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (SqlParameter dato in parameters)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = command.ExecuteNonQuery();
                tranx.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                tranx.Rollback();
                throw ex;
            }
            catch (Exception ex)
            { throw ex; }
            finally 
            { conex.Close(); }
        }
    }
}
