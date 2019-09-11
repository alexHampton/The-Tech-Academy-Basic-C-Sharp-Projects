using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise
{
    class MathOps // The Class is MathOps
    {
        // This is the Constructor for MathOps. It takes in an integer, then does
        // 3 different math operations on that integer, and saves the output of those
        // operations into 3 different variables.
        public MathOps(int userNum) 
        {
            this.AddTen(userNum); // Operation/Method 1.
            this.Square(userNum); // Operation/Method 2.
            this.MinusFour(userNum); // Operation/Method 3.
        }

        // Method 1: Add 10
        public void AddTen(int n)
        {
            addTen = n + 10;
        }

        // Method 2: Square
        public void Square(int n)
        {
            square = n * n;
        }

        //Method 3: Subtract 4
        public void MinusFour(int n)
        {
            minusfour = n - 4;
        }
        
        // These are the actual variables where the outputs are saved.
        public int addTen;
        public int square;
        public int minusfour;
    }
}
