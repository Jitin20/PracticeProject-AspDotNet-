namespace PracticeProject.Models
{
    public class Subscription
    {
        public int SubsId { get; set; } 
        public string SubscriptionName { get; set; }
        public decimal SubscriptionPrice { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public string SubscrptionDesc { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
         

    }
}
