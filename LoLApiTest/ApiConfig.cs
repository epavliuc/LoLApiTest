using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApiTest
{
    class ApiConfig
    {
        public static string ApiUrl = ConfigurationManager.AppSettings["BaseApiUrl"];
        public static string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
    }
}
