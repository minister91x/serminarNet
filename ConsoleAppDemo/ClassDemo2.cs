
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
}
