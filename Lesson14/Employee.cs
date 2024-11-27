namespace Lesson14;

public class Human
{
    public Human(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }
    
    public string Name { get; set; }
    
    public DateTime BirthDate { get; protected set; }
}

public class Employee : Human
{
    public Employee(string name, DateTime birthDate, EmployeeRole role)
    : base(name, birthDate)
    {
        Role = role;
    }
    
    public EmployeeRole Role { get; set; }
    
    public void Update(DateTime birthDate, EmployeeRole role)
    {
        BirthDate = birthDate;
        Role = role;
    }
}

public enum EmployeeRole
{
    Developer,
    Manager,
    Director
}