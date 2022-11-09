namespace Exercise3
{
    internal class Program
    {
        /*
         Frågor
        3.3
            13: Om vi upptäcker att alla fåglar behöver ett nytt attribut så lägger vi det i Bird klassen.
            14: Om alla djur behöver få ett nytt attribut så lägger vi det i Animal klassen.
         
         3.4

         
         */
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            Person person1 = personHandler.CreatePerson(28, "Johan", "Paro", 194, 130);
            Console.WriteLine(person1.ToString());


            List<UserError> userErrors = new List<UserError>();

            userErrors.Add(new TextInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new NullInputError());

            foreach (UserError error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

        }
    }
}