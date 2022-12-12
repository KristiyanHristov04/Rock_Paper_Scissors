using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string playerChoice = string.Empty;
        private string enemyChoice = string.Empty;
        private Random random = new Random();
        private int playerScore = 0;
        private int enemyScore = 0;

        private string EnemyChoice()
        {
            int choiceNumber = this.random.Next(0, 3);
            string[] possibleEnemyChoices = { "Rock", "Paper", "Scissors" };
            return possibleEnemyChoices[choiceNumber];
        }

        private void CheckWinner(string playerChoice, string enemyChoice)
        {
            if (playerChoice == "Rock" && enemyChoice == "Rock")
            {
                playerRockImage.Visible = true;
                enemyRockImage.Visible = true;
                MessageBox.Show("Draw!");
                ResetChoices();
            }
            else if (playerChoice == "Rock" && enemyChoice == "Paper")
            {
                playerRockImage.Visible = true;
                enemyPaperImage.Visible = true;
                enemyScore++;
                scoreTextBox2.Text = enemyScore.ToString();
                MessageBox.Show("Player 2 wins!");
                ResetChoices();
            }
            else if (playerChoice == "Rock" && enemyChoice == "Scissors")
            {
                playerRockImage.Visible = true;
                enemyScissorsImage.Visible = true;
                playerScore++;
                scoreTextBox1.Text = playerScore.ToString();
                MessageBox.Show("Player 1 wins!");
                ResetChoices();
            }
            else if (playerChoice == "Paper" && enemyChoice == "Rock")
            {
                playerPaperImage.Visible = true;
                enemyRockImage.Visible = true;
                playerScore++;
                scoreTextBox1.Text = playerScore.ToString();
                MessageBox.Show("Player 1 wins!");
                ResetChoices();
            }
            else if (playerChoice == "Paper" && enemyChoice == "Paper")
            {
                playerPaperImage.Visible = true;
                enemyPaperImage.Visible = true;
                MessageBox.Show("Draw!");
                ResetChoices();
            }
            else if (playerChoice == "Paper" && enemyChoice == "Scissors")
            {
                playerPaperImage.Visible = true;
                enemyScissorsImage.Visible = true;
                enemyScore++;
                scoreTextBox2.Text = enemyScore.ToString();
                MessageBox.Show("Player 2 wins!");
                ResetChoices();
            }
            else if (playerChoice == "Scissors" && enemyChoice == "Rock")
            {
                playerScissorsImage.Visible = true;
                enemyRockImage.Visible = true;
                enemyScore++;
                scoreTextBox2.Text = enemyScore.ToString();
                MessageBox.Show("Player 2 wins!");
                ResetChoices();
            }
            else if (playerChoice == "Scissors" && enemyChoice == "Paper")
            {
                playerScissorsImage.Visible = true;
                enemyPaperImage.Visible = true;
                playerScore++;
                scoreTextBox1.Text = playerScore.ToString();
                MessageBox.Show("Player 1 wins!");
                ResetChoices();
            }
            else if (playerChoice == "Scissors" && enemyChoice == "Scissors")
            {
                playerScissorsImage.Visible = true;
                enemyScissorsImage.Visible = true;
                MessageBox.Show("Draw!");
                ResetChoices();
            }
        }

        private void ResetChoices()
        {
            playerChoice = string.Empty;
            enemyChoice = string.Empty;

            playerRockImage.Visible = false;
            playerPaperImage.Visible = false;
            playerScissorsImage.Visible = false;

            enemyRockImage.Visible = false;
            enemyPaperImage.Visible = false;
            enemyScissorsImage.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            enemyChoice = EnemyChoice();
            CheckWinner(playerChoice, enemyChoice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            enemyChoice = EnemyChoice();
            CheckWinner(playerChoice, enemyChoice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            enemyChoice = EnemyChoice();
            CheckWinner(playerChoice, enemyChoice);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
