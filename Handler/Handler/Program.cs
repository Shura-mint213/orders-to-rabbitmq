using Handler;
using Shared.Static;

internal class Program
{    /// <summary>
    /// Загрузка настроек для приложения
    /// </summary>
    /// <param name="configuration"></param>
    private static void SettingsLoad(IConfiguration configuration)
    {
        IConfigurationSection rebbitMqSection = configuration.GetSection("RabbitMQ");
        RabbitMqSettings.HostName = rebbitMqSection.GetValue<string>("HostName");
        RabbitMqSettings.Password = rebbitMqSection.GetValue<string>("Password");
        RabbitMqSettings.UserName = rebbitMqSection.GetValue<string>("UserName");
        RabbitMqSettings.Port = rebbitMqSection.GetValue<int>("Port");
    }

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        SettingsLoad(builder.Configuration);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHostedService<RabbitMqListener>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}