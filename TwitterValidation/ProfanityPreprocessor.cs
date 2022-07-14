// See https://aka.ms/new-console-template for more information
using TwitterValidation;

internal class ProfanityPreprocessor : TextPreprocessor
{

    List<string> words = new List<string> { "consectetur", "quam", "some", "more", "words" }; // List of fake profanity words to look for in a text
    protected override bool Validate(string text)
    {
        return !words.Any(word => text.Contains(word)); // if contains at least one blacklisted word
    }

    protected override string FixText(string text)
    {
        Console.WriteLine("\n>> Text contains profanity! Cleaning it!\n"); // LOG

        words.ForEach(word => text = text.Replace(word, "***")); // replace each word with *** 
        return text;
    }
}