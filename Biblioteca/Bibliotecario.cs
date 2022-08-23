using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Bibliotecario
    {
        private int _codBib;

        public int CodBib
        {
            get { return _codBib; }
            set
            {
                if (value > 0)
                {
                    _codBib = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un ID de bibliotecario correcto");
                }
            }
        }

        private string _nomBib;

        public string NomBib
        {
            get { return _nomBib; }
            set
            {
                if (value.Length > 0)
                {
                    _nomBib = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        private string _apeBib;
        private string usuario;

        public string ApeBib
        {
            get { return _apeBib; }
            set
            {
                if (value.Length > 0)
                {
                    _apeBib = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        public Bibliotecario()
        {
            _codBib = 0;
            _nomBib = string.Empty;
            _apeBib = string.Empty;
        }

        public Bibliotecario(int codBib, string nomBib, string apeBib)
        {
            this.CodBib = codBib;
            this.NomBib = nomBib;
            this.ApeBib = apeBib;
        }

        public Bibliotecario(string usuario)
        {
            this.usuario = usuario;
        }

        public bool Create()
        {
            try
            {
                Datos.Bibliotecario bib = new Datos.Bibliotecario()
                {
                    CodBib = this.CodBib,
                    NomBib = this.NomBib,
                    ApeBib = this.ApeBib,
                };
                Conexion.Bli.Bibliotecario.Add(bib);
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
                Datos.Bibliotecario bib = (from Auxbib in Conexion.Bli.Bibliotecario
                                           where Auxbib.CodBib == this.CodBib
                                           select Auxbib).First();
                this.CodBib = bib.CodBib;
                this.NomBib = bib.NomBib;
                this.ApeBib = bib.ApeBib;
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
                Datos.Bibliotecario bib = Conexion.Bli.Bibliotecario.First(l => l.CodBib == this.CodBib);
                bib.CodBib = this.CodBib;
                bib.NomBib = this.NomBib;
                bib.ApeBib = this.ApeBib;
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
                Datos.Bibliotecario bib = (from Auxbib in Conexion.Bli.Bibliotecario
                                           where Auxbib.CodBib == this.CodBib
                                           select Auxbib).First();
                Conexion.Bli.Bibliotecario.Remove(bib);
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
