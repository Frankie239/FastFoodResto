using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class ConsoleController
    {
        public static string MenuPrincipal()
        {
            string presionada = "0";
           

            while(presionada.ToUpper() != "X")
            {
                Console.Write("1 Generar Pedido  2 Buscar producto  3 Agregar nuevo producto\n" +
               "4 Modificar Producto   5 Eliminar producto  6 Mostrar todos los prods \n 7 salir \n");

                presionada = Console.ReadLine();
                switch (presionada)
                {
                    case "1":
                        Pedido newPedido = new Pedido(1, Dummy.GetRandomClient(), DateTime.Now.ToString());

                        Console.Clear();

                        string desition = "";

                        while (desition != "X")
                        {

                            Console.WriteLine("Seleccione Categoria, Ingrese X para generar el ticket, intro para continuar");
                            desition = Console.ReadLine();
                            eCategoria auxCategoria = eCategoria.Cafeteria;
                            if(desition.ToUpper() == "X")
                            {
                                DesserializarEnMasa(newPedido.products);
                                Console.WriteLine("Confirmar pedido Y/N");
                                string confirmacion = Console.ReadLine();
                                if(confirmacion.ToUpper() == "Y")
                                {
                                    TicketController<Pedido>.PrintTicket(newPedido);

                                    PrintingAnimation();
                                }
                            }
                            else
                            {
                                int selection = GetEnumInConsole<eCategoria>(auxCategoria);


                                auxCategoria = (eCategoria)selection;
                                string name = "";

                                //Hacer que si busca no tire exception
                                switch (auxCategoria)
                                {

                                    case eCategoria.Cafeteria:
                                        DesserializarEnMasa(Dummy.Cafeteria);
                                        //Añado el producto a el pedido dependiendo del nombre445rrrrr (colaboracion de scon)fggggggggggggggggggggggggggrrrrrrrrr
                                        name = Console.ReadLine();
                                        if (!string.IsNullOrEmpty(name))
                                            try
                                            {
                                                newPedido.products.Add(Dummy.Cafeteria.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                            }
                                            catch (InvalidOperationException e)
                                            {
                                                Console.WriteLine("No se encontro ese producto");
                                                name = Console.ReadLine();
                                                newPedido.products.Add(Dummy.Cafeteria.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                            }

                                        else
                                            Console.WriteLine("Ingrese un nombre de producto");
                                        break;
                                    case eCategoria.Hamburguesa:
                                        DesserializarEnMasa(Dummy.Hamburguesas);
                                        name = Console.ReadLine();
                                        if (name != "")
                                            try
                                            {
                                                newPedido.products.Add(Dummy.Hamburguesas.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                            }
                                            catch(InvalidOperationException e)
                                            {
                                                Console.WriteLine("No se encontro ese producto");
                                                name = Console.ReadLine();
                                                newPedido.products.Add(Dummy.Hamburguesas.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                            }
                                           
                                        break;
                                    case eCategoria.Pasteleria:
                                        DesserializarEnMasa(Dummy.Pasteleria);
                                        name = Console.ReadLine();
                                        if (name != "")
                                            try
                                            {
                                                newPedido.products.Add(Dummy.Pasteleria.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                            }
                                            catch (InvalidOperationException e)
                                            {
                                                Console.WriteLine("No se encontro ese producto");
                                                name = Console.ReadLine();
                                                newPedido.products.Add(Dummy.Pasteleria.Where(p => p.nombre.ToUpper() == name.ToUpper()).First());
                                            }
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                        break;

                    case "2":
                        FindProd();
                        break;
                        

                    case "3":
                        try
                        {
                            ProductosController.AddProducto(SerializeProd<Producto>());
                        }
                        catch(NullReferenceException e)
                        {
                            Console.WriteLine("Por favor ingrese datos validos");
                        }

                        break;

                    case "4":
                        ShowAllProds();

                        List<string> res = FindProd();

                        ProductosController.UpdateProd(res[0], SerializeProd<Producto>());
                        break;
                    case "5":
                        Console.Clear();
                        ShowAllProds();
                        List<string> response = FindProd();
                        ProductosController.DeleteProd(response[0], response[1]);
                        break;

                    case "6":
                        Console.Clear();
                        ShowAllProds();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;







                            

                            


                       

                        







                }
            }
           

            
            return presionada;
        }

        private static List<string> FindProd()
        {
            List<string> res = new List<string>();
            Console.WriteLine("Ingrese un nombre");
            string presionada = Console.ReadLine();
            res.Add(presionada);
            Console.WriteLine("Y una categoria: \n Bebida \n ProdHamburgueseria \n ProdCafeteria \n ProdPasteleria");
            string cat = Console.ReadLine();
            res.Add(cat);
            Deserializar(ProductosController.GetProducto(presionada, cat));
            return res;
        }
            
        
        private static void PrintingAnimation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Imprimiendo");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine("Ticket impreso");
            Thread.Sleep(200);
            
            Console.ForegroundColor = ConsoleColor.White;
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
            mySb.Append(string.Format("{0, -6} | ", "Peso: "));


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
        public  static Producto SerializeProd<T>() where T : Producto
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



            Console.WriteLine("Seleccione una categoria");

            eCategoria auxCategoria = eCategoria.Cafeteria;

            int selection = GetEnumInConsole<eCategoria>(auxCategoria);
          

            auxCategoria = (eCategoria)selection;


            switch (auxCategoria)
            {

                case eCategoria.Hamburguesa:

                    //Ask if wants it in combo
                    Console.WriteLine("Combo");
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
                        //ProductosController.AddProducto(toAdd);
                        return toAdd;

                    }
                    else
                    {

                        Bebida comboDrink = (Bebida)Dummy.Bebidas.First(b => b.nombre.ToUpper() == "SIN BEBIDA");
                        ProdHamburgueseria toAdd = new ProdHamburgueseria(name, desc, price, weight, eCategoria.Hamburguesa, combo, comboDrink);
                        //ProductosController.AddProducto(toAdd);
                        return toAdd;
                    }


                    
                    break;


                   




                case eCategoria.Cafeteria:
                    //Ask if wants it in combo
                    Console.WriteLine("Sub categoria");
                    EsubCategoria subCat = EsubCategoria.Cafe;
                    selection = GetEnumInConsole<EsubCategoria>(subCat);
                    subCat = (EsubCategoria)selection;

                    ProdCafeteria toAddCaf = new ProdCafeteria(name, desc, price, weight, auxCategoria, subCat);

                    //ProductosController.AddProducto(toAddCaf);

                    return toAddCaf;
                    break;
                
                case eCategoria.Pasteleria:
                    ProdPasteleria toAddPast = new ProdPasteleria(name, desc, price, weight, auxCategoria);
                    //ProductosController.AddProducto(toAddPast);
                    return toAddPast;
                    break;

                case eCategoria.Postre:
                    Console.WriteLine("Sub categoria");
                    ESabores flavor = ESabores.Combinado;
                    selection = GetEnumInConsole<ESabores>(flavor);
                    flavor = (ESabores)selection;

                    ProdHeladeria toAddHel = new ProdHeladeria(name, desc, price, weight, auxCategoria, flavor);
                    //ProductosController.AddProducto(toAddHel);
                    return toAddHel;
                    break;

                default:
                    return null;
                    break;


            }
            
           
            
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

            Console.Clear();
            //Extracting the type of the enumerator that comes into the param
            Type enumType = enumerator.GetType();

            //Extracting the values of the enum and putting them into a var
            var cats = Enum.GetValues(enumerator.GetType());

            //Initializing a index, just for visualization purposes
            byte index = 0;
            //Start iterating through the var
            foreach (var cat in cats)
            {
                //Write each one of the enum elements
                Console.WriteLine(index.ToString()+"-" + cat.ToString());
                index++;

            }
            int EnumSelection = 0;
            //Get the input from the user
            try
            {
                EnumSelection  = int.Parse(Console.ReadLine());
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Ingrese un numero dentro de los mostrados");
                EnumSelection = int.Parse(Console.ReadLine());
            }
            

            return EnumSelection;

        }


        private static void ShowAllProds()
        {
            DesserializarEnMasa(Dummy.Bebidas);
            DesserializarEnMasa(Dummy.Cafeteria);
            DesserializarEnMasa(Dummy.Hamburguesas);
            DesserializarEnMasa(Dummy.Pasteleria);

        }


        
    }
}
