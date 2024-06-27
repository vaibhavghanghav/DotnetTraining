using System;
namespace swap{
    class swap{

        static void Main(string[] args){

            int a=3,b=7;
            Console.WriteLine("Before Swapping :: \na : "+a+"\nb : "+b);
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("After Swapping :: \na : "+a+"\nb : "+b);
        }
    }
}