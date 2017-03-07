using Moq;
using UnitTest.Interfaces;

namespace UnitTestProject
{
  internal class MockTerritory
  {
    private readonly Mock<ITerritory> _mock;

    internal MockTerritory()
    {
      _mock = new Mock<ITerritory>();
    }

    internal MockTerritory WithTrespassingAnimal()
    {
      _mock.Setup(x => x.TrespassingAnimals.Count).Returns(1);
      return this;
    }

    internal MockTerritory WithNoTrespassingAnimal()
    {
      _mock.Setup(x => x.TrespassingAnimals.Count).Returns(0);
      return this;
    }

    internal MockTerritory OnAClearDay()
    {
      // Clear day logic here
      return this;
    }

    internal MockTerritory DuringSummer()
    {
      // Summer logic here
      return this;
    }

    internal ITerritory GetTerritory()
    {
      return _mock.Object;
    }
  }
}