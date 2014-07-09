using System;

namespace NCalc {
    public class BinaryExpressionArgs : EventArgs {
        public object LeftValue { get; set; }
        public object RightValue { get; set; }
        public string Operator { get; set; }

        internal bool ResultSetted { get; set; }

        private object _result;
        public object Result {
            get { return _result; }
            set {
                _result = value;
                ResultSetted = true;
            }
        }
    }
}