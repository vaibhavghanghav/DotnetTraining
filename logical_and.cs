using System;
namespace logical_and{
    class logical_and{
        static void Main(string[] args){
            Console.WriteLine("Enter Marks : ");
            int marks=Convert.ToInt32(Console.ReadLine());
            
            if(marks>35 && marks<50){
                Console.WriteLine("Pass But Poor Performance");
            }
            else if(marks>50 && marks<70){
                Console.WriteLine("Pass with gud Performance");
            }
            else{
                Console.WriteLine("Pass with Best Result");
            }
        }
    }
}