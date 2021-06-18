using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
    public class PersonsDetail
    {
        List<Person> personsList = new List<Person>();

        public IList<Person> getAllPersons()
        {
            personsList.Add(new Person(
                                        "Nishan Aryal",
                                        22,
                                        "Software Engineer",
                                        "Kathmandu Nepal",
                                        new DateTime(2000, 7, 10)
                                        )
                                    );


            foreach (var persons in personsList)
            {
                Console.WriteLine("Person: {0},{1},{2},{3},{4}", persons.Name, persons.Age, persons.Profession, persons.Address, persons.DOB);
            }

            return personsList;
        }
    }
}
