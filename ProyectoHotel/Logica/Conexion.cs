using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoHotel.Logica
{
    public class Conexion
    {
        //public static string CN = "Data Source=tcp:serverhotel.database.windows.net,1433;Initial Catalog=Hotel;User Id=administrador@serverhotel;Password=JC2406962020jc2021";
        public static string CN = "Data Source=JHANPC\\SQLEXPRESS;Database=DB_HOTEL;User Id=sa;Password=12345678;Trusted_Connection=False;MultipleActiveResultSets=True";
        //public static string CN = "Data Source=JHANPC\\SQLEXPRESS;Initial Catalog=DB_HOTEL;Integrated Security=True";
    }
}