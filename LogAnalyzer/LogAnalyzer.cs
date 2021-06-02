using System;

namespace LogAnalyzer
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName) {
            return fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase) ? true : false;
        }
    }
}
