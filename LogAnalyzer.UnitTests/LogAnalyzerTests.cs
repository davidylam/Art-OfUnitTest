using System;
using Xunit;

namespace LogAnalyzer.UnitTests
{
    public class LogAnalyzerTests
    {
        //[Fact]
        //public void IsValidLogFileName_BadExtension_ReturnsFalse()
        //{
        //    var analyzer = new LogAnalyzer();
        //    bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

        //    Assert.False(result);
        //}

        //[Fact]
        //public void IsValidLogFileName_GoodExtensionLowerCase_ReturnTrue()
        //{
        //    var analyzer = new LogAnalyzer();
        //    bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");

        //    Assert.True(result);
        //}


        [Theory]
        [InlineData("filewithbadextension.foo", false)]
        [InlineData("filewithnoextension", false)]
        public void IsValidLogFileName_BadExtensions_ReturnFalse(string fileName, bool expected)
        {
            var analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(fileName);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("filewithgoodextension.SLF", true)]
        [InlineData("filewithgoodextension.slf", true)]
        public void IsValidLogFileName_GoodExtensions_ReturnTrue(string fileName, bool expected) {

            var analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(fileName);

            Assert.Equal(expected, result);
        }
    }
}
