using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCalc.Domain;

namespace NCalc.Tests {
    [TestClass]
    public class NaNTests {

        [TestMethod]
        public void CanSumNaN() {
            double p1 = Double.NaN;
            double p2 = 1;
            Expression ex = new Expression("p1 + p2");
            ex.EvaluateBinaryExpression += ex_EvaluateBinaryExpression;
            ex.Parameters["p1"] = p1;
            ex.Parameters["p2"] = p2;

            double x = (double)ex.Evaluate();
            Assert.AreEqual(1, x);

        }

        [TestMethod]
        public void Can_sum_NaN_complex() {
            double p1 = Double.NaN;
            double p2 = 1;
            Expression ex = new Expression("p1 + 1+ 2 * 2 + (2+1) + p2");
            ex.EvaluateBinaryExpression += ex_EvaluateBinaryExpression;
            ex.Parameters["p1"] = p1;
            ex.Parameters["p2"] = p2;

            double x = (double)ex.Evaluate();
        }

        void ex_EvaluateBinaryExpression(BinaryExpressionType type, BinaryExpressionArgs args) {
            if (type == BinaryExpressionType.Plus) {
                double left = Convert.ToDouble(args.LeftValue);
                double right = Convert.ToDouble(args.RightValue);
                left = Double.IsNaN(left) ? 0 : left;
                right = Double.IsNaN(right) ? 0 : right;
                args.Result = left + right;
            }
        }
    }
}
