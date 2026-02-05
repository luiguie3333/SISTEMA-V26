using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SISTEMA_V26.CONEXION_A_BASE
{
    internal class ConexionBD
    {
        private string servidor = "localhost";
        private string puerto = "3306";
        private string database = "sistema_luis3;";
        private string usuario = "root";
        private string password = "root";  

        private string CadenaConexion()
        {
            return $"server={servidor}; port={puerto}; database={database}; uid={usuario}; pwd={password};";
        }

        public bool ProbarConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(CadenaConexion());
                conexion.Open();
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                
                MessageBox.Show("Error detallado: " + ex.Message + "\n\nCódigo: " + ex.Number,
                    "Error MySQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}