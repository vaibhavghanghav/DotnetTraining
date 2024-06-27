using System;
namespace logical_not{
    class logical_not{
        static void Main(string[] args){
            Console.WriteLine("Enter Ur Favorite number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            
            if(a%2!=0){
                Console.WriteLine(" It is Odd Number");
            }
            else{
                Console.WriteLine("Even Number");
            }
        }
    }
}