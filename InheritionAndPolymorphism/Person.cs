using System;
using System.Collections.Generic;
using System.Text;

namespace InheritionAndPolymorphism
{
    internal abstract class Person(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;

        public string LastName { get; set; } = lastName;

        public string? Number { get; set; }

        public string? Email { get; set; }

        public abstract void IntroduceMyself();

    }
}
