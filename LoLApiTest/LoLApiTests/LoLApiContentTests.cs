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
    class LoLApiContentTests
    {
        LoLApiService lolApiService = new LoLApiService();

        [Test]
        public void ApiStatusCheck()
        {
            Assert.AreEqual("OK", lolApiService.lolApiResponse.StatusCode.ToString());
        }

        [Test]
        public void ApiTierCheck()
        {
            Assert.AreEqual("CHALLENGER", lolApiService.lolApiDTO.loLApiModel.tier);
        }

        [Test]
        public void ApiLeagueIDCheck()
        {
            Assert.AreEqual("65ebcd4f-368c-30f6-a635-976beb0e1a8c", lolApiService.lolApiDTO.loLApiModel.leagueId);
        }

        [Test]
        public void ApiEntriesCountCheck()
        {
            IList<LeagueItem> playerDetails = lolApiService.lolApiDTO.loLApiModel.entries;
            Assert.AreEqual(300, playerDetails.Count);
        }

        [Test]
        public void ApiQueueCheck()
        {
            Assert.AreEqual("RANKED_SOLO_5x5", lolApiService.lolApiDTO.loLApiModel.queue);
        }

        [Test]
        public void ApiLeagueNameCheck()
        {
            Assert.AreEqual("Varus's Outriders", lolApiService.lolApiDTO.loLApiModel.name);
        }

    }

}
