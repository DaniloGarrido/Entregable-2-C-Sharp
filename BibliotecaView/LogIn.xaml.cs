using System;
using System.Windows;
using Biblioteca.Negocios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;



namespace BibliotecaView
{
    /// <summary>
    /// Lógica de interacción para LogIn.xaml
    /// </summary>
    public partial class LogIn : MetroWindow
    {
        public LogIn()
        {
            InitializeComponent();
            txtusuario.Text = string.Empty;
            pswcontrasena.Password = string.Empty;
            txtusuario.Focus();
        }

        private async void btniniciarsesion(object sender, RoutedEventArgs e)
        {
            Sesion sesion= new Sesion();
            try
            {
                sesion.Usuario = txtusuario.Text;
            }
            catch (ArgumentException zz)
            {
                await this.ShowMessageAsync("Error!", string.Format(" Ingrese un nombre de 'Usuario' "));
                txtusuario.Text = string.Empty;
                txtusuario.Focus();
                return;
            }

            try
            {
                sesion.Contrasena = pswcontrasena.Password;
            }
            catch (ArgumentException zz)
            {
                await this.ShowMessageAsync("Error!", string.Format(" Ingrese una 'Contrasena'"));
                pswcontrasena.Password = string.Empty;
                pswcontrasena.Focus();
                return;

            }

             if (sesion.Read())
             {
                if(sesion.Tipouser.ToString()=="Administrador")
                {
                    await this.ShowMessageAsync("Bienvenido otra vez",string.Format("Administrador {0}",sesion.Usuario));
                    this.Hide();
                    Admin admin = new Admin (sesion.Usuario);
                    admin.Show();

                }
                else if (sesion.Tipouser.ToString()=="Bibliotecario")
                {
                    await this.ShowMessageAsync("Bienvenido otra vez", string.Format("Bibliotecario {0}", sesion.Usuario));
                    this.Hide();
                    Bibliotecarioview bib = new Bibliotecarioview(sesion.Usuario);
                    bib.Show();
                }

             }
             else
            {
                await this.ShowMessageAsync("Error!", string.Format("Usuario o contrasena incorrecto"));
                txtusuario.Text = string.Empty;
                pswcontrasena.Password = string.Empty;
                txtusuario.Focus();
            }

                


        }

    }
}
