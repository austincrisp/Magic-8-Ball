using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class Happy : IQuestionable
    {
        public void Answer()
        {
            GoodResponse();
        }

        private static void GoodResponse()
        {
            int[] goodResposne = new int[] { 1, 2, 3 };
            var goodRng = new Random();

            var goodChoice = goodRng.Next(1, 4);

            if (goodChoice == 1)
            {
                string goodOne = "This will absolutely happen!";
                Console.WriteLine(goodOne);
            }
            else if (goodChoice == 2)
            {
                string goodTwo = "You are the greatest!";
                Console.WriteLine(goodTwo);
            }
            else
            {
                string goodThree = "Keep up the great work!";
                Console.WriteLine(goodThree);
            }
        }
    }
}
