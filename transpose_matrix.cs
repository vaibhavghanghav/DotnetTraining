using System;
class transpose{
    public static void Main(string[] args){
        int r=3;
        int c=2;
        int [,] matrix=new int[r,c];
        Console.WriteLine("Enter Elements :") ;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                matrix[i,j]=Convert.ToInt32(Console.ReadLine());
            }
            
        }
        Console.WriteLine("\nMatrtix :") ;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                Console.WriteLine(matrix[i,j]);
            }
        }
        Console.WriteLine("\n Transpose of Matrtix :") ;
        for(int i=0;i<c;i++){
            for(int j=0;j<r;j++){
                Console.WriteLine(matrix[j,i]);
            }
        }

    }
}