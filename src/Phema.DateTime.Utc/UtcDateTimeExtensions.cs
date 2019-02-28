using Microsoft.Extensions.DependencyInjection;

namespace Phema.DateTime
{
	public static class UtcDateTimeExtensions
	{
		public static IServiceCollection AddPhemaUtcDateTime(this IServiceCollection services)
		{
			return services.AddPhemaDateTime<UtcDateTime>();
		}
	}
}