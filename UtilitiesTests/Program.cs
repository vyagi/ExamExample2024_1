using System;
using Utilities;

namespace UtilitiesTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "maRcIN JagIeła JunIOr";
            Console.WriteLine(StringUtilities.ToWords(name));
            Console.WriteLine(StringUtilities.ToSentence(name));
            Console.WriteLine(StringUtilities.ToCamelCase(name));
            Console.WriteLine(name.ToCamelCase());
        }
    }
}
