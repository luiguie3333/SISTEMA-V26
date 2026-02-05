using MySql.Data.MySqlClient;
using SISTEMA_V26.CONEXION_A_BASE;
using SISTEMA_V26.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_V26
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }


        private void btnProbarConexion_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("El botón funciona!"); // LÍNEA DE PRUEBA

            ConexionBD bd = new ConexionBD();
            if (bd.ProbarConexion())
            {
                MessageBox.Show("✓ Conexión exitosa a la base de datos 'sistema_ventas'",
                    "Conexión Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("✗ No se pudo conectar a la base de datos.\n\nVerifica que:\n" +
                    "- MySQL esté ejecutándose\n" +
                    "- La base de datos 'sistema_ventas' exista\n" +
                    "- Las credenciales sean correctas",
                    "Error de Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TXTUsuario.Text) || string.IsNullOrWhiteSpace(TXTContrasena.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña", "Campos vacíos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                string connectionString = "Server=localhost;Database=sistema_luis3;Uid=root;Pwd=root;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = @"SELECT u.id_usuario, u.nombre, r.nombre as rol, r.nivel_acceso 
                           FROM usuarios u 
                           INNER JOIN roles r ON u.id_rol = r.id_rol 
                           WHERE u.nombre = @usuario 
                           AND u.contrasena = @contrasena 
                           AND u.estado = 'activo'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", TXTUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@contrasena", TXTContrasena.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                string nombreUsuario = reader["nombre"].ToString();
                                string rol = reader["rol"].ToString();
                                int nivelAcceso = Convert.ToInt32(reader["nivel_acceso"]);
                                int idUsuario = Convert.ToInt32(reader["id_usuario"]);

                                reader.Close();

                                
                                string updateQuery = "UPDATE usuarios SET ultimo_login = NOW() WHERE id_usuario = @id";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@id", idUsuario);
                                    updateCmd.ExecuteNonQuery();
                                }

                                
                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                               
                                MessageBox.Show("Usuario o contraseña incorrectos",
                                              "Error de acceso",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                                TXTContrasena.Clear();
                                TXTUsuario.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Utilidades.SalirAplicacion();
        }
    }
}
