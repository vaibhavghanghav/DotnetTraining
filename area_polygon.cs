using System;
namespace area_poly
{
    class area_poly{
        static void Main(string[] args){
            Console.WriteLine("Enter Number of Sides :: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length & radius :: ");
            int l=Convert.ToInt32(Console.ReadLine());
            int r=Convert.ToInt32(Console.ReadLine());
            double area = (n/2.0)*l*r;
            Console.WriteLine("Area of Rectangle :: "+area);
        }
    }
}