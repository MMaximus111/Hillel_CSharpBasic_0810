// Wolf wolf = new Wolf();
//
// wolf.Heartbeat();
//
// Snake snake = new Snake();
//
// snake.Heartbeat();

using System.Collections;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

List<Wolf> wolves = new List<Wolf>
{
    new Wolf("W1", 123),
    new Wolf("W2", 234),
    new Wolf("W3", 345)
};

Dictionary<string, int> userAges = new Dictionary<string, int>
{
    ["John"] = 30,
    ["Jane"] = 25
};

Stack<string> names = new Stack<string>();

names.Push("John");

string name = names.Pop();

Queue<string> namesQueue = new Queue<string>();

namesQueue.Enqueue("John");

string nameFromQueue = namesQueue.Dequeue();


ArrayList list = new ArrayList();

// LIFO


// CustomList<string> names = new CustomList<string>();
//
// names.Add("John");
// names.Add("Jane");
//
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// Person person1 = new Person("John", "Doe");
// Person person2 = new Person("John", "Doe");
//
// int age = 67;
//
// Console.WriteLine(person1 == person2);

// object animal = new Wolf();
//
// Console.WriteLine(animal.ToString());

// ILiveObject snakeAnimal = new Snake();
//
// snakeAnimal.Heartbeat();
//
// if (snakeAnimal is Snake snake1)
// {
//     snake1.Slither();
// }

// IReadOnlyCollection<string> namesToSayHello = GetNamesToSayHello();
//
// Console.WriteLine($"There are {namesToSayHello.Count} names to say hello to.");
//
// foreach (string name in namesToSayHello)
// {
//     Console.WriteLine($"Hello, {name}!");
// }
//
// IReadOnlyCollection<string> GetNamesToSayHello()
// {
//     return new List<string>
//     {
//         "John",
//         "Jane",
//         "Jack",
//         "Jill"
//     };
// }

// Wolf wolf1 = new Wolf("W1", 123);
// object wolf2 = new Wolf("W1", 123);
//
// Console.WriteLine(wolf1.Equals(wolf2));
// Console.WriteLine(wolf1.GetHashCode());



// class BankAccount
// {
//     public decimal Balance { get; private set; }
//     
//     public void Deposit(decimal amount)
//     {
//         if (amount <= 0)
//         {
//             throw new ArgumentException("Deposit amount must be greater than zero.");
//         }
//         
//         Balance += amount;
//         
//         SendSms($"You have deposited {amount}.");
//         
//         Console.WriteLine($"Your new balance is {Balance}.");
//     }
//
//     private void SendSms(string message)
//     {
//         
//     }
// }

class Wolf : Animal
{
    public Wolf(string name, int age)
        : base(name, age)
    {
    }

    public void Howl()
    {
        Console.WriteLine($"{Name} is howling.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }

    public override string ToString()
    {
        return $"Name: {Name} Age: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Wolf otherWolf)
        {
            return Name == otherWolf.Name && Age == otherWolf.Age;
        }

        return false;
    }
}

class Snake : Animal
{
    public Snake()
        : base(nameof(Snake), 12)
    {
    }

    public void Slither()
    {
        Console.WriteLine($"{Name} is slithering.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }

    public override void Heartbeat()
    {
        Console.WriteLine("Snake strange heartbeat");
        Console.WriteLine("Snake strange heartbeat");
        Console.WriteLine("Snake strange heartbeat");
    }
}

abstract class Animal : IAnimal, ILiveObject
{
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; }
    
    public int Age { get; }

    public abstract void Eat();

    public abstract void Sleep();

    public abstract void Move();

    public virtual void Heartbeat()
    {
        Console.WriteLine("Simple heartbeat");
        Console.WriteLine("Simple heartbeat");
        Console.WriteLine("Simple heartbeat");
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Age.GetHashCode();
    }
}

interface IAnimal
{
    void Eat();
    void Sleep();
    void Move();
}

interface ILiveObject
{
    void Heartbeat();
}

class CustomList<T> : IEnumerable<T>
{
    private readonly List<T> _list = new List<T>();

    public void Add(T item)
    {
        _list.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

record Person(string FirstName, string LastName);

record HomeTask
{
    public string? Title { get; init; }

    public string? Description { get; init; }
}

record Student : Person
{
    public Student(string firstName, string lastName, string studentId)
        : base(firstName, lastName)
    {
        StudentId = studentId;
    }

    public string StudentId { get; }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}