namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            // #### ACT ####
            string title = person.MakeTitle();
        }
    }
}