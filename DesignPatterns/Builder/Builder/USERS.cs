using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class USERS
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string old;
        private string height;
        private string weight;
        private string email;


        public USERS( string firstName, string lastName, string gender, string old, string height, string weight, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.old = old;
            this.height = height;
            this.weight = weight;
            this.email = email;
        }
    }
}
