using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEx_24_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST

            Console.WriteLine("Pllease enter all your stuff separated by a ';' ");
            string userStuff = Console.ReadLine();
            string [] pieces = userStuff.Split(';');

            List<string> favoriteThings = new List<string>();
            string answer; //since the var can't be defined in the do part of the loop you do it outside of the loop so the while sees it and the do still sees it as answer

            do
            {
                Console.WriteLine("Please enter one of your favorite things");
                favoriteThings.Add(Console.ReadLine());

                Console.WriteLine("Do you have another favorite things to add? Y/N");
                answer = Console.ReadLine().ToUpper()[0].ToString(); //to make sure user is entering uppercase- they might enter yes so the 0 chooses first character (y) and capitalizes it
            }
            while (answer != "N");

            Random ran = new Random();
            int randomThing = ran.Next(0, favoriteThings.Count()); // figure out max
            Console.WriteLine($"Random thing { favoriteThings[randomThing]}");





            Console.ReadKey();

        }
    }
}
