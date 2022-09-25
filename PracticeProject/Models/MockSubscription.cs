using System.Collections.Generic;
using System.Linq;

namespace PracticeProject.Models
{
    public class MockSubscription : ISubs
    {
        private readonly ISubs _category = new MockSubscription();

        public IEnumerable<Subscription> AllSubs =>
               new List<Subscription>
               {
                new Subscription{SubsId=1, SubscriptionName="Monthly", SubscriptionPrice=1000.00M, SubscrptionDesc="Get a small Monthly Package for you"},
                new Subscription{SubsId=2, SubscriptionName="Quarterly", SubscriptionPrice=2500.00M, SubscrptionDesc="Get an optmized quarterly subs for you"},
                new Subscription{SubsId=3, SubscriptionName="Annual", SubscriptionPrice=11000.00M, SubscrptionDesc="Get your goals achived with us."}
               };

        public Subscription GetSubscriptionById(int subsId)
        {
            return AllSubs.FirstOrDefault(s => s.SubsId == subsId);
        }
    }
}
