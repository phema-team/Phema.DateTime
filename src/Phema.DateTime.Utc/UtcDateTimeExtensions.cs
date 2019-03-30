using Microsoft.Extensions.DependencyInjection;
using Phema.DateTime.Internal;

namespace Phema.DateTime
{
	public static class UtcDateTimeExtensions
	{
		public static IServiceCollection AddUtcDateTime(this IServiceCollection services)
		{
			return services.AddDateTime<UtcDateTime>();
		}
	}
}