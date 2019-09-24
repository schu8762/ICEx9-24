using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEx9_24_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //using dictionary



            Dictionary<int, double> studentGrades = new Dictionary<int, double>();
            studentGrades.Add(1, 3.5);
            studentGrades.Add(2, 3.2);
            studentGrades.Add(3, 3.8);
            //if we try to add another it won't error like the previous example because dicionaries keep going

            Console.WriteLine("Please pick a student id to see their gpa: ");

            foreach (var studentid in studentGrades.Keys)
            {
                Console.Write(studentid + " ");
            }
            Console.WriteLine(); //so input is on the next line

            int userInput = Convert.ToInt32(Console.ReadLine());

            if (studentGrades.ContainsKey(userInput) == true)
            {
                Console.WriteLine($"The student with id {userInput} has a GPA of {studentGrades[userInput]}");
            }

            else
            {
                Console.WriteLine("Sorry you entered an invalid ID, try again");
            }
            
            Console.ReadKey();

        }
    }
}
