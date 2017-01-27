using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class Sad : IQuestionable
    {
        public void Answer()
        {
            SadResponse();
        }

        public void SadResponse()
        {
            int[] sadResposne = new int[] { 1, 2, 3 };
            var sadRng = new Random();

            var sadChoice = sadRng.Next(1, 4);

            if (sadChoice == 1)
            {
                string sadOne = "Not gonna happen...";
                Console.WriteLine(sadOne);
            }
            else if (sadChoice == 2)
            {
                string sadTwo = "How could you possibly ask something like that?!";
                Console.WriteLine(sadTwo);
            }
            else
            {
                string sadThree = "Maybe next time.";
                Console.WriteLine(sadThree);
            }
        }
    }
}
