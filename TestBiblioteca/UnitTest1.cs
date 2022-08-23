using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Negocios;
namespace TestBiblioteca.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       public void TestLeer()
        {
            string esperado = "Gantz 8";
            string resultado = "";
            Libro li = new Libro()
            {
                Codlib = 55

            };
        
        }
        [TestMethod]
        public void TestLeer2()
        {
            bool esperado = true;
            string resultado = "";
            Sesion log = new Sesion()
            {
                Codemple = 111,
                Contrasena = "michisito"
            };
           
        }
    }

}
