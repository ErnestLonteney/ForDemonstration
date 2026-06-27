using System;
using System.Collections.Generic;
using System.Text;

namespace NullRefExceptionHandling
{
    internal class Person
    {
        public int Id { get; set; }

        public required string FirstName { get; init; } 

        public required string LastName { get; init; }

        public string? Description { get; set; }

        public DateOnly BirthDay { get; set; }   

    }
}
