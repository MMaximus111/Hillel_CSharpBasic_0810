using Lesson12.Asp.Api;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddSingleton<IWeatherProvider, BbcWeatherProvider>();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.MapGet("/tomorrow_weather_forecast", (IWeatherProvider weatherProvider) =>
{
    return weatherProvider.GetForecast(DateTime.Now.AddDays(1));
});

app.MapGet("/today_weather_forecast", (IWeatherProvider weatherProvider) =>
{
    return weatherProvider.GetForecast(DateTime.Now);
});

app.MapGet("/hello", () =>
    {
        return $"hello!!! {Random.Shared.Next(1, 100000)}";
    })
    .WithName("Hello");

app.Run();

