using Microsoft.AspNetCore.Mvc;

namespace Test.Api.Controllers
{
    public class RejectRequestController : BaseController
    {
        /// <summary>
        /// GET api/Venues
        /// </summary>
        [HttpGet]
        public IActionResult Reject()
        {
            return Unauthorized();
        }
    }
}
