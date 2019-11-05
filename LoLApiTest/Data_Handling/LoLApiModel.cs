using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApiTest.Data_Handling
{
    public class LoLApiModel
    {
        public string leagueId { get; set; }
        public string tier { get; set; }
        public List<PlayerDetails> playerDetails { get; set; }
        public string queue { get; set; }
        public string name { get; set; }
    }
    public class PlayerDetails
    {
        public string sumName { get; set; }
        public bool hotStreak { get; set; }
        public MiniSeries miniSeries { get; set; }
        public int wins { get; set; }
        public bool veteran { get; set; }
        public int losses { get; set; }

        public bool freshBlood { get; set; }
        public bool inactive { get; set; }
        public string rank { get; set; }
        public string summonerId { get; set; }
        public int leaguePoints { get; set; }
    }

    public class MiniSeries
    {
        public string progress { get; set; }
        public int losses { get; set; }
        public int target { get; set; }
        public int wins { get; set; }
    }
}
