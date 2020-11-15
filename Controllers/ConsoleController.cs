using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class ConsoleController
    {
        public static string MenuPrincipal()
        {
            string presionada = "0";
            Console.Write("1 Generar Pedido  2 Buscar producto  3 Agregar nuevo producto\n" +
                "4 Modificar Producto   5 Eliminar producto  6 Facturacion \n 7 salir \n");

            while(presionada.ToUpper() != "X")
            {
                presionada = Console.ReadLine();
                switch (presionada)
                {
                    case "1":
                        Pedido newPedido = new Pedido(1, Dummy.GetRandomName(), DateTime.Now.ToString());




                        while (Console.ReadLine().ToUpper() != "X")
                        {

                            Console.WriteLine("Seleccione Categoria, Ingrese X para generar el ticket");

                            eCategoria auxCategoria = eCategoria.Cafeteria;

                            int selection = GetEnumInConsole<eCategoria>(auxCategoria);


                            auxCategoria = (eCategoria)selection;
                            string name = "";

                            switch (auxCategoria)
                            {

                                case eCategoria.Cafeteria:
                                    DesserializarEnMasa(Dummy.Cafeteria);
                                    //Añado el producto a el pedido dependiendo del nombre445rrrrr (colaboracion de scon)fggggggggggggggggggggggggggrrrrrrrrr
                                    name = Console.ReadLine();
                                    newPedido.products.Add(Dummy.Cafeteria.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                    break;
                                case eCategoria.Hamburguesa:
                                    DesserializarEnMasa(Dummy.Hamburguesas);
                                    name = Console.ReadLine();
                                    newPedido.products.Add(Dummy.Hamburguesas.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                    break;
                                case eCategoria.Pasteleria:
                                    DesserializarEnMasa(Dummy.Pasteleria);
                                    name = Console.ReadLine();
                                    newPedido.products.Add(Dummy.Pasteleria.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                    break;

                            }


                        }

                        TicketController<Pedido>.PrintTicket(newPedido);



                        break;

                    case "2":
                        Console.WriteLine("Ingrese un nombre");
                        presionada = Console.ReadLine();

                        Console.WriteLine("Y una categoria: Bebida \n ProdHamburgueseria \n ProdCafeteria \n ProdPasteleria");
                        string cat = Console.ReadLine();
                        Deserializar(ProductosController.GetProducto(presionada, cat));
                        break;




                    case "3":
                        SerializeProd<Producto>();
                        break;


                }
            }
           

            
            return presionada;
        }

        /// <summary>
        /// Loads the headers for the prods
        /// </summary>
        private static void Headers()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            StringBuilder mySb = new StringBuilder();
            mySb.Append(string.Format("{0, -19}  | ", "Nombre: "));
            mySb.Append(string.Format("{0, -14}  | ", "Categoria: "));
            mySb.Append(string.Format("{0, -20}  | ", "Desc: "));
            mySb.Append(string.Format("{0, -6}| ", "Precio: "));
            mySb.Append(string.Format("{0, -61} | ", "Peso: "));


            Console.WriteLine(mySb.ToString());

            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Deserializes a prod and shows it in the console
        /// </summary>
        /// <param name="prod"></param>
        private static void Deserializar(Producto prod)
        {
            if (prod != null)
            {
                StringBuilder mySb = new StringBuilder();
                mySb.Append("|");
                mySb.Append(string.Format("{0, -18}  | ", prod.nombre));
                mySb.Append(string.Format("{0, -14}  | ", prod.categoria));
                mySb.Append(string.Format("{0, -20}  | ", prod.descripcion));
                mySb.Append(string.Format("{0, -6}  | ", prod.Precio));
                mySb.AppendLine(string.Format("{0, -6}  | ", prod.peso));



                Console.Write(mySb.ToString());
            }
            else Console.WriteLine("El producto no existe");

        }

        /// <summary>
        /// Calls Deserializar into each object of a collection
        /// </summary>
        /// <param name="devueltos"></param>
        private static void DesserializarEnMasa(List<Producto> devueltos)
        {

            Headers();

            foreach (Producto prod in devueltos)
            {
                Deserializar(prod);
            }
            Console.WriteLine();
            
        }

        /// <summary>
        /// Makes all the procedure to add a product to a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>the product in his child class</returns>
        public  static void SerializeProd<T>() where T : Producto
        {
            //List<T> data = new List<T>();

            Console.Write("Nombre:  ");
            string name = Console.ReadLine();

            Console.Write("Descripcion:  ");
            string desc = Console.ReadLine();

            Console.Write("Precio:  ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Peso: ");
            double weight = double.Parse(Console.ReadLine());



            eCategoria auxCategoria = eCategoria.Cafeteria;

            int selection = GetEnumInConsole<eCategoria>(auxCategoria);
          

            auxCategoria = (eCategoria)selection;


            switch (auxCategoria)
            {

                case eCategoria.Hamburguesa:

                    //Ask if wants it in combo
                    ECombo combo = ECombo.Sin_Combo;
                    selection = GetEnumInConsole<ECombo>(combo);
                    combo = (ECombo)selection;

                    Console.Write("Bebida? Y/N");
                    string desition = Console.ReadLine();

                    if(desition.ToUpper() == "Y")
                    {
                        DesserializarEnMasa(Dummy.Bebidas);
                        Console.Write("Nombre de la bebida: ");
                        desition = Console.ReadLine();
                        Bebida comboDrink = (Bebida)Dummy.Bebidas.Where(b => b.nombre.ToUpper() == desition.ToUpper()).FirstOrDefault();

                        ProdHamburgueseria toAdd = new ProdHamburgueseria(name, desc, price, weight, eCategoria.Hamburguesa, combo, comboDrink);
                        //return toAdd;

                    }
                    else
                    {

                        Bebida comboDrink = (Bebida)Dummy.Bebidas.First(b => b.nombre.ToUpper() == "SIN BEBIDA");
                        ProdHamburgueseria toAdd = new ProdHamburgueseria(name, desc, price, weight, eCategoria.Hamburguesa, combo, comboDrink);
                        //return toAdd;
                    }
                    break;


                   




                case eCategoria.Cafeteria:
                    //Ask if wants it in combo
                    Console.WriteLine("Sub categoria");
                    EsubCategoria subCat = EsubCategoria.Cafe;
                    selection = GetEnumInConsole<EsubCategoria>(subCat);
                    subCat = (EsubCategoria)selection;

                    ProdCafeteria toAddCaf = new ProdCafeteria(name, desc, price, weight, auxCategoria, subCat);

                    //return toAddCaf;
                    break;
                
                case eCategoria.Pasteleria:
                    ProdPasteleria toAddPast = new ProdPasteleria(name, desc, price, weight, auxCategoria);
                    //return toAddPast;
                    break;

                case eCategoria.Postre:
                    Console.WriteLine("Sub categoria");
                    ESabores flavor = ESabores.Combinado;
                    selection = GetEnumInConsole<ESabores>(flavor);
                    flavor = (ESabores)selection;

                    ProdHeladeria toAddHel = new ProdHeladeria(name, desc, price, weight, auxCategoria, flavor);
                    //return toAddHel;
                    break;


            }
            //return null;
           
            
        }

        /// <summary>
        /// Prints on console a list of the enumerator 
        /// elements, and gives you the choice to select one of them
        /// </summary>
        /// <typeparam name="T">Expected a Enum</typeparam>
        /// <param name="enumerator">the object enumerator to iterate</param>
        /// <returns>the int of the selection to later cast </returns>
        private static int GetEnumInConsole<T>(T enumerator) where T:Enum
        {

            //Extracting the type of the enumerator that comes into the param
            Type enumType = enumerator.GetType();

            //Extracting the values of the enum and putting them into a var
            var cat = Enum.GetValues(enumerator.GetType());

            //Initializing a index, just for visualization purposes
            byte index = 0;
            //Start iterating through the var
            foreach (var auxCat in cat)
            {
                //Write each one of the enum elements
                Console.WriteLine(index.ToString()+"-" + auxCat.ToString());
                index++;

            }

            //Get the input from the user
            int EnumSelection = int.Parse(Console.ReadLine());

            return EnumSelection;

        }
    }
}
