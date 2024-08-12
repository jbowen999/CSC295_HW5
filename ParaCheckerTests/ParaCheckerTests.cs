using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC295_HW5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295_HW5.Tests
{
    [TestClass()]
    public class ParaCheckerTests
    {
        [TestMethod()]
        public void IsBalancedTest_StringIsEmpty_ShouldBeTrue()
        {
            //Arrange
            //Act
            var res = ParaChecker.IsBalanced("");
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsHasWords_NoParas_ShouldBeTrue()
        {
            //Arrange
            //Act
            var res = ParaChecker.IsBalanced("Hello, World!");
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsBalancedWithOneParaSet_ShouldReturnTrue()
        {
            //Arrange
            //Act
            var res = ParaChecker.IsBalanced("()");
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsBalancedWithMultiParaSets_ShouldReturnTrue()
        {
            //Arrange
            //Act
            var res = ParaChecker.IsBalanced("{([})]");
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsBalancedWithOneParaSet_AndWordsInside_ShouldReturnTrue()
        {
            //Arrange
            //Act
            var res = ParaChecker.IsBalanced("(Hello, world!)");
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsNotBalanced_ShouldReturnFalse()
        {
            //Arrange
            //Act
            var res = ParaChecker.IsBalanced("(string");
            //Assert
            Assert.IsFalse(res);
        }
    }
}