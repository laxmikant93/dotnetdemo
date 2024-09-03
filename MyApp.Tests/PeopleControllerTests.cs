// MyApp.Tests/PeopleControllerTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp.Api.Controllers;
using MyApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Tests
{
    [TestClass]
    public class PeopleControllerTests
    {
        [TestMethod]
        public void Get_ReturnsPeopleList()
        {
            // Arrange
            var controller = new PeopleController();

            // Act
            var result = controller.Get() as ActionResult<IEnumerable<Person>>;

            // Assert
            Assert.IsNotNull(result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var people = okResult.Value as IEnumerable<Person>;
            Assert.IsNotNull(people);
            Assert.AreEqual(2, people.Count()); // Assuming you have 2 people in the list
        }
    }
}
