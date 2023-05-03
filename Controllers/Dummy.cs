using System;
using System.Collections.Generic;
using System.Linq;
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
                new ProdHamburgueseria("Big mac","Deliciosa",150,200,eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Bebidas[0]),
                new ProdHamburgueseria("Plastic hamburger","Fantastic negrito",150,200,eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Bebidas[3]),
                new ProdHamburgueseria("Whooper","Muy grande",150,200,eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Bebidas[2]),
                new ProdHamburgueseria("Stacker","Varias capas",150,200,eCategoria.Hamburguesa, ECombo.Regular, (Bebida)Bebidas[1]),
                new ProdHamburgueseria("Swift","eso es una marca",150,200,eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Bebidas[0]),
                new ProdHamburgueseria("doble Cuarto de libra","Un clasico, este no podia faltar",150,200,eCategoria.Hamburguesa, ECombo.Grande, (Bebida)Bebidas[2])
        };

        public static List<Producto> Cafeteria = new List<Producto>()
        {
                new ProdCafeteria("Cafe Descaf","Negro",50,250,eCategoria.Cafeteria,EsubCategoria.Descafeinado),
                new ProdCafeteria("Cafe negro","Negro",50,250,eCategoria.Cafeteria,EsubCategoria.Cafe),
                new ProdCafeteria("cortado","con leche",70,250,eCategoria.Cafeteria,EsubCategoria.Cafe),
                new ProdCafeteria("capuchino","con leche y chocolate",100,250,eCategoria.Cafeteria,EsubCategoria.EdicLimitada),
                new ProdCafeteria("te verde","hierbas",50,250,eCategoria.Cafeteria,EsubCategoria.Infusiones)

        };

        public static List<Cliente> Clients = new List<Cliente>()
        {
                 new Cliente(0,"Fran","791 Psj. Del Carmen",EPayingMethod.Debito),
                new Cliente(1,"Rania","486 Westridge Pass",EPayingMethod.Debito),
                new Cliente(2,"Bevan","9856 Lake View Road",EPayingMethod.Efectivo),
                new Cliente(3,"Gerald","64790 Waxwing Way",EPayingMethod.Credito),
                new Cliente(4,"Lorri","92 Carioca Lane",EPayingMethod.Debito),
                new Cliente(5,"Myrwyn","0565 Luster Place",EPayingMethod.Efectivo),
                new Cliente(6,"Valida","582 Sachs Crossing",EPayingMethod.Credito),
                new Cliente(7,"Egbert","4641 Cordelia Way",EPayingMethod.Debito),
                new Cliente(8,"Wilek","40525 Basil Street",EPayingMethod.Efectivo),
                new Cliente(9,"Jolyn","8821 Crescent Oaks Lane",EPayingMethod.Credito),
                new Cliente(10,"Verne","3204 Sunnyside Way",EPayingMethod.Debito),

        };

        public static List<Producto> Pasteleria = new List<Producto>()
        {
                new ProdPasteleria("Torta balcarce","Recontra dulce",300,500,eCategoria.Pasteleria)
        };




        static Dummy()
        {
           

        }

        public static Cliente GetRandomClient()
        {
            Random rand = new Random();
            int index = rand.Next(10);
            return Clients.First(c => c.Id == index);
        }

    }


}

