

try 
{
    SendMessageToViber(Console.ReadLine()!);
}
catch (ViberException ex)
{
    Console.WriteLine("Введений номер пустий");
}
catch
{
    Console.WriteLine("Something went wrong");
}


static void SendMessageToViber(string phone)
{
    if (string.IsNullOrEmpty(phone))
    {
        throw new ViberException("Phone number is empty");
    }
}


class ViberException : Exception
{
    public ViberException(string errorText)
        : base(errorText)
    {
    }
}


