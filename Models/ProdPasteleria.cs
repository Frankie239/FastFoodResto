using System.Text;

namespace Models
{
    public class ProdPasteleria : Producto
    {
        public ProdPasteleria(string nombre, string descripcion, double precio, double peso, eCategoria categoria) : base(nombre, descripcion, precio, peso, categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = categoria;
        }

        public override string PrintDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.PrintDatos());

            return sb.ToString();
        }
    }
}
