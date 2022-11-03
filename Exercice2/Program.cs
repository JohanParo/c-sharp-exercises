namespace Exercics2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool keepGoing = true;

            Console.WriteLine("Welcome to the main menu!");
            do
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| För att komma till Biljettpriser tryck 1.                          |");
                Console.WriteLine("| För att räkna ut biljettpris för flera personer tillsammans tryck 2|");
                Console.WriteLine("| do to third thing type 3                                           |");
                Console.WriteLine("| to do fourth thing type 4, to quit type 0.                         |");
                Console.WriteLine("----------------------------------------------------------------------");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        {
                            keepGoing = false;
                            break;
                        }
                    case "1": //check age of customer
                        {
                            Console.WriteLine("Ange din ålder");
                            int age = Int32.Parse(Console.ReadLine());
                            if (age < 20)
                            {
                                Console.WriteLine("Undomspris: 80kr");
                            }
                            else if (age > 64)
                            {
                                Console.WriteLine("Pensionärspris: 90kr");
                            }
                            else
                            {
                                Console.WriteLine("Standardpris: 120kr");
                            }
                            break;
                        }
                    case "2":
                        {

                            Console.WriteLine("Hur många personer är ni?");
                            int customers = Int32.Parse(Console.ReadLine());
                            int totalprice = 0;
                            for (int i = 0; i < customers; i++)
                            {
                                Console.WriteLine($"Hur gammal är person{i + 1}");
                                int age = Int32.Parse(Console.ReadLine());
                                totalprice += GetTicketPrice(age);
                            }
                            Console.WriteLine($"Ni är totalt {customers} många personer");
                            Console.WriteLine($"Den totala kostnaden för er är {totalprice}kr");
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("not a valid input");
                            break;
                        }
                }

            } while (keepGoing);
        }

        private static int GetTicketPrice(int age)
        {
            if (age < 20)
            {
                return 80;
            }
            else if (age > 64)
            {
                return 90;
            }
            else
            {
                return 120;
            }
        }

    }
}