using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pandronka.Data;
using System.Linq;

namespace UnitTestsPandronka
{
    [TestClass]
    public class DbTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            //Arrange
            ApplicationDbContext db = new ApplicationDbContext();

            //Act
            bool connectionResult = db.Database.CanConnect();

            //Assert
            Assert.AreEqual(true,connectionResult,"Nie mo¿na siê po³¹czyæ z baz¹ danych");
        }

        [TestMethod]
        public void FetchItems()
        {
            //Arrange
            ApplicationDbContext db = new ApplicationDbContext();

            //Act
            var getResult = db.MenuItem.ToList();

            //Assert
            Assert.IsTrue(getResult.Any(),"Brak produktów w bazie");
        }
    }
}
