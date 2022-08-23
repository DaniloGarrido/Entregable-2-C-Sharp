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
    /// Lógica de interacción para Bibliotecarioview.xaml
    /// </summary>
    public partial class Bibliotecarioview : MetroWindow
    {
        Biblioteca.Negocios.Manejadora Mane = new Manejadora();
        public Bibliotecarioview(string usuario)
        {
            InitializeComponent();
            cboxcate.ItemsSource = Enum.GetValues(typeof(Categoria));
            cboxgenero.ItemsSource = Enum.GetValues(typeof(Genero));
        }
        private void btnlib(object sender, RoutedEventArgs e)
        {

            IngresoLibro viewingresolib = new IngresoLibro(Mane);
            viewingresolib.Show();
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

            private void Btnflyout(object sender, RoutedEventArgs e)
            {
                flyoutingreso.IsOpen = true;
            }

            private async void Ingresar(object sender, RoutedEventArgs e)
            {
                Biblioteca.Negocios.Libro Libr = new Biblioteca.Negocios.Libro();
                try
                {
                    int codli;
                    int.TryParse(txtcod.Text, out codli);
                    Libr.Codlib = codli;
                    txtcod.Focus();

                }
                catch (ArgumentException zz)
                {
                    await this.ShowMessageAsync("Error!", string.Format(" Ingrese un codigo valido' "));
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
                    await this.ShowMessageAsync("Error!", string.Format(" Ingrese un nombre valido "));
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
                    await this.ShowMessageAsync("Error!", string.Format(" Ingrese un codigo ISBN valido' "));
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
                    await this.ShowMessageAsync("Error!", string.Format(" Ingrese un nombre de autor valido"));
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
                    await this.ShowMessageAsync("Error!", string.Format(" Ingrese un nombre de editorial valido "));
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
                    await this.ShowMessageAsync("Error!", string.Format(" Ingrese una fecha de publicacion valida "));
                    txtfechapublic.Text = string.Empty;
                    txtfechapublic.Focus();
                    return;
                }
                Libr.Categoria = (Categoria)cboxcate.SelectedValue;

                 Libr.Genero = (Genero)(cboxgenero.SelectedValue);
            if (Libr.Create())
                {

                await this.ShowMessageAsync("Confirmado", string.Format("Libro ingresado correctamente"));
                Libr.Create();

                }
                else
            {
                await this.ShowMessageAsync("Error!", string.Format("No se ha ingresado el libro"));

                Limpiar();

            }
                
                   
               
                   
               
               
            }

            private async void btnbuscar(object sender, RoutedEventArgs e)
            {
                try
                {
                    Libro lii = new Libro()
                    {
                        Codlib = int.Parse(txtbuscar.Text)///viene de un text box
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
                    await this.ShowMessageAsync("Algo ha ocurrido...", string.Format("La busqueda no ha arrojado ningun resultado"));
                    Limpiar();
                }


            }
            
        

            private async void btnmodi(object sender, RoutedEventArgs e)
            {
                try
                {
                    Libro lii = new Libro()
                    {
                        Codlib = int.Parse(txtcodmodi.Text),
                        Nomlib = txtnommodi.Text,
                        Isbn = txtcodisbnmodi.Text,
                        Autor = txtautormodi.Text,
                        Editorial = txteditorialmodi.Text,
                        Fechapublic = txtfechapublicmodi.Text,

                        Categoria = (Categoria)(cboxcatemodi.SelectedValue),
                        Genero = (Genero)(cboxgeneromodi.SelectedValue)

                    };
                    if (lii.Update())
                    {
                        Limpiar();
                        await this.ShowMessageAsync("Exito", string.Format("El libro ha sido modificado con exito"));
                    }
                    else
                    {
                        await this.ShowMessageAsync("Algo ha ocurrido...", string.Format("El libro no se ha modificado"));
                    }

                }
                catch (Exception zz)
                {
                    await this.ShowMessageAsync("Algo ha ocurrido...", string.Format("Rellene los campos correctamente",string.Format("he intente de nuevo")));
                    Limpiar();
                }

            }

            private void btndgrid(object sender, RoutedEventArgs e)
            {
                dgridver.ItemsSource = (from en in Mane.ListarLibs()
                                        select new
                                        {
                                            Codigo_Libro = -en.Codlib,
                                            Nombre_Libro = en.Nomlib,
                                            Codigo_ISBN = en.Isbn,
                                            en.Autor,
                                            en.Editorial,
                                            Ano = en.Fechapublic,
                                            en.Categoria,
                                            en.Genero
                                        }
                                         )
                                         .ToList();


            }

        private void btnlogout(object sender, RoutedEventArgs e)
        {
            LogIn login = new LogIn();
            this.Close();
            login.Show() ;
        }

      
        }
    }




