using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassToEval;

namespace ClassToEvalTests
{
    
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathoperation;

        [TestInitialize]
        public void Init()
        {
            _mathoperation = new MathOperations();
        }

        [TestMethod]
        [DataRow(10, 10, 20)]
        [DataRow(25, 25, 50)]
        [DataRow(17, 43, 60)]
        public void Add_WithPositiveOperator_ReturnInt(int numberOne, int numberTwo, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _mathoperation.Add(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(10, 10, 1)]
        [DataRow(25, 5, 5)]
        [DataRow(50, 10, 5)]
        public void Divide_WithTwoNumbersSecondOneIsNotZero_ReturnsDivision(int numberOne, int numberTwo, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _mathoperation.Divide(numberOne, numberTwo));
        }

        [TestMethod]
        public void Divide_WithSecondNumberAsZero_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => _mathoperation.Divide(10, 0));
        }

        [TestMethod]
        public void GetOddNumbers_LimitIsZero_ReturnsEmptyList()
        {
            var limit = 0;

            var result = _mathoperation.GetOddNumbers(limit);

            Assert.IsTrue(!result.Any());
        }
    }
}

