using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
   public class Person
    {
        private String name;
        private String surname;
        private String phonenumber;
        private String address;
        private String description;
        private String email;

        public Person(String name,String surname,String phonenumber, String address, String description, String email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Phonenumber = phonenumber;
            this.Address = address;
            this.Description = description;
            this.Email = email;
        }
        public String Name { get => name; set => name = value; }
        public String Surname { get => surname; set => surname = value; }
        public String Phonenumber { get => phonenumber; set => phonenumber = value; }
        public String Address { get => address; set => address = value; }
        public String Description { get => description; set => description = value; }
        public String Email { get => email; set => email = value; }
        public bool IsValidP(String name, String surname,string phonenumber)
        {
            return this.Name.Equals(name) && this.Surname.Equals(surname) && this.Phonenumber.Equals(phonenumber);
        }
        public string To_Sttring()
        {
            return Name + "," + Surname + "," + Phonenumber +"," + Address + "," + Description + "," + Email;
        }

    }
}
