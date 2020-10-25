using System;
using Xunit;

namespace BLL.Test
{
	public class WeatherForecastServiceTest
	{
		[Fact]
		public void Should_Return_Forecasts()
		{
			var service = new WeatherForecastService();
			var forecasts = service.Get();
			Assert.NotEmpty(forecasts);
		}
	}
}
