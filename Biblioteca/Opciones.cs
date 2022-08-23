using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocios
{
   
        public enum Genero
        {
            Magia = 0,
            Ciencia_Ficcion = 1,
            Horror = 2,
            Terror = 3,
            Comedia = 4,
            Historia = 5,
            Geografia = 6,
            Informatica = 7,
            Medieval = 8,
            Ingenieria = 9,
            Aventuras = 10,
            Infantil = 11,
            Romance=12
        }
        public enum Categoria
        {
            Libro = 0,
            Comic = 1,
            Cuento = 2,
            Novela = 3,
            Enciclopedia = 4,
            Recetas = 5
        }
        public enum TipoUser
        {
        Administrador,
        Bibliotecario
        }
    
    
}
