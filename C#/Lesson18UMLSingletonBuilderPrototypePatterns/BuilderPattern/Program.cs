using BuilderPattern;
using System.Diagnostics;
using System.Text;

//House house = new(4, 1, 2, 1, false, false, true, false);

//var builder = new HouseBuilder();

//builder.BuildGarden().BuildRooms(5);
////builder.BuildRooms(4);
//builder.BuildDoors(5);
//builder.BuildRoof();

//var house = builder.GetHouse();

//Console.WriteLine(house.Rooms);


//string str = string.Empty;
//Stopwatch sw = new Stopwatch();
//sw.Start();

//for (int i = 0; i < 100000; i++)
//{
//    str += i;
//}
//sw.Stop();

//Console.WriteLine(str);
//Console.WriteLine(sw.Elapsed);

var sb = new StringBuilder();
var sw = new Stopwatch();
sw.Start();

for (int i = 0; i < 10000000; i++)
{
    sb.Append(i);
}
sw.Stop();

Console.WriteLine(sb.ToString());
Console.WriteLine(sw.Elapsed);