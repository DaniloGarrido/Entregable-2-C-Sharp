using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;


namespace Biblioteca.Negocios
{
    public class Libro
    {
        private int _codLib;

        public int Codlib
        {
            get { return _codLib; }
            set
            {
                if (value > 0)
                {
                    _codLib = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un ID");
                }
            }
        }
        private string _nomLib;

        public string Nomlib
        {
            get { return _nomLib; }
            set
            {
                if (value.Length > 0)
                {
                    _nomLib = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        private string _isbn;

        public string Isbn
        {
            get { return _isbn; }
            set
            {
                if (value.Length > 0 || value.Length < 13)
                {
                    _isbn = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un codigo ISBN correcto con un limite de 13 Digitos");
                }
            }
        }

        private string _autor;

        public string Autor
        {
            get { return _autor; }
            set
            {
                if (value.Length > 0)
                {
                    _autor = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un nombre");
                }
            }
        }
        private string _editorial;

        public string Editorial
        {
            get { return _editorial; }
            set
            {
                if (value.Length > 0)
                {
                    _editorial = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un nombre de editorial correcto ");
                }
            }
        }

        private string _fechaPublic;

        public string Fechapublic
        {
            get { return _fechaPublic; }
            set
            {
                if (value.Length > 0)
                {
                    _fechaPublic = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un ID");
                }
            }
        }

        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private Genero _genero;

        public Genero Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public Libro()
        {
            _codLib = 0;
            _nomLib = string.Empty;
            _isbn = string.Empty;
            _autor = string.Empty;
            _editorial = string.Empty;
            _fechaPublic = string.Empty;
            _editorial = string.Empty;
            _categoria = Categoria.Comic;
            _genero = Genero.Medieval;
        }
        public Libro(int codlib, string nomli, string isbn, string autor, string edit, string fecapubli, string catego, string gene)
        {
            this.Codlib = codlib;
            this.Nomlib = nomli;
            this.Isbn = isbn;
            this.Autor = autor;
            this.Fechapublic = fecapubli;
            this.Editorial = edit;
            Categoria caenum;
            Enum.TryParse(catego, out caenum);
            Genero geenum;
            Enum.TryParse(gene, out geenum);
            this.Categoria = caenum;
            this.Genero = geenum;

        }



        public bool Create()
        {
            try
            {
                Datos.Libro liib = new Datos.Libro()
                {
                    CodLib = this.Codlib,
                    NombreLib = this.Nomlib,
                    CodISBN = this.Isbn,
                    Autor = this.Autor,
                    Fechapublic = this.Fechapublic,
                    Editorial = this.Editorial,
                    Categoria = Categoria.ToString(),
                    Genero = Genero.ToString()

                };
                Conexion.Bli.Libro.Add(liib);
                Conexion.Bli.SaveChanges();
                return true;
            }
            catch
            {
                

                return false;

            }

        }
        public bool Read()
        {
            try
            {
                Datos.Libro lii = (from Auxlib in Conexion.Bli.Libro
                                   where Auxlib.CodLib == this.Codlib
                                   select Auxlib).First();
                this.Codlib = lii.CodLib;
                this.Nomlib = lii.NombreLib;
                this.Isbn = lii.CodISBN;
                this.Autor = lii.Autor;
                this.Fechapublic = lii.Fechapublic;
                this.Editorial = lii.Editorial;
                Categoria ca;
                Enum.TryParse(lii.Categoria, out ca);
                this.Categoria = ca;
                Genero ge;
                Enum.TryParse(lii.Genero, out ge);
                this.Genero = ge;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Datos.Libro lii = Conexion.Bli.Libro.First(l => l.CodLib == this.Codlib);
                lii.CodLib = this.Codlib;
                lii.NombreLib = this.Nomlib;
                lii.CodISBN = this.Isbn;
                lii.Autor = this.Autor;
                lii.Fechapublic = this.Fechapublic;
                lii.Editorial = this.Editorial;
                lii.Categoria = this.Categoria.ToString();
                lii.Genero = this.Genero.ToString();
                Conexion.Bli.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Delete()
        {
            try
            {
                Datos.Libro lii = (from Auxlib in Conexion.Bli.Libro
                                   where Auxlib.CodLib == this.Codlib
                                   select Auxlib).First();
                Conexion.Bli.Libro.Remove(lii);
                Conexion.Bli.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }


    }









}



