

using MassTransit;
using PSNotificationServiceAPI.Consumers;
using PSNotificationServiceAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();



// Configure the HTTP request pipeline.
builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter(prefix: "ps", includeNamespace: false));
    busConfigurator.AddConsumer<NotificationCreatedConsumer>();

    busConfigurator.UsingRabbitMq((context, configurator) =>
    {
        //configurator.UseDelayedRedelivery(r => r.Intervals(TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(15), TimeSpan.FromMinutes(30)));
        //configurator.UseMessageRetry(r => r.Immediate(5));
        //configurator.UseInMemoryOutbox();
        //configurator.PrefetchCount = 16;
        //configurator.UseMessageRetry(r => r.Interval(2, 10));
        //configurator.Host(new Uri("amqp://guest:guest@localhost:5672"), h => { }
        configurator.Host(new Uri(builder.Configuration["MessageBroker:Host"]!), h =>
            {

                h.Username(builder.Configuration["MessageBroker:Username"]);
                h.Password(builder.Configuration["MessageBroker:Password"]);
                //h.Heartbeat(TimeSpan.FromSeconds(300));


            }
        );
        configurator.ConfigureEndpoints(context);
    });

});
var app = builder.Build();
app.UseHttpsRedirection();

app.UseAuthorization();
app.MapHub<NotificationHub>("/notifications");


app.Run();
