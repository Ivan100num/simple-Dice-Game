//Ivan Garcia
// Date 1-22-24
// CS 3280, Assignment 2

using System;
using System.Drawing.Text;
using System.Security.Cryptography;


namespace Assignment2
{
    /// <summary>
    /// THis is the class Form where it contains the program code
    /// </summary>
    public partial class DiceGameForm : Form
    {
        /// <summary>
        /// This attribute, FreqNum is an array that stores the amount for Frequency that each number was rolled. 
        /// </summary>
        private int[] FreqNum = new int[7];
        /// <summary>
        /// This attribute, NumOfGuesses is an array that stores the number othe user guessed that number
        /// </summary>
        private int[] NumOfGusses = new int[7];
        /// <summary>
        /// This attribute, Precent is an array that stores the precentage that each number was rolled. 
        /// </summary>
        private double[] Percent = new double[7];
        /// <summary>
        /// This stores the number of times a user has played.
        /// </summary>
        private int increment = 0;
        /// <summary>
        /// This stores the number of times a user lost
        /// </summary>
        private int pointLost = 0;
        /// <summary>
        /// THis stores the number of times a user won
        /// </summary>
        private int pointWon = 0;

        /// <summary>
        /// This class stores the constatns, Won, Lost, and Neutal
        /// </summary>
        private enum Status { Won, Lost, Neutal }

        /// <summary>
        /// This is a method for Form1
        /// </summary>
        public DiceGameForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method gets called if the user clicks on the Roll Button.
        /// This method contians functions to increment and to check the result to see if the user won or lost.
        /// It also has a for loop to change the image of the dice whenever it rolls.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void button1_Click(object sender, EventArgs e)
        {

            string userInput = EnterBox.Text; // User enters a number
            Status Statuss;

            if (int.TryParse(userInput, out int userNumber)) //Checks if the input is a letter or character.
            {

                if (userNumber <= 6 && userNumber >= 1) //Checks if the input is a number between 1-6.
                {
                    ErrorLable.Text = ""; //Resets the ErrorLable text.

                    Random DiceNum = new Random(); // Generates random number from 1-6
                    int RandomDice = DiceNum.Next(1, 7);
                    CheckUserNumber(RandomDice, userNumber, out Statuss);//Method CheckUserNumber gets called.
                    GameResult(Statuss); //Method GameResult gets called.
                    FillingUpTables(RandomDice, userNumber); //Method FillingUpTables gets called.
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    for (int i = 1; i <= RandomDice; i++) // This for loop loops till it equals to the Random number
                    {
                        pictureBox.Image = Image.FromFile(@"Images\die" + i.ToString() + ".gif"); //Displays the certian dice image based on the random number
                        pictureBox.Refresh();
                        Thread.Sleep(100);
                    }
                }
                else
                {
                    ErrorLable.Text = "Error Type a number from 1-6"; // If the user input was not a number between 1-6
                }
            }
            else
            {
                ErrorLable.Text = "Error Type a valid number from 1-6"; // If the iser input was a character or letter
            }
        }
        /// <summary>
        /// Method to see if the random number matches with the user input.
        /// </summary>
        /// <param name="RandomDi">Random Number Generated</param>
        /// <param name="UserNum">User Input</param>
        /// <param name="Statuss">Status</param>
        private static void CheckUserNumber(int RandomDi, int UserNum, out Status Statuss)
        {
            Statuss = Status.Neutal; // First Statuss gets initialzed to Neutal

            if (RandomDi == UserNum)
            {
                Statuss = Status.Won;
            }
            else
            {
                Statuss = Status.Lost;
            }

        }
        /// <summary>
        /// This Method increments arrays NumOfGuess, FreqNum, and Precent from inside the table
        /// </summary>
        /// <param name="RandomDi"></param>
        /// <param name="UserNum"></param>
        private void FillingUpTables(int RandomDi, int UserNum)
        {
            Label[] LFreqNumLabels = { null, LFreqNum1, LFreqNum2, LFreqNum3, LFreqNum4, LFreqNum5, LFreqNum6 }; // All of the Frequency labels get stored inside this array
            Label[] LGuessNumLabels = { null, LGuess1, LGuess2, LGuess3, LGuess4, LGuess5, LGuess6 }; // All of the Guess labels get stored inside this array
            Label[] LPercentLabels = { null, LPercent1, LPrecent2, LPrecent3, LPrecent4, LPrecent5, LPrecent6 }; // All of the Percent labels get stored inside this array


            for (int i = 1; i <= 6; i++) //This for loop loops through all of the different labels from each array and increments them by 1
            {
                if (UserNum == i)
                {
                    NumOfGusses[i]++; // NumOfGuesses gets incremented
                    LGuessNumLabels[i].Text = NumOfGusses[i].ToString(); // The number of guesses gets stored in the Guess label text
                }
                if (RandomDi == i)
                {
                    FreqNum[i]++; // FreqNum gets incremented
                    Percent[i] += 20.00; // Precent gets incremented by %20.00
                    LFreqNumLabels[i].Text = FreqNum[i].ToString();
                    LPercentLabels[i].Text = $"{Percent[i]:F2}%";
                }
            }
        }
        /// <summary>
        /// Method that aquires the status of the user and increments the number of times the user as been playing and the 
        /// point won or point lost.
        /// </summary>
        /// <param name="Statuss">Status</param>
        private void GameResult(Status Statuss)
        {


            if (Statuss == Status.Won)
            {
                pointWon++; // Point Won gets incremented
                LNumWon.Text = pointWon.ToString();

            }
            else
            {
                pointLost++; // Point Lost gets incremented
                LNumLost.Text = pointLost.ToString();
            }
            increment++; // Num of Plays gets incremented
            LNumPlay.Text = increment.ToString();

        }
        /// <summary>
        /// This Method gets called if the user clicks on the reset button, it resets all of the labels that are inside
        /// the table and the labels inside the Game info groupbox to zero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Label[] LFreqNumLabels = { null, LFreqNum1, LFreqNum2, LFreqNum3, LFreqNum4, LFreqNum5, LFreqNum6 }; // All of the Frequency labels get stored inside this array
            Label[] LGuessNumLabels = { null, LGuess1, LGuess2, LGuess3, LGuess4, LGuess5, LGuess6 }; // All of the Guess labels get stored inside this array
            Label[] LPercentLabels = { null, LPercent1, LPrecent2, LPrecent3, LPrecent4, LPrecent5, LPrecent6 }; // All of the Percent labels get stored inside this array

            increment = 0;
            pointLost = 0;
            pointWon = 0;

            LNumWon.Text = "0";
            LNumLost.Text = "0";
            LNumPlay.Text = "0";
            ErrorLable.Text = "";
            EnterBox.Text = "";

            for (int i = 1; i <= 6; i++) //This for loop loops through all of the different labels from each array resets them to zero
            {


                NumOfGusses[i] = 0;
                LGuessNumLabels[i].Text = NumOfGusses[i].ToString();
                FreqNum[i] = 0;
                Percent[i] = 0;
                LFreqNumLabels[i].Text = FreqNum[i].ToString();
                LPercentLabels[i].Text = $"{Percent[i]:F2}%";

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
