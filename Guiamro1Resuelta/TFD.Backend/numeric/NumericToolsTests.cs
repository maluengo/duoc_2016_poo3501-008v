using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._1.App.Back.numeric;

namespace TFD.Backend.numeric
{
    [TestClass()]
    public class NumericToolsTests
    {
        [TestMethod()]
        public void IsNumericTest()
        {

            //Inicializar contexto.
            var objTest = new NumericTools();

            //Generar contexto. 
            var test1 = "perrito";
            var test2 = "4";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            //Aserciones o resultados.
            var resultTes1 = objTest.IsNumeric(test1);
            var resultTes2 = objTest.IsNumeric(test2);
            var resultTes3 = objTest.IsNumeric(test3);
            var resultTes4 = objTest.IsNumeric(test4 as string);
            var resultTes5 = objTest.IsNumeric(test5);

            Assert.IsFalse(resultTes1);
            Assert.IsTrue(resultTes2);
            Assert.IsFalse(resultTes3);
            Assert.IsFalse(resultTes4);
            Assert.IsFalse(resultTes5);



        }
    }
}