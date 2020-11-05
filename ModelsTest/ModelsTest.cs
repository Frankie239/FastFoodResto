using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace ModelsTest
{
    [TestClass]
    public class ModelsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Producto_SetPrecio_MenorZero_ArgumentOutOfRangeException()
        {
            //Arrange:
            //Act:
            Helado helado = new Helado("McFlurry", "Helado el vasito", -1, 200, eCategoria.Postre, eSabores.Crema);
        }

        /// <summary>
        /// Se fija que el valor ingresado sea el correcto
        /// </summary>
        [TestMethod]
        public void Producto_SetPrecio_MayorAZero_ValoresIguales()
        {
            //Arrange:
            double Expected = 1;
            //Act:
            Helado helado = new Helado("McFlurry", "Helado el vasito", 1, 200, eCategoria.Postre, eSabores.Crema);
            //Assert: 
            Assert.AreEqual(Expected, helado.Precio);
        }


        /// <summary>
        /// Se fija que el objeto creado tenga los mismos valores que el esperado
        /// 
        /// </summary>
        [TestMethod]
        public void Helado_SetNombre_TodoOk() 
        {
            //arrange:
            string ExNombre = "McFlurry";
            
            

            //Act:
            Helado Actual = new Helado("McFlurry", "Helado el vasito", 200, 200, eCategoria.Postre, eSabores.Crema);

            //Assert: 
            Assert.AreEqual(ExNombre,Actual.nombre);

            


        }

        [TestMethod]
        public void Helado_eSabor_TodoOk()
        {
            //arrange:
            eSabores ExSabor = eSabores.Chocolate;

            //Act:
            Helado Actual = new Helado("McFlurry", "Helado el vasito", 200, 200, eCategoria.Postre, eSabores.Chocolate);

            //Assert: 
            Assert.AreEqual(ExSabor, Actual.Sabor);
        }














    }
}
