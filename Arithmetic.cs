using System;
namespace Arithmetic
{
    class Arithmetic{
        static void Main(string[] args){
            Console.WriteLine("Enter 2 Numbers : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int add=a+b;
            int sub=a-b;
            int mul=a*b;
            int div=a/b;
            Console.WriteLine("Addition : "+add+"\nSubtraction: "+sub+"\nMultiplication : "+mul+"\nDivision : "+div);
        }
    }
}
