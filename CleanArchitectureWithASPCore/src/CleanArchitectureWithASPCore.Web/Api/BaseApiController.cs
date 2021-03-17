using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureWithASPCore.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
