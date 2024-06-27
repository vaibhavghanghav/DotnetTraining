using System;
class row{
    public static void Main(string[] args){
        int r=3;
        int c=3;
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
                Console.Write(matrix[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n Enter 1st row to change :") ;
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Enter 2nd row to change :") ;
        int b=Convert.ToInt32(Console.ReadLine());
        int x;
        for(int i=0;i<c;i++){
            x =matrix[a,i];
            matrix[a,i]=matrix[b,i];
            matrix[b,i]=x;
        }

        Console.WriteLine("\n Interchange row Matrtix :") ;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                Console.Write(matrix[i,j]);
            }
            Console.WriteLine();
        }

    }
}