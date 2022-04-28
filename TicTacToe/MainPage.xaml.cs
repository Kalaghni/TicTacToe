using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToe
{
    /// <summary>
    /// 
    /// Tic Tac Toe game against impossible AI
    /// Author: Josh Wood
    /// 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Update();
        }

        #region AI Call
        public void AIRound()
        {
            if (radEasy.IsChecked == true)
            {
                boardValues = ai.EasyAI(boardValues);
            }
            else if (radMedium.IsChecked == true)
            {
                boardValues = ai.MediumAI(boardValues);
            }
            else if (radImpossible.IsChecked == true)
            {
                boardValues = ai.ImpossibleAI(boardValues);
            }
        }

        #endregion

        string[,] boardValues = new string[,] { { "-", "-", "-" },
                                                { "-", "-", "-" },
                                                { "-", "-", "-" } };
        public int roundsPlayed = 0;
        int ticker = 1;

        #region Clear
        //End of round, sets all values and visuals back to default
        public void Clear()
        {
            txtOne.Text = "-";
            txtTwo.Text = "-";
            txtThree.Text = "-";
            txtFour.Text = "-";
            txtFive.Text = "-";
            txtSix.Text = "-";
            txtSeven.Text = "-";
            txtEight.Text = "-";
            txtNine.Text = "-";
            boardValues = new string[,] { { "-", "-", "-" },
                                          { "-", "-", "-" },
                                          { "-", "-", "-" } };
            ticker = 0;
            Update();
        }

        //Update method sets all visual letters to matching array value to assure accuracy, also checks for tie
        #endregion

        #region Update
        public void Update()
        {
            txtTies.Text = game.ties.ToString();
            txtRound.Text = roundsPlayed.ToString();
            txtPlayerScore.Text = game.playerScore.ToString();
            txtAiScore.Text = game.computerScore.ToString();
            txtOne.Text = boardValues[0, 0];
            txtTwo.Text = boardValues[0, 1];
            txtThree.Text = boardValues[0, 2];
            txtFour.Text = boardValues[1, 0];
            txtFive.Text = boardValues[1, 1];
            txtSix.Text = boardValues[1, 2];
            txtSeven.Text = boardValues[2, 0];
            txtEight.Text = boardValues[2, 1];
            txtNine.Text = boardValues[2, 2];
            if (ticker % 2 == 0)
            {
                txtTurn.Text = "O Turn";
            }
            else if (ticker % 2 != 0)
            {
                txtTurn.Text = "X Turn";
            }
        }
        #endregion

        #region Buttons
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        //Accessing TicTacToe and AI classes
        private readonly Game game = new Game();
        private readonly AI ai = new AI();

        public void btnClick(TextBlock txt, int[] placeholder)
        {

            //Play against AI (For each difficulty)
            if (!(bool)chkMulti.IsChecked && boardValues[placeholder[0], placeholder[1]] == "-")
            {
                txt.Text = "X";
                boardValues[placeholder[0], placeholder[1]] = "X";
                if (game.CheckForWin(boardValues).Result)
                {
                    Clear();
                    roundsPlayed++;
                }
                Update();
                AIRound();
                if (game.CheckForWin(boardValues).Result)
                {
                    Clear();
                    roundsPlayed++;
                }
                Update();
            }

            //Play multiplayer
            else if (boardValues[placeholder[0], placeholder[1]] == "-")
            {
                if (ticker % 2 == 0)
                {
                    txt.Text = "O";
                    txtTurn.Text = "X Turn";
                    boardValues[placeholder[0], placeholder[1]] = "O";
                }
                else if (ticker % 2 != 0)
                {
                    txt.Text = "X";
                    txtTurn.Text = "O Turn";
                    boardValues[placeholder[0], placeholder[1]] = "X";
                }
                ticker++;
                if (game.CheckForWin(boardValues).Result)
                {
                    Clear();
                    roundsPlayed++;
                }
                Update();
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtOne, new int[] { 0, 0 });
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtTwo, new int[] { 0, 1 });
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtThree, new int[] { 0, 2 });
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtFour, new int[] { 1, 0 });
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtFive, new int[] { 1, 1 });
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtSix, new int[] { 1, 2 });
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtTwo, new int[] { 2, 0 });
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtTwo, new int[] { 2, 1 });
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            btnClick(txtTwo, new int[] { 2, 2 });
        }

        //Sets scores and rounds back to zero
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            game.computerScore = 0;
            game.playerScore = 0;
            roundsPlayed = 0;
            game.ties = 0;
            Update();
        }

        #endregion
    }
}
