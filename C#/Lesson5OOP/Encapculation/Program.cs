using Encapculation.Models;

try
{
    var person = new Person
    {
        Id = 1,
        Age = -2
    };
}
catch (ArgumentOutOfRangeException aore)
{
    Console.WriteLine(aore.Message);
}
