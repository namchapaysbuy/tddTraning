using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityNameChecker
{
    public interface IRestClient
    {
        string Get(string url);
    }
}
