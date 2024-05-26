using ClassLibrary1;
using ExampleNamespace;
using Lesson4StructClass;
using System.ComponentModel;
using PC = ExampleNamespace.PointClass;


//PointStruct p = new PointStruct(1, 2);
//var p1 = new PointStruct(1, 2);
//PointStruct p2 = new(1, 2);

//PointStruct p3;

//p.Show();

//PointClass pc = new PointClass(1, 2);
////var pc1 = new PointClass(1, 2);
////PointClass pc2 = new(1, 2);

//pc.y = 3;
//pc.x = 4;

//pc.Show();


//PointStruct pointStruct = new(x: 1, y: 2);
//PointStruct ps = pointStruct;
//ps.y = 42;
//pointStruct.Show();

//Foo(pointStruct);

//// lvalue    18               rvalue
//PointClass pointClass = new PointClass(1, 2);
////         18
//PointClass pc = pointClass.Clone();

//pc.y = 42;
//pointClass.Show();

//PointClass p;
//Some sp;

//PointClass pc = new(111, 2222);
//Console.WriteLine(pc);

//string s = $"{pc}";
//Console.WriteLine(s);

//PC pointClass;


// ?? null coalescing operator
//string? str = "matata";

//var s = str ?? "d";

////Console.WriteLine(s);

//void Foo(PointClass pointClass)
//{
//    //ArgumentNullException.ThrowIfNull(pointClass);
//    //var f  = pointClass ?? throw new ArgumentNullException();
//}

//var student = new Student();
//student.SetAge(54);
//student.Age = 42;
//student.Foo();
//Console.WriteLine(student.Age);

//var student = new Student { Age = 2, Average = 1.2 };

//Some o = new() { SomeString = "Hakuna Matata" };
//o.SomeString = "hakuna";
//Console.WriteLine(o.SomeString);

//PointStruct[] pointStructs = new PointStruct[4];
//PointClass[] pointClasses = new PointClass[4] {
//    new(1,2),
//    new(1,2),
//    new(1,2),
//    new(1,2),
//};
//foreach (var item in pointClasses)
//{
//    Console.WriteLine(item.y);
//}

//var student = new Student {   };

//Some o = new();
//Some.StaticProperty = 2;
//Some.StaticMethod();

// normal
// partial
// static

//PartialExampleClass pec = new();
string question1 = "Where is capital of Azerbaijan?";
string[] answers1 = ["Ganja", "Baku", "Nakchivan"];

Random rnd = new();

while (true)
{
    rnd.Shuffle(answers1);
    Console.WriteLine($"a. {answers1[0]}");
    Console.WriteLine($"b. {answers1[1]}");
    Console.WriteLine($"c. {answers1[2]}");
    Console.ReadKey();
}
