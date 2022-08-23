using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Biblioteca.Negocios;

namespace BibliotecaView
{
    /// <summary>
    /// Lógica de interacción para Admin.xaml
    /// </summary>
    public partial class Admin : MetroWindow
    {
        Manejadora Mane = new Manejadora();

        public Admin(string usuario)
        {
            InitializeComponent();
            cboxtipouser.ItemsSource = Enum.GetValues(typeof(TipoUser));
            cboxcatemodiuser.ItemsSource = Enum.GetValues(typeof(TipoUser));
        }

        private void Btnflyout(object sender, RoutedEventArgs e)
        {
            flyoutingreso.IsOpen = true;
        }
        private void btndgridusuario(object sender, RoutedEventArgs e)
        {
            dgridveruser.ItemsSource = Mane.Listarsesion();
            dgridveruser.Items.Refresh();


        }
 
        public void Limpiar()
        {
            txtcoduser.Text = string.Empty;
            txtnomuser.Text = string.Empty;
            txtcontrasenauser.Text = string.Empty;
            cboxtipouser.SelectedIndex = 1;
        }

        private async void Ingresaruser(object sender, RoutedEventArgs e)
        {
            Biblioteca.Negocios.Sesion sesion = new Biblioteca.Negocios.Sesion();
            Biblioteca.Negocios.Sesion sesione = new Biblioteca.Negocios.Sesion();
            try
            {
                int Codemple;
                int.TryParse(txtcoduser.Text, out Codemple);
                sesion.Codemple = Codemple;
                txtcoduser.Focus();

            }
            catch (ArgumentException zz)
            {
                await this.ShowMessageAsync("Error!", string.Format(" Ingrese un codigo de usuario valido' "));
                txtcoduser.Text = string.Empty;
                txtcoduser.Focus();
                return;
            }

            try
            {
                sesion.Usuario = txtnomuser.Text;
            }
            catch (ArgumentException zz)

            {
                await this.ShowMessageAsync("Error!", string.Format(" Ingrese un nombre de usuario valido "));
                txtnomuser.Text = string.Empty;
                txtnomuser.Focus();
                return;
            }

            try
            {
                sesion.Contrasena = txtcontrasenauser.Text;
            }
            catch (ArgumentException zz)

            {
                await this.ShowMessageAsync("Error!", string.Format(" Ingrese una contraseña valida' "));
                txtcontrasenauser.Text = string.Empty;
                txtcontrasenauser.Focus();
                return;
            }


            sesion.Tipouser = TipoUser.Administrador;
            if(sesion.Create())
            {
                sesion.Create();
                 await this.ShowMessageAsync("Confirmado", string.Format("Tipo de usuario agregado correctamente"));
            }
            else
            {
                await this.ShowMessageAsync("Error!", string.Format("No se creo el usuario."));
                

                Limpiar();
            }

        }
        private void btnlogoutadmin(object sender, RoutedEventArgs e)
        {
            LogIn login = new LogIn();
            this.Close();
            login.Show();
        }
        private async void btnmodiuser(object sender, RoutedEventArgs e)
        {
            try
            {
                Sesion sesion = new Sesion()
                {
                    Codemple = int.Parse(txtcodmodiuser.Text),
                    Usuario = txtnommodiuser.Text,
                    Contrasena = txtcontrasenauser.Text,
                    Tipouser = (TipoUser)(cboxcatemodiuser.SelectedValue)
                };
                if (sesion.Update())
                {
                    Limpiar();
                    await this.ShowMessageAsync("Error!", string.Format("No se ha modificado el libro."));
                }
                else
                {
                    await this.ShowMessageAsync("Error!", string.Format("No se ha modificado el libro."));
                }

            }
            catch (Exception zz)
            {
                await this.ShowMessageAsync("Error!", string.Format("No se creo el usuario rellene los campos correctamente."));
                Limpiar();
            }
        }

        private void btnsalir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}
