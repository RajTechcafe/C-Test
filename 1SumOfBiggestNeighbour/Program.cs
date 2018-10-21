using System;
using System.Collections.Generic;
using System.Linq;
/*---------------------------------------------------------
 * This problem divided in three step 
 * 1: Find frequency of each element which cost O(n)
 * 2. Filtering the item whose frequency is atleast M-1 which cost is O(n)
 * 3. Finding sum of neighnouring element which cost is O(n-1)
 * Final Time complexity is O(n) and extra space O(n+1) for holding frequency of element.
 *--------------------------------------------------------
 */
namespace _1SumOfBiggestNeighbour
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOFBiggestNeighbour sumOFBiggestNeighbour = new SumOFBiggestNeighbour();
            Console.WriteLine("Enter your number comma seprated");
            var data = Console.ReadLine();
           var splitedData = data.Split(',').ToList();
            int[] input = new int[splitedData.Count];
            for (int i = 0; i < splitedData.Count; i++)
            {
                input[i] = Convert.ToInt32(splitedData[i]);
            }

           int result = sumOFBiggestNeighbour.Challenge(input);
            Console.WriteLine("Result is {0}", result.ToString());
            Console.ReadKey();
        }

       
    }
    class SumOFBiggestNeighbour
    {
        /// <summary>
        /// Method to find sum of biggest neighbour
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Challenge(int[] input)
        {
            try
            {
                List<int> inputList = new List<int>(input);
                int maxElement = inputList.Max();
                int[] frequencyOfElement = new int[maxElement + 1]; // creating array of the size of max element in input

                // Mark the frequency of each input element at respective index
                foreach (var item in inputList)
                {
                    if (frequencyOfElement[item] != 0)
                        frequencyOfElement[item] += 1;
                    else
                        frequencyOfElement[item] = 1;

                }
                List<int> frequency = new List<int>(frequencyOfElement);

                // Filtering the item which have occurencne of Max-1
                List<int> NeighbourList = inputList.Where(x => frequency[x] >= frequency.Max() - 1).ToList();
                List<int> SumOFNeighbour = new List<int>();

                // Finding the sum of neighbouring element
                for (int pos = 0; pos < NeighbourList.Count - 1; pos++)
                {
                    int sumofNeighbour = NeighbourList[pos] + NeighbourList[pos + 1];
                    SumOFNeighbour.Add(sumofNeighbour);
                }


                return SumOFNeighbour.Max();

            }
            catch (Exception)
            {

                return 0;
            }

        }
    }
}
