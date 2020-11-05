using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum eCombo 
    {
        Sin_Combo,
        Chico,
        Regular,
        Grande
    }
    

    
    public class Hamburguesa : Producto
    {

        eCombo Combo;
        Bebida bebida;
        public Hamburguesa(string nombre, string descripcion, double precio, double peso, eCategoria categoria,eCombo combo) : base(nombre, descripcion, precio, peso, categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = categoria;
            this.Combo = combo;
        }

        public Hamburguesa(string nombre, string descripcion, double precio, double peso, eCategoria categoria, eCombo combo,Bebida bebida) : base(nombre, descripcion, precio, peso, categoria)
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
            sb.AppendLine(Combo.ToString());

            return sb.ToString();
        }
    }
}
