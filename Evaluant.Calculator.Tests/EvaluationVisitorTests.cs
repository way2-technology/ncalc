using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCalc.Domain;

namespace NCalc.Tests {
    [TestClass]
    public class EvaluationVisitorTests {

        [TestMethod]
        public void ShouldReplaceNullLeftValueWhenEvaluateBinaryExpressionIsSet()
        {
            var  expression = new Expression("p1 + p2");
            expression.EvaluateBinaryExpression += ex_EvaluateBinaryExpression;
            expression.Parameters["p1"] = null;
            expression.Parameters["p2"] = 5.1m;

            var actual = expression.Evaluate();

            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(7.1m, (Decimal)actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ShouldNotReplaceNullLeftValueWhenEvaluateBinaryExpressionIsNotSet() {
            var expression = new Expression("p1 + p2");
            expression.Parameters["p1"] = null;
            expression.Parameters["p2"] = 5.1m;
            
            expression.Evaluate();
        }

        [TestMethod]
        public void ShouldReplaceNullRightValueWhenEvaluateBinaryExpressionIsSet() {
            var expression = new Expression("p1 + p2");
            expression.EvaluateBinaryExpression += ex_EvaluateBinaryExpression;
            expression.Parameters["p1"] = 5.1m;
            expression.Parameters["p2"] = null;

            var actual = expression.Evaluate();

            Assert.AreEqual(typeof(Decimal), actual.GetType());
            Assert.AreEqual(7.1m, (Decimal) actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ShouldNotReplaceNullRightValueWhenEvaluateBinaryExpressionIsNotSet() {
            var expression = new Expression("p1 + p2");
            expression.Parameters["p1"] = 5.1m;
            expression.Parameters["p2"] = null;

            expression.Evaluate();
        }

        private static void ex_EvaluateBinaryExpression(BinaryExpressionType type, BinaryExpressionArgs args) {
            args.LeftValue = args.LeftValue ?? 2;
            args.RightValue = args.RightValue ?? 2;
        }
    }
}
