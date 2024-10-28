// int j = 0;
//
// while (j < 10)
// {
//     Console.WriteLine(j);
//     j++;
// }


// Point123:
//
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//
//     if (i == 5)
//     {
//         goto Point123;
//     }
// }
//
//
//
// Console.WriteLine();
//
// for (int i = 10; i < 20; i++)
// {
//     Console.WriteLine(i);
// }

// int[] ages = { 10, 20, 30, 40, 50 };

//char[] charArray = { 'm', 'a', 'x', 'i', 'm' };


// string name = "sdsdsd";
//
//
// foreach (char chatItem in charArray)
// {
//     Console.WriteLine(chatItem);
// }

// foreach (char nameChar in charArray)
// {
//     Console.Write(nameChar);
// }

internal class Program
{
    private static void Main(string[] args)
    {
        // task 1
        decimal totalSalary = 0;

        Console.WriteLine("Enter the number of workers: ");

        int numberOfWorkers = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= numberOfWorkers; i++)
        {
            Console.WriteLine($"Enter {i} Worker Salary: ");

            decimal workerSelery = decimal.Parse(Console.ReadLine()!);

            totalSalary += workerSelery;
        }

        Console.WriteLine($"Avarage Seleri: {totalSalary / numberOfWorkers}");
        
        // task 2

    }
}