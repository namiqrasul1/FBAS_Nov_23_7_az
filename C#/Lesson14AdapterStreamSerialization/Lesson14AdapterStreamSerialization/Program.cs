using Lesson14AdapterStreamSerialization.Models;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;



#region AdapterStream



// StreamWriter, StreamReader
// BinaryWriter, BinaryReader

//var data = "Hakuna Matata 42";

//using (var fs = new FileStream("some.txt", FileMode.Create, FileAccess.Write))
//{
//    var bytes = Encoding.UTF8.GetBytes(data);
//    fs.Write(bytes, 0, bytes.Length);

//}


//using var fs = new FileStream("some.txt", FileMode.OpenOrCreate, FileAccess.Write);
//using var sw = new StreamWriter(fs);

//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");
//sw.WriteLine("hakuna matata");

//using var sw = new StreamWriter("some.txt");
//sw.WriteLine("john doe");


//using var fileStream = new FileStream("some.txt", FileMode.Open, FileAccess.Read);
//var bytes = new byte[fileStream.Length];

//fileStream.Read(bytes, 0, bytes.Length);

//var data = Encoding.UTF8.GetString(bytes);
//Console.WriteLine(data);

//using var fileStream = new FileStream("some.txt", FileMode.Open, FileAccess.Read);
//using var sReader= new StreamReader(fileStream);
////var data = sReader.ReadToEnd();
//while (!sReader.EndOfStream)
//{
//    var data = sReader.ReadLine();
//    Console.WriteLine(data);
//}

#endregion


// Name:Hakuna Surname:Matata MidName:John FName:Doe Age:42

// xml 
// json


#region XmlSerialize
/*
<xml version>
<Cars>
    <Car>
        <Vendor>Nissan</Vendor>
        <Model>SkyLine</Model>
        <Year>1999</Year>
    </Car>
    <Car>
        <Vendor>Toyota</Vendor>
        <Model>Supra</Model>
        <Year>1998</Year>
    </Car>
    <Car>
        <Vendor>Ford</Vendor>
        <Model>Mustang</Model>
        <Year>1963</Year>
    </Car>
</Cars>
*/

void XmlWrite(List<Car> cars)
{
    using var xml = new XmlTextWriter("cars.xml", Encoding.UTF8);

    xml.Formatting = Formatting.Indented;

    xml.WriteStartDocument();
    xml.WriteStartElement("Cars");

    foreach (var car in cars)
    {
        xml.WriteStartElement("Car");

        //xml.WriteElementString("Vendor", car.Vendor);
        //xml.WriteElementString("Model", car.Model);
        //xml.WriteElementString("Year", car.Year.ToString());

        xml.WriteAttributeString("Vendor", car.Vendor);
        xml.WriteAttributeString("Model", car.Model);
        xml.WriteAttributeString("Year", car.Year.ToString());

        xml.WriteEndElement();
    }
    xml.WriteEndElement();
    xml.WriteEndDocument();
}

void XmlRead(List<Car> cars)
{
    var xmlDoc = new XmlDocument();
    xmlDoc.Load("cars.xml");

    var root = xmlDoc.DocumentElement;
    if (root is not null)
    {
        if (root.HasChildNodes)
        {
            foreach (XmlNode node in root.ChildNodes)
            {
                var car = new Car
                {
                    Vendor = node.Attributes![0].Value,
                    Model = node.Attributes![1].Value,
                    Year = int.Parse(node.Attributes![2].Value),
                };
                cars.Add(car);
            }
        }
    }
}



//var cars = new List<Car>
//{
//    new Car{Vendor = "Nissan", Model = "Skyline", Year = 1999},
//    new Car{Vendor = "Toyota", Model = "Supra", Year = 1998},
//    new Car{Vendor = "Ford", Model = "Mustang", Year = 1963},
//};


//XmlWrite(cars);


//var cars = new List<Car>();
//XmlRead(cars);

//foreach (var car in cars)
//{
//    Console.WriteLine(car);
//}

//var stud = new Student
//{
//    Name = "Hakuna",
//    Surname = "Matata",
//    BirthDate = new DateOnly(1942, 12, 03).ToString(),
//    Scores = [5, 4, 3, 5, 4]
//};

//var xml = new XmlSerializer(typeof(Student));
//using var fs = new FileStream("student.xml", FileMode.OpenOrCreate);

//xml.Serialize(fs, stud);


using var fs = new FileStream("student.xml", FileMode.OpenOrCreate);
var xml = new XmlSerializer(typeof(Student));
Student? st = xml.Deserialize(fs) as Student;





Console.WriteLine();
#endregion



#region JsonSerialize

//var stud = new Student
//{
//    Name = "Hakuna",
//    Surname = "Matata",
//    BirthDate = new DateOnly(1942, 12, 03).ToString(),
//    Scores = [5, 4, 3, 5, 4]
//};

//var json = JsonSerializer.Serialize(stud);
//File.WriteAllText("student.json", json);

//var json = File.ReadAllText("student.json");
//var obj = JsonSerializer.Deserialize<Student>(json);

//Console.WriteLine();



//var cars = new List<Car>
//{
//    new Car{Vendor = "Nissan", Model = "Skyline", Year = 1999, Month = 2},
//    new Car{Vendor = "Toyota", Model = "Supra", Year = 1998, Month = 2},
//    new Car{Vendor = "Ford", Model = "Mustang", Year = 1963, Month = 2},
//};

//var js = JsonSerializer.Serialize(cars);
//File.WriteAllText("cars.json", js);
//Console.WriteLine(js);

//var js = File.ReadAllText("cars.json");

//var cars = JsonSerializer.Deserialize<List<Car>>(js);


#endregion