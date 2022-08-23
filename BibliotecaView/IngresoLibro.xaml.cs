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
using Biblioteca.Negocios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace BibliotecaView
{
 
    public partial class IngresoLibro : MetroWindow
    {
        Manejadora Mane2 = new Manejadora();
        public IngresoLibro(Manejadora Mane)
        {
            InitializeComponent();
            Mane2 = Mane;
            cboxcate.ItemsSource = Enum.GetValues(typeof(Categoria));
            cboxgenero.ItemsSource = Enum.GetValues(typeof(Genero));

        }

        public void Limpiar()
        {
            txtcod.Text = string.Empty;
            txtnom.Text = string.Empty;
            txtcodisbn.Text = string.Empty;
            txtautor.Text = string.Empty;
            txteditorial.Text = string.Empty;
            txtfechapublic.Text = string.Empty;
            cboxcate.SelectedIndex = -1;
            cboxgenero.SelectedIndex = -1;
        }


        private void btnlimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Ingresar(object sender, RoutedEventArgs e)
        {
            Libro Libr = new Libro();
            try
            {
                int codli;
                int.TryParse(txtcod.Text, out codli);
                Libr.Codlib = codli;
                txtcod.Focus();

            }
            catch (ArgumentException zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtcod.Text = string.Empty;
                txtcod.Focus();
                return;
            }

            try
            {
                Libr.Nomlib = txtnom.Text;
            }
            catch (ArgumentException zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtnom.Text = string.Empty;
                txtnom.Focus();
                return;
            }

            try
            {
                Libr.Isbn = txtcodisbn.Text;
            }
            catch (ArgumentException zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtcodisbn.Text = string.Empty;
                txtcodisbn.Focus();
                return;
            }

            try
            {
                Libr.Autor = txtautor.Text;
            }
            catch (ArgumentException zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtautor.Text = string.Empty;
                txtautor.Focus();
                return;
            }

            try
            {
                Libr.Editorial = txteditorial.Text;
            }
            catch (ArgumentException zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txteditorial.Text = string.Empty;
                txteditorial.Focus();
                return;
            }
            try
            {
                Libr.Fechapublic = txtfechapublic.Text;
            }
            catch (ArgumentException zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtfechapublic.Text = string.Empty;
                txtfechapublic.Focus();
                return;
            }
            try
            {
                Libr.Categoria = (Categoria)cboxcate.SelectedValue;
                if (Libr.Create())
                {
                    MessageBox.Show("Categoria ingresada.");
                }
                else
                {
                    MessageBox.Show("Categoria no ha ingresada.");

                }
            }
            catch (Exception zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
               
                Limpiar();
            }

            try
            {
                Libr.Genero = (Genero)(cboxgenero.SelectedValue);
                if (Libr.Create())
                {
                    MessageBox.Show("Genero ingresado.");
                }
                else
                {
                    MessageBox.Show("Genero no ha ingresada.");

                }
            }
            catch (Exception zz)

            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                
                Limpiar();
            }

        }



        private void btnbus(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro lii = new Libro()
                {
                    Codlib = int.Parse(txtcod.Text)///viene de un text box
                };
                if (lii.Read())
                {
                    txtcod.Text = lii.Codlib.ToString();
                    txtnom.Text = lii.Nomlib;
                    txtcodisbn.Text = lii.Isbn;
                    txtautor.Text = lii.Autor;
                    txteditorial.Text = lii.Editorial;
                    txtfechapublic.Text = lii.Fechapublic;
                    cboxcate.SelectedValue = lii.Categoria;
                    cboxgenero.SelectedValue = lii.Genero;
                }
                else
                {
                    txtcod.Text = string.Empty;
                    txtnom.Text = string.Empty;
                    txtcodisbn.Text = string.Empty;
                    txtautor.Text = string.Empty;
                    txteditorial.Text = string.Empty;
                    txtfechapublic.Text = string.Empty;
                    cboxcate.SelectedValue = -1;
                    cboxgenero.SelectedValue = -1;

                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }
        }

        private void btnmodi(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro lii = new Libro()
                {
                   Codlib=int.Parse(txtcod.Text),
                    Nomlib = txtnom.Text,
                    Isbn=txtcodisbn.Text,
                    Autor=txtautor.Text,
                    Editorial=txteditorial.Text,
                    Fechapublic=txtfechapublic.Text,
   
                    Categoria = (Categoria)(cboxcate.SelectedValue),
                    Genero = (Genero)(cboxgenero.SelectedValue)

                };
                if (lii.Update())
                {
                    Limpiar();
                    MessageBox.Show("Libro modificado con exito","Modifica Datos");
                }
                else
                {
                    MessageBox.Show("El libro no ha sido modificado...", "Modifica Datos");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }
        }

        private void btnsalir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        
  

        private void btnelim (object sender, RoutedEventArgs e)
        {
            try
            {Libro Libmin = new Libro()
                {
                    Codlib = int.Parse(txtcod.Text)
                };
                if (Libmin.Delete())
                {
                    Limpiar();
                    MessageBox.Show("Libro Eliminado");
                }
                else
                {
                    txtcod.Text = "";
                    txtnom.Text = "";
                    txtcodisbn.Text = "";
                    txtautor.Text = "";
                    txteditorial.Text = "";
                    txtfechapublic.Text = "";


                    MessageBox.Show("No se pudo eliminar");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtcod.Text = "";
                txtnom.Text = "";
                txtcodisbn.Text = "";
                txtautor.Text = "";
                txteditorial.Text = "";
                txtfechapublic.Text = "";

            }
        }

    }
}

