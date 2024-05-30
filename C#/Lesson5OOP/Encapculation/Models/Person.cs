namespace Encapculation.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private int age;
        public int Age
        {
            get => age;
            set => age = 0 < value && value < 130 ? value : throw new ArgumentOutOfRangeException();
        }
    }
}
