using LoLApiTest.Data_Handling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoLApiTest.LoLApiMain;

namespace LoLApiTest
{
    public static class LoLApiSearch
    {  

        //search player from entries by name
        public static LeagueItem ByName(string summName)
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

        //search player from entries by id
        public static LeagueItem ByID(string summID)
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

        //search for player with highest league points
        public static LeagueItem HighestLeaguePoints()
        {
            LoLApiService lolApiService = new LoLApiService();
            IList<LeagueItem> playerDetails = lolApiService.lolApiDTO.loLApiModel.entries;
            LeagueItem player = new LeagueItem();

            int leaguepoints = 0;
            foreach(LeagueItem li in playerDetails)
            {
                if (li.leaguePoints > leaguepoints)
                {
                    leaguepoints = li.leaguePoints;
                    player = li;
                }
            }
            return player;
        }

        //return entries sorted by league points
        public static IList<LeagueItem> SortedList(IList<LeagueItem> leagueItems)
        {
            return leagueItems.OrderByDescending(o => o.leaguePoints).ToList();
        }
    }
}
