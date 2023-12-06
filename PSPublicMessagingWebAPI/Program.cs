using MassTransit;
using PSPublicMessagingAPI.Application;
using PSPublicMessagingAPI.Infrastructure;
using PSPublicMessagingWebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetKebabCaseEndpointNameFormatter();
    //busConfigurator.AddConsumer<NotificationCreatedConsumer>();
    busConfigurator.UsingRabbitMq((context, configurator) =>
    {
        //configurator.Host(new Uri("amqp://guest:guest@localhost:5672"), h => { }
        configurator.Host(new Uri(builder.Configuration["MessageBroker:Host"]!), h =>
    {
        h.Username(builder.Configuration["MessageBroker:Username"]);
        h.Password(builder.Configuration["MessageBroker:Password"]);

    }
            );
        configurator.ConfigureEndpoints(context);
    });
    
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseCustomExceptionHandler();

app.MapControllers();
app.Run();
