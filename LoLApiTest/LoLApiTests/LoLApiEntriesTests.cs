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

        [Test]
        public void ApiPlayerNameCheck()
        {
            Assert.AreEqual("Valcious", LoLApiSearch.ByName("Valcious").summonerName);
        }

        [Test]
        public void ApiPlayerIDCheck()
        {
            Assert.AreEqual("xoJxTUa16rU1NFVP3PoXtYtLYWRkRRL-g9S6PYtRG2y-uCg", LoLApiSearch.ByID("xoJxTUa16rU1NFVP3PoXtYtLYWRkRRL-g9S6PYtRG2y-uCg").summonerId);
        }

        [Test]
        public void ApiBestPlayerCheck()
        {
            Assert.AreEqual("TheUnshackIedone", LoLApiSearch.HighestLeaguePoints().summonerName);
        }

    }
}
