using System.Collections.Generic;
namespace PracticeProject.Models
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> GetCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Cardio", CategoryDesc="Just a routine cardio and running exercices- eligible for each age group"},
                new Category{CategoryId=2, CategoryName="Barbells & Dumbells", CategoryDesc="Build your body and structire with our fully fledged barbells and advanced dumbell as well as machines"},
                new Category{CategoryId=3, CategoryName="Advanced Weight Lifting", CategoryDesc="Enhance your shredded body muscles with personal training partner."}
            };
    }
}
