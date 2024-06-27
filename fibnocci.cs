using System;
namespace fibnocci{
    class fibnocci{

        static void Main(string[] args){
            Console.WriteLine("Fibnocci series :");
            for(int i=0;i<15;i++){
                Console.WriteLine(fib(i)+"\n");
            }
        }
        static int fib(int n){
            if(n<=1){
                return 1;
            }
            else{
                return fib(n-1)+fib(n-2);
            }
        }
    }
}