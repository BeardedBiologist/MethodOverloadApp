using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Tim", "Corey");

            person.GenerateEmail();
            //person.GenerateEmail("gmail.com", true);

            Console.WriteLine(person.Email);

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public PersonModel(string firstname, string lastname, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", firstInitialMethod);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{ FirstName.Substring(0,1) }.{ LastName }@{ domain }";
            }
            else
            {
                Email = $"{ FirstName }.{ LastName }@{ domain }";
            }
        }


    }
}