using System;
namespace atm
{
    class atm{
        static void Main(string[] args){


            Console.WriteLine("**************** || Welcome || ******************");
            Console.WriteLine("Enter Your PIN :: ");
            int pin=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PIN is : "+pin);
            int actual=1000,add,sub,ch=1,c;

            do{

            Console.WriteLine(" Enter Ur Choice :: ");
            Console.WriteLine("\n1.Balance\n2.Deposite\n3.Withdraw\n4.Quite");
            ch=Convert.ToInt32(Console.ReadLine());
            
            switch(ch) 
            {
                case 1:
                Console.WriteLine("Balance :: "+actual);
                break;

                case 2:
                Console.WriteLine(" Enter Amount To Deposite :: ");
                add=Convert.ToInt32(Console.ReadLine()); 
                actual+=add;        
                Console.WriteLine("Balance :: "+actual);
                break;

                case 3:
                Console.WriteLine(" Enter Amount To Withdraw :: ");   
                sub=Convert.ToInt32(Console.ReadLine());
                actual-=sub;   
                Console.WriteLine("Balance :: "+actual);    
                break;

                case 4:
                Console.WriteLine("Quite...!");
                break;

                default:
                Console.WriteLine("Invalid Choice ......");
                break;
            }
            Console.WriteLine("\nDo u want to continue : \nYes :1\nNo :0\n");
            c =Convert.ToInt32(Console.ReadLine());
            }while(c==1);

            }
    }
}
