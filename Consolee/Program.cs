﻿using System.Numerics;

namespace Consolee
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            AlgorithQue1 algorithQue1 = new();
            string x = "500";
            Console.WriteLine(x[2]);
            Console.WriteLine(algorithQue1.SumCalculator("91111111111", "9999998"));
            Console.WriteLine(AlgorithQue2.PowCalculator(3.5,4));
            Console.WriteLine(AlgorithmQue3.Calculator("1", "3", 4)[0]);
            Console.WriteLine(AlgorithmQue4.Calculator
                (new DateTime(2012,6,6)));
            Console.ReadLine(); // Programın kapanmaması için bekletme
        }
        protected internal class x
        { 
            //in mynotes
        }
      
    } 
}
