using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhuzinaDR.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;
            switch (n)
            {
                case 1:
                    if (m >= 2)
                        res = (m - 1) + "." + "01";
                    else
                        res = 31 + "." + "01";
                    break;

                case 2:
                    if (m >= 2)
                        res = (m - 1) + "." + "02";
                    else
                        res = 31 + "." + "01";
                    break;
                case 3:
                    if (m >= 2)
                        res = (m - 1) + "." + "03";
                    else
                        res = 28 + "." + "02";
                    break;
                case 4:
                    if (m >= 2)
                        res = (m - 1) + "." + "04";
                    else
                        res = 31 + "." + "03";
                    break;
                case 5:
                    if (m >= 2)
                        res = (m - 1) + "." + "05";
                    else
                        res = 30 + "." + "04";
                    break;
                case 6:
                    if (m >= 2)
                        res = (m - 1) + "." + "06";
                    else
                        res = 31 + "." + "05";
                    break;
                case 7:
                    if (m >= 2)
                        res = (m - 1) + "." + "07";
                    else
                        res = 30 + "." + "06";
                    break;
                case 8:
                    if (m >= 2)
                        res = ((m - 1) + "." + "08");
                    else
                        res = 31 + "." + "07";
                    break;
                case 9:
                    if (m >= 2)
                        res = (m - 1) + "." + "09";
                    else
                        res = 31 + "." + "08";
                    break;
                case 10:
                    if (m >= 2)
                        res = (m - 1) + "." + "10";
                    else
                        res = 30 + "." + "09";
                    break;
                case 11:
                    if (m >= 2)
                        res = (m - 1) + "." + "11";
                    else
                        res = 31 + "." + "10";
                    break;
                case 12:
                    if (m >= 2)
                        res = ((m - 1) + "." + "12");
                    else
                        res = 30 + "." + "11";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение{n}");


            }
            return (res);

        }
    }
}