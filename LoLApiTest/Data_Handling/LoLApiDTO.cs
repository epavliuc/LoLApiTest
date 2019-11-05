using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApiTest.Data_Handling
{
    public class LoLApiDTO
    {
        public LoLApiModel loLApiModel { get; set; }

        public void DeserializeApi(String lolApiResponse)
        {
            loLApiModel = JsonConvert.DeserializeObject<LoLApiModel>(lolApiResponse);
        }
    }
}
