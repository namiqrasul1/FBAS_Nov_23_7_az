namespace Lesson4StructClass
{
    class Some
    {
        public int SomeInt { get; set; } = 42;
        //public string SomeString { get; private set; }
        public string SomeString { get; init; }
        public Some()
        {
            SomeString = "hakuna";
            Console.WriteLine("default ctor");
        }

        public const int constInt = 42;

        public static int staticField = 3;
        public static double StaticProperty { get; set; }   
        public static void StaticMethod()
        {
            Console.WriteLine(constInt);
            StaticProperty = 42;
            staticField++;
        }

        static Some()
        {
            Console.WriteLine("static ctor");
        }

        public void SomeMethod()
        {
            staticField--;
            //SomeString = "d"; // error
        }
    }
}
