using Microsoft.Extensions.DependencyInjection;

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