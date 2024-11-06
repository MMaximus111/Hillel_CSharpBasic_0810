// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Hour[][] hours =
[
    new Hour[]
    {
        new Hour { Number = 0, Note = "" },
        new Hour { Number = 1, Note = "" },
        new Hour { Number = 2, Note = "" },
        new Hour { Number = 3, Note = "" },
        new Hour { Number = 4, Note = "" },
        new Hour { Number = 5, Note = "" },
        new Hour { Number = 6, Note = "" },
        new Hour { Number = 7, Note = "" },
        new Hour { Number = 8, Note = "" },
        new Hour { Number = 9, Note = "" },
        new Hour { Number = 10, Note = "" },
        new Hour { Number = 11, Note = "" },
        new Hour { Number = 12, Note = "" },
        new Hour { Number = 13, Note = "" },
        new Hour { Number = 14, Note = "" },
        new Hour { Number = 15, Note = "" },
        new Hour { Number = 16, Note = "" },
        new Hour { Number = 17, Note = "" },
        new Hour { Number = 18, Note = "" },
        new Hour { Number = 19, Note = "" },
        new Hour { Number = 20, Note = "" },
        new Hour { Number = 21, Note = "" },
        new Hour { Number = 22, Note = "" },
        new Hour { Number = 23, Note = "" },
    },
];

PrintTimeTable();


while (true)
{
    Console.WriteLine("Possible commands: ADD/DELETE");
    Console.Write("Enter command: ");
    string command = Console.ReadLine()!;

    if (string.Equals(command, "ADD", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("Enter day: ");
        string day = Console.ReadLine()!;
        
        Console.Write("Enter hour: ");
        byte hour = byte.Parse(Console.ReadLine()!);
        
        Console.Write("Enter note: ");
        string note = Console.ReadLine()!;
        
        hours[(int)Enum.Parse<Day>(day)][hour].Note = note;
        
        PrintTimeTable();
    }
    else if (string.Equals(command, "DELETE", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("Enter day: ");
        string day = Console.ReadLine()!;
        
        Console.Write("Enter hour: ");
        byte hour = byte.Parse(Console.ReadLine()!);
        
        hours[(int)Enum.Parse<Day>(day)][hour].Note = string.Empty;
        
        PrintTimeTable();
    }
    else
    {
        Console.WriteLine("Invalid command");
    }
}


void PrintTimeTable()
{
    Console.Clear();
    Console.WriteLine();
    
    Day[] days = new Day[]
    {
        Day.Monday,
        Day.Tuesday,
        Day.Wednesday,
        Day.Thursday,
        Day.Friday,
        Day.Saturday,
        Day.Sunday
    };

    foreach (Day day in days)
    {
        try
        {
            Hour[] allHourFromDay = hours[(int)day];
        
            Console.WriteLine($"Day: {day}");
        
            foreach (Hour hour in allHourFromDay)
            {
                Console.WriteLine($"Hour: {hour.Number}, Note: {hour.Note}");
            }
        
            Console.WriteLine();
        }
        catch (IndexOutOfRangeException)
        {
            continue;
        }
    }
}


enum Day
{
    Monday = 0,
    Tuesday = 1,
    Wednesday = 2,
    Thursday = 3,
    Friday = 4,
    Saturday = 5,
    Sunday = 6
}

class Hour
{
    public byte Number { get; set; }
    
    public string Note { get; set; }
} 