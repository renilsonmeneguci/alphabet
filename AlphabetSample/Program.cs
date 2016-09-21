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

            var index = AlphabetService.GetIndexFromCharacter("j");
            Console.WriteLine("Index:" + index);

            Console.ReadKey();
        }
    }
}
