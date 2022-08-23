using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Cliente
    {
        private int _codCli;

        public int CodCli
        {
            get { return _codCli; }
            set
            {
                if (value > 0)
                {
                    _codCli = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar un ID de cliente correcto");
                }
            }

        }

        private string _nomCli;

        public string NomCli
        {
            get { return _nomCli; }
            set
            {
                if (value.Length > 0)
                {
                    _nomCli = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        private string _apeCli;

        public string ApeCli
        {
            get { return _apeCli; }
            set
            {
                if (value.Length > 0)
                {
                    _apeCli = value;
                }
                else
                {
                    throw new ArgumentException("Error.. debe ingresar al menos un caracter");
                }
            }
        }

        public Cliente()
        {
            _codCli = 0;
            _nomCli = string.Empty;
            _apeCli = string.Empty;
        }

        public Cliente(int codCli, string nomCli, string apeCli)
        {
            this.CodCli = codCli;
            this.NomCli = nomCli;
            this.ApeCli = apeCli;
        }

        public bool Create()
        {
            try
            {
                Datos.Cliente cli = new Datos.Cliente()
                {
                    CodCli = this.CodCli,
                    NomCli = this.NomCli,
                    ApeCli = this.ApeCli,
                };
                Conexion.Bli.Cliente.Add(cli);
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
                Datos.Cliente cli = (from Auxcli in Conexion.Bli.Cliente
                                     where Auxcli.CodCli == this.CodCli
                                     select Auxcli).First();
                this.CodCli = cli.CodCli;
                this.NomCli = cli.NomCli;
                this.ApeCli = cli.ApeCli;
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
                Datos.Cliente cli = Conexion.Bli.Cliente.First(l => l.CodCli == this.CodCli);
                cli.CodCli = this.CodCli;
                cli.NomCli = this.NomCli;
                cli.ApeCli = this.ApeCli;
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
                Datos.Cliente cli = (from Auxcli in Conexion.Bli.Cliente
                                     where Auxcli.CodCli == this.CodCli
                                     select Auxcli).First();
                Conexion.Bli.Cliente.Remove(cli);
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