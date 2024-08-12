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
            Stack<char> stack = new Stack<char>();
            //Act
            var res = ParaChecker.IsBalanced(stack);
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsBalancedWithOneParaSet_ShouldReturnTrue()
        {
            //Arrange
            Stack<char> stack = ParaChecker.createStack("()");
            //Act
            var res = ParaChecker.IsBalanced(stack);
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsBalancedWithMultiParaSets_ShouldReturnTrue()
        {
            //Arrange
            Stack<char> stack = ParaChecker.createStack("{([})]");
            //Act
            var res = ParaChecker.IsBalanced(stack);
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void IsBalancedTest_StringIsNotBalanced_ShouldReturnFalse()
        {
            //Arrange
            Stack<char> stack = ParaChecker.createStack("(string");
            //Act
            var res = ParaChecker.IsBalanced(stack);
            //Assert
            Assert.IsFalse(res);
        }
    }
}