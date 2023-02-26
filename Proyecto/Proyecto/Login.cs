using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)

        {
           
            if (Conexion.conectar())
            {
             Form2 form2 = new Form2();
                form2.Show();
            }
           
            
        }
    }

//     try
//            {
//                if (Conexion.conectar())
//                {
//                    ///Se llama el producto con el comando
//                    MySqlCommand comando = new MySqlCommand("update ventas SET Estado=@Delete where ID=@ID");
//    comando.Parameters.AddWithValue("@Delete", "Cancelada");
//                    comando.Parameters.AddWithValue("@ID", eliminar);
//                    comando.Connection = Conexion.conexion;
//                    resultado = comando.ExecuteNonQuery();
//                    if (resultado == 1)
//                    {
//                        MessageBox.Show("Se elimino la venta");
//                        Conexion.desconectar();
//                    }
//                    else
//{
//    MessageBox.Show("No se pudo eliminar la venta");
//    Conexion.desconectar();
//}
//                }
//                else
//{
//    MessageBox.Show("Error: No se pudo conectar al servidor");
//}
//            }
//            catch (MySqlException ex)
//{
//    if (ex.Number == 1064)
//    {
//        MessageBox.Show("Error en eliminación.", "Error en eliminación");
//    }
//}
//catch (Exception)
//{
//    MessageBox.Show("Error: No se pudo eliminar la venta");
//}
//finally
//{
//    Conexion.desconectar();
//}
}
