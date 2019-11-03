using Microsoft.AspNetCore.Mvc;

namespace BairesDev.Opportunity.Management.Web.Controllers
{
    [Route("groups")]
    public class GroupsController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return Content("Hellow World!");
        }
    }
}