using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConcreateBuilder : UserBuilder
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string old;
        private string height;
        private string weight;
        private string email;


        public UserBuilder SetFName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public UserBuilder SetLName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public UserBuilder SetGender(string gender)
        {
            this.gender = gender;
            return this;
        }

        public UserBuilder SetOld(string old)
        {
            this.old = old;
            return this;
        }

        public UserBuilder SetHeight(string height)
        {
            this.height = height;
            return this;
        }
        public UserBuilder SetWeight(string weight)
        {
            this.weight = weight;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            this.email = email;
            return this;
        }

        public USERS build()
        {
            Console.WriteLine("Register User With Information Is: \n");

            if (firstName != null)
            {
                Console.WriteLine("First name: " + firstName.ToString());
            }
            if (lastName != null)
            {
                Console.WriteLine("Last name: " + lastName.ToString());
            }
            if (gender != null)
            {
                Console.WriteLine("Gender: " + gender.ToString());
            }
            if (old != null)
            {
                Console.WriteLine("Old: " + old.ToString());
            }
            if (height != null)
            {
                Console.WriteLine("Height: " + height.ToString());
            }
            if (weight != null)
            {
                Console.WriteLine("Weight: " + weight.ToString());
            }
            if (email != null)
            {
                Console.WriteLine("Email: " + email.ToString());
            }


            return new USERS(firstName, lastName, gender, old, height, weight, email);
        }
    }
}
