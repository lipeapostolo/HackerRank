using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    public class SalesByMatch
    {

        //Function Description
        //Complete the sockMerchant function in the editor below.
        //sockMerchant has the following parameter(s) :
        //int n: the number of socks in the pile
        //int ar[n]: the colors of each sock
        /*
         * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

        public int SockMerchant(int n, List<int> ar)
        {
            if (n < 1 || n > 100 || ar.Any(x => x < 1 || x > 100)) return 0;

            var totalGrupos = 0;

            var grupos = ar.GroupBy(x => x);

            foreach(var grupo in grupos)
            {
                var quantidadeDepares = grupo.Count() / 2;

                if (quantidadeDepares < 1) continue;

                totalGrupos = totalGrupos + quantidadeDepares;
            }

            return totalGrupos;
        }
    }
}
