using Dapper;
using Microsoft.Data.Sqlite;

namespace Lesson16;

public class StudentsRepository
{
    private const string connectionString = "Data Source=M:\\hillel.sqlite;";

    internal void AddStudent(string name, int age)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            
            const string query = "INSERT INTO students (Name, Age) VALUES (@Name, @Age);";
            
            connection.ExecuteScalar<int>(query, new { Name = name, Age = age} );
        }
    }

    internal void UpdateStudent(int id, string name, int age)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var query = "UPDATE students SET Name = @Name, Age = @Age WHERE Id = @Id;";
            connection.Execute(query, new { Id = id, Name = name, Age = age });
            Console.WriteLine($"Student with ID {id} updated.");
        }
    }

    internal void DeleteStudent(int id)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var query = "DELETE FROM students WHERE Id = @Id;";
            connection.Execute(query, new { Id = id });
            Console.WriteLine($"Student with ID {id} deleted.");
        }
    }

    internal void DisplayStudents()
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM students WHERE id > 70;";
            Student[] students = connection.Query<Student>(query).ToArray();
            
            Console.WriteLine("\nList of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }
    }
}