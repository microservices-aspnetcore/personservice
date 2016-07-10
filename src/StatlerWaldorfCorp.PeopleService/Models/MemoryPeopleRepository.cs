using System;
using System.Linq;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.PeopleService.Models
{
    public class MemoryPeopleRepository : IPeopleRepository
    {
		protected static ICollection<Person> _people;

        public Person AddPerson(Person person) 
        {
            _people.Add(person);
            return person;
        }

        public Person GetPerson(Guid id) {
			return _people.FirstOrDefault(t => t.ID == id);            
        }

        public MemoryPeopleRepository() 
        {
            _people = new List<Person>();
        }        
    }
}