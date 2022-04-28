using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace TicTacToe
{
    class Game
    {
        MessageDialog win;

        public int playerScore;
        public int computerScore;
        public int ties;

        public async Task<bool> CheckForWin(string[,] numberArray)
        {
            for (int i = 0; i < 3; i++)
            {

                //Checks all horizontal wins
                if (numberArray[i, 0] == numberArray[i, 1] && numberArray[i, 1] == numberArray[i, 2] && numberArray[i, 1] != "-")
                {
                    if (numberArray[i, 1] == "X")
                    {
                        playerScore += 1;
                        win = new MessageDialog($"X Wins! New Score: {playerScore}");
                    }
                    else if (numberArray[i, 1] == "O")
                    {
                        computerScore += 1;
                        win = new MessageDialog($"O Wins! New Score: {computerScore}");

                    }

                    await win.ShowAsync();
                    return true;

                }

                //Checks all vertical wins
                else if (numberArray[0, i] == numberArray[1, i] && numberArray[1, i] == numberArray[2, i] && numberArray[1, i] != "-")
                {
                    if (numberArray[1, i] == "X")
                    {
                        playerScore++;
                        win = new MessageDialog($"X Wins! New Score: {playerScore}");
                    }
                    else if (numberArray[1, i] == "O")
                    {
                        computerScore++;
                        win = new MessageDialog($"O Wins! New Score: {computerScore}");
                    }

                    await win.ShowAsync();
                    return true;
                }
            }

            //checks diagonal wins
            if (numberArray[0, 0] == numberArray[1, 1] && numberArray[1, 1] == numberArray[2, 2] && numberArray[1, 1] != "-")
            {
                if (numberArray[1, 1] == "X")
                {
                    playerScore++;
                    win = new MessageDialog($"X Wins! New Score: {playerScore}");
                }
                else if (numberArray[1, 1] == "O")
                {
                    computerScore++;
                    win = new MessageDialog($"O Wins! New Score: {computerScore}");
                }

                await win.ShowAsync();
                return true;
            }

            else if (numberArray[0, 2] == numberArray[1, 1] && numberArray[1, 1] == numberArray[2, 0] && numberArray[1, 1] != "-")
            {
                if (numberArray[1, 1] == "X")
                {
                    playerScore++;
                    win = new MessageDialog($"X Wins! New Score: {playerScore}");
                }
                else if (numberArray[1, 1] == "O")
                {
                    computerScore++;
                    win = new MessageDialog($"O Wins! New Score: {computerScore}");
                }

                await win.ShowAsync();
                return true;
            }
            //Checks tie
            else if (numberArray[0, 0] != "-" && numberArray[0, 1] != "-" && numberArray[0, 2] != "-" && numberArray[1, 0] != "-" && numberArray[1, 1] != "-" && numberArray[1, 2] != "-" && numberArray[2, 0] != "-" && numberArray[2, 1] != "-" && numberArray[2, 2] != "-")
            {
                ties++;
                win = new MessageDialog("Round Tie! No points assigned.");
                await win.ShowAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
