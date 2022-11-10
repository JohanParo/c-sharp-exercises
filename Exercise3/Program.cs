using Exercise3.Animals;

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
            9: Det fungerar inte då en horse och en Dog inte har någon relation annat än att dom båda ärver från samma klass Animal
            10: Listan måste vara av typ animal för att alla olika djur ska kunna lagras tillsammans, listan måste vara av typ objekt om man vill att ALLA klasser ska kunna lagras tillsammans.
            13: Varje Animal kallar den mest specialicerade Stats metoden dom kan
            16: Vi kommer inte åt metoden då Animals klassen inte har den metoden, för att komma åt metoden måste vi först kolla om vårat animal är en Dog och sen casta den till en Dog, då kan vi komma åt metoden.
         
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

            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse("Nagli", 19));
            animals.Add(new Pelican("Tony", 5));
            animals.Add(new Dog("Eddy", 8));
            animals.Add(new Flamingo("Pinky", 1));
            animals.Add(new Hedgehod("Spiky", 3));
            animals.Add(new Swan("Angry", 4));
            animals.Add(new Wolf("Ghost", 14));
            animals.Add(new Worm("Bobby", 77));
            animals.Add(new Wolfman("Ted", 45));

            foreach (Animal animal in animals)
            {
                
                Console.WriteLine(animal.Stats());
                animal.DoSound(); 
                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal;
                    person.Talk();
                }
            }

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                    Dog dog = (Dog)animal;
                    Console.WriteLine(dog.isAGoodBoy());
                }
            }

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse("Nagli", 19));

        }
    }
}