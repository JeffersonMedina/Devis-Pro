using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DevisProApp.Clases;

namespace DevisProApp.Clases
{
    class Cadena
    {
        public String CadenaApp;
        public String Obtener_cadena()
        {
            CadenaApp = ConfigurationManager.ConnectionStrings["APPcadena"].ConnectionString;
            return CadenaApp;
        }

    }
}
