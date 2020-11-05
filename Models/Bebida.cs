namespace Models
{
    public enum eTipo 
    {
         
    
    }
    public class Bebida : Producto
    {
        public Bebida(string nombre, string descripcion, double precio, double peso, eCategoria categoria) : base(nombre, descripcion, precio, peso, categoria)
        {
        }
    }
}