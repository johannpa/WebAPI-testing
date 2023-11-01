using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;

namespace WebAPI.Tests
{
    public class WeatherForecastControllerTest
    {
        private readonly WeatherForecastController _weatherForecastController;

        public WeatherForecastControllerTest()
        {
            _weatherForecastController = new WeatherForecastController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnOkResult()
        {
            //Arrange - create a new instance of the class we want to test - this where you would prepare everything for the test, prepare for testing

            //Act - this is where the method we are testing is executed
            var okResult = _weatherForecastController.Get();

            //Assert - this is the final part of the test, where we check that the method we are testing returns the expected value
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsFiveItems()
        {
            // Act
            var okResult = _weatherForecastController.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<WeatherForecast[]>(okResult.Value);
            Assert.Equal(5, items.Length);
        }
    }
}