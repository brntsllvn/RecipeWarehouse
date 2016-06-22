using NUnit.Framework;
using RecipeWarehouse.Controllers;

namespace RecipeWarehouse.Tests.Controllers
{
    [TestFixture]
    class RecipesControllerTests
    {
        [Test]
        public void RecipeIndexIsNotNull()
        {
            var recipesController = new RecipesController();
        }
    }
}
