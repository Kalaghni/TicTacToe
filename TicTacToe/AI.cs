using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AI
    {
      /*  public bool valueCheck(string[,] valArray, int val1, int val2, int val3, int val4, int val5, int val6, int val7, int val8, int val9, int val10,)
        {
            return (valArray[val1, val1] == valArray[val1, val1] && valArray[val1, val1] == "O" && valArray[val1, val1] == "-");
        }*/

        #region Impossible Ai
        public string[,] ImpossibleAI(string[,] valueArray)
        {
            //Check for potential win and place O
            if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 1] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 0] && valueArray[1, 0] == "O" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 2] == "O" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 1] && valueArray[2, 1] == "O" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 1] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[2, 1] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 2] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[0, 2] && valueArray[0, 2] == "O" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 1] && valueArray[2, 1] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //Check for blocks after checking all potential winning locations
            else if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 0] && valueArray[1, 0] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[2, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 2] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //Blocks and corner-corner checkmates
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }

            //blocks any corner "checkmates"
            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[1, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[1, 0] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }

            else if (valueArray[1, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }

            else if (valueArray[2, 1] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[2, 1] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }


            //Blocks "L-shaped" checkmates
            else if (valueArray[1, 0] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 2] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 0] && valueArray[0, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[2, 1] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            //Checks if middle spot is open
            else if (valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //checks any other potentially winning spots
            else if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[0, 0] == valueArray[1, 0] && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 0] && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 1] && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 1] && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[2, 1] == valueArray[2, 2] && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 2] == valueArray[2, 2] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 2] && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[0, 2] && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 2] && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 0] && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 1] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 1] && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[2, 1] == valueArray[1, 2] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            //Places in any leftover spot if no blocks or wins are possible
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (valueArray[x, y] == "-")
                        {
                            valueArray[x, y] = "O";
                            break;
                        }
                    }
                }
            }
            return valueArray;
        }
        #endregion

        #region Medium AI
        public string[,] MediumAI(string[,] valueArray)
        {
            //Check for potential win and place O
            if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 1] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 0] && valueArray[1, 0] == "O" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 2] == "O" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 1] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //Check for blocks after checking all potential winning locations
            else if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[2, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[2, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //blocks any corner "checkmates"
            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[1, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[1, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }


            //Blocks "L-shaped" checkmates
            else if (valueArray[1, 0] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 0] && valueArray[0, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[2, 1] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            //Checks if middle spot is open
            else if (valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //checks any other potentially winning spots
            else if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[0, 0] == valueArray[1, 0] && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 1] && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[2, 1] == valueArray[2, 2] && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 2] == valueArray[2, 2] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[0, 2] && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 0] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[2, 1] == valueArray[1, 2] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            //Places in any leftover spot if no blocks or wins are possible
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (valueArray[x, y] == "-")
                        {
                            valueArray[x, y] = "O";
                            break;
                        }
                    }
                }
            }
            return valueArray;
        }
        #endregion

        #region Easy AI 
        public string[,] EasyAI(string[,] valueArray)
        {
            //Check for potential win and place O
            if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 1] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 2] == "O" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 1] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[1, 1] == "O" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[2, 0] == "O" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 2] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 2] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[1, 2] == "-")
            {
                valueArray[1, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[2, 2] && valueArray[2, 2] == "O" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //Check for blocks after checking all potential winning locations
            else if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 1] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[2, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 1] == valueArray[2, 2] && valueArray[2, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[0, 2] == valueArray[1, 1] && valueArray[1, 1] == "X" && valueArray[2, 0] == "-")
            {
                valueArray[2, 0] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 2] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            else if (valueArray[0, 1] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }
            //blocks any corner "checkmates"
            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[1, 0] == "X" && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[1, 0] == valueArray[2, 1] && valueArray[2, 1] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }

            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 1] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }


            //Blocks "L-shaped" checkmates
            else if (valueArray[1, 0] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[2, 1] == valueArray[0, 2] && valueArray[0, 2] == "X" && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            //Checks if middle spot is open
            else if (valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            //checks any other potentially winning spots
            else if (valueArray[0, 0] == valueArray[0, 1] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            else if (valueArray[0, 1] == valueArray[1, 1] && valueArray[2, 1] == "-")
            {
                valueArray[2, 1] = "O";
            }
            else if (valueArray[1, 1] == valueArray[1, 2] && valueArray[1, 0] == "-")
            {
                valueArray[1, 0] = "O";
            }

            else if (valueArray[1, 1] == valueArray[2, 0] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }
            else if (valueArray[0, 0] == valueArray[0, 2] && valueArray[0, 1] == "-")
            {
                valueArray[0, 1] = "O";
            }
            else if (valueArray[1, 0] == valueArray[1, 2] && valueArray[1, 1] == "-")
            {
                valueArray[1, 1] = "O";
            }

            else if (valueArray[0, 1] == valueArray[1, 0] && valueArray[0, 0] == "-")
            {
                valueArray[0, 0] = "O";
            }
            else if (valueArray[2, 1] == valueArray[1, 2] && valueArray[2, 2] == "-")
            {
                valueArray[2, 2] = "O";
            }
            else if (valueArray[1, 2] == valueArray[0, 1] && valueArray[0, 2] == "-")
            {
                valueArray[0, 2] = "O";
            }

            //Places in any leftover spot if no blocks or wins are possible
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (valueArray[x, y] == "-")
                        {
                            valueArray[x, y] = "O";
                            break;
                        }
                    }
                }
            }
            return valueArray;
        }
        #endregion
    }
}
