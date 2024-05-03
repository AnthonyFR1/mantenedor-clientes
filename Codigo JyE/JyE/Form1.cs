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
    public partial class Form1 : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = 123; USER ID = ABC");
        public Form1()
        {
            InitializeComponent();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE NOMBRE_USUARIO = :usuario and CONTRASEÑA = :contra", conexion);

            comando.Parameters.AddWithValue(":usuario", textoUsuario.Text);
            comando.Parameters.AddWithValue(":contra", textoContraseña.Text);

            OracleDataReader lector = comando.ExecuteReader();

            if(lector.Read())
            {
                Clientes formulario = new Clientes();
                conexion.Close();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario Erroneo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
