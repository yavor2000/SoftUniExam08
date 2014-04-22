/* Problem 5. Bit Flipper
 */

using System;

class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString((long)n,2).PadLeft(64, '0'));
        int[] tripple = new int[3];
        tripple[0] = -1;
        tripple[1] = (int)(n >> 63 & 1);
        tripple[2] = (int)(n >> 62 & 1);

        for (int i = 61; i >= 0; i--)
        {
            tripple[0] = tripple[1];
            tripple[1] = tripple[2];
            tripple[2] = (int)(n >> i & 1);
            if (tripple[0] == tripple[1] && tripple[1]==tripple[2])
            {
                ulong mask = ((ulong)7 << i);
                if (tripple[0] == 1) n ^= mask;
                else n |= mask;
                tripple[0] = -1;
                tripple[1] = -2;
                tripple[2] = -3;
                //Console.WriteLine(Convert.ToString((long)n, 2).PadLeft(64, '0'));
            }
        }
        Console.WriteLine(n);
    }
}