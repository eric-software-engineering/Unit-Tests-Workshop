using System;
using System.Collections.Generic;
using UnitTest.Enums;
using UnitTest.Interfaces;

namespace UnitTest.Classes
{
  // Single Responsibility principle
  public class Jungle : ITerritory
  {
    private readonly Random _random;

    public Jungle()
    {
      _random = new Random();
    }

    public IList<IAnimal> TrespassingAnimals { get; set; }

    public TerritorrySize Size => TerritorrySize.Small;

    // Randomness to solve in the test environment
    public void NewDay()
    {
      TrespassingAnimals = new List<IAnimal>();
      for (var i = 0; i < _random.Next(0, (int) Size); i++)
        TrespassingAnimals.Add(new Bear(new Jungle(), new BearBehavior()));
    }
  }
}