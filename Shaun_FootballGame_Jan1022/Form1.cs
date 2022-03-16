using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaun_FootballGame_Jan1022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int currentDown, currentYTG, scoreT1, scoreT2, currentYL;

        private void radSTPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (radSTPlay.Checked == true)
            {
                gbSpecialTeams.Visible = true;

            } 
            else
            {
                gbSpecialTeams.Visible = false;
            }

           

            
        }

        private void btnBreakHuddle_Click(object sender, EventArgs e)
        {
            if (radPassPlay.Checked)
            {
                bool CurrentCatch;
                CurrentCatch = CatchNoCatch();

                if (CurrentCatch)
                {
                    int gain = 0;
                    int gainOfCatch = 0;
                    gainOfCatch = GetRandomNumber(0, 7);
                    switch (gainOfCatch)
                    {
                        case 0:
                            MessageBox.Show("Interception!");
                            TurnOver();
                            break;

                        case 1:

                            gain = GetRandomNumber(20, 99);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;

                        case 2:
                            gain = GetRandomNumber(6, 20);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;

                        case 3:
                            gain = GetRandomNumber(1, 5);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;

                        case 4:
                            gain = GetRandomNumber(1, 5);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;

                        case 5:
                            gain = GetRandomNumber(6, 20);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;

                        case 6:
                            gain = GetRandomNumber(1, 5);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;

                        case 7:
                            gain = GetRandomNumber(6, 20);
                            MessageBox.Show("Gain of " + gain);
                            CheckForFirstDown(currentYTG, gain);
                            break;
                    }
                    RefreshStats();
                }
            }

            if (radRunPlay.Checked)
            {

                int runYards = 0;
                int gain=0;
                runYards = RunAttempt();
                switch (runYards)

                {
                    case 0:
                        MessageBox.Show("Fumble");
                        TurnOver();
                        break;

                    case 1:

                        gain = GetRandomNumber(20, 99);
                        MessageBox.Show("Gain of " +gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;

                    case 2:
                        gain = GetRandomNumber(6, 20);
                        MessageBox.Show("Gain of " + gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;

                    case 3:
                        gain = GetRandomNumber(1, 5);
                        MessageBox.Show("Gain of " + gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;

                    case 4:
                        gain = GetRandomNumber(1, 5);
                        MessageBox.Show("Gain of " + gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;

                    case 5:
                        gain = GetRandomNumber(6, 20);
                        MessageBox.Show("Gain of " + gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;

                    case 6:
                        gain = GetRandomNumber(1, 5);
                        MessageBox.Show("Gain of " + gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;

                    case 7:
                        gain = GetRandomNumber(6, 20);
                        MessageBox.Show("Gain of " + gain);
                        CheckForFirstDown(currentYTG, gain);
                        break;
                }

                RefreshStats();
            }

            if (radPuntPlay.Checked)
            {

            }

            if (radFGPlay.Checked)
            {

            }
        }

        private bool CatchNoCatch()
        {
            int reception = 0;
            bool goodCatch = false;
           reception= GetRandomNumber(1, 3);

            switch (reception)
            {
                case 1:
                    MessageBox.Show("Good Catch");
                    goodCatch = true;
                    break;

                case 2:
                    MessageBox.Show("No Catch");
                    CheckForFirstDown(currentYTG, 0);
                    RefreshStats();
                    goodCatch = false;
                    break;
            }
            return goodCatch;
        }

        private int RunAttempt()
        {
            int runSuccess = 0;

            runSuccess = GetRandomNumber(0, 8);

            switch (runSuccess)
            {
                case 0:
                    MessageBox.Show("Fumble");
                    break;

                case 1:
                    MessageBox.Show("Big Run");
                    break;

                case 2:
                    MessageBox.Show("Medium Run");
                    break;

                case 3:
                    MessageBox.Show("Small Run");
                    break;

                case 4:
                    MessageBox.Show("Small Run");
                    break;

                case 5:
                    MessageBox.Show("Medium Run");
                    break;

                case 6:
                    MessageBox.Show("Small Run");
                    break;

                case 7:
                    MessageBox.Show("Small Run");
                    break;
            }
            return runSuccess;
        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentDown = 1;
            currentYTG = 10;
            scoreT1 = 0;
            scoreT2 = 0;
            lblScoreTeam1.Text = scoreT1.ToString();
            lblScoreTeam2.Text = scoreT2.ToString();
            lblCurrentDown.Text += currentDown+" down" + currentYTG+" yards to go";
            currentYL = 25;
            lblCurrentYL.Text = currentYL.ToString();
        }

        private void CheckForFirstDown(int yardsToGo, int yardsGained)
        {
            if (yardsGained>= yardsToGo)
            {
                MessageBox.Show("First Down!");
                currentDown = 1;
                currentYTG = 10;
                currentYL += yardsGained;
            }
            else
            {
                currentDown++;
                yardsToGo = yardsToGo - yardsGained;
                currentYTG = yardsToGo;
                currentYL += yardsGained;
                MessageBox.Show(currentDown.ToString() + "down");
            }
            if (currentYL > 100)
            {
                MessageBox.Show("TouchDown! Team 1");
                scoreT1 += 7;
                MessageBox.Show("Score : \n" +
                    "Team 1: " + scoreT1 + "\n" +
                    "Team 2: " + scoreT2);
                TurnOver();
            }

            if (currentDown > 4)
            {
                MessageBox.Show("You Turned The Ball over on downs");
                TurnOver();
            }
        }

        private void RefreshStats()
        {
            lblCurrentDown.Text = currentDown.ToString() + " down" + currentYTG + " yards to go";
            lblCurrentYL.Text = currentYL.ToString();

        }

        private void TurnOver()
        {
            int results = 0;
            results = GetRandomNumber(0, 4);
            switch (results)
            {
                case 1:
                    MessageBox.Show("TouchDown! Team 2");
                    scoreT2 += 7;
                    MessageBox.Show("Score : \n" +
                        "Team 1: " + scoreT1 + "\n" +
                        "Team 2: " + scoreT2);
                    break;

                case 2:
                    MessageBox.Show("Result of Team 2: \nTurn Over on Downs");
                    currentYL = GetRandomNumber(0, 95);
                    break;

                case 3:
                    MessageBox.Show("Result of Team 2: \nPunt !");
                    currentYL = 25;
                    break;

                case 4:
                    MessageBox.Show("Result of Team 2: \nPunt !");
                    currentYL = 25;
                    break;

            }
            MessageBox.Show("Your Ball!");
            currentDown = 1;
        }
    }
}
