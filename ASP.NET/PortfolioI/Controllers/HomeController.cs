using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index";
        }

        [HttpGet]       //type of request
        [Route("projects")]     //associated route string (exclude the leading /)
        public string Projects()
        {
            return "This is my Projects";
        }

        [HttpGet]       //type of request
        [Route("contacts")]     //associated route string (exclude the leading /)
        public string Contacts()
        {
            return "This is my Contacts";
        }
    }
}
