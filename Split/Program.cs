using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            ///shoping list:
           /* Console.WriteLine("Enter your list of supplies separated by comma:");
            string userList = Console.ReadLine();

            string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i =0; i< shoppingList.Length; i++)
            {
                Console.WriteLine($" item {i+1}: {shoppingList[i]}");
            }*/


            string userInput;
            Console.WriteLine("Enter first+lastname, birth of year");
            userInput=Console.ReadLine();

            GetUserInput(userInput);


            ///Kirjutada funktsioon, kus programm küsib kasutaja andmeid (sünniaasta, .
        }
        public static void GetUserInput (string userInput)
        {
            string[] userData = userInput.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            
            Console.WriteLine($" First name: {userData[0]}");
            Console.WriteLine($" Last name: {userData[1]}");
            Console.WriteLine($" Age: {2019 - int.Parse(userData[2])}");

        }
    }
}
