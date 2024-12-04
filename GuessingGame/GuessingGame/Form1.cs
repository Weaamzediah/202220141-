using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int attempts;    

        public Form1()
        {
            InitializeComponent();
            InitializeGame(); 
        }

       
        private void InitializeGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 1001); 
            attempts = 0;
            labelFeedback.Text = "Guess result appears here.";
            this.BackColor = SystemColors.Control;
            textBoxGuess.Enabled = true;
            textBoxGuess.Text = "";
        }

        private void CheckGuess()
        {
            int userGuess;
            if (int.TryParse(textBoxGuess.Text, out userGuess))
            {
                attempts++;
                if (userGuess == randomNumber)
                {
                    labelFeedback.Text = "Correct!";
                    this.BackColor = Color.LightGreen;
                    MessageBox.Show($"Correct! You guessed it in {attempts} attempts.", "Congratulations");
                    textBoxGuess.Enabled = false;
                }
                else if (userGuess < randomNumber)
                {
                    labelFeedback.Text = "Too Low. Try a higher number.";
                    this.BackColor = Color.Red;
                }
                else
                {
                    labelFeedback.Text = "Too High. Try a lower number.";
                    this.BackColor = Color.Blue;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input");
            }

            textBoxGuess.Text = ""; 
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

     
        private void textBoxGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckGuess();
            }
        }
    }
}
