using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();

      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night.\nYou're sitting in your room and hear a noise\ncoming from down the hall.\nDo you go investigate?");

      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();

      if (noiseChoice == "NO")
      {
        Console.WriteLine("Not much of an adventure if we don't leave\nour room!\nTHE END.");
      }
      else if (noiseChoice == "YES")
      {
        Console.WriteLine("You walk into the hallway and see \na light coming from under a door down the hall.\nYou walk towards it.\nDo you open it or knock?");

        Console.Write("Type OPEN or KNOCK: ");
        string doorChoice = Console.ReadLine();
        doorChoice = doorChoice.ToUpper();

        if (doorChoice == "KNOCK")
        {
          Console.WriteLine("A voice behind the door speaks.\nIt says, \"Answer this riddle: \"\n\"Poor people have it.\nRich people need it.\nIf you eat it you die.\nWhat is it?\"");
          Console.Write("Type your answer: ");
          string riddleAnswer = Console.ReadLine();
          riddleAnswer = riddleAnswer.ToUpper();

          if (riddleAnswer == "NOTHING")
          {
            Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your\nroom and lock the door.\nTHE END.");
          }

          else
          {
            Console.WriteLine("You answered incorrectly.\nThe door doesn't open.\nTHE END.");
          }
        }

        else if (doorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked!\nSee if one of your three keys will open it.");
          Console.Write("Enter a number (1-3): ");
          string keyChoice = Console.ReadLine();
          //keyChoice = Int32.Parse(keyChoice);

          switch(keyChoice)
          {
            case "1":
              Console.WriteLine("You choose the first key.\nLucky choice!\nThe door opens and\nNOTHING is there.\nStrange...\nTHE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key.\nThe door doesn't open.\nTHE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key.\nThe door doesn't open.\nTHE END.");
              break;
            default:
              Console.WriteLine("You didn't choose anything.\nThe story ends.\nTHE END");
              break;
          }
        }
      }
    }
  }
}
