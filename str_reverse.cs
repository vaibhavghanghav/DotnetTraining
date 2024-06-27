using System;
namespace str_reverse{
    class str_rev{
        static void Main(string[] args){
            string a="abcd";
            string rev="";
            for(int i=a.Length-1;i>=0;i--){
                rev=rev+a[i];
            }
            Console.WriteLine(rev);

        }
    }
}