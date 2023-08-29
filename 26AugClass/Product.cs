using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26AugClass
{
    class Product

    {
        private static int IdChange = 0;


        public int Id;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int Income = 0;
        public int Count = 0;

        public Product(string brandName, string model, int price, int count, int income, int cost)
        {
            IdChange++;
            Id = IdChange;
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Income = income;
            Count = count;
            Sale();

        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id}, {BrandName}, {Model}, {Price}, {Cost}, {Income}, {Count}");
        }

        public void Sale()
        {
            if (Count > 0)
            {
                int value = Cost - Price;
                Income += value;
                Count--;
            }
        }
    }
}
