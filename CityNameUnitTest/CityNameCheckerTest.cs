using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityNameChecker;
using System.Collections.Generic;

namespace CityNameUnitTest
{
    [TestClass]
    public class CityNameCheckerTest
    {
        [TestMethod]
        public void GetCities_WithoutInput_ShouldReturnBangkokAndTokyo()
        {
            // Arrange
            var stubRestClient = new FakeRestClient();
            var controller = new CityController(stubRestClient);

            // Act
            var cityList = controller.GetCities();
            var cities = cityList.cities;

            // Assert
            Assert.IsNotNull(cityList);

            Assert.IsTrue(cities != null);
            Assert.IsTrue(cities.Count == 2);

            City c1 = cities[0];
            Assert.IsTrue(c1.name.Equals("Bangkok", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(c1.country.Equals("Thailand", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(c1.code.Equals("th", StringComparison.OrdinalIgnoreCase));

            //City c2 = cities[1];
            //Assert.IsTrue(c2.name == "Tokyo");
            //Assert.IsTrue(c2.country == "Japan");
            //Assert.IsTrue(c2.code == "jp");
        }

        [TestMethod]
        public void GetCities_WithStringBangk_ShouldReturnBangkok()
        {
            throw new NotImplementedException();
        }
    }
}
