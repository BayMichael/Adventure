﻿using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
 
     Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
     
     // Asking the user if he wants to go investigate
      Console.WriteLine("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();

    // If the user types "NO", print this text
      if (noiseChoice == "NO")
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END.");
      }

      // Else if noise == "YES", print this text
      else if (noiseChoice == "YES")
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
        Console.WriteLine("You walk towards it. Do you open it or knock?");
      }









    }
  }
}
