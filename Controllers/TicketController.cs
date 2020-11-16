using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;
using System.Diagnostics;

namespace Controllers
{
    public static class TicketController<T> where T :IMostrarDatos
    {
        public static bool PrintTicket(T auxGeneric)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "ticket.txt";
            bool flag = false;

            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine(auxGeneric.PrintDatos());

                //Checks if at least the textfile has been writen
                

            }

            flag = CheckWriting(path);
            if (flag)
            {
                //Process.Start(path);
                return flag;
            }
            else return false;
        }

        /// <summary>
        /// Function to check if the file has been writen
        /// </summary>
        /// <param name="path">the path to where it's the file</param>
        /// <returns>true if the file contains text, False otherwise</returns>
        private static bool CheckWriting(string path)
        {
            
            using(StreamReader reader = new StreamReader(path))
            {
                return reader.ReadLine() != null;
            }
        }
    }
}
