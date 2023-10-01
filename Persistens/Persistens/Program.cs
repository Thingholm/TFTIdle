namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person[] persons = {
                new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3),
                new Person("Rasmus Thingholm", new DateTime(2002, 1, 9), 176.0, false, 0),
                new Person("Hans Hansen", new DateTime(1982, 2, 5), 187.4, false, 1)
            };

            DataHandler handler = new DataHandler("Data.txt");
            List<Person> personsList = handler.LoadPersons();

            foreach (Person person in personsList)
            {
                Console.WriteLine(person.Name);
            }

            //handler.SavePerson(person);

            //Console.Write("Writing Person: ");
            //Console.WriteLine(person.MakeTitle());

            Console.ReadLine();
        }
    }
}