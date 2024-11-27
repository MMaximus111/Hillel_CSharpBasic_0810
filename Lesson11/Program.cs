Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
//
// void PrintNumbers(params List<int> numbers)
// {
//     foreach (var number in numbers)
//     {
//         Console.WriteLine(number);
//     }
// }

// Console.Write("Enter your text: ");
// string text = Console.ReadLine()!;
//
// Console.WriteLine($"Result: {text.Split(' ', ',').Count(x => !string.IsNullOrWhiteSpace(x))}");


// using Lesson11;
//

// using Lesson11;
//
// string text = "Hello, World! 123 *";

// Console.WriteLine(text.HillelSubstring(5, 3));

// (int lettersCount, int numbersCount, int specialCharsCount) = text.CalculateSymbols();
//
// Console.WriteLine($"Letters: {lettersCount}, Numbers: {numbersCount}, Special chars: {specialCharsCount}");
//
// SymbolsStatistics statistics = text.CalculateSymbolsWithClassResult();
//
// Console.WriteLine($"Letters: {statistics.LettersCount}, Numbers: {statistics.NumbersCount}, Special chars: {statistics.SpecialCharsCount}");


// int x = 5;
//
// PrintNumber(ref x);
// PrintNumber(ref x);
//
//
// void PrintNumber(ref readonly int x)
// {
//     if (x == 7)
//     {
//         return;
//     }
//     
//     Console.WriteLine(x);
//     x = 10;
// }
//
// bool TryParseName(string name, out string result)
// {
//     if (name.Length > 5)
//     {
//         result = name;
//         return true;
//     }
//
//     result = string.Empty;
//     return false;
// }

// User user = new User
// {
//     Age = 25
// };

// PrintUser(user);
// PrintUser(user);
// PrintUser(user);
//
//
// void PrintUser(User user)
// {
//     Console.WriteLine(user.Age);
//     user.Age += 10;
// }
//
// class User
// {
//     public int Age { get; set; }
// }
//

// using Lesson11;
//
//
//
// string s = "1";
//
// if (CustomInt.TryParse(s, out int number))
// {
//     Console.WriteLine(number);
// }
// else
// {
//     Console.WriteLine("Failed to parse");
// }
