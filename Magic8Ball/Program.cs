using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void MagicResponse(IQuestionable ball)
        {
            ball.Answer();
        }

        static void Main()
        {
            Console.WriteLine("Ask the Magic 8 Ball any question and receive your answer! \n");
            Console.Write("What is your question? ");
            Console.ReadLine();
            Console.WriteLine();

            var rng = new Random();
            var positive = new Happy();
            var negative = new Sad();
            var robot = new Neutral();

            var printChoice = rng.Next(1, 4);
            Thread.Sleep(1000);

            if (printChoice == 1)
            {
                MagicResponse(positive);
            }
            else if (printChoice == 2)
            {
                MagicResponse(negative);
            }
            else
            {
                MagicResponse(robot);
            }
        }
    }
}
