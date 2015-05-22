using Flags.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class GamePanel : Form
    {
        private Timer t;
        private int counter = 30;
        //private const int durationInSeconds = 31;
       

        public GamePanel()
        {
            InitializeComponent();
            GameLogic.randomCountry = new Random();
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            GameLogic.AssignRadioButtons(
                GameLogic.GenerateRandomCountryFlag(flagImage),
                optionOne,
                optionTwo,
                optionThree,
                optionFour
            );

            StartTimer();
        }

        private void StartTimer()
        {
            this.t = new Timer();

            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (counter < 10)
            {
                timerLabel.Text = string.Format("00:0{0}", counter.ToString());
            }
            else
            {
                timerLabel.Text = string.Format("00:{0}", counter.ToString());
            }

            counter--;

            if (counter == 0)
            {
                t.Stop();
                MessageBox.Show("Game ended");
                this.Close();
            }
        }

        private void optionOne_CheckedChanged(object sender, EventArgs e)
        {
            if (optionOne.Checked == true)
            {
                this.CheckIfCorrect(optionOne);
                this.RefreshContent();
            }
        }

        private void optionTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (optionTwo.Checked == true)
            {
                this.CheckIfCorrect(optionTwo);
                this.RefreshContent();
            }
        }

        private void optionThree_CheckedChanged(object sender, EventArgs e)
        {
            if (optionThree.Checked == true)
            {
                this.CheckIfCorrect(optionThree);
                this.RefreshContent();
            }
        }

        private void optionFour_CheckedChanged(object sender, EventArgs e)
        {
            if (optionFour.Checked == true)
            {
                this.CheckIfCorrect(optionFour);
                this.RefreshContent();
            }
        }

        private void CheckIfCorrect(RadioButton option)
        {
            if (option.Text == GameLogic.correctAnswer)
            {
                option.BackColor = Color.GreenYellow;
                GameLogic.GameResult += 1;
            }
            else
            {
                option.BackColor = Color.Fuchsia;
            }
        }

        private void ShowAnswer()
        {
            if (optionOne.Text == GameLogic.correctAnswer)
            {
                optionOne.BackColor = Color.GreenYellow;
            }
            else if (optionTwo.Text == GameLogic.correctAnswer)
            {
                optionTwo.BackColor = Color.GreenYellow;
            }
            else if (optionThree.Text == GameLogic.correctAnswer)
            {
                optionThree.BackColor = Color.GreenYellow;
            }
            else
            {
                optionFour.BackColor = Color.GreenYellow;
            }
        }

        private void ResetColors()
        {
            optionOne.BackColor = Color.Transparent;
            optionTwo.BackColor = Color.Transparent;
            optionThree.BackColor = Color.Transparent;
            optionFour.BackColor = Color.Transparent;
        }

        private void RefreshContent()
        {
            ShowAnswer();
            this.Refresh();

            System.Threading.Thread.Sleep(500);

            ResetColors();
            this.Refresh();

            GameLogic.AssignRadioButtons(
                GameLogic.GenerateRandomCountryFlag(flagImage),
                optionOne,
                optionTwo,
                optionThree,
                optionFour
            );
        }

        private void AnimateHideFlag()
        {
            while (this.flagImage.Height > 0)
            {
                this.flagImage.Height -= 1;
                this.Refresh();
            }
        }

        private void AnimateShowFlag()
        {
            while (this.flagImage.Height < 85)
            {
                this.flagImage.Height += 1;
                this.Refresh();
            }
        }
    }
}
