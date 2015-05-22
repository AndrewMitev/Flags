using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> playersInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.UpdateCurrentScore();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Please enter name!");
                return;
            }
            else if (playersInfo.ContainsKey(name.Text))
            {
                MessageBox.Show("Username taken. Please enter another one.");
                return;
            }

            //Save player's name
            Flags.Logic.GameLogic.Nickname = name.Text;

            this.Visible = false;
            GamePanel gamePanel = new GamePanel();
            gamePanel.ShowDialog();

            //Save player's result
            Flags.Logic.GameLogic.InsertUserInfo();

            //Show initial panel when game panel is closed.
            this.UpdateCurrentScore();
            this.Refresh();
            this.Visible = true;
        }

        private void UpdateCurrentScore()
        {
            playersInfo = Flags.Logic.GameLogic.ExtractUsersInfo();

            if (playersInfo.Count != 0 && playersInfo != null)
            {
                string[] players = playersInfo.Keys.ToArray();
                int[] scores = playersInfo.Values.ToArray();

                player1.Text = players[0];
                player2.Text = players[1];
                player3.Text = players[2];
                player4.Text = players[3];
                player5.Text = players[4];

                score1.Text = scores[0].ToString();
                score2.Text = scores[1].ToString();
                score3.Text = scores[2].ToString();
                score4.Text = scores[3].ToString();
                score5.Text = scores[4].ToString();
            }
        }
    }
}
