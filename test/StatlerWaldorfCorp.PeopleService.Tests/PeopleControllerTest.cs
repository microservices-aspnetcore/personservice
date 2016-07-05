using Xunit;
using System.Collections.Generic;using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace StatlerWaldorfCorp.PeopleService
{
    public class PeopleControllerTest
    {	    
        [Fact]
        public async void DeleteNonExistentTeamReturnsNotFound() 
        {
            PeopleController controller = new PeopleController();
        }
    }
}