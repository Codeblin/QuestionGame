using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Windows.Forms;
using System.IO;

/* Author: Stamatis Stiliatis Togrou
 * 
 * Summary: 
 * Player is called to answer questions based on his/her selection(category, difficulty).
 * He has 25 seconds to choose an answer. Right answer is rewarded with (100 * difficulty) points
 * and 5 mana points, wrong answer damage his health points.Playes loses when reach 0 health point
 * and finish the game when there are no more questions.
 * 
 * Powers:
 * There are 3 powers to choose among. 
 * --Clarity -> Reveals the right answer
 * --Fifty-Fifty -> Reveals the right answer and one random
 * --Skip -> Skips the current question.
 */
namespace QuestionGame
{
    public partial class FormGame : Form
    {             
        List<CategoriesID> listType = new List<CategoriesID>();
        List<CategoriesID> listDifficulty = new List<CategoriesID>();
        List<Questions> listQuestions;
        Questions currentQuestion;
        Clarity reveal = new Clarity();
        FiftyFifty fifty = new FiftyFifty();
        Skip skip = new Skip();
        static Random random = new Random();
        int[] randomArrayAnswer = new int[4];
        public int score;
        public const int MAX_HEALTH_POINTS = 5000;
        public const int TIME_LIMIT = 25;
        public int timeLimit = TIME_LIMIT;
        public int MANA_PER_ANSWER = 5;
        int mana = 100;
        public static int questionsDisplayed = 0;
        public int index;

        string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        public FormGame()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            timerForChecks.Interval = 1;
            timerForChecks.Enabled = false;
            score = 0;
            prgBarHealth.Minimum = 0;
            prgBarHealth.Maximum = MAX_HEALTH_POINTS;

            prgBarMana.Minimum = 0;
            prgBarMana.Maximum = 100;
        }             

        // =============== Button events =================
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            timerForChecks.Enabled = true;
            btnNextQuestion.Enabled = false;
            lblMsg.Text = "";
            //here goes the method that determines the current question
            currentQuestion = getNextQuestion((int)cbxQType.SelectedValue, (int)cbxQDifficulty.SelectedValue);
            //if question there is no question, "pause" the timer and disable buttons.
            if (currentQuestion == null)
            {
                lblQuestion.Text = "";
                nullQuestionButtons();
                lblMsg.Text = "No more questions. Change category or difficulty.";
                timer.Enabled = false;
            }
            else
            {
                questionInflate();
            }
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            btnNextQuestion.Enabled = true;
            bool temp;
            temp = checkQuestion(0);
            if (temp == true)
            {
                btnAns1.BackColor = Color.Green;
            }
            else
            {
                btnAns1.BackColor = Color.Red;
            }
            enableAllButtons(false);
            timer.Enabled = false;
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            btnNextQuestion.Enabled = true;
            bool temp;
            temp = checkQuestion(1);
            if (temp == true)
            {
                btnAns2.BackColor = Color.Green;
            }
            else
            {
                btnAns2.BackColor = Color.Red;
            }
            enableAllButtons(false);
            timer.Enabled = false;
        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            btnNextQuestion.Enabled = true;
            bool temp;
            temp = checkQuestion(2);
            if (temp == true)
            {
                btnAns3.BackColor = Color.Green;
            }
            else
            {
                btnAns3.BackColor = Color.Red;
            }
            enableAllButtons(false);
            timer.Enabled = false;
        }

        private void btnAns4_Click(object sender, EventArgs e)
        {
            btnNextQuestion.Enabled = true;
            bool temp;
            temp = checkQuestion(3);
            if (temp == true)
            {
                btnAns4.BackColor = Color.Green;
            }
            else
            {
                btnAns4.BackColor = Color.Red;
            }
            enableAllButtons(false);
            timer.Enabled = false;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Form mainForm = new FormMain();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
        //===============================================

        //============== Button event: powers =============
        private void picReveal_Click(object sender, EventArgs e)
        {

            if (currentQuestion == null)
            {
                lblMsg.Text = "Click Next Question Button";
            }
            else
            {
                if (reveal.available(mana))
                {
                    playSound("clarity_sound.wav");
                    //show the picture that overlap the power picture, in result to be unclickable
                    picRevealDisabled.Show();
                    reduceMana(reveal.mana);
                    reveal.doClarity(currentQuestion, lblMsg);//executes the ability
                }
            }

        }

        private void picFifty_Click(object sender, EventArgs e)
        {

            if (currentQuestion == null)
            {
                lblMsg.Text = "Click Next Question Button";
            }
            else
            {
                if (fifty.available(mana))
                {
                    playSound("fifty_sound.wav");
                    //show the picture that overlap the power picture, in result to be unclickable
                    picFiftyDisabled.Show();
                    reduceMana(fifty.mana);
                    fifty.doFifty(currentQuestion, lblMsg);

                }
            }
        }

        private void picSkip_Click(object sender, EventArgs e)
        {

            if (currentQuestion == null)
            {
                lblMsg.Text = "Click Next Question Button";
            }
            else
            {
                if (skip.available(mana))
                {
                    playSound("skip_sound.wav");
                    //show the picture that overlap the power picture, in result to be unclickable
                    picSkipDisabled.Show();
                    reduceMana(skip.mana);
                    currentQuestion = getNextQuestion((int)cbxQType.SelectedValue, (int)cbxQDifficulty.SelectedValue);
                    questionInflate();
                }
            }
        }
        //================================================

        //======= form, data load and initilization methods =========
        private void FormGame_Load(object sender, EventArgs e)
        {
            gameLoad();//loads the values for combo boxes,questions etc. 
            dataInitialize();//initialize values necessary for game
        }

        private void gameLoad()
        {           
            listTypeLoad();
            listDifficultyLoad();
            questionLoad();
            listQuestions = ShuffleList<Questions>(listQuestions);
        }

        private void dataInitialize()
        {
            timer.Interval = 1000;
            score = 0;
            prgBarHealth.Value = MAX_HEALTH_POINTS;
            prgBarMana.Value = 100;
            currentQuestion = null;

            cbxQType.SelectedIndex = 0;
            cbxQDifficulty.SelectedIndex = 0;
            nullQuestionButtons();
            lblQuestion.Text = "";
            lblMsg.Text = "";
            enableAllButtons(false);

            picRevealDisabled.Hide();
            picFiftyDisabled.Hide();
            picSkipDisabled.Hide();
        }

        private void listTypeLoad()
        {
            listType.Clear();
            listType.Add(new CategoriesID(1, "History"));
            listType.Add(new CategoriesID(2, "Geography"));
            listType.Add(new CategoriesID(3, "Politics"));
            listType.Add(new CategoriesID(4, "Arts"));

            cbxQType.DataSource = listType;
            cbxQType.DisplayMember = "description";
            cbxQType.ValueMember = "ID";
            cbxQType.SelectedIndex = 0;
        }

        private void listDifficultyLoad()
        {
            listDifficulty.Clear();
            listDifficulty.Add(new CategoriesID(1, "Easy"));
            listDifficulty.Add(new CategoriesID(2, "Hard"));

            cbxQDifficulty.DataSource = listDifficulty;
            cbxQDifficulty.DisplayMember = "description";
            cbxQDifficulty.ValueMember = "ID";
            cbxQDifficulty.SelectedIndex = 0;
        }

        private void questionLoad()
        {
            //listQuestions.Clear();
            questionDeserialization();//read from json
        }

        private void questionDeserialization()
        {      
            string json = "";
            try
            {
                json = System.IO.File.ReadAllText(Application.StartupPath + @"\questions.json");
                listQuestions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Questions>>(json);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }            
        }
        //=========================================================

        //================= question runtime checks =================
        private Questions getNextQuestion(int type, int difficulty)
        {
            timerReset();
            resetButtonColor();
            int length = listQuestions.Count, i;
            // loop that finds the first question that corresponds to the combo boxes values
            // and haven't been displayed before.
            for (i = 0; i < length; i++)
            {
                if (listQuestions[i].type == type && listQuestions[i].difficulty == difficulty && listQuestions[i].alreadyDisplayed == false)
                {
                    listQuestions[i].alreadyDisplayed = true;
                    questionsDisplayed++;
                    break;
                }
            }            
            return (i < length) ? listQuestions[i] : null;
        }

        //receives the id of the button and checks if is equal to the right answer
        private bool checkQuestion(int answerID)
        {           
            if (answerID == currentQuestion.correctAnswer)
            {
                score += currentQuestion.difficulty * 100;
                mana += MANA_PER_ANSWER;
                setScore();
                lblMsg.Text = "Right Answer!";
                if (prgBarMana.Value + MANA_PER_ANSWER >= 100)
                {
                    lblMana.Text = "100/100";
                    prgBarMana.Value = 100;
                }
                else
                {
                    lblMana.Text = mana.ToString() + "/100";
                    prgBarMana.Value = mana;
                }                
                return true;
            }
            else
            {
                setHealth();
                lblMsg.Text = "Wrong Answer!";
                lblMsg.Text = 
                    "Wrong!! \n Right Answer: " + (char)((int)'A' + currentQuestion.correctAnswer)
                    + ".";
                return false;
            }           
        }
        //=========================================================

        //==================== miscellaneous methods ================

        private List<Questions> ShuffleList<E>(List<Questions> qList)
        {
            Random r = new Random();
            for (int i = qList.Count - 1; i > 0; i--)
            {
                int randomIndex = r.Next(i + 1);
                Questions temp = qList[i];
                qList[i] = qList[randomIndex];
                qList[randomIndex] = temp;
            }

            return qList; //returns randomly shuffled list
        }

        private void setScore()
        {
            lblScore.Text = score.ToString();          
        }

        private void setHealth()
        {
            if (currentQuestion == null)
            {
            }else
            {               
                if (prgBarHealth.Value - (currentQuestion.difficulty * 1000) <= 0)
                {
                    prgBarHealth.Value = 0;
                    gameOver();
                }else
                {
                    prgBarHealth.Value -= 1000;
                    lblHealth.Text = prgBarHealth.Value.ToString() + "/5000";
                }
            }
            
        }

        private void reduceMana(int reduction)
        {
            if (prgBarMana.Value - reduction <= 0)
            {
                mana = 0;
                prgBarMana.Value = 0;
            }
            else
            {
                prgBarMana.Value -= reduction;
                mana = prgBarMana.Value;
                lblMana.Text = mana.ToString() + "/100";
            }
        }

        private void gameOver()
        {
            timer.Enabled = false;
            Form formGameOver = new FormGameOver(score);
            this.Hide();
            formGameOver.ShowDialog();
            this.Close();
        }

        private void playSound(string soundName)
        {
            string fileName = string.Format("{0}Resources\\Sounds\\" + soundName, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            SoundPlayer timeOverSound = new SoundPlayer(fileName);
            timeOverSound.Play();
        }

        //shows the question and its answers on the right labels
        private void questionInflate()
        {
            if (currentQuestion == null)
            {
                lblQuestion.Text = "";
                nullQuestionButtons();
                lblMsg.Text = "No more questions. Change category or difficulty.";
            }
            else
            {
                randomizeAnswer();
                lblQuestion.Text = currentQuestion.Question;
                btnAns1.Text = "A. " + currentQuestion.Answer[randomArrayAnswer[0]];
                btnAns2.Text = "B. " + currentQuestion.Answer[randomArrayAnswer[1]];
                btnAns3.Text = "C. " + currentQuestion.Answer[randomArrayAnswer[2]];
                btnAns4.Text = "D. " + currentQuestion.Answer[randomArrayAnswer[3]];
                enableAllButtons(true);
            }
            for (int i = 0; i < randomArrayAnswer.Length; i++){randomArrayAnswer[i] = 0;} 
        }

        // randomize the order that answers show
        private void randomizeAnswer()
        {
            for (int i = 0; i < 3; i++)
            {
                int randomIndex;

                // generates random index as long as it's not contained
                // in our new randomized array for answers
                do
                {
                    randomIndex = random.Next(0, 4);
                }while (randomArrayAnswer.Contains(randomIndex));
                randomArrayAnswer[i] = randomIndex; //fills the array with the indexes
            }
            // gets the index of the random array that contains the correct answer
            // and makes the correct answer equal to that index so it can
            // be recognized as the correct answer by the button click id (answerID)
            int index = Array.IndexOf(randomArrayAnswer, currentQuestion.correctAnswer);
            currentQuestion.correctAnswer = index;
            index = 0;
        }

        private void timerReset()
        {
            lblTimeLeft.Font = new Font("Arial", 15);
            lblTimeLeft.ForeColor = default(Color);
            timeLimit = TIME_LIMIT;
            lblTimeLeft.Text = "25";
            timer.Enabled = true;
        }
        //============================================================

        //============= button miscellaneous methods =================
        private void enableAllButtons(bool v)
        {
            btnAns1.Enabled = v;
            btnAns2.Enabled = v;
            btnAns3.Enabled = v;
            btnAns4.Enabled = v;
        }

        public void nullQuestionButtons()
        {
            btnAns1.Text = "A.";
            btnAns2.Text = "B.";
            btnAns3.Text = "C.";
            btnAns4.Text = "D.";
            enableAllButtons(false);
        }

        public void resetButtonColor()
        {
            btnAns1.BackColor = default(Color);
            btnAns2.BackColor = default(Color);
            btnAns3.BackColor = default(Color);
            btnAns4.BackColor = default(Color);
        }

        //================ time events ===================

        //countdown timer
        private void timer_Tick(object sender, EventArgs e)
        {
            timeLimit--;
            lblTimeLeft.Text = timeLimit.ToString();
            if (timeLimit <= 5)
            {
                lblTimeLeft.Font = new Font("Arial", 24);
                lblTimeLeft.ForeColor = Color.Red;
            }
            if (timeLimit <= 0)
            {
                btnNextQuestion.Enabled = true;
                playSound("ringout.wav");
                timeLimit = 0;
                timer.Enabled = false;
                setHealth();
                enableAllButtons(false);
                lblQuestion.Text = "";
                lblMsg.Text = "Time is over! You lost the question :(";
            }
        }

        //- checks the mana contitions and manages the pictures
        //- checks when all the questions are displayed and finishes the game.
        private void timerForChecks_Tick(object sender, EventArgs e)
        {
            //constantly checks if there is enough mana
            //and manages the pic responsible for disabling powers
            if (reveal.available(mana))
                picRevealDisabled.Hide();
            else
                picRevealDisabled.Show();

            if (fifty.available(mana))
                picFiftyDisabled.Hide();
            else
                picFiftyDisabled.Show();

            if (skip.available(mana))
                picSkipDisabled.Hide();
            else
                picSkipDisabled.Show();

            //when reach the end of questions enables the next button
            if (currentQuestion == null)
            {
                btnNextQuestion.Enabled = true;
            }

            //checks if the game is over. When all question have been displayed
            if (questionsDisplayed == listQuestions.Count)
            {
                timerForChecks.Enabled = false;
                gameOver();
            }
        }
        //================================================
    }
}
