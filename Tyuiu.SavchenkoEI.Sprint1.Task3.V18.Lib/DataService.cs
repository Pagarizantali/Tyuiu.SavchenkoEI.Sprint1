using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SavchenkoEI.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++;
            }
            while (b >= c)
            {
                b -= c;
                n++;
            }
            int count = 0;
            for (int i = 0; i < k; i++)
                count += n;
            return n;
        }
    }
}
