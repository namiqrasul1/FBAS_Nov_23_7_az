using AtmHomework.Helpers;
using AtmHomework.Models;


//StringType type = StringType.Alpha;

//string str = type switch
//{
//    StringType.Numeric => "0123456789",
//    StringType.Alpha => "abcdefghijklmnopqrstuvwxyz",
//    StringType.AlphaNumeric => "0123456789abcdefghijklmnopqrstuvwxyz",
//    _ => throw new ArgumentException()
//};

//Console.WriteLine(str);
//Random rnd = new();
//var r = string.Empty;
//for (int i = 0; i < 10; i++)
//{
//    r += str[rnd.Next(0, str.Length)];
//}

//Console.WriteLine(r);

//Card card = new(10, 2);
//Card card1 = new(10, 2);
//Card card2 = new(10, 2);
//Card card3 = new(10, 2);

//Console.WriteLine($"{card.Pan} {card.Pin} {card.Cvc}");
//Console.WriteLine($"{card1.Pan} {card1.Pin} {card1.Cvc}");
//Console.WriteLine($"{card2.Pan} {card2.Pin} {card2.Cvc}");
//Console.WriteLine($"{card3.Pan} {card3.Pin} {card3.Cvc}");

//var str = DateTime.Now.ToString("MM/yy");

//Console.WriteLine(str);

//var dt = DateTime.Now;
//var s = dt.ToString("MM/yy");
//Console.WriteLine(s);

//Card card = new(450, 5);

//Console.WriteLine(card);

//card.ToString();

//DateTime dateTime = DateTime.Now;


//User user = new User(name: "hakuna", surname: "matata", amount: 500, year: 3);

//Console.WriteLine(user.ToString());

Bank bank = new();
bank.ShowAllUsers();


while (true)
{
    if(bank.currentUser is null)
    {
        login:
        try
        {
            Console.Write("pan: ");
            var pan = Console.ReadLine();
            Console.Write("pin: ");
            var pin = Console.ReadLine();
            bank.Login(pan, pin);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            goto login;
        }
    }

    var amount = int.Parse(Console.ReadLine());
    bank.Withdraw(amount);

    Console.WriteLine(bank.currentUser!.CreditCard);
    Console.ReadKey();
}