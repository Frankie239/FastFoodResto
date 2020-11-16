using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{


    [Serializable]
    public class ProdAlreadyExistException : Exception
    {
        public ProdAlreadyExistException() { }
        public ProdAlreadyExistException(string message) : base(message) { }
        
    }
    static public class ProductosController
    {

        public static List<Producto> productos = new List<Producto>();
        //public static void ImprimirTicket<T>() where T : List<IMostrarDatos>
        //{



        //}

        /// <summary>
        /// Adds a producto to the list of productos
        /// but first checks if the product doesen't exists in the List productos
        /// throws a ProdAlreadyExistException if the product already exists
        /// </summary>
        /// <param name="prod">the product to add</param>
        public static void AddProducto(Producto prod)
        {
            //if (ProductoExists(prod.nombre))
            //{
            //    throw new ProdAlreadyExistException("The product you are trying to add already exists in this list");
            //}
            //else
            //{


            //}

            Type type = prod.GetType();


            switch (type.Name)
            {
                case "Bebida":
                    Dummy.Bebidas.Add(prod);
                    break;

                case "ProdHamburgueseria":
                    Dummy.Hamburguesas.Add(prod);
                    break;

                case "ProdCafeteria":
                    Dummy.Cafeteria.Add(prod);
                    break;

                case "ProdPasteleria":
                    Dummy.Pasteleria.Add(prod);
                    break;
            }


        }
        /// <summary>
        /// Deletes a product from the List
        /// </summary>
        /// <param name="name">the name(unique value) </param>
        /// <returns>True if has been deleted, False if not</returns>
        public static void DeleteProd(string name, string categoria)
        {
            //if (ProductoExists(name))
            //{
            //    productos.RemoveAll(p => p.nombre == name);
            //    return true;
            //}
            //else
            //    return false;
           


            switch (categoria)
            {
                case "Bebida":
                    Dummy.Bebidas.RemoveAll(p => p.nombre == name);

                    break;

                case "ProdHamburgueseria":
                    Dummy.Hamburguesas.RemoveAll(p => p.nombre == name); 
                    break;

                case "ProdCafeteria":
                    Dummy.Cafeteria.RemoveAll(p => p.nombre == name);
                    break;

                case "ProdPasteleria":
                    Dummy.Pasteleria.RemoveAll(p => p.nombre == name);
                    break;
            }

        }


        /// <summary>
        /// Updates the values of a product
        /// </summary>
        /// <param name="name">the name of the Product(unique value)</param>
        /// <param name="prod">The product with the new values</param>
        public static void UpdateProd(string name, Producto prod)
        {
           
            DeleteProd(name, prod.GetType().Name.ToString());
            AddProducto(prod);
               


        }
   
        /// <summary>
        /// Finds a product by its Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Producto GetProducto(string name,string Type)
        {
            
            switch (Type.ToUpper())
            {
                case "BEBIDA":
                    return Dummy.Bebidas.Find(p => p.nombre.ToUpper() == name.ToUpper());

                    break;

                case "PRODHAMBURGUESERIA":
                    return Dummy.Hamburguesas.Find(p => p.nombre.ToUpper() == name.ToUpper());
                    break;

                case "PRODCAFETERIA":
                    return Dummy.Cafeteria.Find(p => p.nombre.ToUpper() == name.ToUpper());
                    break;

                case "PRODPASTELERIA":
                    return Dummy.Pasteleria.Find(p => p.nombre.ToUpper() == name.ToUpper());
                    break;
            }


            return null;
        }

        private static bool ProductoExists(string name)
        {
           return productos.Any(p => p.nombre == name);
        }

        
    }
}
