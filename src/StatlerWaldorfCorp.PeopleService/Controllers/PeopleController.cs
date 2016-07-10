using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatlerWaldorfCorp.PeopleService.Models;

namespace StatlerWaldorfCorp.PeopleService
{
	[Route("[controller]")]
	public class PeopleController : Controller
	{		
		private IPeopleRepository _repository;

		[HttpGet]
        public async virtual Task<IActionResult> GetAllPeople()
		{
			return this.Ok("person");
		}

		public async virtual Task<IActionResult> CreatePerson([FromBody]Person newPerson) 
		{
			newPerson = _repository.AddPerson(newPerson);
			return this.Created($"/people/{newPerson.ID}", newPerson);
		}

		public PeopleController(IPeopleRepository repository) 
		{
			_repository = repository;
		}
	}
}
