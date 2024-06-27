using System;

class Project
{
    static void Main(string[] args)
    {
        // Take user inputs for Student and Fee Details
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();
        
        Console.Write("Enter USN: ");
        string usn = Console.ReadLine();
        
        Console.Write("Enter Branch and Semester (e.g., 7th Sem, CSE): ");
        string branch = Console.ReadLine();
        
        Console.Write("Enter Academic Year (e.g., 2023-2024): ");
        string academicYear = Console.ReadLine();
        
        Console.Write("Enter Time (e.g., 11:45 AM): ");
        string time = Console.ReadLine();

        Console.Write("Enter Entrance Fee: ");
        decimal entranceFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Exams Fee: ");
        decimal examsFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Library Fee: ");
        decimal libraryFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Hostel Fee: ");
        decimal hostelFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Laboratory Fee: ");
        decimal laboratoryFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Project and Class Fee: ");
        decimal projectAndClassFee = decimal.Parse(Console.ReadLine());

        // Calculate Total Fee
        decimal totalFee = entranceFee + examsFee + libraryFee + hostelFee + laboratoryFee + projectAndClassFee;
        decimal gst = totalFee * 0.18m;  // Assuming GST is 18%
        decimal grandTotal = totalFee + gst;

        // Display the Fee Receipt
        Console.WriteLine("\n\n\tSANJIVANI COLLEGE OF ENGINEERING");
        Console.WriteLine("\t    ~ Academic Fee Receipt ~");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("USN: " + usn);
        Console.WriteLine("Branch: " + branch);
        Console.WriteLine("Academic Year: " + academicYear);
        Console.WriteLine("\tTime: " + time);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("1. Entrance Fee: \t\t\t" + entranceFee.ToString("C"));
        Console.WriteLine("2. Exams Fee: \t\t\t\t" + examsFee.ToString("C"));
        Console.WriteLine("3. Library Fee: \t\t\t" + libraryFee.ToString("C"));
        Console.WriteLine("4. Hostel Fee: \t\t\t\t" + hostelFee.ToString("C"));
        Console.WriteLine("5. Laboratory Fee: \t\t\t" + laboratoryFee.ToString("C"));
        Console.WriteLine("6. Project and Class Fee: \t" + projectAndClassFee.ToString("C"));
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Total: \t\t\t\t\t" + totalFee.ToString("C"));
        Console.WriteLine("GST (18%): \t\t\t\t" + gst.ToString("C"));
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Grand Total: \t\t\t\t" + grandTotal.ToString("C"));
    }
}
