using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void TestGet()
        {
            var returnValue = controller.Get();
            Assert.NotNull(returnValue);
        }

        
        [Fact]
        public void Test1()
        {

        }
    }
}
