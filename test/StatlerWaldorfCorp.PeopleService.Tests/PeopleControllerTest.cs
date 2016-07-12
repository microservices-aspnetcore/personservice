using Xunit;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using StatlerWaldorfCorp.PeopleService.Models;

namespace StatlerWaldorfCorp.PeopleService
{
    public class PeopleControllerTest
    {	    
        [Fact]
        public async void CreatePersonAddsPerson() 
        {
            IPeopleRepository repository = new MemoryPeopleRepository();
            PeopleController controller = new PeopleController(repository);
            
            Guid testPersonID =  Guid.NewGuid();
            Person newPerson = new Person();
            newPerson.ID = testPersonID;
            newPerson.FirstName = "Jim";
            newPerson.LastName = "Jazaroo";

            await controller.CreatePerson(newPerson);

            Person testPerson = repository.GetPerson(testPersonID);
            Assert.NotNull(testPerson);
            Assert.Equal(testPerson.FirstName, "Jim");
            Assert.Equal(testPerson.LastName, "Jazaroo");            
        }

        [Fact]
        public async void GetPersonReturnsCorrectPerson() 
        {
            IPeopleRepository repository = new MemoryPeopleRepository();
            PeopleController controller = new PeopleController(repository);
           
            Guid testPersonID =  Guid.NewGuid();
            Person newPerson = new Person();
            newPerson.ID = testPersonID;
            newPerson.FirstName = "Jim";
            newPerson.LastName = "Jazaroo";

            await controller.CreatePerson(newPerson);
            Person testPerson = (Person)(await controller.GetPerson(testPersonID) as ObjectResult).Value;
            
        }        
    }
}