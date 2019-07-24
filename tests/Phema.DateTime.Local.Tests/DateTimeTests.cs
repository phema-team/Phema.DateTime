using System;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Phema.DateTime.Local.Tests
{
	public class DateTimeTests
	{
		[Fact]
		public void LocalTime()
		{
			var dateTime = new ServiceCollection()
				.AddLocalDateTime()
				.BuildServiceProvider()
				.GetRequiredService<IDateTime>();

			Assert.True(Math.Abs(System.DateTime.Now.Ticks - dateTime.Now.Ticks) < 1000);
		}
	}
}