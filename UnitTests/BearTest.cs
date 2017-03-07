using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Classes;

namespace UnitTestProject
{
  [TestClass]
  public class BearTest
  {
    [TestMethod]
    public void TestPatrolWithTrespassingAnimal()
    {
      // Arrange
      var mockTerritory = new MockTerritory();
      var mockBehavior = new MockBehavior();

      mockTerritory.WithTrespassingAnimal();

      // Act
      Bear testBear = new Bear(mockTerritory.GetTerritory(), mockBehavior.GetBehavior());
      testBear.PatrolOneDay();

      // Assert
      mockBehavior.VerifyDefendTerritory();
    }

    [TestMethod]
    public void TestPatrolWithNoTrespassingAnimal()
    {
      // Arrange
      var mockTerritory = new MockTerritory();
      var mockBehavior = new MockBehavior();

      mockTerritory.WithNoTrespassingAnimal();

      // Act
      Bear testBear = new Bear(mockTerritory.GetTerritory(), mockBehavior.GetBehavior());
      testBear.PatrolOneDay();

      // Assert
      mockBehavior.VerifyRest();
    }

    [TestMethod]
    public void HuntTrespassersIfHungry()
    {
      // Arrange
      var mockTerritory = new MockTerritory();
      var mockBehavior = new MockBehavior();

      mockTerritory.WithTrespassingAnimal();

      // Act
      Bear testBear = new Bear(mockTerritory.GetTerritory(), mockBehavior.GetBehavior(), true);
      testBear.PatrolOneDay();

      // Assert
      mockBehavior.VerifyHunt();
    }
  }
}