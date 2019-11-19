using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LoLApiTest.Data_Handling;
using LoLApiTest.HTTP_Management;
using static LoLApiTest.LoLApiMain;

namespace LoLApiTest.LoLApiTests
{
    [TestFixture]
    class LoLApiEntriesTests
    {
        LoLApiSearch lolApiSearch = new LoLApiSearch();

        [Test]
        public void ApiPlayerNameCheck()
        {
            Assert.AreEqual("Valcious", lolApiSearch.ByName("Valcious").summonerName);
        }

        [Test]
        public void ApiPlayerIDCheck()
        {
            Assert.AreEqual("xoJxTUa16rU1NFVP3PoXtYtLYWRkRRL-g9S6PYtRG2y-uCg", lolApiSearch.ByID("xoJxTUa16rU1NFVP3PoXtYtLYWRkRRL-g9S6PYtRG2y-uCg").summonerId);
        }

        [Test]
        public void ApiBestPlayerCheck()
        {
            Assert.AreEqual("TheUnshackIedone", lolApiSearch.HighestLeaguePoints().summonerName);
        }

    }
}
