using System;
namespace box_unbox2{
    class box_unbox2{
        static void Main(string[] args){

            int a= 90;
            object A=a;
            a = 30;
            Console.WriteLine("############## BOXING ###########");
            Console.WriteLine(" a : "+a);
            Console.WriteLine("A obj : "+A);

            int ua=(int) a;
            Console.WriteLine("unboxed a : "+ua);

            Console.WriteLine("############## UNBOXING ###########");

            string s= "SID";
            object S=s;
             s= "Abcd";
            Console.WriteLine("BOXING");
            Console.WriteLine(" s : "+s);
            Console.WriteLine("S obj : "+S);

            string us=(string) s;
            Console.WriteLine("Str unboxed : "+us);
            
            Console.WriteLine("########################Proper Output############################");

            int r=1;
            object obj=r;

            object ob="siddhi";
            string n=Convert.ToString(ob);
            Console.WriteLine("Roll : "+r);
            Console.WriteLine("Name : "+n);










        }
        
    }
}