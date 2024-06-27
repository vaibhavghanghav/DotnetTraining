using System;
namespace prime{
    class prime{

        static void Main(string[] args){

            for(int i=2;i<=100;i++){
                if(Prime(i)){
                    Console.WriteLine(i);
                }
            }
        }

        static bool Prime(int n){
            if(n<2){
                return false;
            }
            for(int i=2;i<=Math.Sqrt(n);i++){
                if(n%i==0){
                    return false;
                }
            }
            return true;
        }
    }
}