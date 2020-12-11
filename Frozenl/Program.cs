using System;
using System.Collections.Generic;
using System.IO;

namespace Frozenl
{
    class Program
    {
        class Presents
        {

            string name;
            string present;

            public Presents(string _name, string _present)
            {

                name = _name;
                present = _present;

            }



            public string Name { get { return name; } }
            public string Present { get { return present; } }


        }

            class WishList
            {
                List<Presents> presents;
                string present;


                public WishList()
                {
                    presents = new List<Presents>();
                } 
                
                public void AddWishesToTheList(string name, string present)
                {
                  Presents newPresent = new Presents(name, present);
                  presents.Add(newPresent);
                }
                 


                public void PrintAllWishes()
                {
                  foreach(Presents present in presents)
                  {
                    Console.WriteLine($"{present.Name} wants {present.Present} for Christmas");
                  }


                }
                
                public void NoPresentsForYou()
                {

                }


            }

           
       
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Roland Strod\Samples";
            string fileName = @"Frozenl.txt";
            string fullfilePath = Path.Combine(filePath, fileName);

            string[] linefromfile = File.ReadAllLines(fullfilePath);
            WishList myList = new WishList();
            foreach(string line in linefromfile)
            {
                Console.WriteLine(line);
            }


            foreach (string line in linefromfile)
            {
                string[] tempArray = line.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                string presentname = tempArray[0];
                string Wishername = tempArray[1];
                Console.WriteLine(Wishername);

                myList.AddWishesToTheList(presentname, Wishername);

            }
            myList.PrintAllWishes();
        }
    }
}
