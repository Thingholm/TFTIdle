using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName 
        { 
            get 
            { 
                return dataFileName; 
            } 
        }
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(dataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }
        public void SavePersons(Person[] persons)
        {
            StreamWriter sw = new StreamWriter(dataFileName);
            foreach (Person person in persons)
            {
                sw.WriteLine(person.MakeTitle());
            }
            sw.Close();
        }
        public Person LoadPerson()
        {
            StreamReader sr = new StreamReader(dataFileName);
            string line = sr.ReadLine();
            sr.Close();
            string[] splitLine = line.Split(";");
            Person newPerson = new Person(splitLine[0], DateTime.Parse(splitLine[1]), double.Parse(splitLine[2]), bool.Parse(splitLine[3]), int.Parse(splitLine[4]));
            return newPerson;
        }
        public List<Person> LoadPersons()
        {
            List<Person> personsList = new List<Person>();
            string line;
            StreamReader sr = new StreamReader(dataFileName);
            while ((line = sr.ReadLine()) != null)
            {
                string[] splitLine = line.Split(";");
                personsList.Add(new Person(splitLine[0], DateTime.Parse(splitLine[1]), double.Parse(splitLine[2]), bool.Parse(splitLine[3]), int.Parse(splitLine[4])));
            }
            sr.Close();

            return personsList;
        }
    }
}
