namespace ClassLibrary1
{
    public class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"{Vendor} {Model} {Year}";
    }

    class S
    {
        public Car Car { get; set; }
    }
}
