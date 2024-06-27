using System;
namespace stud_record
{
    class Stud_record{

        int roll,sem;
        string name,branch,clg;

        public Stud_record(int r,int s,string n,string b,string c){
            roll=r;
            sem=s;
            name=n;
            branch=b;
            clg=c;
        }

        public void stud_info(){
            Console.WriteLine("\n****************Student Record *****************");
            Console.WriteLine("Roll Number : "+roll+"\nName : "+name+"\nBranch : "+branch+"\nSemister : "+sem+"\nCollege : "+clg+"\n");
        }

        
        static void Main(string[] args){
            int num;
            Console.WriteLine("Enter Number of Records : ");
            num = Convert.ToInt32(Console.ReadLine());

            Stud_record[] arr=new Stud_record[num];
            //obj.stud_info();

            for(int i=0;i<num;i++){

                Console.WriteLine("Enter Record Number "+(i+1));
                Console.WriteLine("Roll Number :");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Branch :");
                string branch = Console.ReadLine();
                Console.WriteLine("Semister :");
                int sem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("College :");
                string clg = Console.ReadLine();

                 arr[i]=new Stud_record(roll,sem,name,branch,clg);
                
            }
            for(int i=0;i<num;i++){
                arr[i].stud_info();
            }
            
        }
    }
}