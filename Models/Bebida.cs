using System.Text;

namespace Models
{
    public enum ETipo 
    {
       NukaCola,
       Pepsi,
       Agua

    
    }
    public class Bebida : Producto
    {
        public ETipo Tipo;
        public Bebida(string nombre, string descripcion, double precio, double peso, eCategoria categoria, ETipo tipo) : base(nombre, descripcion, precio, peso, categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = eCategoria.Cafeteria;
            this.Tipo = tipo;
        }

       
        public override string PrintDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(Tipo.ToString() +" "+ peso+"ml"));

            return sb.ToString();
        }
    }
}