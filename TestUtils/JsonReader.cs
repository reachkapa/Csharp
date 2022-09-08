using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenHybridFramework.TestUtils
{
    public class JsonReader
    {
        public string getTestData(string tokenKey)
        {
            string JsonFile = File.ReadAllText("C:/Users/CLD16766/source/repos/ConsoleApp1/DataDrivenHybridFramework/TestData/LoginTestData.json");
            var JsonObject = JToken.Parse(JsonFile);
            return JsonObject.SelectToken(tokenKey).Value<string>();
        }
    }
}
