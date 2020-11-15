using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public enum ESabores 
    {
        Crema,
        Chocolate,
        DDL,
        Combinado
    }

    
    public class ProdHeladeria : Producto
    {

        //public string nombre;

        //public string descripcion;

        //public double peso;

        //public eCategoria categoria;
        public ESabores Sabor;

        public ProdHeladeria(string nombre, string descripcion, double precio, double peso, eCategoria categoria, ESabores sabor) : base(nombre, descripcion, precio, peso, categoria)
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
