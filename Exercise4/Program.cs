using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {


        /*
                Frågor:
                        1: Stacken fungerar så att man lägger instruktionerna i en hög så det senaste som lagts in är alltid det första som måste komma ut innan något annat kan göra det.
                           Heapen däremot tar mycket mer minne men låter dig få tag på sakerna i heapen oavsett vart dom ligger så länge du vet vart dom ligger.
                    
                        2: value types är ett sätt av redan definierade "simpla" typer som vi använder för all tillexempel jämföra och evaluera olika variabler.
                           Reference types är alla typer som ärver från System.Object vilket är alla olika typer av klasser (interface abstract etc)

                        3: I den första metoden så sparas värdet 3 i x variabeln och när vi sätter y = x så copieras värdet av x till y vilket inte påverkar värdet i x
                           I den andra metoden däremot så sparas en referense till MyInt i x och när vi sätter y = x så pekar nu y på samma reference som x. när vi sedan ändrar värdet som y pekar på så kommer nu x också ha en förändrat värde då den pekar på samma värde som y.
                
                Uppgift1:
                        2: kapaciteten ökar när den annars skulle gå out of bound, alltså aldrig innan det faktiskt behövs
                        3: Kapaciteten dubblas
                        4: det tar mycket mer tid/resources att utöka en lista jämfört med att bara lägga till ett element i den.
                        5: nej
                        6: när du vet exakt hur stor arrayen behöver vara

                Uppgift4:
                        1: Jag tänker använda en stack
                            Idéen är att för varje start parantes så lägger vi den på stacken, och sedan för varje slut parantes så kollar vi att det är korrekt parantes och sen tar vi bort den från stacken.


         
         
         */
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            bool doNotExit = true;
            List<string> theList = new List<string>();
            do
            {
                Console.WriteLine("+ to add or - to remove");
                Console.WriteLine(theList.Capacity);
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine(theList.Capacity);
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine(theList.Capacity);
                        break;
                }
                foreach (var item in theList)
                {
                    Console.Write($"{item.ToString()}, ");
                }
                Console.WriteLine();

            } while (doNotExit);

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            bool doNotExit = true;
            Queue<string> theQueue = new Queue<string>();
            string kalle = "Kalle";
            string greta = "Greta";
            string stina = "Stina";
            string olle = "Olle";

            Console.WriteLine("Kön är tom");
            theQueue.Enqueue(kalle);
            Console.WriteLine("Kalle ställer sig i kö");
            theQueue.Enqueue(greta);
            Console.WriteLine("greta ställer sig i kö");
            Console.WriteLine(theQueue.Dequeue() + " lämnar kön");
            theQueue.Enqueue(stina);
            Console.WriteLine("Stina ställer sig i kö");
            Console.WriteLine(theQueue.Dequeue() + " lämnar kön");
            theQueue.Enqueue(olle);
            Console.WriteLine("Olle ställer sig i kö");
            Console.WriteLine(theQueue.Dequeue() + " lämnar kön");
            Console.WriteLine(theQueue.Dequeue() + " lämnar kön");
            Console.WriteLine("Kön är tom");
            Console.ReadLine();
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            string kalle = "Kalle";
            string greta = "Greta";
            string stina = "Stina";
            string olle = "Olle";

            Stack<string> theStack = new Stack<string>();
            Stack<char> reverseStack = new Stack<char>();
            Console.WriteLine("1 for ICA example, 2 for Reversing a word");
            string menu = Console.ReadLine();
            char nav = menu[0];


            switch (nav)
            {
                case '1':
                    Console.WriteLine("Kön är tom");
                    theStack.Push(kalle);
                    Console.WriteLine("Kalle ställer sig i kö");
                    theStack.Push(greta);
                    Console.WriteLine("Greta ställer sig i kö");
                    Console.WriteLine(theStack.Pop() + " lämnar kön");
                    theStack.Push(stina);
                    Console.WriteLine("Stina ställer sig i kö");
                    Console.WriteLine(theStack.Pop() + " lämnar kön");
                    theStack.Push(olle);
                    Console.WriteLine("Olle ställer sig i kö");
                    Console.WriteLine(theStack.Pop() + " lämnar kön");
                    Console.WriteLine(theStack.Pop() + " lämnar kön");
                    Console.WriteLine("Kön är tom");
                    Console.ReadLine();
                    break;
                case '2':
                    do
                    {
                        Console.WriteLine("Input a word and get the word in reverse back");
                        string input = Console.ReadLine();
                        foreach (char letter in input)
                        {
                            reverseStack.Push(letter);
                        }
                        foreach (char letter in input)
                        {
                            Console.Write(reverseStack.Pop());
                        }
                        Console.WriteLine();
                    } while (true);
                    break;
            }


        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             * 
             * ({[
             */

            Console.WriteLine("enter a expression");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            string output1 = "";
            string output2 = "";
            int count = 0;
            char tmp;

            foreach (char item in input)
            {
                switch (item)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(item);
                        count++;
                        break;
                    case ')':

                        tmp = stack.Pop();
                        if (tmp != '(')
                        {
                            Console.WriteLine("inte välformat");
                            continue;
                        }
                        else
                        {
                            count--;
                        }
                        break;
                    case '}':
                        tmp = stack.Pop();
                        if (tmp != '{')
                        {
                            Console.WriteLine("inte välformat");
                            continue;
                        }
                        else
                        {
                            count--;
                        }
                        break;
                    case ']':
                        tmp = stack.Pop();
                        if (tmp != '[')
                        {
                            Console.WriteLine("inte välformat");
                            continue;
                        }
                        else
                        {
                            count--;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Välformad");
            Console.ReadLine();

            //for (int i = 0; i < count/2; i++)
            //{
            //    char tmp = stack.Pop();
            //    char tmp2 = queue.Dequeue();
            //    if ((tmp == '(' && tmp2 == ')') || (tmp == '{' && tmp2 == '}') || (tmp == '[' && tmp2 == ']'))
            //    {
            //        //output1 = output1 + tmp + tmp2;
            //        output1 += tmp;
            //        output2 += tmp2;
            //    }
            //    else
            //    {
            //        output1 += tmp;
            //        output2 += tmp2;
            //        Console.WriteLine("inte välformad");
            //        //break;
            //    }
            //}

            //Console.WriteLine(output1);
            //Console.WriteLine(output2);

            //if (count != 0)
            //{
            //    Console.WriteLine("inte välformad");
            //}


        }

    }
}

