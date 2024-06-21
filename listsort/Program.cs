// C# Program to Sort a List of Names in Alphabetical Order
using System;
using System.Collections.Generic;

namespace SortNames
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string> { "John", "Alice", "Bob", "Diana" };
            
            names.Sort();

            Console.WriteLine("Sorted list of names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}



// 2. C# Program to Demonstrate Pass by Value
// using System;

// class Program
// {
//     static void Main()
//     {
//         int number = 10;
//         Console.WriteLine("Before calling the method, number = " + number);
        
//         PassByValue(number);
        
//         Console.WriteLine("After calling the method, number = " + number);
//     }

//     static void PassByValue(int num)
//     {
//         num = 20;
//         Console.WriteLine("Inside the method, num = " + num);
//     }
// }


//3. C# Program to Demonstrate Pass by Reference
// using System;

// class Program
// {
//     static void Main()
//     {
//         int number = 10;
//         Console.WriteLine("Before calling the method, number = " + number);
        
//         PassByReference(ref number);
        
//         Console.WriteLine("After calling the method, number = " + number);
//     }

//     static void PassByReference(ref int num)
//     {
//         num = 20;
//         Console.WriteLine("Inside the method, num = " + num);
//     }
// }


//4. C# Program to Illustrate Regular Expression Patterns
// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         string text = "The quick Brown Fox jumps over the Lazy Dog.";
        
//         string pattern = @"\b[A-Z][a-z]*\b"; // Pattern to match words starting with a capital letter
        
//         MatchCollection matches = Regex.Matches(text, pattern);

//         Console.WriteLine("Words starting with a capital letter:");
//         foreach (Match match in matches)
//         {
//             Console.WriteLine(match.Value);
//         }
//     }
// }


// 5. C# Program to Implement Namespaces
//--not done
/
// 8. C# Program to Convert Upper case to Lower Case
// using System;

// class Program
// {
//     static void Main()
//     {
//         string uppercaseString = "HELLO, WORLD!";
//         string lowercaseString = uppercaseString.ToLower();

//         Console.WriteLine("Lowercase string: " + lowercaseString);
//     }
// }

// 9. C# Program to Convert Characters of a String to Opposite Case
// using System;

// class Program
// {
//     static void Main()
//     {
//         string inputString = "Hello, World!";
//         string oppositeCaseString = "";

//         foreach (char c in inputString)
//         {
//             if (char.IsLower(c))
//             {
//                 oppositeCaseString += char.ToUpper(c);
//             }
//             else if (char.IsUpper(c))
//             {
//                 oppositeCaseString += char.ToLower(c);
//             }
//             else
//             {
//                 oppositeCaseString += c;
//             }
//         }

//         Console.WriteLine("Opposite case string: " + oppositeCaseString);
//     }
// }

// 10. C# Program to Find the Length of a String
// using System;

// class Program
// {
//     static void Main()
//     {
//         string inputString = "Hello, World!";
//         int length = inputString.Length;

//         Console.WriteLine("Length of the string: " + length);
//     }
// }