using SISTEMA_V26.CONEXION_A_BASE;
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
    }
}
