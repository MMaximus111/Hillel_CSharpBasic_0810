// int[] numbers = { 1, 2, 3, 4, 5 };
// string[] names = { "wewe", "dfdfdfdf" };
//
// // foreach (var number in numbers)
// // {
// //     Console.WriteLine(number);
// // }
//
// Console.WriteLine(numbers[2]);


// string[] students = new string[12];
//
// Console.WriteLine(students.Length);


//


// Car[] cars;
//
// class Car
// {
//     public string MaxSpeed { get; init; }
// }
//
// students = new string[1];
//
// Console.WriteLine(students.Length);


// for (int i = 0; i < students.Length; i++)
// {
//     Console.Write("Enter username: ");
//     students[i] = Console.ReadLine()!;
// }
//
// foreach (string student in students)
// {
//     Console.WriteLine(string.IsNullOrEmpty(student) ? "empty box" : student);
// }
//
// Console.WriteLine(students[12]);


// int[][] jaggedArray =
// [
//     [1, 3, 5, 7, 9],
//     [0, 2, 4, 6],
//     [11, 22]
// ];
//
// foreach (int[] array in jaggedArray)
// {
//     foreach (int number in array)
//     {
//         Console.Write(number);
//     }
// }


// int[,] matrix = new int[3, 3];

// int[,,] multiDimensionalArray3D = new int[3, 3, 3];

// for (int i = 0; i < matrix.Length; i++)
// {
//     Console.WriteLine(matrix[i, 0]);
// }

// DaysOfTheWeek day = DaysOfTheWeek.Wednesday;
//
// if (day == DaysOfTheWeek.Sunday)
// {
//     Console.WriteLine("It's Sunday!");
// }
// else
// {
//     Console.WriteLine("It's not Sunday!");
// }
//
// int dayNumber = (int)day;

// Console.WriteLine(dayNumber);

DaysOfTheWeek[] weekends = new[] { DaysOfTheWeek.Saturday, DaysOfTheWeek.Sunday };

foreach (var weekend in weekends)
{
    Console.WriteLine(weekend);
}


string? numberText = null;

Console.WriteLine(Convert.ToInt32(numberText));


enum DaysOfTheWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

enum Cars
{
    BMW,
    Mercedes,
    Audi,
    Toyota,
    Honda
}