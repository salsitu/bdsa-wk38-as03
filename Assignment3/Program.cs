using System;

namespace BDSA2021.Assignment03
{
    public class Program
    {
        public delegate void StringFormatter(string str);
        public delegate bool NumChecker(string str, int num);

        static void Main(string[] args)
        {
            Queries.WizardsByRowling_LINQ();
        }

        public static void Reverse()
        {
            var rev = new StringFormatter(
                delegate (string str)
                {
                    for (int i = str.Length - 1; i >= 0; i--) {
                        Console.Write(str[i]);
                    }
                }
            );

            rev("Reverse");
        }

        public static bool IsNumericallyEqual(string str, int num)
        {
            var check = new NumChecker(
                delegate (string str, int num)
                {
                    bool isInt = Int32.TryParse(str, out int converted);

                    if (isInt) 
                    {
                        return num == converted;
                    }

                    return false;
                }
            );

            return check(str, num);
        }
    }
}
