//string text = "ededed";

using Lesson10;
using Lesson9;

String text = new String("Усатенко  Максим       Володимирович   ");
//
// Console.WriteLine(text.Length);
//
//
// foreach (char c in text)
// {
//     
// }
//
// foreach (char c in text.Where(x => x == 'q'))
// {
//     
// }
//
// bool wContains = text.Contains('w');
//
//string trimmedText = text.Trim('1');
//
// Console.WriteLine(trimmedText);
//
// Console.WriteLine(trimmedText.Substring(6));

// foreach (string splittedStringPart in trimmedText.Split('o'))
// {
//  Console.WriteLine(splittedStringPart);
// }

Console.OutputEncoding = System.Text.Encoding.UTF8;
//
// string[] splittedInitials = text.Split().Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).ToArray();
//
// foreach (string initial in splittedInitials)
// {
//     Console.WriteLine(initial);
// }
//
// if (splittedInitials.Length != 3)
// {
//     throw new Exception("Incorrent initials");
// }
//
// string lastName = splittedInitials[0];
// string firstName = splittedInitials[1];
// string middleName = splittedInitials[2];
//
// if (!char.IsUpper(firstName[0]))
// {
//     throw new Exception("First name should start with upper case letter");
// }

// string replacedText = text.Replace("о", "*");
// //
// // Console.WriteLine(replacedText);
//
// string upperText = text.ToUpper();
// string lowerText = text.ToLower();
//
// Console.WriteLine(text.Remove(5, 10));
//
// // ctrl + k + d
//
// string cardNumber = "1111 2222 3333 4444";
//
// string maskedCardNumber = string.Join(" ", cardNumber.Split(" ").Select((x, i) =>
// {
//     if (i % 2 == 0)
//     {
//         return new string('*', x.Length);
//     }
//
//     return x;
// }));
//
// Console.WriteLine(maskedCardNumber);


// StringBuilder sb = new StringBuilder();
//
// sb.Append("Hello");
// sb.Append(" ");
// sb.Append("World");
//
// sb.Clear();
//
// Console.WriteLine(sb.ToString());

// Car car = new Car(CarColor.Blue);
//
// // car.CurrentSpeed = 100;
//
// Console.WriteLine(car.CurrentSpeed);
// Console.WriteLine(Car.MaxSpeed);
// Console.WriteLine(car.Color);
//
// Console.WriteLine(Car.ValidateCarPlate("AA1234AA"));


// int z = 5;
// Human maxim = new Human() {Name = "123", Age = 12};
//
// User user = new User();
//
// PrintHuman(maxim);
// PrintInt(z);
//
// void PrintInt(int num)
// {
//     Console.WriteLine(num);
// }
//
// void PrintHuman(Human human)
// {
//     Console.WriteLine(human.Name);
// }
//
// public class PublicClass
// {
//     
// }
//
// internal class InternalClass
// {
//     
// }
//
//

PrintNumbers(2, 4, 6, 7, 8);

void PrintNumbers(params int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}