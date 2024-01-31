using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GLearn.Web.Controllers;

[Route("[controller]/[action]")]
public class Base : ControllerBase
{
	[HttpGet]
	public Results<Ok<string>, BadRequest> Index()
	{
		return TypedResults.Ok("SUCCESS");
	}
}
