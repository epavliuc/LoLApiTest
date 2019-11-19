using LoLApiTest.Data_Handling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoLApiTest
{
    public class LoLApiSearch : LoLApiMain
    {  
        public LeagueItem ByName(string summName)
        {
            LoLApiService lolApiService = new LoLApiService();
            IList<LeagueItem> playerDetails = lolApiService.lolApiDTO.loLApiModel.entries;
            foreach(LeagueItem li in playerDetails)
            {
                if (li.summonerName == summName)
                {
                    return li;
                }
            }
            return null;
        }

        public LeagueItem ByID(string summID)
        {
            LoLApiService lolApiService = new LoLApiService();
            IList<LeagueItem> playerDetails = lolApiService.lolApiDTO.loLApiModel.entries;
            foreach (LeagueItem li in playerDetails)
            {
                if (li.summonerId == summID)
                {
                    return li;
                }
            }
            return null;
        }
    }
}
