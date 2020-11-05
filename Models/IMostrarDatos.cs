using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IMostrarDatos
    {
        /// <summary>
        /// Obtiene los valores del objeto y los serializa en un string 
        /// </summary>
        /// <returns>string con formato dependiendo del objeto</returns>
        string PrintDatos();

        
    }
}
