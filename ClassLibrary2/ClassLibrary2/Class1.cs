using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class StringAverage
    {
        //enum stringNum { zero, one, two, three, four, five, six, seven, eight, nine };

        public static string AverageString(string str)
        {
            char[] splitString = { ' ' };  //設定切割字元
            int total = 0;
            int average;
            string avg = "";
            string[] numbers = str.Split(splitString);  //切割傳入的字串(用空白切割後，把切割的字元存在字串陣列中)
            int flag = 0;

            foreach (string s in numbers) //將陣列的元素一個一個抓出來比對
            {
                if (s != "")  //如果陣列元素沒有為空，就正常比對
                {
                    switch (s)
                    {
                        case "zero":
                            total = total + 0;
                            break;

                        case "one":
                            total = total + 1;
                            break;

                        case "two":
                            total = total + 2;
                            break;

                        case "three":
                            total = total + 3;
                            break;

                        case "four":
                            total = total + 4;
                            break;

                        case "five":
                            total = total + 5;
                            break;

                        case "six":
                            total = total + 6;
                            break;

                        case "seven":
                            total = total + 7;
                            break;

                        case "eight":
                            total = total + 8;
                            break;

                        case "nine":
                            total = total + 9;
                            break;

                        default:
                            flag = 1;
                            break;

                    }
                }
                else  //若為空，就把total 設成-1，強迫跳進avg判斷式的else中
                {
                    total = -1;
                }

            }
           
            int i = numbers.Length;
            average = (int)(total / i);  //計算平均值(取int)
            
            if (flag == 1)
            {
                average = -1;
            }

            if (average == 0)
            {
                avg = "zero";
            }

            else if (average == 1)
            {
                avg = "one";
            }

            else if (average == 2)
            {
                avg = "two";
            }

            else if (average == 3)
            {
                avg = "three";
            }

            else if (average == 4)
            {
                avg = "four";
            }

            else if (average == 5)
            {
                avg = "five";
            }

            else if (average == 6)
            {
                avg = "six";
            }

            else if (average == 7)
            {
                avg = "seven";
            }

            else if (average == 8)
            {
                avg = "eight";
            }

            else if (average == 9)
            {
                avg = "nine";
            }

            else
            {
                avg = "n/a";
            }

            return avg;
        }

    }

}
