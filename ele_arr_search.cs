using System;
class arr_search{
    public static void Main(string[] args){
        int[] arr={1,2,3,4};
        int flag=0,ele=5;
        for(int i=0;i<arr.Length;i++){
            if(arr[i]==ele){
                flag=1;
                break;
            }
        }
        if(flag==1){
            Console.WriteLine("Found !!!");
        }
        else{
            Console.WriteLine("Not Found !!");
        }
    }
}