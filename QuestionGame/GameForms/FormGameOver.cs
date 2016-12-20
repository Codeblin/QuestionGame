using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{
    public partial class FormGameOver : Form
    {
        int score;
        string name;
        string jsonString = "";
        List<Player> player;
        Form backToMain = new FormMain();

        public FormGameOver(int score)
        {
            InitializeComponent();
            lblFinalScore.Text = score.ToString();
            this.score = score;
               
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serializePlayerData();           
            if (MessageBox.Show("Save was succesful!", "Saved!", MessageBoxButtons.OK) == DialogResult.OK)
            {
                gotoMainMenu();
            }

        }

        // if the json file is empty it returns null (error when trying to add)
        // so we check if the list is null before writting
        public void serializePlayerData()
        {
            name = txtBoxName.Text;
            if (player == null)
            {
                player = new List<Player>();
                player.Add(new Player(score, name));
            }else
            {
                player.Add(new Player(score, name));
            }            
            try
            {
                string playerData = Newtonsoft.Json.JsonConvert.SerializeObject(player.ToArray(), Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(Application.StartupPath + @"\scores.json", playerData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deserializePlayerData()
        {           
            try
            {
                jsonString = System.IO.File.ReadAllText(Application.StartupPath + @"\scores.json");
                player = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Player>>(jsonString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }          
        }

        public void gotoMainMenu()
        {
            this.Hide();
            backToMain.ShowDialog();
            this.Close();
        }

        private void FormGameOver_Load(object sender, EventArgs e)
        {
            //initialize the the list and fills it with data from json file
            player = new List<Player>();
            deserializePlayerData();
            
        }
    }
}
