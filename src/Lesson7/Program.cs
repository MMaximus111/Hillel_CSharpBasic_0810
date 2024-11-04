double x = 12.365;
decimal y = 455.55m;
//
// int q = 222222222222222;
// long s = -2222222222222222222;

// =
// == 

// if (true) ;
//
// if (true)
// {
//     
// }

// for (; ; )
// {
//    Console.WriteLine("Hello");
// }

// PrintHello("Maxim", "454545");
// PrintHello("Maxim", "454545");
// PrintHello("Maxim", "454545");
// PrintHello("Maxim", "454545");
// PrintHello("Maxim", "454545");
//
// void PrintHello(string name, string name2)
// {
//     Console.WriteLine("Hello " + name);
// }


// int age = 18;
//
// int maximumAgeToBecomePilot = 42;
//
// if (age < 42)
// {
//     
// }



// char[] specialCharsForPassword = new[] { '@', '?', '*' };
//
// foreach (char c in "@?*")
// {
//    
// }
//
// foreach (char c in specialCharsForPassword)
// {
//     
// }

// Console.WriteLine(Math.Sqrt(121));

// const byte DepositPercentPerMonth = 7;
//
// Console.Write("Enter deposit month quantity: ");
// byte depositMonthQuantity = byte.Parse(Console.ReadLine()!);
//
// Console.WriteLine();
// Console.Write("Enter deposit: ");
// decimal deposit = decimal.Parse(Console.ReadLine()!);
//
// for (int i = 0; i < depositMonthQuantity; i++)
// {
//     deposit += deposit * DepositPercentPerMonth / 100;
// }
//
// Console.WriteLine($"Total amount: {deposit}");

Console.OutputEncoding = System.Text.Encoding.UTF8;

int firstNumberInt = 0;
int secondNumberInt = 0;
int countOfErrors = 0;

while (true)
{
    if (countOfErrors == 3)
    {
        Console.WriteLine("Не тупи!");
    }
    
    Console.Write("Enter first number: ");
    string firstNumber = Console.ReadLine()!;

    if (IsExitWasEntered(firstNumber))
    {
        return;
    }
    
    if(!TryParseAndValidateNumber(firstNumber, out firstNumberInt))
    {
        Console.WriteLine("Invalid number. Please try again.");
        countOfErrors++;
        continue;
    }
    
    Console.Write("Enter second number: ");
    string secondNumber = Console.ReadLine()!;
    
    if (IsExitWasEntered(secondNumber))
    {
        return;
    }
    
    if(!TryParseAndValidateNumber(secondNumber, out secondNumberInt))
    {
        Console.WriteLine("Invalid number. Please try again.");
        countOfErrors++;
        continue;
    }
    
    break;
}

Console.WriteLine($"Multiply: {firstNumberInt * secondNumberInt}");

bool TryParseAndValidateNumber(string numberString, out int number)
{
    if (!int.TryParse(numberString, out number))
    {
        return false;
    }

    if (number < 0 || number > 10)
    {
        number = 0;
        return false;
    }

    return true;
}

bool IsExitWasEntered(string input)
{
    return input == "exit";
}