using PigLatin;

Console.WriteLine("Pig Latin Translator");
Console.Write("Enter a word: ");
string entry = Console.ReadLine().ToLower();

if (entry == "")
{
    Console.WriteLine("Sorry, enter a word!");
}
else
{
    Console.WriteLine(Translator.PigLatinize(entry));
}