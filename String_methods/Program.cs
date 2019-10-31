using System;

namespace String_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Need on stringi meetodid:
            //Trim() - sellega saab tühikuid eest ja tagant ära võtta.
            //IndexOf näitab asukohta. Kui on char siis tuleb kasutada ''
            //Substring
            //Split

            string fullName = " Anu Kuusik  ";
            Console.WriteLine($"Full name lengh before trim: {fullName.Length}");

            fullName = fullName.Trim();
            Console.WriteLine($"Full name lengh after trim: {fullName.Length}");

            Console.WriteLine($"{fullName[0]}");

            int indexOfSpace = fullName.IndexOf(' ');
            Console.WriteLine($"The position of the space is {indexOfSpace}");

            ///See on siis kui teama, et on üks tühiks kahe sõna vahel.
            string firstName;
            string lastName;

            firstName = fullName.Substring(0, indexOfSpace);
            Console.WriteLine($"Firstname: {firstName}");

            lastName = fullName.Substring(indexOfSpace+1);
            Console.WriteLine($"Lastname: {lastName}");
            ///-------------------------------------------------------------------------
            ///Split():
            string[] personalData = fullName.Split(' ');
            foreach(string value in personalData)
            {
                Console.WriteLine($"Value from personal data: {value}");
            }


            string userInput;
           
            Console.WriteLine("Please enter your firstname and lastname");
            userInput = Console.ReadLine();



            GetNames(userInput);

        }///võtab parameetriks kasutaja nime ning tagastab sinu eesnimi on see ning perenimi selline:
        public static void GetNames (string userInput)
        {
            string[] fullname = userInput.Split(' ');
            Console.WriteLine($"First name: {fullname[0]}");
            Console.WriteLine($"Last name: {fullname[1]}");

        }
    }
}
