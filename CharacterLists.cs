using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongPasswordGenerator
{
    internal static class CharacterLists
    {
        public static List<char> LowerCase = new List<char> {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
        'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
        'w', 'x', 'y', 'z'
        };

        public static List<char> UpperCase = new List<char> {
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
        'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
        'W', 'X', 'Y', 'Z'
        };

        public static List<char> Numbers = new List<char> {
        '0', '1', '2', '3', '4', '5' , '6', '7', '8', '9'
        };

        public static List<char> Symbols = new List<char> {
        '`', '!', '"', '$', '%', '^', '&', '*', '(', ')',
        '-', '_', '=', '+', '/', '|', '<', '>', '?',
        ';', ':', '@', '#', '~', '[', ']', '{', '}' , '£'
        };
    }
}
