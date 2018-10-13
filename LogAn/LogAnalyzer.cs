using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn
{
  public class LogAnalyzer
  {
    public bool WasLastFileNameValid { get; set; }

    public bool IsValidLogFileName(string FileName)
    {
      WasLastFileNameValid = false;

      if (string.IsNullOrEmpty(FileName))
      {
        throw new ArgumentException("filename has to be provided");
      }

      if (!FileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
      {
        return false;
      }

      WasLastFileNameValid = true;
      return true;
    }
  }
}
