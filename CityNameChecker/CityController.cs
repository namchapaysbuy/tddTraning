using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace CityNameChecker
{
    public class CityController
    {
        private readonly IRestClient restClient;
        public CityController(IRestClient restClient)
        {
            this.restClient = restClient; 
        }

        public CityList GetCities()
        {
            var jsonGetCity = this.restClient.Get("https://localhost/city");

            var result = JsonConvert.DeserializeObject<CityList>(jsonGetCity);

            return result;
        }
    }
}