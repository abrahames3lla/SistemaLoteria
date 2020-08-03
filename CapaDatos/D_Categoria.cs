using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Categoria
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Categoria> listarCategoria(string buscar){

            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_Buscar_Categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR",buscar);

            leerFilas = cmd.ExecuteReader();

            List<E_Categoria> listar = new List<E_Categoria>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Categoria{
                    IdCategoria = leerFilas.GetInt32(0),
                    CodigoCategoria = leerFilas.GetString(1),
                    NombreCategoria = leerFilas.GetString(2),
                    DescripcionCategoria = leerFilas.GetString(3)


                });
            }

            conexion.Close();
            leerFilas.Close();

            return listar;
        }

    }
}
