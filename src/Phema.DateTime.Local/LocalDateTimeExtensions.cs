using Microsoft.Extensions.DependencyInjection;
using Phema.DateTime.Internal;

namespace Phema.DateTime
{
	public static class LocalDateTimeExtensions
	{
		public static IServiceCollection AddLocalDateTime(this IServiceCollection services)
		{
			return services.AddDateTime<LocalDateTime>();
		}
	}
}