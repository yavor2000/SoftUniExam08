/* Problem 1. 
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double h = double.Parse(Console.ReadLine());
        List<double[]> point = new List<double[]>();
        for (int i = 0; i < 5; i++)
        {
            point.Add(new double[2]);
            point[i][0] = double.Parse(Console.ReadLine());
            point[i][1] = double.Parse(Console.ReadLine());
        }

        List<double[]> house = new List<double[]>();
        house.Add(new double[2]);
        house[house.Count - 1][0] = 0.0; //rect1 X1  0 0
        house[house.Count - 1][1] = 0.0; //rect1 Y1    0 1
        house.Add(new double[2]);
        house[house.Count - 1][0] = 3.0 * h; //rect1 X2   1 0
        house[house.Count - 1][1] = h; //rect1 Y2         1 1
        house.Add(new double[2]);
        house[house.Count - 1][0] = h; //rect2 X1         2 0
        house[house.Count - 1][1] = h; //rect2 Y1         2 1
        house.Add(new double[2]);
        house[house.Count - 1][0] = 2.0 * h; //rect2 X2   3 0
        house[house.Count - 1][1] = 4.0 * h; //rect2 Y2   3 1
        swap(ref house[0][0], ref house[1][0]);
        swap(ref house[0][1], ref house[1][1]);
        swap(ref house[2][0], ref house[3][0]);
        swap(ref house[2][1], ref house[3][1]);

        for (int i = 0; i < point.Count; i++)
        {
            if (   (point[i][0] >= house[0][0] && point[i][0] <= house[1][0] && point[i][1] >= house[0][1] && point[i][1] <= house[1][1])
                || (point[i][0] >= house[2][0] && point[i][0] <= house[3][0] && point[i][1] >= house[2][1] && point[i][1] <= house[3][1]))
                Console.WriteLine("inside");
            else Console.WriteLine("outside");
        }
    }

    private static void swap(ref double p1, ref double p2)
    {
        if (p1 > p2)
        {
            double tmp = p1;
            p1 = p2;
            p2 = tmp;
        }
    }
}