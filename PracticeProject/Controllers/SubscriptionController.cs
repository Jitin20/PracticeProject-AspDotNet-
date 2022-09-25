using Microsoft.AspNetCore.Mvc;
using PracticeProject.Models;

namespace PracticeProject.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly ISubs subs;
        private readonly ICategory category;

        public SubscriptionController(ISubs _subs, ICategory _category)
        {
            subs = _subs;     
            category = _category; 
        }

        public IActionResult getAllSubsList()
        {
            return View(subs.AllSubs);
        }

    }
}
