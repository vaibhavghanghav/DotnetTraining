using System;
namespace arr_user_input{
class arr_user_input{
    static void Main(string[] args){
    
        int n=3,m=3;
        int[,] arr1=new int[n,m];
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("\nMatrix ::::\n");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.WriteLine(arr1[i,j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThank You .... !");
    }
}
}