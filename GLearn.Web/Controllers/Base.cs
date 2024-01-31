using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GLearn.Web.Controllers;

public class Base : ControllerBase
{
	public Results<Ok<string>, BadRequest> Index()
	{
		return TypedResults.Ok("SUCCESS");
	}
}
