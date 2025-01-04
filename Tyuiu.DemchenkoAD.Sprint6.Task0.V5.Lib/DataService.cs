using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DemchenkoAD.Sprint6.Task0.V5.Lib
{
    public class DataService : ISprint6Task0V5
    {
        public double Calculate(int x)
        {
            double y = -1.4 * Math.Pow(5, 3) + 2.3 * Math.Pow(5, 2) + 0.6 * 5;
            return Math.Round(y, 3);
        }
    }
}
