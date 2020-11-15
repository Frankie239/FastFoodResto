using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models

{
    enum EPayingMethod
    {
        Efectivo,
        Debito
    }
    public class Pedido : IMostrarDatos
    {
        public int id;
        public string client;

        public string date;
        private double facturacion;

        EPayingMethod Pay { set; get; } 

      

        public double calcFacturacion()
        {
            double total = 0;
            foreach (Producto prod in this.products)
            {
                total += prod.Precio;
            }
            return total;
        }


        public List<Producto> products = new List<Producto>();

        public Pedido(int id, string client, string date)
        {
            this.id = id;
            this.client = client;
            this.date = date;
        }

        public string PrintDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("** Pedido N° " + id + " **"));
            sb.AppendLine("** " + date + " **");
            sb.AppendLine(string.Format("** Cliente: " + client + " **"));

            foreach (Producto prod in products)
            {
                sb.AppendLine(prod.PrintDatos());
            }

            sb.AppendLine("Total-----------$" + calcFacturacion().ToString());

            sb.AppendLine("** Medio de pago: " + Pay.ToString()+" **");

            sb.AppendLine("**************FIN DEL PEDIDO**************");

            return sb.ToString();

        }
    }
}
