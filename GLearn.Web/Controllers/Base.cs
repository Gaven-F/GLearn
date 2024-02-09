using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace GLearn.Web.Controllers;

[ApiController]
[OpenApiTag("Demo", Description = "Demo controller")]
[Route("[controller]/[action]")]
public class Base
{
	/// <summary>
	/// Demo Api
	/// </summary>
	/// <remarks>
	/// # Demo Api
	/// 
	/// Just a demo api.
	/// </remarks>
	/// <returns>
	///	Nothing return, just a "SUCCESS".
	/// </returns>
	/// <request code="200">SUCCESS</request>
	[HttpGet]
	[ApiExplorerSettings(GroupName = "DEMO")]
	[ProducesResponseType(typeof(string), statusCode: StatusCodes.Status200OK)]
	public Results<Ok<string>, BadRequest> Index()
	{
		return TypedResults.Ok("SUCCESS");
	}


	[HttpGet]
	[ApiExplorerSettings(GroupName = "DEMO")]
	[ProducesResponseType(typeof(string), statusCode: StatusCodes.Status200OK, "text/plain")]
	public ContentResult StringResult()
	{
		return new ContentResult() { Content = "SUCCESS", ContentType = "text/plain" };
	}
}
