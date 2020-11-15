using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum ECombo 
    {
        Sin_Combo,
        Chico,
        Regular,
        Grande
    }
    

    
    public class ProdHamburgueseria : Producto
    {

        ECombo Combo;
        Bebida bebida;
        //public Hamburguesa(string nombre, string descripcion, double precio, double peso, eCategoria categoria,ECombo combo) : base(nombre, descripcion, precio, peso, categoria)
        //{
        //    this.nombre = nombre;
        //    this.descripcion = descripcion;
        //    this.Precio = precio;
        //    this.peso = peso;
        //    this.categoria = categoria;
        //    this.Combo = combo;
        //}

        public ProdHamburgueseria(string nombre, string descripcion, double precio, double peso, eCategoria categoria, ECombo combo,Bebida bebida) : base(nombre, descripcion, precio, peso, categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = categoria;
            this.Combo = combo;
            this.bebida = bebida;
        }

        public override string PrintDatos()
        {
            string result = base.PrintDatos();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(result);

            if(Combo.ToString() != ECombo.Sin_Combo.ToString())
            {
                sb.AppendLine(String.Format(Combo.ToString()+" "+bebida.PrintDatos()));
                
            }
            else
            {
                sb.AppendLine(bebida.PrintDatos());
            }           

            return sb.ToString();
        }
    }
}
