using Lesson16;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// DriveInfo[] drives = DriveInfo.GetDrives();
//
// foreach (DriveInfo drive in drives)
// {
//     Console.WriteLine($"Назва: {drive.Name}");
//     Console.WriteLine($"Тип: {drive.DriveType}");
//
//     if (drive.IsReady)
//     {
//         Console.WriteLine($"Об'єм диска: {drive.TotalSize}");
//         Console.WriteLine($"Вільний простір: {drive.TotalFreeSpace}");
//         Console.WriteLine($"Мітка диска: {drive.VolumeLabel}");
//     }
//
//     Console.WriteLine();
// }

// var dir  =Directory.GetCurrentDirectory();
//
// Console.WriteLine($"Поточний каталог: {dir}");
//
// var files = Directory.GetFiles(dir);
//
// foreach (var file in files)
// {
//     Console.WriteLine(file);
// }

StudentsRepository repository = new StudentsRepository();

// foreach (int age in Enumerable.Range(0, 100))
// {
//     repository.AddStudent("Олексій", age);
// }

// repository.UpdateStudent(1, "Максим", 19);

// repository.DeleteStudent(2);

// repository.DisplayStudents();

// object o1 = new { Name = "Maxim"};
// object o2 = new { Name = "Maxim"};

int number = 77;

object numberObject = number;

number = (int)numberObject;


R1 r1 = new R1("Maxim");
R1 r2 = new R1("Maxim");



if (r1.Equals(r2))
{
    Console.WriteLine("Equals");
}
else
{
    Console.WriteLine("Not equals");
}


class C1{}

record R1(string Name);

interface ICar
{
    void Drive();
}

class Lexus : ICar
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

class Tesla : ICar
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

