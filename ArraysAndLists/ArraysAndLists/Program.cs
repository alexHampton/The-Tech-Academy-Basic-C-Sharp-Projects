using System;
using System.Collections.Generic; //Used when creating Lists.


class Program
{
    static void Main()
    {

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.Read();

        //// Must initialize the total amount of items in an array in C#
        //// With arrays, you are stuck with the same length indefinitely.
        //// Used when you have a known, fixed quantity.
        //int[] numArray = new int[5]; // Length is 5
        //numArray[0] = 5;
        //numArray[1] = 3;
        //numArray[2] = 2;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// Less tedious way
        //// The length you set will still be the permamnent set length.
        //int[] numArray1 = new int[] { 5, 3, 2, 200, 5000 };

        //// Even quicker way
        //int[] numArray2 = { 5, 2, 10, 15, 24, 32, 7, 343 };

        //numArray2[4] = 30;


        //Console.WriteLine(numArray2[4]);
        //Console.Read();
    }
}
