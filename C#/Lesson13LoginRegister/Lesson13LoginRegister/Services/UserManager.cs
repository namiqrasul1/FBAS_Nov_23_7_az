using Lesson13LoginRegister.Models;
using Lesson13LoginRegister.Models.Enums;
using System.Text.Json;

namespace Lesson13LoginRegister.Services
{
    internal static class UserManager
    {
        public static List<User> Users { get; set; }
        public static User? User { get; set; }

        static UserManager()
        {
            if (File.Exists("users.json"))
            {
                var json = File.ReadAllText("users.json");
                var listOfUser = JsonSerializer.Deserialize<List<User>>(json);
                if (listOfUser is not null) Users = listOfUser;
            }
            Users ??= [];

        }

        public static void Register(string name, string surname, string email, string pass, string date)
        {
            var user = Users.FirstOrDefault(u => u.Email == email);
            if (user is null)
            {
                user = new User
                {
                    Email = email,
                    Surname = surname,
                    Name = name,
                    Password = pass,
                    DateOfBirth = DateOnly.ParseExact(date!, "dd.MM.yyyy")
                };
                Users.Add(user);

                var json = JsonSerializer.Serialize(Users);
                File.WriteAllText("users.json", json);

                //User = user;
                return;
            }
            throw new Exception("User already exist");
        }

        public static void Login(string email, string password)
        {
            User = Users.FirstOrDefault(u => u.Email == email.ToLower().Trim() && u.Password == password);
            if (User is null) throw new Exception("Invalid email or password");
            if (User.Status == UserStatus.NonVerificated) throw new Exception("Firstly verify you account");
            if (User.Status == UserStatus.Deleted) User.Status = UserStatus.Active;

        }

        public static void Logout()
        {
            User = null;
        }

        public static void Remove()
        {
            if (User is null) throw new Exception("invalid user");
            Users.Remove(User);

            var json = JsonSerializer.Serialize(Users);
            File.WriteAllText("users.json", json);
        }
    }
}
