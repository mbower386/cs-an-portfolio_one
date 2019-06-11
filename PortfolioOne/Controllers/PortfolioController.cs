using Microsoft.AspNetCore.Mvc;

namespace PorfolioOne.Controllers
{
    public class PortfolioController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public string Index ()
        {
            return "This is my Index!";
        }

        // Projects
        [HttpGet]
        [Route ("projects")]
        public string Projects ()
        {
            return "These are my projects!";
        }

        // Contacts
        [HttpGet]
        [Route ("contact")]
        public string Contacts ()
        {
            return "This is my Contact!";
        }
    }
}