using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.Modls
{
    class Book:Product
    {
        public string Genre;

        public Book(string genre,string name, int number,double price,int count ):base(number, name, price)
        {
            Genre = genre;    
        }

        public void Infobook()
        {
            Console.WriteLine($"Genre : {Genre} \n" +
                $"Name :{Name} \n" +
                $"Number : {Number} \n" +
                $"Price : {Price} \n" +
                $"Count : {Count}");
             
        }
       
   
    }
}
