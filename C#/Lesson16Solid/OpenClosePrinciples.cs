namespace OpenClose;

abstract class Figure
{
    public abstract double CalcArea();
}
class Circle : Figure
{
    public double Radius { get; set; }
    public override double CalcArea()
    {
        return Radius * Radius * 3.14;
    }
}

class Rectangle : Figure
{
    public double Height { get; set; }
    public double Width { get; set; }
    public override double CalcArea()
    {
        return Height * Width;
    }
}

class Triangle : Figure
{
    public override double CalcArea()
    {
        return 4;
    }
}

class Calc
{
    public double CalcArea(Figure figure)
    {
        return figure.CalcArea();
    }
}


interface IMailService
{
    void SendMail(string to, string subject, string body);
}

class GmailService : IMailService
{
    public void SendMail(string to, string subject, string body)
    {
        // smtp gmail uchun kodlar
    }
}

class YandexMailService : IMailService
{
    public void SendMail(string to, string subject, string body)
    {
        // smtp yandex uchun kodlar
    }
}