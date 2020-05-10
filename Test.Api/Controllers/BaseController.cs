using Microsoft.AspNetCore.Mvc;
using Test.Api.CustomAttributes;

namespace Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
    }
}