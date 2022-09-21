using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class GameMech
  {
    public string WhoWins(string p1, string p2)
    {
      //p1=paper
      if (p1 == "paper" || p1 == "Paper" && p2 == "rock" || p2 == "Rock") 
      {
        return "Player 1 Wins!";
      } 
      else if (p1 == "paper" || p1 == "Paper" && p2 == "scissors" || p2 == "Scissors") 
      {
        return "Player 2 Wins!";
      } 

      else if (p1 == "rock" || p1 == "Rock" && p2 == "paper" || p2 == "Paper") 
      {
        return "Player 2 Wins!";
      }
      else if (p1 == "scissors" || p1 == "Scissors" && p2 == "paper" || p2 == "Paper") 
      {
        return "Player 1 Wins!";
      }

      else if (p1 == "rock" || p1 == "Rock" && p2 == "scissors" || p2 == "Scissors") 
      {
        return "Player 1 Wins!";
      }
      
      else if (p1 == "scissors" || p1 == "Scissors" && p2 == "rock" || p2 == "Rock") 
      {
        return "Player 2 Wins!";
      }

      //tie
      else if (p1 == "rock" || p1 == "Rock" && p2 == "rock" || p2 == "Rock") 
      {
        return "It's a Draw!";
      }
      else if (p1 == "paper" || p1 == "Paper" && p2 == "paper" || p2 == "Paper") 
      {
        return "It's a Draw!";
      }
      else if (p1 == "scissors" || p1 == "Scissors" && p2 == "scissors" || p2 == "Scissors") 
      {
        return "It's a Draw!";
      }
      else 
      {
        return "Is there a typo?";
      }

    }
  }
}


// Write a method for all combinations of plays, write specs for all combos
// all possible combos : 
// RP - Paper Wins
//PR - Paper Wins
//PS - Scissors Wins
//SP - Scissors Wins
//RS - Rock Wins
//SR - Rock Wins
//PP - Draw
//RR - Draw
//SS - Draw
// Takes two inputs
// Returns Player 1 or Player 2 depending on who wins, Draw if nobody wins


// Possible inputs and outputs
// Player 1, player 2, draw