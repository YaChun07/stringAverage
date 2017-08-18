using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class StringAverage
    {
        enum stringNum { zero, one, two, three, four, five, six, seven, eight, nine };

        public static string AverageString(string str)
        {

            int total = 0;
            int average;

            if (string.IsNullOrEmpty(str))
            {
                return "n/a";
            }

            string[] numbers = str.Split(' ');

            foreach (string s in numbers)
            {
                int strintToInt = StringToInt(s);

                if (strintToInt == -1)
                {
                    return "n/a";
                }

                total += StringToInt(s);
            }

            average = (int)(total / numbers.Length);

            return intToString(average);

        }

        private static int StringToInt(string StringToInt)
        {
            try
            {
                stringNum StringToEnum = (stringNum)Enum.Parse(typeof(stringNum), StringToInt);
                int EnumToInt = (int)StringToEnum;
                return EnumToInt;
            }
            catch
            {
                return -1;
            }

        }

        private static string intToString(int intToString)
        {
            stringNum intToEnum = (stringNum)intToString;
            string EnumToString = (string)intToEnum.ToString();
            return EnumToString;
        }
    }

}
