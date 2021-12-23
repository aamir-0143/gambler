using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambler
{
    public class Class1
    {
       public void start()
       { 
        
             int stake = 100;
             int bet = 1;
             Console.WriteLine("Total money : + money ");
       }
        public void WinLose()
        {
            int bet = 1;
            int money = 100;
            Random bet_num = new Random();
            int check = bet_num.Next(0, 100);
            Console.WriteLine("Started:");
            Console.WriteLine(check);
            if(bet == check)
            {
                Console.WriteLine("U win");

            }
            else
            {
                Console.WriteLine("loss");
            }
        }


    }

}
