using System;
namespace max_min{
    class max_min{
        static void Main(string[] args){
            Console.WriteLine("Enter 2 Numbers : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MAXIMUM : "+Math.Max(a,b)+"\nMINIMUM :"+Math.Min(a,b));
        }
    }
}