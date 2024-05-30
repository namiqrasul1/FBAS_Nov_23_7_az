using System.Text;

string[] questions = ["Where is capital of Azerijan?", "Question 2", "Question 3"];
string[][] answers = [
                    ["Baku", "Ganja", "Iravan"],
                    ["Answer1", "Answer2", "Answer3"],
                    ["Answer1", "Answer2", "Answer3"],
];

string[] correctAnswers = ["Baku", "Answer1", "Answer3"];


int score = 0;
Random random = new();
for (int i = 0; i < questions.Length; i++)
{
    Console.Clear();
    Console.WriteLine($"Score: {score}");
    Console.WriteLine(questions[i]);
    random.Shuffle(answers[i]);
    Console.WriteLine($"A) {answers[i][0]}");
    Console.WriteLine($"B) {answers[i][1]}");
    Console.WriteLine($"C) {answers[i][2]}");

answering:
    var key = Console.ReadKey().Key;

    int index = key switch
    {
        ConsoleKey.A => 0,
        ConsoleKey.B => 1,
        ConsoleKey.C => 2,
        _ => -1
    };
    if (index == -1) goto answering;

    if (correctAnswers[i] == answers[i][index])
        score += 10;
    else
        score = score == 0 ? 0 : score - 10;

}

Console.WriteLine("Total score: {0}", score);

Console.WriteLine("{0} {2} {1}", 4, "k", true);