using System;
using System.Collections.Generic;
using System.Text;

namespace Static__Extension_Task.Models.Static_Class
{
    static class ExtentionMethods
    {
        public static bool IsOdd( this int Num)
        {
            if (Num%2==0)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int Num)
        {
            if (Num%2!=0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string Str)
        {
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i]>=48 && Str[i]<=57)
                {
                    return true;
                    break;
                }
            }
                return false;
        }
        public static string ToCapitalize(this string Str)
        {
            StringBuilder str = new StringBuilder();
            str.Append(char.ToUpper(Str[0]));
            str.Append(Str.Substring(1).ToLower());
            return str.ToString();
            //string upper = Str.ToUpper();
            //Console.WriteLine(upper);
        }
    }
}
