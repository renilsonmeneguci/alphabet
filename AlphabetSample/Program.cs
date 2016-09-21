using Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = AlphabetService.GetCharacterFromNumber(10);
            Console.WriteLine("Character:" + character);

            var number = AlphabetService.GetNumberFromCharacter("j");
            Console.WriteLine("Number:" + number);

            Console.ReadKey();
        }
    }
}
