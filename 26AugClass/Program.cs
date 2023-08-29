using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26AugClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product("BMW", "X5", 300, 5, 100, 200);
            Product product1 = new Product("BMW", "X6", 300, 5, 100, 200);

            product.GetInfo();
            product1.GetInfo();



        }
    }
}
