using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class VendingMachine
    {
        private int currentAmount = 10;


        public void GetQuarters(int depositeCoin)
        {
            if(depositeCoin >= 25)
            {
                currentAmount += depositeCoin - 25;
                Console.WriteLine(currentAmount);
            }
            else if (depositeCoin >= 5)
            {
                currentAmount += depositeCoin - 5;
                Console.WriteLine(currentAmount);
            }
            else if (depositeCoin >= 10)
            {
                currentAmount += depositeCoin - 10;
                Console.WriteLine(currentAmount);
            }
            else if (depositeCoin == 0)
            {
                Console.WriteLine("Insert valid coin");
            }
            else
            {
                Console.WriteLine("INSERT COIN");
            }
        }
    }
}
