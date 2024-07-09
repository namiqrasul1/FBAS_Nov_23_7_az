using FlyWeight;

List<Tree> trees = [];

for (int i = 0; i < 1_000_000; i++)
{
    trees.Add(new Tree(1, 2, "red", "text", "palid"));
}

trees[0].Type.Color = "blue";

Console.WriteLine(trees[10].Type.Color);

Console.ReadKey();