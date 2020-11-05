using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
        

                
    public enum eCategoria
    {
        Postre,
        Hamburguesa,
        Cafeteria,
        Pasteleria,
    }
        
    public abstract class Producto : IMostrarDatos
    {
        public string nombre;

        public string descripcion;

        private double _precio;

        /// <summary>
        /// Esta propiedad se asegura de que el valor ingrsado sea >0, si no es asi, lanza un Argument Out of range Exception.
        /// </summary>
        public double Precio
        {
            get { return _precio; }

            set
            {
                if (value > 0)
                {
                    _precio = value;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Precio", "Ingrese un precio mayor a 0");
                }
            }
        }


        public double peso;

        public eCategoria categoria;

       

        protected Producto(string nombre, string descripcion, double precio, double peso, eCategoria categoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.peso = peso;
            this.categoria = categoria;
        }

        //public abstract string MostrarDatos();

        /// <summary>
        /// Serializa la informacion del objeto para que luego se le agregue la info propietaria de cada objeto
        /// </summary>
        /// <returns></returns>
        public virtual string PrintDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------");
            sb.AppendLine(string.Format(nombre+"----$"+Precio));
            sb.Append(categoria.ToString());
            return sb.ToString();
        }





    }
}
