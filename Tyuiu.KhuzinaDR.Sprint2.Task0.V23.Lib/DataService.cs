using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhuzinaDR.Sprint2.Task0.V23.Lib
{

    public class DataService : ISprint2Task0V23
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 690 == y;
            res[1] = x + 690 != y;
            res[2] = x < y;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = x + 1000 >= y;


            return res;

        }
    }
}