using System;

namespace StatlerWaldorfCorp.PeopleService.Models
{
    public class Person 
    {
        public Guid ID {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}