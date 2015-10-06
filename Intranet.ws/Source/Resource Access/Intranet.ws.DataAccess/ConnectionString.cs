using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Intranet.ws.DataAccess
{
    internal class ConnectionString
    {
        public static string GetConnectionString(string name)
        {
            var connStr = ConfigurationManager.ConnectionStrings[name];

            if (connStr != null)
                return connStr.ConnectionString;

            throw new Exception("No se encontro la conexión");
        }

        public static int GetTimeout()
        {
            var timeOut = ConfigurationManager.AppSettings["Timeout"];
            if (timeOut != null) return 0; else return Convert.ToInt32(timeOut);
        }
    }
}

