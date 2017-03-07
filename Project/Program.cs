using System;
using UnitTest.Classes;

namespace UnitTest
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Bear bagheera = new Bear(new Jungle(), new BearBehavior());

      for (var i = 0; i < 5; i++)
        bagheera.PatrolOneDay();

      Console.ReadKey();
    }
  }
}