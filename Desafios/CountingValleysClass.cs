using System;
using System.Linq;

namespace Desafios
{
    public class CountingValleysClass
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public int CountingValleys(int steps, string path)
        {
            var uphill = 'U';
            var downhill = 'D';

            path = path.Substring(0, steps - 1);

            if (2 > steps || steps >= Math.Pow(10, 6)
                || path.Any(x => x != uphill && x != downhill)) return 0;

            int contStep = 0;
            int contValley = 0;

            foreach(var step in path)
            {
                if(step == uphill)
                {
                    contStep = contStep +1;
                    continue;
                }
                contStep = contStep-1;

                if(contStep == -1)
                {
                    contValley = contValley+1;
                }

            }


            return contValley;
        }
    }
}
