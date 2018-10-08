using Exempel.Logic.Interfaces;

namespace Exempel.Logic
{
    public class MySubLogicImpl : IMySubLogic
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}