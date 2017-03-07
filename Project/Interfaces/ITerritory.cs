using System.Collections.Generic;
using UnitTest.Enums;

namespace UnitTest.Interfaces
{
  // Interface Segregation principle
  public interface ITerritory
  {
    IList<IAnimal> TrespassingAnimals { get; set; }

    TerritorrySize Size { get; }

    void NewDay();
  }
}