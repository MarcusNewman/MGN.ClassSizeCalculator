using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Tests
{
    [TestClass]
    public class ClassSizeCalculatorTests
    {
        [TestMethod]
        public void AssemblyShouldExist()
        {
            var assembly = GetAssembly();
            Assert.IsNotNull(assembly, "Assembly should exist and be referenced.");
        }

        private static Assembly GetAssembly()
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.Load("MGN.ClassSizeCalculator");
            }
            catch { }

            return assembly;
        }

        [TestMethod]
        public void ClassSizeCalculatorClassShouldExist()
        {
            var type = GetAssembly().GetType("MGN.ClassSizeCalculator.ClassSizeCalculator");
            Assert.IsNotNull(type, "ClassSizeCalculator class should exist.");
        }

        [TestMethod]
        public void CalculateMethodShouldExist()
        {
            var methodInfo = GetAssembly().GetType("MGN.ClassSizeCalculator.ClassSizeCalculator").GetMethod("Calculate");
            Assert.IsNotNull(methodInfo, "Calculate method should exist.");
        }

        [TestMethod]
        public void CalculateMethodShouldAcceptAParameter()
        {
            var parameters = GetAssembly().GetType("MGN.ClassSizeCalculator.ClassSizeCalculator").GetMethod("Calculate").GetParameters();
            Assert.AreEqual(1, parameters.Length, "Calculate should accept a parameter.");
        }

        [TestMethod]
        public void CalculateMethodShouldAcceptAnIntArray()
        {
            var parameter = GetAssembly().GetType("MGN.ClassSizeCalculator.ClassSizeCalculator").GetMethod("Calculate").GetParameters()[0];
            Assert.AreEqual(parameter.ParameterType, typeof(int[]), "Calculate method should accept an integer array as its first parameter.");
        }
    }
}
