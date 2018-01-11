﻿using System;

namespace _08.CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double FirstPdoubleDistance = CalculateDistanceToZero(X1, Y1);
            double SecondPdoubleDistance = CalculateDistanceToZero(X2, Y2);
            if (FirstPdoubleDistance <= SecondPdoubleDistance) Console.WriteLine($"({X1}, {Y1})");
            else Console.WriteLine($"({X2}, {Y2})");
        }
        private static double CalculateDistanceToZero(double X, double Y)
        {
            double Distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return Distance;
        }
    }
}