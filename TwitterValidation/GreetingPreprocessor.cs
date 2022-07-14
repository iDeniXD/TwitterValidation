// See https://aka.ms/new-console-template for more information
using TwitterValidation;

internal class GreetingPreprocessor : TextPreprocessor
{
    const string start_string = "Hello there!"; // Greeting string to look for at the beginning of the text
    protected override bool Validate(string text)
    {
        return text.StartsWith(start_string); 
    }

    protected override string FixText(string text)
    {
        Console.WriteLine("\n>> Text does not start with 'Hello there!'. Adding it to the beginning!\n"); // LOG

        return text.Insert(0, start_string + " "); 
    }
}