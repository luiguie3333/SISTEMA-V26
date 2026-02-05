using System;
using System.Windows.Forms;

namespace SISTEMA_V26
{
    public static class Utilidades
    {
        
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

       
        public static void SalirSinConfirmar()
        {
            Application.Exit();
        }

        
        public static void VolverAlLogin(Form formularioActual)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "Login")
                    {
                        form.Show();
                        formularioActual.Close();
                        return;
                    }
                }

                
                Login loginForm = new Login();
                loginForm.Show();
                formularioActual.Close();
            }
        }

        public static void ConfigurarCierreSecundario(Form formSecundario, Type tipoFormPrincipal)
        {
            formSecundario.FormClosing += (sender, e) =>
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == tipoFormPrincipal)
                    {
                        form.Show();
                        break;
                    }
                }
            };
        }

        
        public static void ConfigurarCierrePrincipal(Form formPrincipal)
        {
            formPrincipal.FormClosing += (sender, e) =>
            {
                Application.Exit();
            };
        }
    }

}
