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
        [Route("api/Assignment2/DiceGame/")]
        public string DiceGame(int DiceOneSides, int DiceTwoSides)
        {
            // An array of int's initialized to the size of 'DiceOneSides'
            int[] DiceOne = new int [DiceOneSides];
            for(int i = 0; i < DiceOneSides; i++)
            {
                DiceOne[i] = i + 1;
            }

            int[] DiceTwo = new int [DiceTwoSides];
            for (int i = 0; i < DiceTwoSides; i++)
            {
                DiceTwo[i] = i + 1;
            }

            int NumOfWays = 0;

            string ReturnMessage = $"There are {NumOfWays} to get the sum 10";

            return ReturnMessage;
        }
    }
}
