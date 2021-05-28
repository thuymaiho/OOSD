using System;

namespace Builder
{
    public interface UserBuilder
    {
        USERS build();

        UserBuilder SetFName(string firstName);
        UserBuilder SetLName(string lastName);
        UserBuilder SetGender(string gender);
        UserBuilder SetOld(string old);
        UserBuilder SetHeight(string height);
        UserBuilder SetWeight(string weight);
        UserBuilder SetEmail(string email);
    }
}
