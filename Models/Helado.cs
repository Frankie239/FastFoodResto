using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public enum eSabores 
    {
        Crema,
        Chocolate,
        DDL,
        Combinado
    }
    public class Helado : Producto
    {

        //public string nombre;

        //public string descripcion;

        //public double peso;

        //public eCategoria categoria;
        public eSabores Sabor;

        public Helado(string nombre, string descripcion, double precio, double peso, eCategoria categoria, eSabores sabor) : base(nombre, descripcion, precio, peso, categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = categoria;
            this.Sabor = sabor;
            
        }

        public override string PrintDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.PrintDatos());
            sb.AppendLine(Sabor.ToString());
            return sb.ToString();
        }
    }
}
