using System;
using task.Modls;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       Product class :
                   - No
                   - Name
                   - Price
                   - Count

                    Book class - Productdan miras alır 
                   - Genre 

                    No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz
                    Genre dəyəri təyin olunmadan Book yaradıla bilməz

                    Proqram run olduqda bizden say istemelidi, sayi daxil etdikden sonra hemin uzunluqda bir book arrayi yaradilmalidir
                    daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi,
                    dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir 

                    Arrayi tam olaraq doldurduqdan sonra menu penceresi gorunmelidir console-da ve orada asagidaki kimi yazilmalidir:
                    1. Kitablari qiymete gore filterle
                    2. Butun kitablari goster
                    0. Proqrami bagla

                    bu gorsendeikden sonra proqram bizden bir input daxil etmeyimizi istemelidi
            
                    Eger daxil etdiyimiz deyer 1 olarsa proqram kitablari filter edib bize gostermek ucun bizden 
                    minPrice ve maxPrice deyerlerini daxil etmeyimizi istemelidi.
                    Biz her iki deyeri daxil etdikden sonra proqram yaranmis kitab arrayindeki kitablari
                    gonderdiyimiz min ve max price deyerlerine gore filter edib bize gostermelidi.
                    Daha sonra yeniden menu penceresi gorunmelidir.      
                    Eger daxil etdiyimiz deyer 2 olarsa butun kitablar gosterilmelidir ve sonra menu penceresi gorsenmelidir yene
                    Eger daxil etdiyimiz deyer 0 olarsa proqram baglanmalidir
                    Eger daxil etdiyimiz deyer bu 3-unden basqa bir sey olarsa proqram bizden yeniden secim etmeyimizi istemelidir ta ki duz secim edenedek*/







            Console.WriteLine("Please write the number of books:");
            int num = Convert.ToInt32(Console.ReadLine());

            Book[] bookArray = new Book[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Please enter your Genre: ");
                string genre = Console.ReadLine();

                Console.Write("Please Enter the book Number:  ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Write the Name of the book:  ");
                string name = Console.ReadLine();

                Console.WriteLine("Please Write the Price of the book: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("How many pieces were needed?: ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Your next book");
                Console.WriteLine("");
                bookArray[i] = new Book(genre, name, number, price, count);
                
                
            }
            
            foreach (var item in bookArray)
            {
                item.Infobook();
                Console.WriteLine("-----------");
                
            }
            MinMaxPrice(bookArray);


           


            static void MinMaxPrice(Book[] bookArray)

            {

                int input = 0;
                bool kontrol = true;

                while (true)
                {
                    Console.WriteLine("1: Filter books according to the Price");
                    Console.WriteLine("2: Show all books");
                    Console.WriteLine("0: Close the program");
                    input = Convert.ToInt32(Console.ReadLine());

                    switch (input)

                    {


                        case 1:
                            Console.WriteLine("Enter the minimum price:");
                            int minPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the maximum price:");
                            int maxPrice = Convert.ToInt32(Console.ReadLine());


                            for (int i = 0; i < bookArray.Length; i++)
                            {
                                Book pric = bookArray[i];
                                if (pric.Price <= minPrice || pric.Price <= maxPrice)
                                {
                                    Console.WriteLine($"Name: {pric.Name} \n" +
                                        $"Number: {pric.Number} \n" +
                                        $"Genre: {pric.Genre}\n" +
                                        $"Price: {pric.Price} ");
                                    Console.WriteLine("----------");

                                }


                            }

                            input = Convert.ToInt32(Console.ReadLine());

                            break;

                        case 2:
                            foreach (var item in bookArray)
                            {
                                Console.WriteLine("-----------");
                                item.Infobook();
                            }

                            break;

                        case 0:
                            Console.WriteLine("Thank you");
                            kontrol = false;


                            break;


                    }
                }













            }
        }
    }
}
