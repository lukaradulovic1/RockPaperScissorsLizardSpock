
namespace RPSLSAppTest
{
    [TestClass]
    public class GameLogicTest
    {

        private IGameLogic _gameLogic;

        [TestInitialize]
        public void Setup()
        {
            _gameLogic = new RockPaperScissorsLizardSpockLogic(); 
        }

        // Rock test
        [TestMethod]
        public void DetermineWinner_PlayerRock_ComputerPaper()
        {
            //Arrange
            var player = new Player { Shape = Shape.Rock }; 
            var cpuPlayer = new Player { Shape = Shape.Paper };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerRock_ComputerScissors()
        {
            //Arrange
            var player = new Player { Shape = Shape.Rock };
            var cpuPlayer = new Player { Shape = Shape.Scissors };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerRock_ComputerLizard()
        {
            //Arrange
            var player = new Player { Shape = Shape.Rock };
            var cpuPlayer = new Player { Shape = Shape.Lizard };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerRock_ComputerSpock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Rock };
            var cpuPlayer = new Player { Shape = Shape.Spock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }

        // Paper test 
        [TestMethod]
        public void DetermineWinner_PlayerPaper_ComputerRock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Paper };
            var cpuPlayer = new Player { Shape = Shape.Rock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerPaper_ComputerScissors()
        {
            //Arrange
            var player = new Player { Shape = Shape.Paper };
            var cpuPlayer = new Player { Shape = Shape.Scissors };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerPaper_ComputerLizard()
        {
            //Arrange
            var player = new Player { Shape = Shape.Paper };
            var cpuPlayer = new Player { Shape = Shape.Lizard };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerPaper_ComputerSpock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Paper };
            var cpuPlayer = new Player { Shape = Shape.Spock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }

        // Scissors test
        [TestMethod]
        public void DetermineWinner_PlayerScissors_ComputerRock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Scissors };
            var cpuPlayer = new Player { Shape = Shape.Rock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerScissors_ComputerPaper()
        {
            //Arrange
            var player = new Player { Shape = Shape.Scissors };
            var cpuPlayer = new Player { Shape = Shape.Paper };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerScissors_ComputerLizard()
        {
            //Arrange
            var player = new Player { Shape = Shape.Scissors };
            var cpuPlayer = new Player { Shape = Shape.Lizard };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerScissors_ComputerSpock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Scissors };
            var cpuPlayer = new Player { Shape = Shape.Spock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }

        // Lizard test
        [TestMethod]
        public void DetermineWinner_PlayerLizard_ComputerRock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Lizard };
            var cpuPlayer = new Player { Shape = Shape.Rock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerLizard_ComputerPaper()
        {
            //Arrange
            var player = new Player { Shape = Shape.Lizard };
            var cpuPlayer = new Player { Shape = Shape.Paper };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }

        [TestMethod]
        public void DetermineWinner_PlayerLizard_ComputerScissors()
        {
            //Arrange
            var player = new Player { Shape = Shape.Lizard };
            var cpuPlayer = new Player { Shape = Shape.Scissors };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }

        [TestMethod]
        public void DetermineWinner_PlayerLizard_ComputerSpock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Lizard };
            var cpuPlayer = new Player { Shape = Shape.Spock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }

        // Spock test
        [TestMethod]
        public void DetermineWinner_PlayerSpockComputerRock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Spock };
            var cpuPlayer = new Player { Shape = Shape.Rock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerSpockComputerPaper()
        {
            //Arrange
            var player = new Player { Shape = Shape.Spock };
            var cpuPlayer = new Player { Shape = Shape.Paper };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerSpockComputerScissors()
        {
            //Arrange
            var player = new Player { Shape = Shape.Spock };
            var cpuPlayer = new Player { Shape = Shape.Scissors };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.win.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerSpockComputerLizard()
        {
            //Arrange
            var player = new Player { Shape = Shape.Spock };
            var cpuPlayer = new Player { Shape = Shape.Lizard };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.lose.ToString(), result.Results);
        }


        /* Draw/ties outcomes */
        [TestMethod]
        public void DetermineWinner_PlayerRockComputerRock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Rock };
            var cpuPlayer = new Player { Shape = Shape.Rock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.tie.ToString(), result.Results);
        }

        [TestMethod]
        public void DetermineWinner_PlayerPaperComputerPaper()
        {
            //Arrange
            var player = new Player { Shape = Shape.Paper };
            var cpuPlayer = new Player { Shape = Shape.Paper };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.tie.ToString(), result.Results);
        }

        [TestMethod]
        public void DetermineWinner_PlayerScissorsComputerScissors()
        {
            //Arrange
            var player = new Player { Shape = Shape.Scissors };
            var cpuPlayer = new Player { Shape = Shape.Scissors };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.tie.ToString(), result.Results);
        }

        [TestMethod]
        public void DetermineWinner_PlayerLizardComputerLizard()
        {
            //Arrange
            var player = new Player { Shape = Shape.Lizard };
            var cpuPlayer = new Player { Shape = Shape.Lizard };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.tie.ToString(), result.Results);
        }
        [TestMethod]
        public void DetermineWinner_PlayerSpockComputerSpock()
        {
            //Arrange
            var player = new Player { Shape = Shape.Spock };
            var cpuPlayer = new Player { Shape = Shape.Spock };

            //Act
            var result = _gameLogic.DetermineWinner(player, cpuPlayer, _gameLogic.InstanciateGameOutcomes());

            //Assert
            Assert.AreEqual(Outcome.tie.ToString(), result.Results);
        }
    }
}