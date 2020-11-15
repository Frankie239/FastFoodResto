using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum ETamanio
    {
        Chico,
        Mediano,
        Grande
    }
    public enum EsubCategoria
    {
        Cafe,
        Descafeinado,
        Infusiones,
        EdicLimitada
    }

    public class ProdCafeteria : Producto
    {
        EsubCategoria subCategoria;
        ETamanio tamanio;
        public ProdCafeteria(string nombre, string descripcion, double precio, double peso, eCategoria categoria, EsubCategoria subCategoria) : base(nombre, descripcion, precio, peso, categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = categoria;
            this.subCategoria = subCategoria;
        }

        public override string PrintDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.PrintDatos());
            sb.AppendLine(string.Format(tamanio.ToString() + "ml"));
            sb.AppendLine(subCategoria.ToString());
            return sb.ToString();
        }







    }
}
