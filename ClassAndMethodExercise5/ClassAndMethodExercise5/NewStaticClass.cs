using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise5
{
    // Declare a class to be static.
    static class NewStaticClass // Since it is static, you can't instantiate objects. So if you want to use a method within the class, you call the class itself, then the method
    {
        public static int numPlusFive(int num)
        {
            input = num;
            return num + 5;
        }

        public static int input;
    }
}
