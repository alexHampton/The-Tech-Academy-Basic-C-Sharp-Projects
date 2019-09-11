using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndIterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Create an array, ask user to input a string. Use loop to add user input to each element in the array.
            //string[] addToArray = new string[] { "1: ", "2: ", "3: ", "4: ", "5: " };
            //Console.WriteLine("Please type something, anything at all: ");
            //string userInput1 = Console.ReadLine();

            //for (int i = 0; i < addToArray.Length; i++)
            //{
            //    addToArray[i] = addToArray[i] + userInput1;
            //    Console.WriteLine(addToArray[i]);
            //}
            //Console.ReadLine();





            //////2. Create an infinite loop
            ////for (int j = 1; j > 0; j++)
            ////{
            ////    Console.WriteLine(j);
            ////}





            ////3. Fix the infinite loop so it will execute
            //for (int k = 1; k <= 10; k++)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.Read();





            ////4. Create a loop that uses a "<" comparison to determine whether to continue the loop or not.
            //for (int l = 0; l < 20; l += 2)
            //{
            //    Console.WriteLine(l);
            //}
            //Console.Read();





            ////5. Same as "4." but use a "<=" operator
            //for (int m = 0; m <= 20; m += 2)
            //{
            //    Console.WriteLine(m);
            //}
            //Console.Read();





            //6. Create a list of strings where each element is unique. Ask user to select text to search for in the List.
            //   Create a loop that iterates through the List and displays the index of the array that contains matching text
            //   on the screen.

            List<string> stateList = new List<string>() { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
                "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine",
                "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
                "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island",
                "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };

            // I made a For loop to put all the states to lower case because I didn't want to go through manually and do it. 
            for (int n = 0; n < stateList.Count; n++)
            {
                stateList[n] = stateList[n].ToLower();
            }

            Console.WriteLine("Please use a term to search the List: "); //user can search for any string
            string userInput = Console.ReadLine().ToLower(); // converts user's string to lower case in case they use upper case.

            bool containsUserInput = false; // If the below "if" statement doesn't fire, then the search wasn't found on the list, and this variable will remain false.

            foreach (string state in stateList)
            {
                if (state.Contains(userInput)) // If user's input is found in the element of the list, this branch will execute.
                {
                    Console.WriteLine(state + " includes your text at index " + state.IndexOf(userInput)); // Says the index number of the element in the list where the user input is found.
                    containsUserInput = true; // This boolean variable is switched to true so that the "SEARCH NOT FOUND" message doesn't fire.

                    // This is used to exit the program once a match is found. If you remove this code, it will show every match within the List.
                    Console.Read();
                    return;

                }
            }

            if (!containsUserInput)
            {
                Console.WriteLine("Your search is not found in this List.");
            }





            // 7. Add code to the above loop that tells a user if they put in text that isn't in the List
            //    DONE. LINE 75 AND LINE 91.





            // 8. Add code to that above loop that stops it from executing once a match has been found.
            //    DONE. LINE 85.





            // 9. Create a list of strings that has at least two identical strings in the list. User inputs a search. Loop iterates through the list, 
            //    displays the indices of the array that contain matching text on the screen

            List<string> fruitList = new List<string>() { "apple", "banana", "cherry", "banana", "kiwi", "apple", "orange", "lemon", "grapes" };
            Console.WriteLine("Please search for a fruit on the list");
            string userFruitInput = Console.ReadLine().ToLower();

            bool haveThatFruit = false; // This boolean will change in the below "if" statement if we have that fruit.

            // Unlike the pervious program about states, this will only match if the user perfectly matches the word to a word on the List.
            for (int o = 0; o < fruitList.Count; o++)
            {
                if (fruitList[o] == userFruitInput)
                {
                    Console.WriteLine("We have that fruit at index " + o);
                    haveThatFruit = true;
                }
            }

            if (!haveThatFruit) // If we don't have that fruit, then let the user know.
            {
                Console.WriteLine("We not have that fruit... :(");
            }





            //10.Add code that tells a user if they put in text that isn't in the List.
            //   DONE. LINE 113 AND 125.





           // 11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that
           //     evaluates each item in the list, and displays a message showing the string and whether or not it has already
           //     apeared in the list.

           List<string> alphabetList = new List<string>() { "a", "c", "f", "b", "y", "b", "f", "c", "l" };
            List<string> appearedLetters = new List<string>(); // List used for storing letters as they appear.

            foreach (string letter in alphabetList)
            {
                if (appearedLetters.Contains(letter))
                {
                    Console.WriteLine(letter + " has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine(letter + " has not appeared before this occurrence.");
                }
                appearedLetters.Add(letter); // After each loop, the letter is added to the appeared letter list.
            }





            Console.Read();
        }
    }
}
