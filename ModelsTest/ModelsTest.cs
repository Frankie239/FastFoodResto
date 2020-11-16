using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Controllers;

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
            new ProdHeladeria("McFlurry", "Helado el vasito", -1, 200, eCategoria.Postre, ESabores.Crema);
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
            ProdHeladeria helado = new ProdHeladeria("McFlurry", "Helado el vasito", 1, 200, eCategoria.Postre, ESabores.Crema);
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
            ProdHeladeria Actual = new ProdHeladeria("McFlurry", "Helado el vasito", 200, 200, eCategoria.Postre, ESabores.Crema);

            //Assert: 
            Assert.AreEqual(ExNombre,Actual.nombre);

            


        }

        [TestMethod]
        public void Helado_eSabor_TodoOk()
        {
            //arrange:
            ESabores ExSabor = ESabores.Chocolate;

            //Act:
            ProdHeladeria Actual = new ProdHeladeria("McFlurry", "Helado el vasito", 200, 200, eCategoria.Postre, ESabores.Chocolate);

            //Assert: 
            Assert.AreEqual(ExSabor, Actual.Sabor);
        }

        [TestMethod]

        public void GetProducto_returns_bebida()
        {
            //Arrange: 
            Bebida Expected = new Bebida("Nuka cola", "Radiactivamente deliciosa", 10, 250, eCategoria.Cafeteria, ETipo.NukaCola);
            //Act: 
            Bebida Actual = (Bebida)ProductosController.GetProducto("Nuka cola", Expected.GetType().Name.ToString());
            //Assert:
            Assert.AreEqual(Expected.nombre, Actual.nombre);
        }


        [TestMethod]
        public void GetProducto_returns_hamburguesa()
        {
            //Arrange: 
            ProdHamburgueseria Expected = new ProdHamburgueseria("Big mac", "Deliciosa", 150, 200, eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Dummy.Bebidas[0]);
            //Act: 
            ProdHamburgueseria Actual = (ProdHamburgueseria)ProductosController.GetProducto("Big mac", Expected.GetType().Name.ToString());
            //Assert:
            Assert.AreEqual(Expected.nombre, Actual.nombre);
        }


        [TestMethod]
        public void GetProducto_returns_cafe()
        {
            //Arrange: 
            ProdCafeteria Expected = new ProdCafeteria("Cafe Descaf", "Negro", 50, 250, eCategoria.Cafeteria, EsubCategoria.Descafeinado);
            //Act: 
            ProdCafeteria Actual = (ProdCafeteria)ProductosController.GetProducto("Cafe Descaf", Expected.GetType().Name.ToString());
            //Assert:
            Assert.AreEqual(Expected.nombre, Actual.nombre);
        }

        [TestMethod]
        public void GetProducto_returns_pasteleria()
        {
            //Arrange: 
            ProdPasteleria Expected = new ProdPasteleria("Torta balcarce", "Recontra dulce", 300, 500, eCategoria.Pasteleria);
            //Act: 
            ProdPasteleria Actual = (ProdPasteleria)ProductosController.GetProducto("Torta balcarce", Expected.GetType().Name.ToString());
            //Assert:
            Assert.AreEqual(Expected.nombre, Actual.nombre);
        }














    }
}
