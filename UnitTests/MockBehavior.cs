using Moq;
using UnitTest.Interfaces;

namespace UnitTestProject
{
  internal class MockBehavior
  {
    private readonly Mock<IBehavior> _mock;

    internal MockBehavior()
    {
      _mock = new Mock<IBehavior>();
    }

    internal MockBehavior VerifyDefendTerritory()
    {
      _mock.Verify(x => x.DefendTerritory());
      return this;
    }

    internal MockBehavior VerifyRest()
    {
      _mock.Verify(x => x.Rest());
      return this;
    }

    internal MockBehavior VerifyHunt()
    {
      _mock.Verify(x => x.Hunt());
      return this;
    }

    internal IBehavior GetBehavior()
    {
      return _mock.Object;
    }
  }
}