using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LogAn;

namespace LogAn.Test
{
  [TestFixture]
  class MemCalculatorTests
  {
    MemCalculator MakeCalculator()
    {
      return new MemCalculator();
    }

    [Test]
    public void Add_WhenCalled_ChangesSum()
    {
      MemCalculator memCalculator = MakeCalculator();

      memCalculator.Add(1);
      int sum = memCalculator.Sum();

      Assert.AreEqual(1, sum);
    }

    [Test]
    public void Sum_ByDefault_ReturnsZero()
    {
      var memCalc = MakeCalculator();

      int lastSum = memCalc.Sum();

      Assert.AreEqual(0, lastSum);
    }
  }
}
