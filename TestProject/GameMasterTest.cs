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
    public class GameMasterTest
    {
        private Mock<IGameLogic> _mockGameLogic;
        private Player _player;
        private GameMaster _gameMaster;


        [TestInitialize]
        public void Setup()
        {
            _mockGameLogic = new Mock<IGameLogic>();
            _player = new Player();
            _gameMaster = new GameMaster(_mockGameLogic.Object);
        }

        [TestMethod]
        public void Test_Creating_Computer_PlayerFailure()
        {
            // Arrange
            Player cpuPlayer = _gameMaster.InstanciateComputerPlayer();

            // Assert
            Assert.IsNotNull(cpuPlayer);
        }

        [TestMethod]
        public void Test_Creating_Computer_PlayerSuccess()
        {
            // Arrange
            Player cpuPlayer = _gameMaster.InstanciateComputerPlayer();

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(Shape), cpuPlayer.Shape));
        }

        // TODO: Correct tests
        [TestMethod]
        public void PlayGame_Success()
        {
            // Arrange
            Player player = new Player();
            player.Shape = Shape.Rock;

            // Act
            var result = _gameMaster.PlayGame(player);

            // Assert
            Assert.IsInstanceOfType(result, typeof(MatchResult));
        }

        [TestMethod]
        public void PlayGame_Failure()
        {
            // Arrange
            Player invalidPlayer = new Player { Shape = (Shape)99 }; 

            // Act
            _gameMaster.PlayGame(invalidPlayer);

            // Assert 
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                _gameMaster.PlayGame(invalidPlayer);
            });

            // Optional: Check the exception message if necessary
            Assert.AreEqual("Invalid player input: shape must be a defined enum value.", exception.Message);
        }
    }
}
