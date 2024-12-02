
using Lesson14;

    // Vehicle vehicle = new Vehicle(CarColor.Blue);

Console.WriteLine("fdfdfdf");

// Mercedes mercedes = new Mercedes(CarColor.Blue);
//
// WeatherDto weather = new WeatherDto
// {
//     Temperature = 343
// };
// using ResultSuccess;
//
// int x;
//
//
// MyTask task1 = new MyTask("task name");
// MyTask task2 = new MyTask("task name");
// MyTask task3 = new MyTask("XXX");
//
// MyTask task4 = new MyTask("task name", true);
//
// Result result = task4.AddSubtask(task2);
//
// if (!result.IsSuccess)
// {
//     Console.WriteLine(result.ErrorObj.ErrorMessage);
// }
//
// MyTask task5 = new MyTask()
// {
//     IsCompleted = true,
// };
//
// Singleton singleton1 = Singleton.Instance;
//
// WeatherDto weather = new WeatherDto
// {
//     City = "New York",
//     Country = "US",
//     Description = "Sunny",
//     Temperature = 25
// };
//
//
MyTask task1 = new MyTask("task name");

Console.WriteLine(task1.Name);

class MyTask
{
    // Fields
    private string _name;
    private int _readsCount;
    private int _setCount;
    public readonly DateTime _createdAt;
    
    public MyTask(string name)
    {
        Name = name;
        IsCompleted = false;
        _createdAt = DateTime.Now;
    }

    public MyTask(string name, bool isCompleted)
    {
        Name = name;
        IsCompleted = isCompleted;
        _createdAt = DateTime.Now;
    }

    public MyTask()
    {
        _createdAt = DateTime.Now;
    }

    public string Name
    {
        get
        {
            _readsCount++;
            return _name;
        }
        private set
        {
            _setCount++;

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Task name cannot be null or empty");
            }

            if (value == "XXX")
            {
                throw new Exception("Task name cannot be XXX");
            }

            _name = value;
        }
    }

    public bool IsCompleted { get; init; }
    
    // public Result AddSubtask(MyTask subtask)
    // {
    //     if (IsCompleted)
    //     {
    //         return Result.Error("Cannot add subtask to completed task");
    //     }
    //     
    //     Name = $"{Name} - {subtask.Name}";
    //     
    //     return Result.Success();
    // }
}
//
// class Singleton
// {
//     private static Singleton? instance;
//     
//     private Singleton()
//     {
//     }
//     
//     public static Singleton Instance
//     {
//         get
//         {
//             if (instance == null)
//             {
//                 instance = new Singleton();
//             }
//             return instance;
//         }
//     }
// }
//
//
public class WeatherDto
{
    public required string City { get; init; }
    public string Country { get; init; }
    public string Description { get; init; }
    public required double Temperature { get; init; }
}
//
