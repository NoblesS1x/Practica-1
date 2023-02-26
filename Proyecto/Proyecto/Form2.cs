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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DGVInventario.DataSource = null;
            DGVInventario.DataSource = Conexion.obtenerInventario();
            foreach (DataGridViewColumn columna in DGVInventario.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Conexion.conectar())
            {
                ///Se llama el producto con el comando
                MySqlCommand comando = new MySqlCommand("DELETE FROM Inventario where idinventario=@idinventario");
                //Console.WriteLine(DGVInventario.Rows[DGVInventario.CurrentRow.Index].Cells[0].Value.ToString());
                comando.Parameters.AddWithValue("@idinventario", DGVInventario.Rows[DGVInventario.CurrentRow.Index].Cells[0].Value.ToString());
                comando.Connection = Conexion.conexion;
                int resultado = comando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    MessageBox.Show("Se elimino el Registro");
                    Conexion.desconectar();
                }
                else
                {
                    MessageBox.Show("No se elimino el Registro");
                    Conexion.desconectar();
                }
            }
            else
            {
                MessageBox.Show("Error: No se pudo conectar al servidor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.selected = DGVInventario.Rows[DGVInventario.CurrentRow.Index].Cells[0].Value.ToString();
            Form1 form = new Form1();
            form.Show();
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            DGVInventario.DataSource = null;
            DGVInventario.DataSource = Conexion.obtenerInventario();
            foreach (DataGridViewColumn columna in DGVInventario.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
