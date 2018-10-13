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
    private LogAnalyzer MakeAnalyzer()
    {
      return new LogAnalyzer();
    }

    [TestCase("file.foo", false)]
    [TestCase("file.slf", true)]
    public void IsValidFileName_WhenCalled_ChangesState(string fileName, bool expected)
    {
      var analyzer = MakeAnalyzer();

      analyzer.IsValidLogFileName(fileName);

      Assert.AreEqual(expected, analyzer.WasLastFileNameValid);
    }

    [TestCase("file.foo", false)]
    [TestCase("file.slf", true)]
    [TestCase("file.SLF", true)]
    public void IsValidFileName_VariousExtensions_CheckThem(string fileName, bool expected)
    {
      LogAnalyzer analyzer = MakeAnalyzer();

      bool result = analyzer.IsValidLogFileName(fileName);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void IsValidFileName_EmptyFileName_Throws()
    {
      var analyzer = MakeAnalyzer();

      var ex = Assert.Catch<ArgumentException>(() => analyzer.IsValidLogFileName(""));

      StringAssert.Contains("filename has to be provided", ex.Message);
    }
    
  }
}
