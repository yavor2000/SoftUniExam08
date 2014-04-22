/* Problem 4. Magic Car Numbers
 */

using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        int[] plate = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        char[] kat = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        for (int a = 0; a <= 9; a++)
            for (int b = 0; b <= 9; b++)
                for (int c = 0; c <= 9; c++)
                    for (int d = 0; d <= 9; d++)
                        for (int x = 0; x < plate.GetLength(0); x++)
                            for (int y = 0; y < plate.GetLength(0); y++)
                            {
                                if (40 + a + b + c + d + plate[x] + plate[y] == num)
                                {
                                    if ( (a == b && b == c && c == d) ||
                                         (a != b && b == c && c == d) ||
                                         (a == b && b == c && c != d) ||
                                         (a == b && b != c && c == d) ||
                                         (a != b && a == c && b == d) ||
                                         (a != b && a == d && b == c)
                                       )
                                    {
                                        count++; //Console.WriteLine("CA" + (a * 1000 + b * 100 + c * 10 + d).ToString().PadLeft(4, '0') + kat[x] + kat[y]);
                                    }

                                }
                            }
        Console.WriteLine(count);
    }
}