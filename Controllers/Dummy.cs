using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public static class Dummy
    {
        public static List<Producto> Bebidas = new List<Producto>()
        {
                new Bebida("Nuka cola", "Radiactivamente deliciosa", 10, 250, eCategoria.Cafeteria, ETipo.NukaCola),
                new Bebida("Pipsi cola", "From chernarus to the world", 30, 150, eCategoria.Cafeteria, ETipo.Pepsi),
                new Bebida("Agüita","Refrescante",5,250, eCategoria.Cafeteria, ETipo.Agua),
                new Bebida("Sin bebida","nada",1,0,eCategoria.Cafeteria,ETipo.Agua)

        };
        public static List<Producto> Hamburguesas = new List<Producto>()
        {
                new ProdHamburgueseria("Big mac","Deliciosa",150,200,eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Bebidas[0])
        };

        public static List<Producto> Cafeteria = new List<Producto>()
        {
                new ProdCafeteria("Cafe Descaf","Negro",50,250,eCategoria.Cafeteria,EsubCategoria.Descafeinado)
        };
        public static List<string> Clients = new List<string>()
        {
                "Hugibert","Egan","Tony","Hasheem", "Yulma","Randal","Curran","Vachel","Garwood", "Monika"

        };

        public static List<Producto> Pasteleria = new List<Producto>()
        {
                new ProdPasteleria("Torta balcarce","Recontra dulce",300,500,eCategoria.Pasteleria)
        };




        static Dummy()
        {
           

        }

        public static string GetRandomName()
        {
            Random rand = new Random();
            return Clients[rand.Next(10)];
        }

    }


}

