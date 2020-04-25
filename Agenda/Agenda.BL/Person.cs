using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.BL
{
    public class Person
    {
        private static int personId = 0;
        private string firstName;
        private string lastName;
        private string email;
        private int age;

        public Person(): this("", "", "", 0)
        {
            
        }

        public Person(string firstName, string lastName, string email, int age)
        {            
            this.PersonId = ++personId;
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.age = 0;
        }

        public int PersonId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

    }
}
