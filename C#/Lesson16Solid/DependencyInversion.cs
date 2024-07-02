using InterfaceSegregation;
using OpenClose;

// has a
// is a
// uses 
// can do



class Water
{

}

class Sirab : Water
{

}

class Isbre : Water
{

}

class Person
{
    public void Drink(Water sirab) { }
}


class App
{
    private readonly IMailService _mailService;
    public App(IMailService mailService)
    {
        _mailService = mailService;
    }
}