using Alphabet;
using System;


namespace AlphabetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = AlphabetService.GetCharacterFromIndex(10);
            Console.WriteLine("Character:" + character);

            var number = AlphabetService.GetIndexFromCharacter("j");
            Console.WriteLine("Number:" + number);

            Console.ReadKey();
        }
    }
}
