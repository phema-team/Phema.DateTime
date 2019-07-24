using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Phema.DateTime.Test.Tests
{
	using System;

	public class DateTimeTests
	{
		[Fact]
		public void TestDateTime()
		{
			var dateTime = new ServiceCollection()
				.AddTestDateTime(new DateTime(2012, 12, 12))
				.BuildServiceProvider()
				.GetRequiredService<IDateTime>();

			Assert.Equal(new DateTime(2012, 12, 12), dateTime.Now);
		}
	}
}