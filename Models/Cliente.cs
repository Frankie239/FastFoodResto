using System;
using System.Text;

namespace Models
{
    public class Cliente : IMostrarDatos
    {
        public int Id;
        public string Name;
        public string Address;
        public EPayingMethod Pay;

        public Cliente(int id, string name, string address, EPayingMethod pay)
        {
            Id = id;
            Name = name;
            Address = address;
            Pay = pay;
        }
        public string CalcDelivery()
        {
            Random rand = new Random();
            double distance = (double)rand.Next(100);
            double envio = distance / 10;
            envio *= 100;
            
            
            return envio.ToString();

        }

        public string PrintDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("** Cliente: " + Name + " **"));
            sb.AppendLine("** " + Address + " **");
            sb.AppendLine("** ENVIO-------$" + CalcDelivery() +" **");

            return sb.ToString();

        }
    }
}
