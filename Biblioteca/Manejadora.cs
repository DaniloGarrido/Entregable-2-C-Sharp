using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Manejadora
    {
        public List<Libro> ListarLibs()
        {
            List<Libro> Listalibs = new List<Libro>();
            foreach (Datos.Libro Libs in Conexion.Bli.Libro)
            {
                Libro newLib = new Libro(Libs.CodLib,
                                          Libs.NombreLib,
                                          Libs.CodISBN,
                                          Libs.Autor,
                                          Libs.Editorial,
                                          Libs.Fechapublic,
                                          Libs.Categoria,
                                          Libs.Genero);
                Listalibs.Add(newLib);
            }
            return Listalibs;
        }

        public List<Sesion> Listarsesion()

        {
            List<Sesion> Listasesion = new List<Sesion>();
            foreach (Datos.Sesion sesion in Conexion.Bli.Sesion)
            {
                Sesion newsesion = new Sesion(sesion.CodigoEmple,
                                              sesion.Usuario,
                                              sesion.contrasena,
                                              sesion.Tipousuario);
                Listasesion.Add(newsesion);
            }
            return Listasesion;
        }


        public List<Sesion> Listarsesion1 (int r)

        {
            List<Sesion> Listasesion1 = new List<Sesion>();
            foreach (Datos.Sesion sesion in Conexion.Bli.Sesion)
            {
                if (sesion.CodigoEmple == r)
                {
                    Sesion newsesion = new Sesion(sesion.CodigoEmple, sesion.Usuario, sesion.contrasena, sesion.Tipousuario);
                    Listasesion1.Add(newsesion);
                }
            }
            return Listasesion1;


        }
    }
}
