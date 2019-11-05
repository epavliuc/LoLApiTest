using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LoLApiTest.HTTP_Management
{
    public class LoLApiCall
    {
        public IRestClient Client { get; set; }
        public IRestResponse Response { get; set; }

        public string LoLApiRequest()
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.ApiUrl);
            Client.AddDefaultHeader("X-Riot-Token", ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }
    }
}
