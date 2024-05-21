/*
Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
For e.g: Input : [0,2,1,1,9,1,1]
Output: [0,2,0,0,9,1,1]
*/

namespace Assignment_3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] originalArray= {0, 2, 1, 1, 9, 1, 1 };
            int targetNum = 1;

            Console.Write("Input: ");
            foreach (int i in originalArray)
            {
                
                Console.Write(i);
            }
           

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i] == targetNum && originalArray[i + 1] == targetNum)
                {
                    originalArray[i] = 0;
                    originalArray[i + 1] = 0;
                    break;
                }
              
            }
            Console.WriteLine();
            Console.Write("Output: ");
            foreach (int i in originalArray)
            {                
                Console.Write(i);
            }
        }

    
    }
    
}
