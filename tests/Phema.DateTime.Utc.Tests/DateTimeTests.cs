using System;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Phema.DateTime.Utc.Tests
{
	public class DateTimeTests
	{
		[Fact]
		public void UtcDateTime()
		{
			var dateTime = new ServiceCollection()
				.AddUtcDateTime()
				.BuildServiceProvider()
				.GetRequiredService<IDateTime>();

			Assert.True(Math.Abs(System.DateTime.UtcNow.Ticks - dateTime.Now.Ticks) < 1000);
		}
	}
}