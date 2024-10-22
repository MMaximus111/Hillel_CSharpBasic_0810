// int x = 10;
// x += 2;
//
// int y = 10;
//
// y -= 2;
// y = y - 2;
//
// int z = 10;
// z *= 2;
// z = z * 2;
//
// int a = 10;
// a /= 2;
// a = a / 2;
//
// int b = 10;
// b %= 2;
// b = b % 2;
//
// b = (a + z) * y;
//
// int q = 10;
//
// q = q + 1;
// q += 1;
// q++;
//
// q -= 1;
// q = q - 1;
//
//
//
// q--;
// --q;
//
// q++;
// ++q;






// int y = 3;
// int b = 2;
//
// int x = b * ++y + (y + b);
//
// Console.WriteLine(x);


// ctrl + K + C
// ctrl + K + U

// int x = 10;
// int y = 20;
//
// bool result = x > y;
// result = x < y;
// result = x <= y;

// bool result = x >= y;

// && - AND
// || - OR

// byte i = 0;
//
// while (true && false)
// {
//     Console.WriteLine(i);
//     i++;
// }
//

// byte age;
// byte height;
// double weight;
//
// while (true)
// {
//     Console.WriteLine();
//     Console.Write("Enter your age: ");
//
//     if (byte.TryParse(Console.ReadLine(), out age) == false)
//     {
//         Console.WriteLine("Incorrect input age");
//         continue;
//     }
//
//     Console.Write("Enter your weight: ");
//     
//     if (double.TryParse(Console.ReadLine(), out weight) == false)
//     {
//         Console.WriteLine("Incorrect input weight");
//         age = 0;
//         continue;
//     }
//     
//     Console.Write("Enter your height: ");
//     
//     if (byte.TryParse(Console.ReadLine(), out height) == false)
//     {
//         Console.WriteLine("Incorrect input height");
//         age = 0;
//         weight = 0;
//         continue;
//     }
//     
//     break;
// }

// bool canAttendDangerousAmusement = age >= 18 && (height > 160 || weight > 50);

// if (age < 18)
// {
//     Console.WriteLine("You are too young");
// }
// else if (weight < 40)
// {
//     Console.WriteLine("You are too light");
// }
// else if (height < 150)
// {
//     Console.WriteLine("You are too short");
// }
// else if (height < 150)
// {
//     Console.WriteLine("You are too short");
// }
// else if (height < 150)
// {
//     Console.WriteLine("You are too short");
// }
// else
// {
//     Console.WriteLine("All okey");
// }

Console.Write("Enter user current age:");
switch (byte.Parse(Console.ReadLine()))
{
    case 18:
        Console.WriteLine("You are already adult");
        break;
    case 25:
    case 30:
    case 35:
    case 40:
    case 45:
    case 50:
        Console.WriteLine("Вітаємо з ювілеєм");
        break;
    case > 60 or < 18:
        Console.WriteLine("You are too old or too young");
        break;
    default:
        Console.WriteLine("Hello unknown user");
        break;
}

string text = byte.Parse(Console.ReadLine()) switch
{
    18 => "You are already adult",
    25 => "You are already adult",
    30 => "You are already adult",
    35 => "You are already adult",
    40 => "You are already adult",
    45 => "You are already adult",
    50 => "You are already adult",
};



