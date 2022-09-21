using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameMechTests
  {
    [TestMethod]
    public void GameMech_ReturnsUserInputValue_Rock()
    {
      //Arrange
      string play = "Rock";
      //Act
      // string UserInput = Console.ReadLine();

      //Assert

      Assert.AreEqual(play, "Rock");
    }

    [TestMethod]
    public void GameMech_DoesItWin_True()
    {
      //Arrange
      string p1 = "Scissors";
      string p2 = "Rock";      
      //Act
      GameMech play = new GameMech();
      //Assert

      Assert.AreEqual("Player 2 Wins!", play.WhoWins(p1, p2));
    }
  }
}