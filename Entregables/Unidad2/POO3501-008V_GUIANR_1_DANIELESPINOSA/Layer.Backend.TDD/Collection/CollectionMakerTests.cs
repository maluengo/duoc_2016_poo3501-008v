using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer.Backend.MathCalculation.Collection.Tests
{
    [TestClass()]
    public class CollectionMakerTests
    {
        [TestMethod()]
        public void GetRandomCollectionByParameterTest()
        {
            CollectionMaker cm = new CollectionMaker();

            var value11 = default(int);
            var value12 = string.Empty;
            var value21 = 0;
            var value22 = "0";
            var value31 = 5;
            var value32 = "1,4";
            var value41 = default(int);
            var value42 = DBNull.Value;
            var value51 = 6;
            var value52 = "3,4";

            var result1 = cm.GetRandomCollectionByParameter(value11, value12);
            var result2 = cm.GetRandomCollectionByParameter(value21, value22);
            var result3 = cm.GetRandomCollectionByParameter(value31, value32);
            var result4 = cm.GetRandomCollectionByParameter(Convert.ToInt32(value41), value42.ToString());
            var result5 = cm.GetRandomCollectionByParameter(value51, value52);

            Assert.AreEqual(result1, default(List<Entities.Dto.NumbersDto>));
            Assert.AreEqual(result2, default(List<Entities.Dto.NumbersDto>));
            Assert.AreNotEqual(result3, default(List<Entities.Dto.NumbersDto>));
            Assert.AreEqual(result4, default(List<Entities.Dto.NumbersDto>));
            Assert.AreNotEqual(result5, default(List<Entities.Dto.NumbersDto>));

        }
    }
}