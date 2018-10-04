using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            // Delegates can hold references to more than one method
            // Use the += to assign more methods to the same variable
            // Use -= to remove a methods reference
            // use = null to remove all references
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            // Syntactic sugar for assigning more methods to a delegate
            // book.NameChanged += OnNameChanged2;

            book.Name = "Mobeen's Grade Book";
            book.Name = "Delegate Invoked";


            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            // Abstract
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + (int)stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);

        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        /*static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }*/
    }
}
