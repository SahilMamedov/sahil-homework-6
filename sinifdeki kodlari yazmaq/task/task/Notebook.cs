using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Notebook : Product
    {
        public string BrandName;
        public string Model;
        public int Ram;
        public int Storage;

        public Notebook(string brandname, double price, int count) : base(price, count)
        {
            BrandName = brandname;

        }


        public void GetInfo()
        {
            Console.WriteLine($"BrandName: {BrandName}/n" +
                $"Model: {Model} /n" +
                $"Ram: {Ram}/n" +
                $"Storage: {Storage}/n" +
                $"Price: {Price}/n" +
                $"Count:{Count} ");

        }

    }
}
