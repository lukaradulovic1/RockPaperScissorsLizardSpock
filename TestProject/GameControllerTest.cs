using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSAppTest
{

    [TestClass]
    public class GameControllerTest 
    {
        private GameController _controller;
        private Mock<IGameMaster> _mockGameMaster;
        private Player _player;

        [TestInitialize]
        public void Setup()
        {
            _mockGameMaster = new Mock<IGameMaster>();
            _player = new Player();
            _controller = new GameController(_mockGameMaster.Object, _player);
        }


        [TestMethod]
        public void GetChoices_WithMockService_ReturnChoices()
        {
            //Arrange
            var result = _controller.Choices() as OkObjectResult;


            //Assert
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void GetChoice_WithMockService_ReturnChoice()
        {
            //Arrange
            var result = _controller.Choice() as OkObjectResult;


            //Assert
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void Play_ValidChoice_ReturnSuccessCase()
        {
            // Arrange 
            var validShape = (int)Shape.Rock;
            var choice = new PlayerChoiceModel { Player = validShape };

            // Act
            var result = _controller.Play(choice) as OkObjectResult;

            // Assert
            Assert.AreEqual(200, result.StatusCode);
  
        }

        [TestMethod]
        public void Play_InvalidChoice_ReturnFailureCase()
        {
            // Arrange
            var invalidShape = 999; 
            var choice = new PlayerChoiceModel { Player = invalidShape };

            // Act
            var result = _controller.Play(choice) as BadRequestObjectResult;

            // Assert
            Assert.AreEqual("Invalid shape provided.", result.Value);
        }

        [TestMethod]
        public void Play_NullChoice_ReturnFailureCase()
        {
            // Arrange
            var choice = new PlayerChoiceModel { Player = null };

            // Act
            var result = _controller.Play(choice) as BadRequestObjectResult;

            // Assert
            Assert.AreEqual(400, result.StatusCode);
        }
    }
}
