// using System.Reflection;
//
// User user = new User
// {
//     Name = "John",
//     Age = 25
// };
// List<User> users = new List<User>();
//
// users.Add(user);
//
//
//
//
//
//
// Car car = new Car
// {
//     Model = "BMW",
//     Year = 2020
// };
//
// Car lexus = null;
//
// CustomSerializer.Serialize(lexus);
// CustomSerializer.Serialize(car);
//
// static class CustomSerializer
// {
//     public static void Serialize<X>(X typeForSerialization)
//     {
//         if (typeForSerialization is null)
//         {
//             return;
//         }
//     }
// }
//
// class User
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }
//
// class Car
// {
//     public string Model { get; set; }
//     public int Year { get; set; }
// }

// Printer myPrinter = new Printer();
//
// myPrinter.StartPrinting("Hello world", date => date.Hour >= 20);

// Messenger messenger = new Messenger();
//
// Messenger.Notify notify = x => Console.WriteLine($"User {x} notified in viber");
//
// notify += x => Console.WriteLine($"User {x} notified in telegram");
// notify += x => Console.WriteLine($"User {x} notified via email");
// notify += x => Console.WriteLine($"User {x} notified in discord");
//
// messenger.SendMessage("Hello", 777, notify);
//
// return;

// Predicate<int> checkSuccessNumber = x => x > 1000;
// Action<string> printer = text => Console.WriteLine(text);
// Func<int, int> addFiveToTheNumber = number => number + 5;
//
//
// double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
// // BCL - base class library
// // LINQ - Language Integrated Query
//
//
// foreach (double number in numbers.Where(x => x > 100))
// {
//     Console.WriteLine(number);
// }
//
// public static class CustomLinq
// {
//     public static List<T> Where<T>(this T[] items, Predicate<T> predicate)
//     {
//         List<T> successItems = new List<T>();
//         
//         foreach (T item in items)
//         {
//             bool success = predicate(item);
//
//             if (success)
//             {
//                 successItems.Add(item);
//             }
//         }
//
//         return successItems;
//     } 
// }

// class Printer
// {
//     public delegate bool DoesPrinterWorkNow(DateTime dateTime);
//
//     public void StartPrinting(string text, DoesPrinterWorkNow doesPrinterWorkNow)
//     {
//         Console.WriteLine("Check printer");
//
//         bool doesPrinterWork = doesPrinterWorkNow(DateTime.Now);
//
//         if (!doesPrinterWork)
//         {
//             Console.WriteLine("Printer not work. Sorry");
//             return;
//         }
//         
//         Console.WriteLine("Printing started");
//
//         Console.WriteLine(text);
//         
//         Console.WriteLine("Printing finished");
//     }
// }

// class Messenger
// {
//     public delegate void Notify(int userId);
//     
//     public void SendMessage(string text, int userId, Notify notify)
//     {
//         Console.WriteLine(text);
//
//         notify(userId);
//     }
// }

// PrintThread(ConsoleColor.Green);
// PrintThread(ConsoleColor.Blue);
// PrintThread(ConsoleColor.Red);

// Thread greenThread = new Thread(_ => PrintThread(ConsoleColor.Green));
//
// greenThread.Start();
//
// Thread blueThread = new Thread(_ => PrintThread(ConsoleColor.Blue));
//
// blueThread.Start();
//
// Thread redThread = new Thread(_ => PrintThread(ConsoleColor.Red));
//
// redThread.Start();
//
//
// void PrintThread(ConsoleColor color)
// {
//     Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//     
//     for (int i = 0; i < 10; i++)
//     {
//         Console.ForegroundColor = color;
//         
//         Console.WriteLine("|||");
//         
//         Thread.Sleep(1000);
//     }
// }


// int x = 0;
//
// Thread incrementThread = new Thread(_ => Increment1());
//
// Thread decrementThread = new Thread(_ => Decrement1());
//
// incrementThread.Start();
// decrementThread.Start();
//
// Thread.Sleep(7000);
//
// Console.WriteLine(x);
//
// void Increment1()
// {
//     for (int i = 0; i < 100000; i++)
//     {
//         x++;
//         //Thread.Sleep(1);
//     }
// }
//
// void Decrement1()
// {
//     for (int i = 0; i < 100000; i++)
//     {
//         x--;
//         //Thread.Sleep(1);
//     }
// }

Weather weather = new Weather();


string response = await weather.GetWeatherAsync();

Console.WriteLine(response);


public class Weather
{
    public async Task<string> GetWeatherAsync()
    {
        HttpClient client = new HttpClient();

        string response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?q=London&appid=3e");

        return response;
    }
}


//            8:00 - 9:00 | 9:00 - 10:00 | 10:00 - 11:00 | 11:00 - 12:00
// -----------------------------------
// monday |    dfdfdfdfdf      |            |          |
// tuesday |          |            |          |


// save