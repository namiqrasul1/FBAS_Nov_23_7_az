using Lesson13LoginRegister.Models;
using Lesson13LoginRegister.Services;

internal class Program
{
    public static void RegisterPage()
    {
    Register:
        Console.Clear();
        Console.WriteLine("*********Sign Up*********");
        Console.Write("Name: ");
        var name = Console.ReadLine();
        Console.Write("Surname: ");
        var surname = Console.ReadLine();
        Console.Write("Date of birth (dd.MM.yyyy): ");
        var date = Console.ReadLine();
        Console.Write("Email: ");
        var email = Console.ReadLine(); // "Hakuna@matata.com "
        Console.Write("Password: ");
        var password = Console.ReadLine();

        // validation (yoxlamalar)

        try
        {
            UserManager.Register(name!, surname!, email!.ToLower().Trim(), password!, date!);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(2000);
            goto Register;
        }
    }

    public static void LoginPage()
    {
    Login:
        Console.Clear();
        Console.WriteLine("*********Sign In*********");
        Console.Write("Email: ");
        var email = Console.ReadLine();
        Console.Write("Password: ");
        var password = Console.ReadLine();

        // validations

        //if (!UserManager.Login(email!, password!))
        //{
        //    Console.WriteLine("Invalid email or password");
        //    Thread.Sleep(2000);
        //    goto Login;
        //}

        try
        {
            UserManager.Login(email!, password!);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(2000);
            goto Login;
        }
    }

    public static void MainPage()
    {
        Console.Clear();
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
    }
    public void Foo() { }

    private static void Main(string[] args)
    {


        //Guid guid = Guid.NewGuid();

        //Console.WriteLine(guid.ToString());

        //var user = new User();
        //var user1 = new User();
        //var user2 = new User();
        //Console.WriteLine(user.Id);
        //Console.WriteLine(user1.Id);
        //Console.WriteLine(user2.Id);

        while (true)
        {
            if (UserManager.User is null)
            {
                MainPage();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": RegisterPage(); break;
                    case "2": LoginPage(); break;
                }
            }
            if (UserManager.User is not null)
            {
                Console.WriteLine($"Welcome, {UserManager.User.Name}");

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Backspace) UserManager.Logout();
            }



        }
    }
}