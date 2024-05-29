using Producer;
using Shared.Interfaces;

namespace OrdersWebApp.Extensions
{
    public static class ServiceProviderExtensions
    {
        /// <summary>
        /// Регистрирует сервисы для работы с RabbitMQ.
        /// </summary>
        /// <param name="services">Коллекция, в которой хранятся все зарегистрированные сервисы</param>
        public static void AddProducerServices(this IServiceCollection services)
        {
            services.AddTransient<IRabbitMqService, RabbitMqService>();
        }
    }
}
