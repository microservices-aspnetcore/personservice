using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.PeopleService
{
	[Route("[controller]")]
	public class PeopleController : Controller
	{
		[HttpGet]
        public async virtual Task<IActionResult> GetAllPeople()
		{
			return this.Ok("person");
		}
	}
}
