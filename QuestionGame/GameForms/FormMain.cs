using QuestionGame.GameForms;
using System;
using System.Media;
using System.Windows.Forms;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{

    public partial class FormMain : Form
    {
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
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\Resources\Sounds\button_click.wav");
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
        }
    }
}
