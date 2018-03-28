using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevisProApp.Clases;

namespace DevisProApp.Clases
{
    class  Login
    {
        Cadena obj = new Cadena();
        public bool Logeo( String Ced, String Pass)
        {
            //login = "@" + login;
            //Cedula = "@" + Cedula;
            //Password = "@" + Password;
            //String proced = login;
            String APPcadena;
            APPcadena = obj.Obtener_cadena();

            MySqlConnection conn = new MySqlConnection(APPcadena);
            
                conn.Open();
                MySqlCommand sql = new MySqlCommand("login", conn);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("Cedula",Ced);
                sql.Parameters.AddWithValue("Password", Pass);

                int valor = int.Parse(sql.ExecuteScalar().ToString());
                return valor > 0;   
        }
    }
}
