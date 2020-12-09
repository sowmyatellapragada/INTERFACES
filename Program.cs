using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Stud("sowmya", 200500, 5, 89);
            Console.WriteLine("Name: " + student.GetName);
            Console.WriteLine("Payment study: " + student.GetPaymentStudy);
            Console.WriteLine("Year study: " + student.GetYearStudy);
            Console.WriteLine("Rating: " + student.GetRating);
            Console.ReadLine();
        }
    }
}
