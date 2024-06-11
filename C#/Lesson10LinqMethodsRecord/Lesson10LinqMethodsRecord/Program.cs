using Lesson10LinqMethodsRecord.Extentions;
using Lesson10LinqMethodsRecord.Models;
using System.Globalization;
using System.Threading.Channels;

List<Student> students = new List<Student>
{
    new Student {
        Name = "Murad",
        Surname = "Babayev",
        DateOfBirth = new DateOnly(2008, 10, 06)
    },
    new Student {
        Name = "Muhammed",
        Surname = "Musayev",
        DateOfBirth = new DateOnly(2007, 04, 27)
    },
    new Student {
        Name = "Amin",
        Surname = "Imamaliyev",
        DateOfBirth = new DateOnly(2008, 09, 19)
    },
    new Student {
        Name = "Murad",
        Surname = "Ahmadov",
        DateOfBirth = new DateOnly(2004, 11, 21)
    },
    new Student {
        Name = "Sanan",
        Surname = "Agayev",
        DateOfBirth = new DateOnly(2008, 11, 06)
    },
    new Student {
        Name = "Maleyka",
        Surname = "Shukurova",
        DateOfBirth = new DateOnly(2006, 03, 24)
    },
    new Student {
        Name = "Banovsha",
        Surname = "Mahalova",
        DateOfBirth = new DateOnly(1997, 09, 08)
    },
    new Student {
        Name = "Eldaniz",
        Surname = "Aliyev",
        DateOfBirth = new DateOnly(2006, 06, 09)
    },
    new Student {
        Name = "Vusal",
        Surname = "Bakirov",
        DateOfBirth = new DateOnly(2003, 09, 28)
    },
    new Student {
        Name = "Yusif",
        Surname = "Xankishiyev",
        DateOfBirth = new DateOnly(2006, 03, 17)
    }
};


// IEnumerable
// IQueryable

//var st = students.GetElderStudent();
//Console.WriteLine(st);

//foreach (var item in students)
//{
//    Console.WriteLine(item);
//}


//var r = students.All(st => !string.IsNullOrWhiteSpace(st.Name));

////var r = students.All(st => st.Name.Contains('m'));
//Console.WriteLine(r);

//var avg = students.Average(s => s.DateOfBirth.Year);
//Console.WriteLine(avg);

//var count = students.Count(s => s.DateOfBirth.Year < 2006);

//Console.WriteLine(count);

//var stud = students.First(st => st.Name.ToLower().StartsWith('s'));

//var student = students.First(st => st.Name.Contains('Q')); // sherte uygun birinci elemente reference qaytarir, uygun deyilse exception atir

//var student = students.FirstOrDefault(st => st.Name.Contains('Q')); // sherte uygun birinci elemente reference qaytarir, uygun deyilse default deyer qaytarir

//if(student is not null)
//{
//    Console.WriteLine(student);
//}

//var s = students.Max();
//var s1 = students.Min();

//Console.WriteLine(s);
//Console.WriteLine(s1);

//string foo(Student s)
//{
//    return s.Name;
//}


//var s = students.Max(foo);
//var s1 = students.Max(delegate(Student s) { return s.Name; });
//Console.WriteLine(s);

//var ord =  students.OrderByDescending(s => s.Name).ToList();
//var ord =  students.OrderBy(s => s.Name).ToList();

//foreach (Student student in ord)
//{
//    Console.WriteLine(student);
//}

//var names = students.Select(s => s.Name).ToList();
//var surnames = students.Select(s => s.Surname).ToList();

//names.ForEach(n => Console.WriteLine(n));
//Console.WriteLine("************");
//surnames.ForEach(s => Console.WriteLine(s));

//var fullnames = students.Select(st => $"{st.Name} {st.Surname}").ToList();
//fullnames.ForEach(fn => Console.WriteLine(fn));

// Anonymous Type

//var obj = new { Name = "Hakuna", Surname = "matata", Age = 42, S = new Student() };
//Console.WriteLine(obj);


//var studs = students.Select(st => new { Name = st.Name, Surname = st.Surname }).ToList();

//foreach (var item in studs)
//{
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.Surname);
//    Console.WriteLine("*************");
//}

//var dtos = students.Select(st => new StudentDto(Name: st.Name, Surname: st.Surname)).ToList();

//dtos.ForEach(d => Console.WriteLine(d.Name));

//var student = students.Single(st => st.Name == "Kamil"); // shert duzdurse ve element tekdirse hemin elemente reference qaytarir, choxdusa ve ya yoxdursaexception atir

//var student = students.SingleOrDefault(st => st.Name == "Kamil"); // shert duzdurse ve element tekdirse hemin elemente reference qaytarir, choxdusa exception atir, yoxdusa default deyer qaytarir

//Console.WriteLine(student);

//var studs = students.Skip(3).ToList();
//var studs = students.SkipLast(3).ToList();
//var studs = students.SkipWhile(st => !st.Name.Contains('S'));

//foreach (Student student in studs)
//{
//    Console.WriteLine(student);
//}

//var studs = students.Where(st => st.DateOfBirth.Year < 2006).ToList();
//foreach (Student student in studs)
//{
//    Console.WriteLine(student);
//}

// yashi 2006 boyuk olanlarin adlarini sort edib goturmek lazimdir

//var names = students
//            .Where(st => st.DateOfBirth.Year < 2006)
//            .Select(st => st.Name)
//            .Order()
//            .ToList();

//names.ForEach(n => Console.WriteLine(n));

Program1.Main1();