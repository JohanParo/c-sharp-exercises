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
                Console.WriteLine(" --------------------------------------------------------------------");
                Console.WriteLine("| För att komma till Biljettpriser tryck 1.                          |");
                Console.WriteLine("| För att räkna ut biljettpris för flera personer tillsammans tryck 2|");
                Console.WriteLine("| För att upprepa en inskriven text 10 gånger tryck 3                |");
                Console.WriteLine("| För att få tillbaka det tredje ordet i en inskriven mening tryck 4 |");
                Console.WriteLine("| För att avsluta programmet tryck 0.                                |");
                Console.WriteLine(" --------------------------------------------------------------------");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        {
                            keepGoing = false;
                            break;
                        }
                    case "1": //check age of customer and return price
                        {
                            Console.WriteLine("Ange din ålder:");
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
                    case "2": //check price of many different people and return total price
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
                    case "3": //repeat input text 10 times
                        {
                            Console.WriteLine("Skriv in en godtycklig text:");
                            string text = Console.ReadLine();

                            for (int i = 0; i < 10; i++)
                            {
                                if (i == 9)
                                {
                                    Console.WriteLine($"{i + 1}. {text}.");
                                }
                                else
                                {
                                    Console.Write($"{i+1}. {text}, ");
                                }
                            }
                            break;
                        }
                    case "4": //return the third word in a user input sentence
                        {
                            Console.WriteLine("Skriv in en mening och få tillbaka det tredje ordet i meningen:");
                            string textInput = Console.ReadLine();

                            List<string> textList = new List<string>();
                            string[] strings = textInput.Split(" ");
                            if (strings.Length < 3)
                            {
                                Console.WriteLine("Det måste finnas minst 3 ord i meningen");
                            }
                            else
                            {
                                Console.WriteLine(strings[2]);
                            }
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

        //Get the price of the ticket based on input age
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