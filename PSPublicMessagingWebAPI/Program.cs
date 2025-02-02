using Carter;
using MassTransit;
using PSPublicMessagingAPI.Application;
using PSPublicMessagingAPI.Infrastructure;
using PSPublicMessagingAPI.Infrastructure.BackgroundJobs;
using PSPublicMessagingWebAPI.Extensions;
using Quartz;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddCarter();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter(prefix: "ps", includeNamespace: false));
    //busConfigurator.AddConsumer<NotificationCreatedConsumer>();
    
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

builder.Services.AddQuartz(configure =>
{
    var jobKey = new JobKey(nameof(ProcessOutboxMessegaesJob));

    configure.AddJob<ProcessOutboxMessegaesJob>(jobKey)
        .AddTrigger(
            trigger =>
                trigger.ForJob(jobKey)
                    .WithSimpleSchedule(
                        schedule => schedule.WithIntervalInSeconds(10)
                            .RepeatForever()));
    configure.UseMicrosoftDependencyInjectionJobFactory();
});
builder.Services.AddQuartzHostedService();
var app = builder.Build();
app.ApplyMigrations();
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
//app.MapCarter();
app.Run();
