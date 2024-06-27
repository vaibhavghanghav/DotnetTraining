using System;
namespace hello{
    class Application {
        public static void Main(string[] args){

            //MARRIAGE CERTIFICATE ISSUE OR NOT
            int age ;
            string gender;
            Console.WriteLine("ENTER AGE :: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER GENDER :: ");
            gender = Console.ReadLine();
            Console.WriteLine("******************");
            if(age >= 0){
                if((gender == "male") && (age >= 21)){
                Console.WriteLine("Marriage certificate can be issued..");
                }
                else if((gender == "male") && (age < 21)){
                    Console.WriteLine("Marriage certificate can not be issued..");
                }
                else if((gender == "female") && (age >=18)){
                    Console.WriteLine("Marriage certificate can be issued..");
                }
                else if((gender == "female") && (age < 18)){
                    Console.WriteLine("Marriage certificate can not be issued..");
                }
            }
            else{
                Console.WriteLine("Entered age is Invalid Age.");
            }

        }
    }
}