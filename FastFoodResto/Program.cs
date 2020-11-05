using System;
using Models;

namespace FastFoodResto
{
    class Program
    {
        static void Main(string[] args)
        {
            Helado helado = new Helado("McFlurry", "Desc", 200, 300, eCategoria.Postre, eSabores.Crema);
            Helado newHelado = new Helado("Conito", "Desc", 150, 100, eCategoria.Postre, eSabores.Chocolate);
            Hamburguesa hamb = new Hamburguesa("Big mac", "Desc", 300, 400, eCategoria.Hamburguesa,eCombo.Chico);

            Console.Write(helado.PrintDatos());
            Console.Write(newHelado.PrintDatos());
            Console.Write(hamb.PrintDatos());
        }
    }
}
