using System;

class Sphinx
{
  static void Main()
  {
    Console.WriteLine("No sooner spoken than broken?");
    string answer = Console.ReadLine();

    if (answer == "silence")
    {
      Console.WriteLine("The sphinx has been defeated!");
    }
    else
    {
      Console.WriteLine("You have been defeated!");
    }
  }

}
