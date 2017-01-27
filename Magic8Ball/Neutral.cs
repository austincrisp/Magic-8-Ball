using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class Neutral : IQuestionable
    {
        public void Answer()
        {
            NeutralResponse();
        }

        private void NeutralResponse()
        {
            int[] neutralResposne = new int[] { 1, 2};
            var neutralRng = new Random();

            var neutralChoice = neutralRng.Next(2);

            if (neutralChoice == 1)
            {
                string neutralOne = "Cannot comprehend.  Have you tried shutting it off and back on?";
                Console.WriteLine(neutralOne);
            }
            else
            {
                string neutralTwo = "Cannot compute.";
                Console.WriteLine(neutralTwo);
            }
        }
    }
}
