using System;

namespace CallEmAll
{
    public class Program
    {
        private static void Main(string[] args)
        {
            char[] letters = new char[] { 'g', 'b', 'c', 'j', 'b', 'd', 'h', 'a' };

            Console.WriteLine(MaxDistance(letters));
            Console.ReadKey();
        }

        /// <summary>
        /// The maximum distance for a pair of any two letters in some array a is defined as the largest difference between any a[i] and a[j]
        /// where i less than j and a[i] comes before a[j] in the alphabet. 
        /// Write a function in C# named MaxDistance (which takes array a as a parameter) 
        /// that calculates and returns the largest distance between two letters in the array.
        /// </summary>
        /// <param name="letters">Array of characters with at least length of 2</param>
        /// <returns>The largest difference between any a[i] and a[j] 
        /// where i less than j and a[i] comes before a[j] in the alphabet</returns>
        public static int MaxDistance(char[] letters)
        {
            // Input validation
            if (letters == null) throw new ArgumentException("Input array is null");
            if (letters.Length < 2) throw new ArgumentException("Input array must contain at least 2 characters");

            // ASSUMPTION: Want to limit to lower case characters only
            foreach(char c in letters)
            {
                if (c < 'a' || c > 'z') throw new ArgumentException("Letters must be lower case");
            }                      
            
            // Using constant extra space
            int maxDistance = 0;
            char minChar = letters[0];

            // For-loop is O(N) time
            for(int i = 1; i < letters.Length; i++)
            {
                // Calculate this distance between (non-inclusive) this character and the smallest character seen previously in the array
                int distance = letters[i] - minChar - 1;

                if (distance >= maxDistance)
                {
                    maxDistance = distance;
                    Console.WriteLine(string.Format("Distance between {0} - {1}: {2}", letters[i], minChar, distance));
                }

                // Update smallest character seen
                if (letters[i] < minChar) minChar = letters[i];                
            }

            return maxDistance;
        }
    }
}
