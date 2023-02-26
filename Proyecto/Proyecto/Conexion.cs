using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Proyecto;
using System.Drawing;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        //public static MySqlTransaction transaccion;
        static string usuario = "DBAdmin";
        static string password = "MaAR_0*YU";//Qwerty123!
        static string bd = "inventario";//practica1
        static string servidor = "102.37.157.182";
        static string puerto = "3306";

        /// <summary>
        /// Realizar conexión a base de datos local
        /// </summary>
        /// <returns>true: se conecto sin problemas, false: no se pudo conectar</returns>
        public static bool conectar()
        {
            try
            {
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor +
                    ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Terminar la conexión estblecida
        /// </summary>
        public static void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            { }
        }

        public static List<Inventario> obtenerInventario()
        {
            try
            {
                if (Conexion.conectar())
                {
                    ///Se llama el producto con el comando
                    MySqlCommand comando = new MySqlCommand("select * from Inventario");
                    //comando.Parameters.AddWithValue("@Delete", "ELIMINADO");
                    ///Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;
                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Inventario> lista = new List<Inventario>();
                    Inventario objCategoria = null;
                    ///Cuando la consulta si obtuvo resultados la tabla trae filas
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCategoria = new Inventario()
                        {
                            //this.idinventario = idinventario;
                            //this.nombreCorto = nombreCorto;
                            //this.Descripcion = descripcion;
                            //this.serie = serie;
                            //this.color = color;
                            //this.fechaAdquision = fechaAdquision;
                            //this.tipoAdquision = tipoAdquision;
                            //this.observaciones = observaciones;
                            //this.idAreas = idAreas;
                            idinventario = Convert.ToInt32(fila["idinventario"]),
                            nombreCorto = fila["nombreCorto"].ToString(),
                            Descripcion = fila["Descripcion"].ToString(),
                            serie = fila["serie"].ToString(),
                            color = fila["color"].ToString(),
                            fechaAdquision = fila["fechaAdquision"].ToString(),
                            tipoAdquision = fila["tipoAdquision"].ToString(),
                            observaciones = fila["observaciones"].ToString(),
                            idAreas = Convert.ToInt32(fila["idAreas"])

                        };
                        lista.Add(objCategoria);
                    }
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }

            }
            catch (Exception)
            {
                throw new Exception("No se puedo obtener la informacion de la categoria");
    }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
