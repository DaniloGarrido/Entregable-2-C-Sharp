using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Sesion
    {
        private int _codigoemp;

        public int Codemple
        {
            get { return _codigoemp; }
            set
            {
                if (value > 0)
                {
                    _codigoemp = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un codigo valido");
                }
            }

        }

        private string _usuario;

        public string Usuario
        {
            get { return _usuario; }
            set
            {
                if (value.Length > 0)
                {
                    _usuario = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        private string _contrasena;

        public string Contrasena
        {
            get { return _contrasena; }
            set
            {
                if (value.Length > 0)
                {
                    _contrasena = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        private TipoUser _tipouser;

        public TipoUser Tipouser
        {
            get { return _tipouser; }
            set { _tipouser = value; }
        }


        public Sesion()
        {
            _codigoemp = 0;
            _usuario = string.Empty;
            _contrasena = string.Empty;
            _tipouser = TipoUser.Bibliotecario;
        }
      

        public Sesion(int codigoEmple, string usuario, string contrasena, string tipousuario)
        {
            this.Codemple = codigoEmple;
            Usuario = usuario;
            Contrasena = contrasena;
            TipoUser typeuser;
            Enum.TryParse(tipousuario, out typeuser);
            this.Tipouser = typeuser;
        }

        public bool Create()
        {
            try
            {
                Datos.Sesion sesion = new Datos.Sesion()
                {
                    CodigoEmple = this.Codemple,
                    Usuario = this.Usuario,
                    contrasena = this.Contrasena,
                    Tipousuario = Tipouser.ToString()
                };
                Conexion.Bli.Sesion.Add(sesion);
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
                Datos.Sesion sesion = (from auxlogin in Conexion.Bli.Sesion
                                       where (auxlogin.Usuario == this.Usuario)
                                       select auxlogin).First();
                this.Codemple = sesion.CodigoEmple;
                this.Usuario = sesion.Usuario;
                this.Contrasena = sesion.contrasena;
                TipoUser tipoUser;
                Enum.TryParse(sesion.Tipousuario, out tipoUser);
                this.Tipouser = tipoUser;
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
                Datos.Sesion sesion = Conexion.Bli.Sesion.First(l => l.CodigoEmple == this.Codemple);

                sesion.CodigoEmple = this.Codemple;
                sesion.Usuario = this.Usuario;
                sesion.contrasena = this.Contrasena;
                sesion.Tipousuario = this.Tipouser.ToString();
                Conexion.Bli.SaveChanges();
                return true;
            }
            catch (ArgumentException zz)
            {
                return false;
            }

        }

        public bool Delete()
        {
            try
            {
                Datos.Sesion sesion = (from Auxsesion in Conexion.Bli.Sesion
                                       where Auxsesion.CodigoEmple == this.Codemple
                                       select Auxsesion).First();
                Conexion.Bli.Sesion.Remove(sesion);
                Conexion.Bli.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}