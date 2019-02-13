﻿using System;
using System.Collections.Generic;
using ProjectEuler.Calculation.Problems;

namespace ProjectEuler.Calculation
{
	internal class Program
	{
		public static void Main(string[] args)
		{
            IProblem problem = new Problem25();
            problem.Run();
		    Console.ReadLine();
		}
	}
}