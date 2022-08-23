using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Administrador
    {
        private int _codAdmin;

        public int CodAdmin
        {
            get { return _codAdmin; }
            set
            {
                if (value > 0)
                {
                    _codAdmin = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un codigo valido");
                }
            }

        }

        private string _nomAdmin;

        public string NomAdmin
        {
            get { return _nomAdmin; }
            set
            {
                if (value.Length > 0)
                {
                    _nomAdmin = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        private string _apeAdmin;

        public string ApeAdmin
        {
            get { return _apeAdmin; }
            set
            {
                if (value.Length > 0)
                {
                    _apeAdmin = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        public Administrador()
        {
            _codAdmin = 0;
            _nomAdmin = string.Empty;
            _apeAdmin = string.Empty;
        }

        public Administrador(int codAdmin, string nomAdmin, string apeAdmin)
        {
            this.CodAdmin = codAdmin;
            this.NomAdmin = nomAdmin;
            this.ApeAdmin = apeAdmin;
        }

        public bool Create()
        {
            try
            {
                Datos.Administrador admin = new Datos.Administrador()
                {
                    CodAdmin = this.CodAdmin,
                    NomAdmin = this.NomAdmin,
                    ApeAdmin = this.ApeAdmin,
                };
                Conexion.Bli.Administrador.Add(admin);
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
                Datos.Administrador admin = (from AuxAdmin in Conexion.Bli.Administrador
                                     where AuxAdmin.CodAdmin == this.CodAdmin
                                     select AuxAdmin).First();
                this.CodAdmin = admin.CodAdmin;
                this.NomAdmin = admin.NomAdmin;
                this.ApeAdmin = admin.ApeAdmin;
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
                Datos.Administrador admin = Conexion.Bli.Administrador.First(l => l.CodAdmin == this.CodAdmin);
                admin.CodAdmin = this.CodAdmin;
                admin.NomAdmin = this.NomAdmin;
                admin.ApeAdmin = this.ApeAdmin;
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
                Datos.Administrador admin = (from AuxAdmin in Conexion.Bli.Administrador
                                     where AuxAdmin.CodAdmin == this.CodAdmin
                                     select AuxAdmin).First();
                Conexion.Bli.Administrador.Remove(admin);
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