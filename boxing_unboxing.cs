using System;
namespace box_unbox{
    class box_unbox{
        static void Main(string[] args){

            fun(23);
            fun(34.8);

        }

        static void fun(object data){
            if(data is int){
                int a=(int) data;
                data=20;
                Console.WriteLine(" A : "+a);
                Console.WriteLine("DATA : "+data);
            }
            else if(data is double){
                double a=(double) data;
                data = 9.9;
                Console.WriteLine("Unboxed Double : "+a);
                Console.WriteLine("DATA : "+data);

            }
            
        }
        
    }
}