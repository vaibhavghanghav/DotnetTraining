using System;
namespace arr_reverse{
class arr_reverse{
    static void Main(string[] args){
        int[] arr={0,1,2,3,4,5,6,7,8,9};
        for(int i=arr.Length-1;i>=0;i--){
            Console.WriteLine(arr[i]);
        }
    }
}
}