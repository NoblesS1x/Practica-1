using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conexion.conectar()){
                    MySqlCommand comando = new MySqlCommand("insert into Inventario values(@idinventario,@nombreCorto,@Descripcion,@serie,@color,@fechaAdquision,@tipoAdquision,@observaciones,@idAreas)");
                    comando.Parameters.AddWithValue("@idinventario",txtId.Text);
                    comando.Parameters.AddWithValue("@nombreCorto", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripccion.Text);
                    comando.Parameters.AddWithValue("@serie", txtSerie.Text);
                    comando.Parameters.AddWithValue("@color", txtColor.Text);
                    comando.Parameters.AddWithValue("@fechaAdquision", Fecha.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@tipoAdquision",Tipo.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);
                    comando.Parameters.AddWithValue("@idAreas", Area.SelectedItem.ToString());
                    comando.Connection = Conexion.conexion;
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Se inserto");
                        Conexion.desconectar();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar");
                        Conexion.desconectar();
                    }
                }
                else{MessageBox.Show("Error: No se pudo conectar al servidor");}
            }
            catch (MySqlException ex){if (ex.Number == 1064){MessageBox.Show("Error en insercion.", "Error en insercion");}}
            catch (Exception){MessageBox.Show("Error: No se pudo insertar");}
            finally{Conexion.desconectar();}
        }

        private void Fecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (Conexion.conectar())
            //{

            //    ///Se llama el producto con el comando
            //    //MySqlCommand comando = new MySqlCommand("UPDATE categorias SET Categoria=@categoria,Descripcion=@descipcion where ID=@idCategoria");
            //    MySqlCommand comando = new MySqlCommand("UPDATE Inventario SET idinventario=@idinventario,nombreCorto=@nombreCorto,Descripcion=@Descripcion,serie=@serie,@color,fechaAdquision=@fechaAdquision,tipoAdquision=@tipoAdquision,observaciones=@observaciones,idAreas=@idAreas where idinventario=@idpre");
            //    comando.Parameters.AddWithValue("@idpre", Program.selected);
            //    comando.Parameters.AddWithValue("@idinventario", txtId.Text);
            //    comando.Parameters.AddWithValue("@nombreCorto", txtNombre.Text);
            //    comando.Parameters.AddWithValue("@Descripcion", txtDescripccion.Text);
            //    comando.Parameters.AddWithValue("@serie", txtSerie.Text);
            //    comando.Parameters.AddWithValue("@color", txtColor.Text);
            //    comando.Parameters.AddWithValue("@fechaAdquision", Fecha.SelectedItem.ToString());
            //    comando.Parameters.AddWithValue("@tipoAdquision", Tipo.SelectedItem.ToString());
            //    comando.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);
            //    comando.Parameters.AddWithValue("@idAreas", Area.SelectedItem.ToString());
            //    comando.Connection = Conexion.conexion;
            //    int resultado = comando.ExecuteNonQuery();
            //    if (resultado == 1)
            //    {
            //        MessageBox.Show("Se actualizo");
            //        Conexion.desconectar();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo actualizar");
            //        Conexion.desconectar();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error: No se pudo conectar al servidor");
            //}
        }
    }
}
