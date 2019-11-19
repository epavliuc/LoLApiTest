using LoLApiTest.Data_Handling;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLApiTest.HTTP_Management;

namespace LoLApiTest
{
    public class LoLApiMain
    {
        static void Main(string[] args)
        {
            //testing playground
            LoLApiService lolApiService = new LoLApiService();
            LoLApiSearch lolApiSearch = new LoLApiSearch();
            Console.WriteLine(lolApiService.lolApiDTO.loLApiModel.entries[1].summonerName);
            Console.WriteLine(lolApiSearch.HighestLeaguePoints().summonerName);

            Console.Read();

        }

        public class LoLApiService
        {
            //DTO
            public LoLApiDTO lolApiDTO = new LoLApiDTO();

            //CallManager
            public LoLApiCall lolApiCall = new LoLApiCall();

            //JObject
            public JObject lolApiJObject;

            //IRestResponse
            public IRestResponse lolApiResponse;

            public LoLApiService()
            {
                lolApiDTO.DeserializeApi(lolApiCall.LoLApiRequest());
                lolApiJObject = JObject.Parse(lolApiCall.LoLApiRequest());
                lolApiResponse = lolApiCall.Response;
            }
        }



    }
}
