using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pandronka.Data;
using Pandronka.Models;
using System.Linq;

namespace UnitTestsPandronka
{
    [TestClass]
    public class MenuItemTests
    {
        [TestMethod]
        public void CreateAndRemove()
        {
            //Arrange
            ApplicationDbContext db = new ApplicationDbContext();

            //Act
            var added = db.MenuItem.Add(new MenuItem()
            {
                CategoryId = db.Category.FirstOrDefault().Id,
                Description = "Test Desc",
                Name = "Test Item",
                Price = 12.00,
                SubCategoryId = db.SubCategory.FirstOrDefault().Id
            });

            db.SaveChanges();

            
            var get = db.MenuItem.Where(x => x.Name == "Test Item").First();
            int id = get.Id;

            db.MenuItem.Remove(db.MenuItem.Find(id));
            db.SaveChanges();

            //Assert
            Assert.IsNotNull(added, "Próba wyszukania jest nullem");
            Assert.IsInstanceOfType(get, typeof(MenuItem), "Pobrana wartość nie jest użytkownikiem");
            Assert.IsNull(db.MenuItem.Find(id),"Nie usunięto produktu");
        }

    }
}
