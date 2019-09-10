using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //// Iterate through integer array

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 90, 88, 92 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85) // Passing score is greater than 85.
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.Read();



        //// Iterate through string array

        //string[] names = { "Alex", "Josh", "Mika", "Billy", "Rob", "Amanda" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}
        //Console.ReadLine();

        //// foreach iteration
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(76);
        //testScores.Add(83);
        //testScores.Add(70);

        //foreach (int score in testScores) 
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}



        //// foreach iteration using a string list
        //List<string> names = new List<string>() { "Alex", "Mika", "Lily", "Billy", "Milly" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}


        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine("Amount of passing scores: " + passingScores.Count);

        Console.Read();
    }
}
