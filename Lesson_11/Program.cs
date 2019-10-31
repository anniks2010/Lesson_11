using System;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Anu", "Malle", "Anu", "Kalle", "Joosep" };

           string nameToLook = "Anu";
            /*foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/

            
            CountName(names, nameToLook);

            /*string nameToLook = "Anu"; Selle bloki asemel on funktsioon all
            int counter = 0;

            foreach (string searchName in names)
            {
                if (nameToLook == searchName)
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} {nameToLook}s in the array.");*/

        }
        public static void CountName(string[] searcArray, string SearchName)
        {
           
            int counter = 0;
            foreach (string name in searcArray)
            {
                if (SearchName == name)
                {
                    counter++;
                } 
            }  
            Console.WriteLine($"There are {counter} {SearchName}s in the array.");
        }
    }
}
