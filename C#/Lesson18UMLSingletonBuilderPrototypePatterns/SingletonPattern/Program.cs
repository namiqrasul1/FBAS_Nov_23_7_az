using SingletonPattern;

var pr = President.GetInstance();
pr.Name = "Hakuna";
pr.Surname = "Matata";

var p = President.GetInstance();
p.Name = "Kamil";

Console.WriteLine(pr.Name);