using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models

{
    public enum EPayingMethod
    {
        Efectivo,
        Debito,
        Credito

    }
    public class Pedido : IMostrarDatos
    {
        public int id;
        public Cliente client;

        public string date;
        private double facturacion;

        //EPayingMethod Pay { set; get; } 

      

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

        public Pedido(int id, Cliente client, string date)
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
            sb.AppendLine(client.PrintDatos());

            foreach (Producto prod in products)
            {
                sb.AppendLine(prod.PrintDatos());
            }

            sb.AppendLine("Total-----------$" + calcFacturacion().ToString());

            sb.AppendLine("** Medio de pago: " + client.Pay.ToString() +" **");

            //To add feature:
            //sb.AppendLine(comment)

            sb.AppendLine("**************FIN DEL PEDIDO**************");

            return sb.ToString();

        }
    }
}
