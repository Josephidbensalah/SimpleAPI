using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Joseph bens",returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
