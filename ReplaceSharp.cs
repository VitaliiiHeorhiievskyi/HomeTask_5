using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    static class Replace
    {
        public static string[] ReplaceSharp(string[] data)
        {
            if (data == null)
                throw new ArgumentNullException();



            int countSharp = 0;

            foreach (var line in data)
            {
                foreach (var element in line)
                {
                    if (element == '#')
                        countSharp++;
                }
            }

            if (countSharp == 0 || countSharp % 2 != 0)
                throw new ArithmeticException("Count of sharp must be even");

            string[] lines = new string[data.Length];

            int countOpen = countSharp / 2;

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (data[i][j] == '#' && countOpen != 0)
                    {
                        lines[i] += '<';
                        countOpen--;
                    }
                    else if (data[i][j] == '#')
                    {
                        lines[i] += '>';
                    }
                    else lines[i] += data[i][j];
                }
            }

            return lines;
        }
    }
}
