using CityNameChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace CityNameUnitTest
{
    public class FakeRestClient : IRestClient
    {
        public string Get(string url)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(path, "city.json");
            var cities = File.ReadAllText(filePath);

            return cities;
            //return JsonConvert.SerializeObject(cities);
        }
    }
}
