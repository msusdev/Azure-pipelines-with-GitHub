using System;
using Phonetic.Speller;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        foreach((char c, string s) in new PhoneticSpeller().GetSpelling("Hello"))
        { 
            Console.WriteLine($"[{c}]\t{s}");
        }
    }
}