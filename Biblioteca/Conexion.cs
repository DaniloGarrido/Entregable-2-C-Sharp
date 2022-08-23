using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;
namespace Biblioteca.Negocios
{
    internal class Conexion
    {
        private static Biblioteca_VirtualEntities3 _bli;
        public static Biblioteca_VirtualEntities3 Bli
        {
            get
            {
                if (_bli == null)
                {
                    _bli = new Biblioteca_VirtualEntities3();
                }
                return _bli;
            }
            set
            {
                _bli = value;
            }
        }   
    }
}
