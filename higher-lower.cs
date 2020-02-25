using System;
using System.Collections.Generic;

public class Program
{
  public static int[] getRange(string input, int low, int high, int guess)
  {
    int[] range = new int[2] { low, high };
    if (input == "higher")
    {
      range[0] = guess + 1;
    }
    else if (input == "lower")
    {
      range[1] = guess;
    }
    else 
    {
      Console.WriteLine("Invalid input. Please try again.");
    }
    return range;
  }


  public static int GuessNum(int[] range)
  {
    Random rnd = new Random();
    return rnd.Next(range[0], range[1]);
  }

  public static void Main()
  {
    Console.WriteLine("Let's play the higher/lower game! Pick a number between 1 - 100.");
    Random rnd = new Random();
    int low = 1;
    int high = 101;
    int guess = rnd.Next(low, high);
    Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct)");
    string input = Console.ReadLine().ToLower();
    while (input != "correct")
    {
      int[] range = getRange(input, low, high, guess);
      low = range[0];
      high = range[1];
      guess = GuessNum(range);
      Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct)");
      input = Console.ReadLine().ToLower();
    }
    Console.WriteLine("Great! I guessed your number.");
  }
}