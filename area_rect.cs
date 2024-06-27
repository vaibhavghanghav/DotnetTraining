using System;
namespace area_rect
{
    class area_rect{
        static void Main(string[] args){
            Console.WriteLine("Enter length & breadth :: ");
            int l=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int area = l*b;
            Console.WriteLine("Area of Rectangle :: "+area);
        }
    }
}