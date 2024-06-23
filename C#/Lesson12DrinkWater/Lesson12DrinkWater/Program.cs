using Lesson12DrinkWater.Models;
using Lesson12DrinkWater.Services;
using System.Text.Json;

//var panel = new ControlPanel();
//panel.Start();
User? user = null;
if (File.Exists("user.json"))
{
    var json = File.ReadAllText("user.json");
    user = JsonSerializer.Deserialize<User>(json);
}
if(user is null)
{
    user = new User();
    // input
}


//while (true)
//{
//    Console.WriteLine("1. Su ich");
//    Console.WriteLine("2. Tarixche");
//    Console.WriteLine("3. Gunu bitir");
//    Console.WriteLine("4. Chixish");

//    // input
//    switch (switch_on)
//    {
//        case 1: user.CurrentLitr += 1; break;
//        default:
//    }
//}
