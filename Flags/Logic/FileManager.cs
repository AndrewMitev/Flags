using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags.Logic
{
    internal static class FileManager
    {
        private static string fileDir = "..\\..\\Data\\";

        internal static void InsertPlayerScore(string playerName, int gameResult, int totalAttempts)
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileDir + "PlayerScore.txt", true);

                using (writer)
                {
                    writer.WriteLine(playerName + " : " + gameResult + " - " + totalAttempts);
                }
            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(string.Format("File {0}PlayerScore.txt was not found! {1}", fileDir, e.StackTrace));
            }

            catch (IOException i)
            {
                MessageBox.Show("I/O Exception " + i.StackTrace);
            }
        }

        internal static Dictionary<string, int> GetPlayersResults()
        {
            try
            {
                StreamReader reader = new StreamReader(fileDir + "PlayerScore.txt");
                string data = string.Empty;

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                using (reader)
                {
                    reader.ReadLine();

                    while (data != null)
                    {
                        data = reader.ReadLine();

                        if (data != null)
                        {
                            int startCoordScore = data.IndexOf(": ") + 2;
                            int endCoordScore = data.IndexOf(" -");

                            string player = data.Substring(0, data.IndexOf(" :"));

                            int score = int.Parse(data.Substring(startCoordScore, endCoordScore - startCoordScore));

                            dictionary.Add(player, score);
                        }
                    }
                }

                dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                return dictionary;
            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(string.Format("File {0}PlayerScore.txt was not found! {1}", fileDir, e.StackTrace));
            }

            catch (IOException i)
            {
                MessageBox.Show("I/O Exception " + i.StackTrace);
            }

            return null;
        }
    }
}
