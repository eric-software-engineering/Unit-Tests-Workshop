using System;
using UnitTest.Interfaces;

namespace UnitTest.Classes
{
  public class Bear : IAnimal
  {
    // Dependency Inversion principle
    private readonly IBehavior _bearBehavior;

    private readonly ITerritory _bearTerritory;

    private readonly bool _hungry;

    // Composition over Inheritance
    public Bear(ITerritory territory, IBehavior behavior, bool hungry = false)
    {
      _bearTerritory = territory;
      _bearBehavior = behavior;
      _hungry = hungry;
    }

    public void PatrolOneDay()
    {
      Console.WriteLine("=> Patroling one day...");
      _bearTerritory.NewDay();
      if (_bearTerritory.TrespassingAnimals.Count > 0)
        if (_hungry)
          _bearBehavior.Hunt();
        else
          _bearBehavior.DefendTerritory();
      else
        _bearBehavior.Rest();
    }
  }
}