using System.Collections.Generic;
namespace PracticeProject.Models
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
