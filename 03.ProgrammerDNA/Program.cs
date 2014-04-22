/* Problem 3. Programmer DNA
 */

using System;
using System.Text;

class Program
{
    static char start;
    static char[] programmer = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
    static int index = 0;
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        start = Console.ReadLine()[0];
        
        for (int i = 0; i < programmer.GetLength(0); i++)
            if (start == programmer[i]) { index = i; break; }
        int len = 1;
        int dir = 2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.', (7 - len) / 2) +DNA(len)+ new string('.', (7 - len) / 2));
            if (len >= 7) dir *= -1;
            len += dir;
            if (len < 0)
            {
                len = 1;
                dir = 2;
            }
        }
    }

    private static string DNA(int len)
    {
        StringBuilder line = new StringBuilder();
        for (int i = 0; i < len; i++)
        {
            line.Append(programmer[index]);
            index++;
        }
        index %= 7;
        return line.ToString();
    }

}