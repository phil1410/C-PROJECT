using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            double score;
            Console.Write("Enter your score: ");
            score = Convert.ToInt64(Console.ReadLine());

            // Console.Write(Calculate(score));
            Console.Write(Score(Calculate(score)));

            Console.ReadLine();
        }
        static double Calculate(double percent)
        {
            double p_score = ((percent / 100) * 100);

            return p_score;
        }

        static double Score(double grad)
        {

            if (grad >= 90 && grad <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (grad >= 80 && grad <= 89)
            {
                Console.WriteLine("Grade B");
            }
            else if (grad >= 70 && grad <= 79)
            {
                Console.WriteLine("Grade C");
            }
            else if (grad >= 60 && grad <= 69)
            {
                Console.WriteLine("Grade D");
            }
            else if (grad >= 0 && grad <= 60)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            return grad;
        }

    }
}
