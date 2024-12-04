using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NSSFParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unclean = "a)b(c)d"; //Input one
            string unclean2 = "))(("; //input two

            string cleaned = CleanExtra(unclean2);


        }
        public static string CleanExtra(string intVal)
        {
            string valid;
            if (intVal == null)
            {
                throw new System.ArgumentException("Value cannot be null", "original");
            }
            else
            {

                valid = Regex.Replace(intVal, " ", "").Replace("(", "").Replace(")", "").Replace(",", "").Replace("/", "").Replace("-", "");
            }

            return valid;
        }
    }
}
