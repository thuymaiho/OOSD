using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBuilder = new ConcreateBuilder()
                .SetLName("Tan Thanh")
                .SetGender("Male")
                .SetOld("21t")
                .SetHeight("174cm")
                .SetWeight("70kg");

            Console.WriteLine(userBuilder.build());
        }
    }
}
