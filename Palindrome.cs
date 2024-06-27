using System;
using Microsoft.Win32;
namespace palindrome{
    class palindrome{
        static void Main(string[] args){
            Console.WriteLine("Enter String : ");
            string a = Console.ReadLine();
            string rev="";
            for(int i=a.Length-1;i>=0;i--){
                rev=rev+a[i];
            }
            if(a==rev){
                Console.WriteLine("Palindrome");
            }
            else{
                Console.WriteLine("Not");
            }
        }
    }
}