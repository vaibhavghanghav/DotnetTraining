using System;
namespace logical_or{
    class logical_or{
        static void Main(string[] args){
            Console.WriteLine("Enter Ur Favorite number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            
            if(a==3 || a==9 || a==30){
                Console.WriteLine("Ur lucky planet is Jupyter");
            }
            else if(a==1 || a==19){
                Console.WriteLine(" Mars");
            }
            else{
                Console.WriteLine("I don't know");
            }
        }
    }
}