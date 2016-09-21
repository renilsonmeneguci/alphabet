using System;
using Alphabet;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ascii = 'A';
            int value = (int)ascii;
            var c = Convert.ToChar(65);

            var aaa = AlphabetService.GetCharacterFromNumber(1, false);
            var bbb = AlphabetService.GetNumberFromCharacter("Za");



            var pause = true;
        }
    }
}
