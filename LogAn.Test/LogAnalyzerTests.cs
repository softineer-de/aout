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
  public class LogAnalyzerTests
  {
    [Test]
    public void IsValidFileName_BadExtension_ReturnsFalse()
    {
      LogAnalyzer analyzer = new LogAnalyzer();

      bool result = analyzer.IsValidLogFileName("fileWithBadExtension.foo");

      Assert.False(result);
    }
  }
}
