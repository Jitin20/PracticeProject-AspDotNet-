using System.Collections.Generic;

namespace PracticeProject.Models
{
    public interface ISubs
    {
        IEnumerable<Subscription> AllSubs { get; }
        Subscription GetSubscriptionById(int SubsId);
    }
}
