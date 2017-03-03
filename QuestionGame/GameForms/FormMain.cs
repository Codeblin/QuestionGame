using QuestionGame.GameForms;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Reflection;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{

    public partial class FormMain : Form
    {
        string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
        CultureInfo cul;            // declare culture info

        public FormMain()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            playButtonSound();
            Form formGame = new FormGame();
            this.Hide();
            formGame.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playButtonSound();
            Application.Exit();
        }

        private void playButtonSound()
        {
            string fileName = string.Format("{0}Resources\\Sounds\\button_click.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            SoundPlayer simpleSound = new SoundPlayer(fileName);
            simpleSound.Play();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            playButtonSound();
            Form formScores = new FormScores();
            this.Hide();
            formScores.ShowDialog();
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form formScores = new FormAbout();
            this.Hide();
            formScores.ShowDialog();
            this.Close();
            playButtonSound();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            subItemGr.Checked = false;    //default language is english
            subItemEn.Checked = true;

            Assembly assembly = Assembly.Load("QuestionGame");
            res_man = new ResourceManager("QuestionGame.Resources.Res", assembly);
            //switch to vietnamese
            switch_language();
        }

        private void switch_language()
        {
            if (subItemGr.Checked == true)    //in greek
            {
                cul = CultureInfo.CreateSpecificCulture("el-GR");        //create culture for greek
            }
            else //in english
            {
                cul = CultureInfo.CreateSpecificCulture("en-GB");        //create culture for english
            }

            // Option menu
            options.Text = res_man.GetString("options", cul);
            itemLang.Text = res_man.GetString("changeLang", cul);
            subItemEn.Text = res_man.GetString("langEn", cul);
            subItemGr.Text = res_man.GetString("langGr", cul);

            // Main Menu
            btnStartGame.Text = res_man.GetString("newGame", cul);
            btnScores.Text = res_man.GetString("score", cul);
            btnAbout.Text = res_man.GetString("about", cul);
            btnExit.Text = res_man.GetString("exit", cul);
        }

        private void subItemGr_Click(object sender, EventArgs e)
        {
            if (subItemGr.Checked == true) //switch to english
            {
                subItemGr.Checked = false;
                subItemEn.Checked = true;
            }
            else
            {
                subItemGr.Checked = true;
                subItemEn.Checked = false;
            }

            switch_language();
        }

        private void subItemEn_Click(object sender, EventArgs e)
        {
            subItemGr_Click(null, null);
        }
    }
}
