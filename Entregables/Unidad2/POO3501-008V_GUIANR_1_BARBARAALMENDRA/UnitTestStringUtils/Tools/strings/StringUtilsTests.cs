using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Tools.strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Backend.MathCalculation.Tools.strings.Tests
{
    [TestClass()]
    public class StringUtilsTests
    {
        [TestMethod()]
        public void GetFirstOrLastValueTest()
        {
            var objTest = new StringUtils();

            var test1 = string.Empty;
            var test2 = default(string);
            var test3 = "4,123123";
            var test4 = string.Empty;
            var test5 = "   ";

            var resultado1 = objTest.GetFirstOrLastValue(test1);
            var resultado2 = objTest.GetFirstOrLastValue(test2);
            var resultado3 = objTest.GetFirstOrLastValue(test3);
            var resultado4 = objTest.GetFirstOrLastValue(test4);
            var resultado5 = objTest.GetFirstOrLastValue(test5);

            Assert.IsNull(resultado1);
            Assert.IsNull(resultado2);
            Assert.IsNull(resultado3);
            Assert.IsNull(resultado4);
            Assert.IsNotNull(resultado5);
            
    
        }
    }
}