using System;
namespace area_tri
{
    class area_tri{
        static void Main(string[] args){
            Console.WriteLine("Enter Base & Height :: ");
            int b=Convert.ToInt32(Console.ReadLine());
            int h=Convert.ToInt32(Console.ReadLine());
            int area = (b*h)/2;
            Console.WriteLine("Area of Triangle :: "+area);
        }
    }
}