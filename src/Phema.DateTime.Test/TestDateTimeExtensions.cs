using System;
using Microsoft.Extensions.DependencyInjection;
using Phema.DateTime.Internal;
using Phema.DateTime.Test;

namespace Phema.DateTime
{
	public static class TestDateTimeExtensions
	{
		public static IServiceCollection AddTestDateTime(
			this IServiceCollection services,
			Action<TestDateTimeOptions> options = null)
		{
			options ??= o => { };

			return services.AddDateTime<TestDateTime>()
				.Configure(options);
		}

		public static IServiceCollection AddTestDateTime(
			this IServiceCollection services,
			System.DateTime dateTime)
		{
			return services.AddDateTime<TestDateTime>()
				.Configure<TestDateTimeOptions>(o => o.DateTimeNow = dateTime);
		}
	}
}