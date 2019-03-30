using Microsoft.Extensions.DependencyInjection;

namespace Phema.DateTime
{
	public static class DateTimeExtensions
	{
		public static IServiceCollection AddDateTime<TDateTime>(this IServiceCollection services)
			where TDateTime : class, IDateTime
		{
			return services.AddSingleton<IDateTime, TDateTime>();
		}
	}
}