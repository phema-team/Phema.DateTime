using Microsoft.Extensions.DependencyInjection;

namespace Phema.DateTime
{
	public static class LocalDateTimeExtensions
	{
		public static IServiceCollection AddPhemaLocalDateTime(this IServiceCollection services)
		{
			return services.AddPhemaDateTime<LocalDateTime>();
		}
	}
}