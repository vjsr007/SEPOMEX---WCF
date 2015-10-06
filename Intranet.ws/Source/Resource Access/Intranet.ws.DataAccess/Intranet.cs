using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Intranet.ws.DataAccess;

namespace Intranet.ws.DataAccess
{
    public partial class IntranetDataContext
    {
        private const String Intranet = "Intranet";

        public static IntranetDataContext GetDataContext()
        {
            var conexion = ConnectionString.GetConnectionString(Intranet);
            var timeout = ConnectionString.GetTimeout();
            if (!string.IsNullOrEmpty(conexion))
            {
                var cnn = new IntranetDataContext(conexion) { CommandTimeout = timeout };
                return cnn;
            }
            return null;
        }
    }
}

