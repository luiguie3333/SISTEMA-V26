using System;
using System.Windows.Forms;

namespace SISTEMA_V26
{
    public static class Utilidades
    {
        // Método para salir de la aplicación
        public static void SalirAplicacion()
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Método para salir sin confirmación
        public static void SalirSinConfirmar()
        {
            Application.Exit();
        }

        // Método para volver al login
        public static void VolverAlLogin(Form formularioActual)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Buscar el formulario de login
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "Login")
                    {
                        form.Show();
                        formularioActual.Close();
                        return;
                    }
                }

                // Si no encuentra el login, crea uno nuevo
                Login loginForm = new Login();
                loginForm.Show();
                formularioActual.Close();
            }
        }
    }
}