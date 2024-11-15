namespace Lesson10;

public class Car
{
    public const int MaxSpeed = 200;

    public Car(CarColor color)
    {
        Color = color;
    }
    
    public int CurrentSpeed { get; private set; }
    
    public CarColor Color { get; }
    
    public void Accelerate()
    {
        // a lot of engine things
        
        AddGasToEngine();
    }
    
    public void Brake()
    {
        AddOilToBreakSystem();
        
        CurrentSpeed = 0;
    }

    private void AddOilToBreakSystem()
    {
        
    }
    
    private void AddGasToEngine()
    {
        RotateWheels();
    }

    private void RotateWheels()
    {
        CurrentSpeed += 10;
    }

    public static bool ValidateCarPlate(string plate)
    {
        return true;
    }
}