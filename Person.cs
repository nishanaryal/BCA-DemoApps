using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
    public class Person
    {
        private string name;
        private short age;
        private string profession;
        private string address;
        private DateTime dob;

        public Person(string name, short age, string profession, string address, DateTime dob)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
            this.address = address;
            this.dob = dob;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
    }
}
