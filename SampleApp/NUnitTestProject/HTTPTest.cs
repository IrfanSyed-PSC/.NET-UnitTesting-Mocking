using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleApp.UnitTest
{
    class HTTPTest
    {

        [Test]
        public async Task performGET()
        {

            HttpClient http = new HttpClient();
            var result = await http.GetAsync("http://localhost:8810/rest/_oepingService/_oeping");

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            var str = (await result.Content.ReadAsStringAsync());

            Assert.IsTrue(str.Contains("_retVal"));

            var myobj = (JObject)JsonConvert.DeserializeObject<object>(str);

            TestContext.WriteLine(myobj.ToString());

            
        }

    }
}
