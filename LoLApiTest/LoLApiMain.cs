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
            LeagueItem player;
            LoLApiService lolApiSerive = new LoLApiService();
            IList<LeagueItem> sortedList = LoLApiSearch.SortedList(lolApiSerive.lolApiDTO.loLApiModel.entries);
            Console.WriteLine(LoLApiSearch.HighestLeaguePoints().summonerName);
            Console.WriteLine("Insert name of player: ");
            player = LoLApiSearch.ByName(Console.ReadLine());
            try
            {  
                Console.WriteLine($"{player.summonerName} has {player.leaguePoints} points");
            }
            catch(NullReferenceException ex)
            {
                NullReferenceException noSuchName = new NullReferenceException("Non existent or Wrong Name", ex);
                Console.WriteLine(noSuchName.Message);
                //throw noSuchName;
            }
            Console.WriteLine(sortedList[299].leaguePoints + sortedList[299].summonerName);


            

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
