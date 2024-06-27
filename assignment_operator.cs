using System;
namespace assignment_op{
    class assignment_op{
        static void Main(string[] args){

            Console.WriteLine("Assignment operator :: ");
            // (=)
            string a = "SIDDHI";
            Console.WriteLine("Original String : "+a);

            string rev="";
            for(int i=a.Length-1;i>=0;i--){
                // Assighnment op : ( += )
                rev+=a[i];
            }
            Console.WriteLine("Reverse String : "+rev);
            if(a==rev){
                Console.WriteLine("Palindrome");
            }
            else{
                Console.WriteLine("Not");
            }
        }
    }
}