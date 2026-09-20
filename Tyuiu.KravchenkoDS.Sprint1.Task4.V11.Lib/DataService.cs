
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KravchenkoDS.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Atan(x) / Math.Exp(y), 3);
            return res; 
        }
    }
}
