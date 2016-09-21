using System;
using System.Collections.Generic;
using System.Linq;

namespace Alphabet
{
    public static class AlphabetService
    {
        private static Dictionary<int, String> alphabet = new Dictionary<int, String>()
        {
            {1, "a" },
            {2, "b" },
            {3, "c" },
            {4, "d" },
            {5, "e" },
            {6, "f" },
            {7, "g" },
            {8, "h" },
            {9, "i" },
            {10, "j" },
            {11, "k" },
            {12, "l" },
            {13, "m" },
            {14, "n" },
            {15, "o" },
            {16, "p" },
            {17, "q" },
            {18, "r" },
            {19, "s" },
            {20, "t" },
            {21, "u" },
            {22, "v" },
            {23, "w" },
            {24, "x" },
            {25, "y" },
            {26, "z" }
        };

        public static String GetCharacterFromIndex(int number, bool lower = true)
        {
            if (number <= 0 || number >= 25) return String.Empty;

            var character = alphabet.First(a => a.Key == number).Value;

            if (!lower)
            {
                return character.ToUpper();
            }

            return character;
        }

        public static int GetIndexFromCharacter(string character)
        {
            if (String.IsNullOrEmpty(character)) return 0;

            var number = alphabet.FirstOrDefault(a => a.Value == character.ToLower());

            return number.Key;
        }
    }
}
