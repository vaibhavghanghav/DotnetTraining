using System;
namespace factorial{
    class factorial{

        static void Main(string[] args){
            Console.WriteLine("Enter number :");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("######## FACTORIAL ########");
            Console.WriteLine(fact(a));

        }
        static int fact(int n){
            if(n==0 || n==1){
                return 1;
            }
            return n*fact(n-1);
        }
    }
}