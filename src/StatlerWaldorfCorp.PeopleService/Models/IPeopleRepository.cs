using System;

namespace StatlerWaldorfCorp.PeopleService.Models
{
    public interface IPeopleRepository
    {
        Person AddPerson(Person person);
        Person GetPerson(Guid id);
    }
}