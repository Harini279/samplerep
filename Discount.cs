using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    public class Discount
    {
        public void Dprice()
        {
            Console.WriteLine("Enter sales price");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount price");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i - j);
        }
    }
}
