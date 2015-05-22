using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags.Logic
{
    internal static class GameLogic
    {
        internal static Random randomCountry = new Random();
        internal const string flagsDirectory = "..\\..\\Images\\Flags";
        internal static string correctAnswer;
        private static int gameResult = 0;
        private static int totalAttempts = -1;

        public static string Nickname { private get; set; }

        internal static int GameResult
        {
            get
            {
                return gameResult;
            }

            set
            {
                gameResult = value;
            }
        }

        internal static void AssignRadioButtons(string correctFlag, RadioButton optionOne, RadioButton optionTwo, RadioButton optionThree, RadioButton optionFour)
        {
            totalAttempts++;

            Random rand = new Random();

            optionOne.TabIndex = 0;
            optionTwo.TabIndex = 0;
            optionThree.TabIndex = 0;
            optionFour.TabIndex = 0;

            optionOne.Checked = false;
            optionTwo.Checked = false;
            optionThree.Checked = false;
            optionFour.Checked = false;

            correctAnswer = correctFlag;

            switch (rand.Next(4))
            {
                case 0:
                    {
                        optionOne.Text = correctFlag; 
                        AssignRandomValues(optionTwo, optionThree, optionFour); 
                        break;
                    }
                case 1:
                    {
                        optionTwo.Text = correctFlag;
                        AssignRandomValues(optionOne, optionThree, optionFour);
                        break;
                    }
                case 2:
                    {
                        optionThree.Text = correctFlag;
                        AssignRandomValues(optionOne, optionTwo, optionFour);
                        break;
                    }
                case 3:
                    {
                        optionFour.Text = correctFlag;
                        AssignRandomValues(optionOne, optionTwo, optionThree);
                        break;
                    }
                default: break;
            }
        }

        internal static string GenerateRandomCountryFlag(PictureBox flagImage)
        {
            string randomCountry = GetRandomCountry();

            try
            {
                flagImage.Image = Image.FromFile(randomCountry);
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show("No image: " + fnf.StackTrace);
            }
            catch (OutOfMemoryException mem)
            {
                MessageBox.Show("No memmory " + mem.StackTrace);
            }

            return StripCountryFromURL(randomCountry);
        }

        internal static string StripCountryFromURL(string countryPath)
        {
            int startindex = countryPath.IndexOf("Flags\\") + 6;
            int lenght = countryPath.IndexOf(".jpg") - startindex;

            if (lenght < 0)
            {
                MessageBox.Show(countryPath);
                Environment.Exit(0);
            }

            countryPath = countryPath.Replace("_", " ");
            return countryPath.Substring(startindex, lenght);
        }

        internal static string GetRandomCountry()
        {
            string[] flags = Directory.GetFiles(flagsDirectory);
            List<string> filteredFlagPaths = new List<string>();

            foreach (var flag in flags)
            {
                if (!(flag.IndexOf(".jpg") == -1))
                {
                    filteredFlagPaths.Add(flag);
                }
            }

            flags = filteredFlagPaths.ToArray();

            return flags[randomCountry.Next(flags.Count())];
        }

        private static void AssignRandomValues(RadioButton buttonOne, RadioButton buttonTwo, RadioButton buttonThree)
        {
            buttonOne.Text = StripCountryFromURL(GetRandomCountry());
            buttonTwo.Text = StripCountryFromURL(GetRandomCountry());
            buttonThree.Text = StripCountryFromURL(GetRandomCountry()); 
        }

        //Logic for Form1

        internal static void InsertUserInfo()
        {
            FileManager.InsertPlayerScore(Nickname, gameResult, totalAttempts);
        }

        internal static Dictionary<string, int> ExtractUsersInfo()
        {
             return FileManager.GetPlayersResults();
        }
    }
}
