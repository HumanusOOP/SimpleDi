using Exempel.Logic.Interfaces;

namespace Exempel.Logic
{
    public class MyLogicImpl : IMyLogic
    {
        private readonly IMySubLogic _mySubLogic;

        public MyLogicImpl(IMySubLogic mySubLogic)
        {
            _mySubLogic = mySubLogic;
        }

        public double MultiplyAndAdd(double a, double b)
        {
            return  Multiply(a,b) + _mySubLogic.Add(a,b);
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
