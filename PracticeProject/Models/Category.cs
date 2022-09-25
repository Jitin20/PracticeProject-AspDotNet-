using System.Collections.Generic;

namespace PracticeProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}
