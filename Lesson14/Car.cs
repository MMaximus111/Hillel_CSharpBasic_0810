namespace Lesson14;


public abstract class PaymentGateway
{
    public abstract string BaseUrl { get; }
    
    public abstract string CreatePaymentLink(decimal amount);
    
    public abstract void ExpirePaymentLink();
    
    public void NotifyClientViaSms(string phone, string message)
    {
        Console.WriteLine("Notifying client via SMS...");
    }
}

public class MonobankGateway : PaymentGateway
{
    public override string BaseUrl { get; } = "https://monobank.com";

    public override string CreatePaymentLink(decimal amount)
    {
        NotifyClientViaSms("1234567890", "Payment link was created. You have 24 hours to pay");
        
        return $"https://monobank.com/pay?amount={amount}";
    }
    
    public override void ExpirePaymentLink()
    {
        Console.WriteLine("Monobank payment link expired");
    }
}

public class Privat24Gateway : PaymentGateway
{
    public override string BaseUrl { get; } = "https://privat24.com";

    public override string CreatePaymentLink(decimal amount)
    {
        return "Https://priv";
    }
    
    public override void ExpirePaymentLink()
    {
        Console.WriteLine("Privat24 payment link expired");
    }
}



public abstract class Engine
{
    public abstract void Start();
    
    public abstract void Stop();
    
    public abstract void Accelerate();
}

public abstract class Vehicle
{
    public Vehicle(byte wheelsQuantity)
    {
        WheelsQuantity = wheelsQuantity;
    }
    
    protected byte WheelsQuantity { get; }
}

public class Train : Vehicle
{
    public Train()
    : base(16)
    {
    }
}

public class Car : Vehicle
{
    protected Car(CarColor color)
    : base(4)
    {
        Color = color;
    }
    
    public CarColor Color { get; }
    
    public string Model { get; set; }
    
    public void Drive()
    {
        Console.WriteLine("Driving...");
    }
}

public class Mercedes : Car
{
    public Mercedes(CarColor color)
    : base(color)
    {
        Model = "Mercedes";
    }
}

public class Toyota : Car
{
    public Toyota(CarColor color)
        : base(color)
    {
        Model = "Toyota";
    }
}


public enum CarColor
{
    Red,
    Blue,
    Green
}