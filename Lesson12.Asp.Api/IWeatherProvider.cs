namespace Lesson12.Asp.Api;

public interface IWeatherProvider
{
    WeatherForecast[] GetForecast(DateTime dateTime);
}