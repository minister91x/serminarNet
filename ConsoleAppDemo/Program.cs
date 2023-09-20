// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var demo = new ClassDemo();
demo.ID = 10;

var jsonData = JsonConvert.SerializeObject(demo);
Console.WriteLine("demo {0}:", jsonData);


Employee employee = new Employee()
{
    EmployeeId = "E001",
    FirstName = "John",
    LastName = "Deo"
};

Console.WriteLine("Record {0}", employee);
const string constantAttribute = "awesome";
const string constantMessage = $"Code maze is {constantAttribute}.";

Console.WriteLine(constantMessage);

Console.ReadKey();