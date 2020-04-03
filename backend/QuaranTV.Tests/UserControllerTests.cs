using QuaranTV.Controllers;
using QuaranTV.Models;
using QuaranTV.Repositories;
using System.Collections.Generic;
using System;
using Xunit;
using NSubstitute;
using System.Linq;

namespace QuaranTV.Tests
{
    public class UserControllerTests
    {
        UserController testController;
        IRepository<User> userMockRepo;

        public UserControllerTests()
        {
            userMockRepo = Substitute.For<IRepository<User>>();
            testController = new UserController(userMockRepo);
        }

        [Fact]
        public void Get_Returns_Count_Of_Users()
        {
            // arrange
            var expectedUsers = new List<User>()
            {
              new User(1, "Tatyana", "tatyana.jpg"),
              new User(2, "Erin", "erin.jpg")
            };

            //albumList
            userMockRepo.GetAll().Returns(expectedUsers);

            // act
            var result = testController.Get();
            var countOfUsers = result.Count();

            // assert
            Assert.Equal(2, countOfUsers);
        }

    }
}
