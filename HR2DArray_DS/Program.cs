using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HR2DArray_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[6][]
            {
                new int[] { -9, -9, -9,  1, 1, 1 },
                new int[] {  0, -9,  0,  4, 3, 2 },
                new int[] { -9, -9, -9,  1, 2, 3 },
                new int[] {  0,  0,  8,  6, 6, 3 },
                new int[] {  0,  0,  0, -2, 0, 0 },
                new int[] {  0,  0,  1,  2, 4, 0 },
            };

            var largestHourglass = -2147483647;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int sum = arr[y][x] + arr[y][x + 1] + arr[y][x + 2] + arr[y + 1][x + 1] + arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];
                    if (sum > largestHourglass)
                    {
                        largestHourglass = sum;
                    }
                }
            }

            Console.WriteLine(largestHourglass);
        }
    }
}
