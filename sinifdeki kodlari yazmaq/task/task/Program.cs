using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Notebook[] notebooks = new Notebook[count_type];

            for (int i = 0; i < count_type; i++)
            {
                Console.Write("zehmet olmasa brendi daxil edin:");
                string brandname = Console.ReadLine();

                Console.Write("zehmet olmasa Modeli daxin edin:");
                string model = Console.ReadLine();

                Console.Write("zehmet olmasa rami daxil edin:");
                int ram = Convert.ToInt32(Console.ReadLine());

                Console.Write("zehmet olmasa yaddashi daxil edin:");
                int storage = Convert.ToInt32(Console.ReadLine());

                Console.Write("zehmet olmasa qiymeti daxil edin:");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("zehmet olmasa sayin daxil edin:");
                int count = Convert.ToInt32(Console.ReadLine());

                notebooks[i] = new Notebook(brandname, price, count)
                {
                    Model = model,
                    Ram = ram,
                    Storage = storage
                };


            }
            Console.WriteLine("Notebooklarin siyahisi");
            foreach (var item in notebooks)
            {
                item.GetInfo();
            }



        }
        static int getinputcount(string name, int min, int max)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());


            } while (input < min || input > max);
            return input;
        }
    }
    }
}
