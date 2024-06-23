using Lesson12DrinkWater.Models;
using System.Text.Json;

namespace Lesson12DrinkWater.Services;

internal class ControlPanel
{
    public User? User { get; set; }

    public ControlPanel()
    {
        Initalize();
    }

    private void Initalize()
    {
        if (File.Exists("user.json"))
        {
            var json = File.ReadAllText("user.json");
            User = JsonSerializer.Deserialize<User>(json);
        }
        if (User is null)
        {
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Weight:");
            double.TryParse(Console.ReadLine(), out double weight);
            User = new User()
            {
                CurrentDate = DateTime.Now,
                Name = name,
                Weight = weight,
                CurrentLitr = 0,
                History = new List<HistoryItem>()
            };
        }
    }

    public void SaveChanges()
    {
        var json = JsonSerializer.Serialize(User);
        File.WriteAllText("user.json", json);
    }

    public void EndDate()
    {
        if (User is null) throw new Exception("User not found");

        var item = new HistoryItem(User.CurrentDate.ToString("dd.MM.yyyy"), User.CurrentLitr);
        User.History.Add(item);

        User.CurrentDate = User.CurrentDate.AddDays(1);
        User.CurrentLitr = 0;
    }

    public void DrinkWater()
    {
        if (User is null) throw new Exception("User not found");

        Console.Clear();

        Console.WriteLine("Litr:");
        double.TryParse(Console.ReadLine(), out double litr);
        User.CurrentLitr += litr;
    }

    public void ShowHistory()
    {
        if (User is null) throw new Exception("User not found");
        Console.Clear();

        Console.WriteLine("Date       | Litr ");
        foreach (var item in User.History)
        {
            Console.WriteLine($"{item.Date} | {item.Litr}");
        }
    }


    public void Start()
    {
        //for (int i = 0; i < 4; i++)
        //{
        //    DrinkWater();
        //    DrinkWater();
        //    DrinkWater();
        //    EndDate();
        //}
        //DrinkWater();
        //ShowHistory();
        //SaveChanges();
        while (true)
        {
            Console.WriteLine("1. Su ich");
            Console.WriteLine("2. Tarixche");
            Console.WriteLine("3. Gunu bitir");
            Console.WriteLine("4. Chixish");

            // input
            switch (switch_on)
            {
                case 1: DrinkWater(); break;
                case 2: ShowHistory(); break;
                default:
            }
        }
    }

}
