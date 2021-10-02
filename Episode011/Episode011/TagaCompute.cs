using System;
namespace Episode011
{
    public abstract class TagaCompute
    {
        private string _securedData;
        protected int _result;

        public int Result {
            get {
                return _result;
            }
        }

        public virtual void Compute(int num1, int num2)
        {
            _result = num1 + num2;
        }
    }
}
