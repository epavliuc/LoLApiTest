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
    }

}
