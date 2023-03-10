using System;

namespace Strings_Lumpkin_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for fav letter
            Console.WriteLine("whats your favorite letter?");

            //Reads the letter input DO NOT PRESS ENTER
            char myChar = Console.ReadKey().KeyChar;

            //Checks if its a letter
            bool isLetter = Char.IsLetter(myChar);

            //writes it out
            Console.WriteLine($"\n {myChar} is a letter: {isLetter}");

            //asks to write a funny story
            Console.WriteLine("Write me a funny story!");

            // sets text to the variable "story"
            string story = Console.ReadLine();

            //asks for a funny word in the story
            Console.WriteLine("whats a funny word in that story?");

            //sets the variable "word" to the users imput
            string word = Console.ReadLine();

            //see if story contains funny word
            bool funnyWordBool = story.Contains(word);

            //asks if its true that the story has that word in it
            Console.WriteLine($"is it true that {story} has the word {word} in it?: {funnyWordBool}");



        }
    }
}
