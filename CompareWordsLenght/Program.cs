using CompareWordsLenght.Business;

Console.WriteLine("type something to analysis:");

var words = Console.ReadLine();
while (string.IsNullOrEmpty(words))
{
    Console.WriteLine("type something to analysis:");
    words = Console.ReadLine();
}
var wordCalculte = new WordCalculate();


Console.WriteLine("The biggest word is: " + wordCalculte.WordsToCalculate(words.Split(" ")));
