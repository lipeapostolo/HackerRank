using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    public class ElectronicsShop
    {
        public int getMoneySpent(List<int> keyboards, List<int> drives, int b)
        {
            var maiorValor = 0;

            foreach(var keyboad in keyboards) 
            {
                foreach(var drive in drives)
                {
                    var buy = keyboad + drive;

                    if (buy <= b && maiorValor < buy) maiorValor = buy;
                }
            }


            return maiorValor  == 0 ? - 1 : maiorValor;
        }
    }
}
