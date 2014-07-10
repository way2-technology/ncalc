using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCalc.Tests {

    [TestClass]
    public class NumbersTests
    {
        [TestMethod]
        public void ShouldAddSingleAndDecimal()
        {
            const Single a = (Single) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Add(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(15, (Decimal)actual);
        }

        [TestMethod]
        public void ShouldAddDoubleAndDecimal()
        {
            const Double a = (Double) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Add(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(15, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldAddDecimalAndSingle()
        {
            const Decimal a = (Decimal) 10;
            const Single b = (Single) 5;
            var actual = Numbers.Add(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(15, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldAddDecimalAndDouble()
        {
            const Decimal a = (Decimal) 10;
            const Double b = (Double) 5;
            var actual = Numbers.Add(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(15, (Decimal) actual);
        }

        [TestMethod]
        public void ShouldSubtractSingleAndDecimal()
        {
            const Single a = (Single) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Soustract(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(5, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldSubtractDoubleAndDecimal()
        {
            const Double a = (Double) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Soustract(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(5, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldSubtractDecimalAndSingle()
        {
            const Decimal a = (Decimal) 10;
            const Single b = (Single) 5;
            var actual = Numbers.Soustract(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(5, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldSubtractDecimalAndDouble()
        {
            const Decimal a = (Decimal) 10;
            const Double b = (Double) 5;
            var actual = Numbers.Soustract(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(5, (Decimal) actual);
        }

        [TestMethod]
        public void ShouldMultiplySingleAndDecimal()
        {
            const Single a = (Single) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Multiply(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(50, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldMultiplyDoubleAndDecimal()
        {
            const Double a = (Double) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Multiply(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(50, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldMultiplyDecimalAndSingle()
        {
            const Decimal a = (Decimal) 10;
            const Single b = (Single) 5;
            var actual = Numbers.Multiply(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(50, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldMultiplyDecimalAndDouble()
        {
            const Decimal a = (Decimal) 10;
            const Double b = (Double) 5;
            var actual = Numbers.Multiply(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(50, (Decimal) actual);
        }

        [TestMethod]
        public void ShouldDivideSingleAndDecimal()
        {
            const Single a = (Single) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Divide(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(2, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldDivideDoubleAndDecimal()
        {
            const Double a = (Double) 10;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Divide(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(2, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldDivideDecimalAndSingle()
        {
            const Decimal a = (Decimal) 10;
            const Single b = (Single) 5;
            var actual = Numbers.Divide(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(2, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldDivideDecimalAndDouble()
        {
            const Decimal a = (Decimal) 10;
            const Double b = (Double) 5;
            var actual = Numbers.Divide(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(2, (Decimal) actual);
        }

        [TestMethod]
        public void ShouldModuloSingleAndDecimal()
        {
            const Single a = (Single) 11;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Modulo(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(1, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldModuloDoubleAndDecimal()
        {
            const Double a = (Double) 11;
            const Decimal b = (Decimal) 5;
            var actual = Numbers.Modulo(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(1, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldModuloDecimalAndSingle()
        {
            const Decimal a = (Decimal) 11;
            const Single b = (Single) 5;
            var actual = Numbers.Modulo(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(1, (Decimal) actual);
        }
        
        [TestMethod]
        public void ShouldModuloDecimalAndDouble()
        {
            const Decimal a = (Decimal) 11;
            const Double b = (Double) 5;
            var actual = Numbers.Modulo(a, b);
            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(1, (Decimal) actual);
        }

    }
}
