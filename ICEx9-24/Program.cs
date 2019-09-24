using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEx9_24
{
    class Program
    {
        static void Main(string[] args)
        {

            //using Array


     
            int[] studentIDs = new int[3];
            studentIDs[0] = 1;
            studentIDs[1] = 2;
            studentIDs[2] = 3;
            double[] gpas = { 2.5, 3.1, 4.0 }; //new double [3]


            Console.WriteLine("Please pick an ID from the list to see their gpa: ");

            foreach (int id in studentIDs)
            {
                Console.Write(" " + id);
            }

            Console.WriteLine();
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIDs.Length; i++)
            {
                if(studentIDs[i] == userInput)
                {
                    Console.WriteLine($"The GPA for the student with id {userInput} is {gpas[i]}");
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
