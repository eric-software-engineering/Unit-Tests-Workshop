namespace UnitTest.Interfaces
{
  // Interface Segregation principle
  public interface IBehavior
  {
    void DefendTerritory();

    void Rest();

    void Hunt();
  }
}