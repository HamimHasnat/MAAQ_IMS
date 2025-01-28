using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAAQ_IMS.GlobalInfo
{
    class ConnectionInfo
    {
        public static string GenerateConnectionString()
        {
            return System.Configuration.ConfigurationSettings.AppSettings["ConnString"];
        }
    }
}
