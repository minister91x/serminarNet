
global using ConsoleAppDemo;
global using Newtonsoft.Json;
namespace ConsoleAppDemo
{
    public record Employee
    {
        public string EmployeeId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public struct Maze
    {
        // Parameterless constructor with property initialization 
        public Maze()
        {
            Size = 10;
        }

        // Initialization of the property at its declaration
        public int Size { get; set; } = 10;
    }
}
