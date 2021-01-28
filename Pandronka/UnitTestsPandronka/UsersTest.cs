using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pandronka.Data;
using Pandronka.Models;
using System.Linq;

namespace UnitTestsPandronka
{
    [TestClass]
    public class UsersTest
    {
        [TestMethod]
        public void FindUser()
        {
            //Arrange
            string username = "admin@gmail.com";

            ApplicationDbContext db = new ApplicationDbContext();

            //Act
            var getResult = db.ApplicationUser.Where(x => x.UserName == username).First();

            //Assert
            Assert.IsNotNull(getResult, "Próba wyszukania jest nullem");
            Assert.IsInstanceOfType(getResult, typeof(ApplicationUser), "Pobrana wartość nie jest użytkownikiem");
        }

    }
}
