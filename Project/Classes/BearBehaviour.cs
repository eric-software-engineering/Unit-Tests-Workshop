using System;
using UnitTest.Interfaces;

namespace UnitTest.Classes
{
  // Single Responsibility principle
  internal class BearBehavior : IBehavior
  {
    public void DefendTerritory()
    {
      Console.WriteLine("Defending its territory");
    }

    public void Rest()
    {
      Console.WriteLine("Resting");
    }

    public void Hunt()
    {
      Console.WriteLine("Hunting");
    }
  }
}