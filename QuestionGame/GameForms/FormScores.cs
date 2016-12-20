using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{
    public partial class FormScores : Form
    {
        List<Player> players = new List<Player>();
        string path = Application.StartupPath + @"\scores.json";
        string s = "";

        public FormScores()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;           
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mainForm = new FormMain();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void FormScores_Load(object sender, EventArgs e)
        {
            deserialiseScores();
            if (players == null)
            {
                return;
            }else
            {
                deserialiseScores();
                players = players.OrderBy(o => o.score).ToList();
                for (int j = 0; j < 115; j++) { s += "."; }
                for (int i = 0; i < players.Count; i++)
                {
                    createScoreLabel(i);
                }
            }           
        }

        private void createScoreLabel(int i)
        {
            int rank = players.Count - i;
            Label lbl = new Label();
            lbl.Text = rank.ToString() + ".  " + players[i].name + s + players[i].score.ToString();
            lbl.Font = new Font("Arial", 12);
            lbl.ForeColor = Color.SpringGreen;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Location = new Point(70, (i * 3) + 20);
            lbl.Dock = DockStyle.Top;
            lbl.AutoSize = false;
            panel1.Controls.Add(lbl);
        }

        private void deserialiseScores()
        {
            string json = "";
            try
            {
                json = System.IO.File.ReadAllText(path);
                players = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Player>>(json);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }      
        }

        private void cleanList()
        {
            System.IO.File.WriteAllText(path, string.Empty);
            MessageBox.Show("Clean successful.", "Cleaning...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanList();
            panel1.Controls.Clear();          
        }
    }
}
