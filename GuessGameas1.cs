using System;

namespace Guessgameas1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool plays = true;
                Console.WriteLine("Guess game ( 0 to 20)Started!!!");
                Random randomobj = new Random();
                Console.Write("Guess my number : ");
                int input = Convert.ToInt32(Console.ReadLine());
                int count = 1;
                int hiddenvalue = randomobj.Next(20);
                while (plays)
                {
                    if (input == hiddenvalue)
                    {
                        Console.WriteLine("Wow !!! You Got it rigth " + count + "rd");
                        Console.WriteLine("Game End!!!");
                        plays = false;

                    }
                    else
                    {
                        if (input > 20)
                        {
                            Console.WriteLine("Read carefully game inf,idiot:  Guess number between 0 and 20 ");
                            Console.Write("Guess number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                            count++;
                        }
                        else if (input < hiddenvalue)
                        {
                            Console.WriteLine(" Your gussing is close to my number !!! try again");
                            Console.Write("Guess number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                            count++;
                        }
                        else if (input > hiddenvalue)
                        {
                            Console.WriteLine("Your gussing if too far to my number !!! try again");
                            Console.Write(" guess number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                            count++;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error !!! Your input must be number");
            }
            Console.WriteLine();
            Console.WriteLine("Thank for using my app");
            Console.WriteLine("Press any key to close the window ");
            Console.ReadKey();
        }
    }
}
