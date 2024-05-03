using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace JyE
{
    public partial class Clientes : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD = oracle; USER ID = JyE");

        public Clientes()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_CLIENTE", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("DNI", OracleType.Number).Value = textoDni.Text;
                comando.Parameters.Add("NOMBRES", OracleType.VarChar).Value = textoNombres.Text;
                comando.Parameters.Add("APELLIDO_PATERNO", OracleType.VarChar).Value = textoApellidoPaterno.Text;
                comando.Parameters.Add("APELLIDO_MATERNO", OracleType.VarChar).Value = textoApellidoMaterno.Text;
                comando.Parameters.Add("TELEFONO", OracleType.VarChar).Value = textoTelefono.Text;
                comando.Parameters.Add("DIRECCION", OracleType.VarChar).Value = textoDireccion.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente guardado");
            }

            catch (Exception)
            {
                MessageBox.Show("Fallo al intentar guardar cliente");
            }

            conexion.Close();
            
        }

        private void botonCargar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand coman = new OracleCommand("MOSTRAR_CLIENTE", conexion);
            coman.CommandType = System.Data.CommandType.StoredProcedure;
            coman.Parameters.Add("REGISTROS",OracleType.Cursor).Direction=ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = coman;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes.DataSource = tabla;

            conexion.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("ACTUALIZAR_CLIENTE", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CLIENTE", OracleType.Number).Value = Convert.ToInt32(textoCodigo.Text);
            comando.Parameters.Add("DNI", OracleType.Number).Value = Convert.ToInt32(textoDni.Text);
            comando.Parameters.Add("NOMBRES", OracleType.VarChar).Value = textoNombres.Text;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.VarChar).Value = textoApellidoPaterno.Text;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.VarChar).Value = textoApellidoMaterno.Text;
            comando.Parameters.Add("TELEFONO", OracleType.VarChar).Value = textoTelefono.Text;
            comando.Parameters.Add("DIRECCION", OracleType.VarChar).Value = textoDireccion.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Actualizado");
            conexion.Close();
        }

        private void textoTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("ELIMINAR_CLIENTE", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CLIENTE", OracleType.Number).Value = Convert.ToInt32(textoCodigo.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("El Cliente ha sido Eliminado");
            conexion.Close();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
