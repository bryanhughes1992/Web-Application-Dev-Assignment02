using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_BryanHughes.Controllers
{
    public class Assignment2Controller : ApiController
    {
        /// <summary>
        /// https://cemc.math.uwaterloo.ca/contests/computing/2020/ccc/juniorEF.pdf
        /// Barley the dog loves treats. At the end of the day he is either happy or sad depending on the 
        /// number and size of treats he receives throughout the day.The treats come in three sizes: small,
        /// medium, and large. His happiness score can be measured using the following formula:
        /// 
        /// (1 x S) + (2 x M) + (3 x L)
        /// 
        /// Where S is the number of small treats, M is the number of medium treats and L is the number of
        /// large treats. If Barley’s happiness score is 10 or greater then he is happy. Otherwise, he is sad.
        /// </summary>
        /// <param name="small">Number of Small Treats</param>
        /// <param name="medium">Number of Medium Treats</param>
        /// <param name="large">Number of Large Treats</param>
        /// <returns>Whether Barley the Dog is happy or sad.</returns>
        [HttpGet]
        [Route("api/Assignment2/HappyMeter/{small}/{medium}/{large}")]
        public string HappyMeter(int small, int medium, int large)
        {
            int happienessScore = (1 * small) + (2 * medium) + (large * 3);
            if (happienessScore < 0 || small < 0 || medium < 0 || large < 0)
            {
                return "No negative values";
            } else if (happienessScore < 10)
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

        /// <summary>
        /// Diana is playing a game with two dice. One side has 'DiceOneSides',
        /// the other side has 'DiceTwoSides'. This program determines how many ways
        /// Diana can get the value of 10 with the number of sides provided for each dice.
        /// </summary>
        /// <param name="DiceOneSides">Number of sides for first dice.</param>
        /// <param name="DiceTwoSides">Number of sides for second dice.</param>
        /// <returns>A string with the number of ways to achieve the sum of 10</returns>
        [HttpGet]
        [Route("api/Assignment2/DiceGame/{DiceOneSides}/{DiceTwoSides}")]
        public string DiceGame(int DiceOneSides, int DiceTwoSides)
        {
            //Input Validation
            if (DiceOneSides <= 0 || DiceTwoSides <= 0)
            {
                return "INPUT VALUES GREATER THAN 0";
            }

            // A dice represented as an array of int's
            // Initialized to the size of 'DiceOneSides', giving 'DiceOne' it's number of sides.
            int[] DiceOne = new int [DiceOneSides];

            // Loops through the first dice, 'DiceOne', adding a face value based off it's index in the array.
            // if 'i' is at position 0, it's the '1' face on the dice. 
            // This loop add's 1 to 'i' until the user inputed number of sides is reached.
            for(int i = 0; i < DiceOneSides; i++)
            {
                DiceOne[i] = i + 1;
            }

            // A second dice represented as an array of int's
            // Initialized to the size of 'DiceTwoSides', giving 'DiceTwo' it's number of sides.
            int[] DiceTwo = new int [DiceTwoSides];

            // Loops through the second dice, 'DiceTwo', adding a face value based off it's index in the array.
            // If 'i' is at position 0, it's the '1' face on the dice. 
            // This loop add's 1 to 'i' until the user inputed number of sides is reached.
            for (int i = 0; i < DiceTwoSides; i++)
            {
                DiceTwo[i] = i + 1;
            }
            
            // A variable for the number of ways 
            int NumOfWays = 0;

            //The first loop iterates through the first set of faces
            for (int i = 0; i < DiceOneSides; i++)
            {
                //The second loop iterates through the second set of faces
                for (int j = 0; j < DiceTwoSides; j++)
                {
                    //This variable is the sum of the two numbers added together
                    int sum = DiceOne[ i ] + DiceTwo[ j ];
                    //If the sum is equal to 10, then 'NumOfWays' is increased by one
                    if (sum == 10)
                    {
                        NumOfWays++;
                    }
                }
            }

            // A string literal, with the number of ways nested inside.
            string ReturnMessage = $"There are {NumOfWays} ways to get the sum 10";

            return ReturnMessage;
        }
    }
}
