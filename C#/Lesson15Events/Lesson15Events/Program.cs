using MyTimer = System.Timers.Timer;
//class Program
//{
//    delegate void MyDelegate();
//    static event MyDelegate MyEvent;
//    static void Main(string[] args)
//    {
//        //MyEvent = () => { Console.WriteLine("Event Invoked"); };
//        //MyEvent += () => { Console.WriteLine("Another Function"); };

//        //MyEvent.Invoke();

//        //MyTimer timer;
//        var timer = new System.Timers.Timer();
//        timer.Interval = 2000;
//        timer.Elapsed += Timer_Elapsed;
//        timer.Start();

//        var text = Console.ReadLine();

//        Console.WriteLine(text);

//        Console.ReadKey();
//    }

//    private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
//    {
//        Console.WriteLine("Salam");
//    }
//}


namespace Lesson15Events
{
    class StepUpdateService
    {
        public delegate void UpdateHandler(object sender, string text);
        public event UpdateHandler Updated = (s, t) => { };
        public void Update(string text)
        {
            Updated.Invoke("Step IT", text);
        }
    }



    class Program
    {
        static void GetEmail(object sender, string text)
        {
            Console.WriteLine("You have new email");
            Console.WriteLine($"From: {sender}");
            Console.WriteLine($"Body: {text}");
        }

        static void GetSms(object sender, string text)
        {
            Console.WriteLine($"New message from {sender}: {text}");
        }

        static void GetMobileNotification(object sender, string text)
        {
            Console.Beep(500, 900);
            Console.Beep(900, 200);
            Console.WriteLine($"Notification from {sender}: {text}");
        }
        static void Main(string[] args)
        {
            var service = new StepUpdateService();
            service.Updated += GetEmail;
            service.Updated -= GetEmail;
            service.Update("sadas");
            int ch = 0;
            bool emailActive = false;
            bool smsActive = false;
            bool mobileActive = false;
            while (ch != '5')
            {
                Console.Clear();
                Console.WriteLine("1. Publish Message");
                Console.WriteLine($"2. Email: {(emailActive ? "Unsubscribe" : "Subscribe")}");
                Console.WriteLine($"3. Sms: {(smsActive ? "Unsubscribe" : "Subscribe")}");
                Console.WriteLine($"4. Mobile: {(mobileActive ? "Unsubscribe" : "Subscribe")}");

                ch = Console.ReadKey().KeyChar;
                switch (ch)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Text:");
                        var text = Console.ReadLine();
                        service.Update(text!);
                        Console.ReadKey();
                        break;
                    case '2':
                        if (!emailActive)
                            service.Updated += GetEmail;
                        else
                            service.Updated -= GetEmail;
                        emailActive = !emailActive;
                        break;
                    case '3':
                        if (!smsActive)
                            service.Updated += GetSms;
                        else 
                            service.Updated -= GetSms;
                        smsActive = !smsActive;
                        break;
                    case '4':
                        if (!mobileActive)
                            service.Updated += GetMobileNotification;
                        else
                            service.Updated -= GetMobileNotification;
                        mobileActive = !mobileActive;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}