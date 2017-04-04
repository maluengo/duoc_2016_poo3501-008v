using System;
using System.Linq;
using atr.app.layer.backend.Contracts;
using atr.app.layer.backend.Factories;
using atr.app.layer.backend.Implement.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace atr.app.layer.tfd.Test
{
    /// <summary>
    /// @anotation
    /// Summary description for ListReaderTest
    /// </summary>
    [TestClass]
    public class ListReaderTest
    {
        [TestMethod]
        public void GetAllValueTest()
        {
            //Instancia directa.
            var objInstance1 = new ListReader();

            //Instancia indirecta por Interfaz.
            IReaderable objInstance2 = new ListReader();

            //Aserciones.
            var testInstDirect1 = objInstance1.GetAllValues();
            var testInstDirect2 = objInstance2.GetAllValues();

            //Probar. 
            Assert.IsNotNull(testInstDirect1);
            Assert.IsNotNull(testInstDirect2);

            Assert.IsTrue(testInstDirect1.Any());
            Assert.IsTrue(testInstDirect2.Any());

            //Encontrar Registro nro 4
            //1 alternativa.
            var auxValue = string.Empty;
            var flagIsOk = default(bool);

            foreach (var item in testInstDirect2)
            {
                //Case sensitive. ==
                if (string.Equals(item, "Registro nro 4", 
                    StringComparison.InvariantCulture))
                {
                    auxValue = item;
                    //Assert.IsTrue(string.Equals(item, "Registro nro 4"))
                }

                //Alternativa 2. 
                flagIsOk = string.Equals(item, "Registro nro 4");

                if (flagIsOk)
                {
                    break;
                }
            }

            Assert.IsTrue(string.Equals(auxValue, "Registro nro 4"));
            Assert.IsTrue(flagIsOk);

            //Linq.
            var auxOjectValue = testInstDirect2.FirstOrDefault
                (x => string.Equals(x, "Registro nro 4", StringComparison.InvariantCulture));

            Assert.IsNotNull(auxOjectValue);
            Assert.IsTrue(!object.ReferenceEquals(auxOjectValue, null));


            //Linq.
            //Assert.IsTrue(!object.ReferenceEquals(objInstance2.GetAllValues().FirstOrDefault
            // (x=> string.Equals(x, "Registro nro 4")), null));







        }

        [TestMethod]
        public void CountInListTest()
        {
            //Instancia directa.
            var objInstance1 = new ListReader();

            //Instancia indirecta por Interfaz.
            IReaderable objInstance2 = new ListReader();

            //Instancia de Factory.
            var factoryHelper = new AbstractFactory();
            var factoryHelper2 = new AbstractFactory(new ListReader());

            //Generar instancia a travéz del factory. 
            var generatedInstance2 = factoryHelper2.GetInstance();
            var generatedInstance1 = factoryHelper.GetInstance();

            //r collectionOfStrings = generatedInstance1.GetAllValues();
            var collectionOfString2 = generatedInstance2.GetAllValues();







        }




    }
}
