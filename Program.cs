using System;

namespace rockpaperscissorsC
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name? \n");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name} \n");
      Console.WriteLine("Do you want to play Rock Paper Scissors with me? y/n \n");
      string playgame = Console.ReadLine().ToLower();
      Console.Clear();

      int playerScore = 0;
      int computerScore = 0;
      bool finished = false;

      while (finished == false)
      {

        if (playgame == "y" || playgame == "yes")
        {
          Console.Clear();
          Console.WriteLine($"Yay! Let's Play Rock Paper Scissors {name}! \n");

          while (playgame == "y" || playgame == "yes")
          {

            string[] computerChoices = { "ROCK", "PAPER", "SCISSORS" };
            Random random = new Random();
            int computer = random.Next(0, computerChoices.Length);
            Console.WriteLine($"Choose your weapon {name}! (Rock Paper Scissors) \n");
            string playerWeapon = Console.ReadLine().ToUpper();
            Console.Clear();
            if (playerWeapon == "ROCK" || playerWeapon == "PAPER" || playerWeapon == "SCISSORS")
            {
              Console.WriteLine($"You Chose {playerWeapon} \n");
              Console.WriteLine($"I Chose {computerChoices[computer]} \n");

              if (playerWeapon == computerChoices[computer])
              {
                Console.WriteLine($"We did the same thing! It's a draw! \n");
                Console.WriteLine($"{name}'s Score: " + playerScore);
                Console.WriteLine("My Score: " + computerScore + "\n");
                Console.WriteLine("Do you want to play again? y/n \n");
                playgame = Console.ReadLine().ToLower();
                Console.Clear();
              }
              else if (playerWeapon == "ROCK" && computerChoices[computer] == "PAPER")
              {
                Console.WriteLine("You Lost! Hahaha! \n");
                computerScore++;
                Console.WriteLine($"{name}'s Score: " + playerScore);
                Console.WriteLine("My Score: " + computerScore + "\n");
                Console.WriteLine("Do you want to play again? y/n \n");
                playgame = Console.ReadLine().ToLower();
                Console.Clear();
              }
              else if (playerWeapon == "PAPER" && computerChoices[computer] == "SCISSORS")
              {
                Console.WriteLine("You Lost! Hahaha! \n");
                computerScore++;
                Console.WriteLine($"{name}'s Score: " + playerScore);
                Console.WriteLine("My Score: " + computerScore + " \n");
                Console.WriteLine("Do you want to play again? y/n \n");
                playgame = Console.ReadLine().ToLower();
                Console.Clear();
              }
              else if (playerWeapon == "SCISSORS" && computerChoices[computer] == "ROCK")
              {
                Console.WriteLine("You Lost! Hahaha! \n");
                computerScore++;
                Console.WriteLine($"{name}'s Score: " + playerScore);
                Console.WriteLine("My Score: " + computerScore + "\n");
                Console.WriteLine("Do you want to play again? y/n \n");
                playgame = Console.ReadLine().ToLower();
                Console.Clear();
              }
              else
              {
                Console.WriteLine($"You Won {name}!");
                playerScore++;
                Console.WriteLine($"{name}'s Score: " + playerScore);
                Console.WriteLine("My Score: " + computerScore + "\n");
                Console.WriteLine("Do you want to play again? y/n \n");

                playgame = Console.ReadLine().ToLower();
                Console.Clear();

              }
            }
            else
            {
              Console.WriteLine("You can't cheat! \n");

            }
          }
        }



        else if (playgame == "n" || playgame == "no")
        {
          Console.WriteLine("It's ok... I just thought we were friends.");
          finished = true;

        }

        else
        {
          Console.WriteLine("That's not an answer!");
          Console.WriteLine("Do you want to play Rock Paper Scissors with me? y/n \n");
          playgame = Console.ReadLine().ToLower();
        }
      }



    }
  }
}
