/* Problem 2. Stident Cables
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cables = 3;
        for (int i = 0; i < n; i++)
        {
            int size = int.Parse(Console.ReadLine());
            size = (Console.ReadLine() == "meters") ? size * 100 : size;
            if (size>=20)cables += size-3;
        }
        Console.WriteLine("{0}\n{1}", cables / 504, cables % 504);
    }
}