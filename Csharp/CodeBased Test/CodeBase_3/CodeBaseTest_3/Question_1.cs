using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest_3
{
    class Cricket
    {
        public void Pointscalculation(int no_of_Matches)
        {
            //create a list to store the scores for each match
            List<double> scores = new List<double>();
            //loop  to input score
            for (int i = 0; i < no_of_Matches; i++)
            {
                Console.Write($"Enter score for Match {i + 1}: ");
                //to parse the user input (Score)
                if (double.TryParse(Console.ReadLine(), out double score))
                {
                    scores.Add(score);// add the score to the list
                }
                else
                {
                    //Display error message for wrong input and retry the match
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; //Decrement i to re-enter the score
                }
            }
            // calculate the total score by summing up all the scores 
            double totalScore = 0;
            foreach (double score in scores)
            {
                totalScore += score;
            }
            // calculate the Avg score
            double averageScore = totalScore / no_of_Matches;

            // display the total score of all matches
            Console.WriteLine($"Total Score: {totalScore}");
            Console.WriteLine($"Average Score: {averageScore}");
        }

        static void Main(string[] args)
        {
            Cricket cricketGame = new Cricket();

            Console.Write("Enter the number of Matches: ");

            //try to parse th user input as an integer(no.of matches)
            if (int.TryParse(Console.ReadLine(), out int no_of_Matches))
            {
                cricketGame.Pointscalculation(no_of_Matches);
            }
            else
            {
                //display error message
                Console.WriteLine("Invalid input. Please enter a valid number of Matches.");
                
            }
            Console.ReadLine();
        }
    }
        
}
   
