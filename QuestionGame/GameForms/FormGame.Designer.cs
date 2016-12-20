namespace QuestionGame
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.prgBarHealth = new System.Windows.Forms.ProgressBar();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cbxQDifficulty = new System.Windows.Forms.ComboBox();
            this.cbxQType = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.prgBarMana = new System.Windows.Forms.ProgressBar();
            this.groupBoxPowers = new System.Windows.Forms.GroupBox();
            this.picSkipDisabled = new System.Windows.Forms.PictureBox();
            this.picFiftyDisabled = new System.Windows.Forms.PictureBox();
            this.picRevealDisabled = new System.Windows.Forms.PictureBox();
            this.picSkip = new System.Windows.Forms.PictureBox();
            this.picFifty = new System.Windows.Forms.PictureBox();
            this.picReveal = new System.Windows.Forms.PictureBox();
            this.tooltipReveal = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipFifty = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipSkip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timerForChecks = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.groupBoxPowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSkipDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiftyDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevealDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFifty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReveal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(290, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Teal;
            this.lblScore.Location = new System.Drawing.Point(343, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(81, 27);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Teal;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(21, 256);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(720, 36);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAns1
            // 
            this.btnAns1.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnAns1.FlatAppearance.BorderSize = 2;
            this.btnAns1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAns1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAns1.ForeColor = System.Drawing.Color.White;
            this.btnAns1.Location = new System.Drawing.Point(21, 309);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(357, 51);
            this.btnAns1.TabIndex = 6;
            this.btnAns1.Text = "btnAns1";
            this.btnAns1.UseVisualStyleBackColor = false;
            this.btnAns1.Click += new System.EventHandler(this.btnAns1_Click);
            // 
            // btnAns2
            // 
            this.btnAns2.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnAns2.FlatAppearance.BorderSize = 2;
            this.btnAns2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAns2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAns2.ForeColor = System.Drawing.Color.White;
            this.btnAns2.Location = new System.Drawing.Point(384, 309);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(357, 51);
            this.btnAns2.TabIndex = 7;
            this.btnAns2.Text = "btnAns2";
            this.btnAns2.UseVisualStyleBackColor = true;
            this.btnAns2.Click += new System.EventHandler(this.btnAns2_Click);
            // 
            // btnAns3
            // 
            this.btnAns3.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnAns3.FlatAppearance.BorderSize = 2;
            this.btnAns3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAns3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAns3.ForeColor = System.Drawing.Color.White;
            this.btnAns3.Location = new System.Drawing.Point(21, 366);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(357, 51);
            this.btnAns3.TabIndex = 8;
            this.btnAns3.Text = "btnAns3";
            this.btnAns3.UseVisualStyleBackColor = true;
            this.btnAns3.Click += new System.EventHandler(this.btnAns3_Click);
            // 
            // btnAns4
            // 
            this.btnAns4.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnAns4.FlatAppearance.BorderSize = 2;
            this.btnAns4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAns4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAns4.ForeColor = System.Drawing.Color.White;
            this.btnAns4.Location = new System.Drawing.Point(384, 366);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(357, 51);
            this.btnAns4.TabIndex = 9;
            this.btnAns4.Text = "btnAns4";
            this.btnAns4.UseVisualStyleBackColor = true;
            this.btnAns4.Click += new System.EventHandler(this.btnAns4_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnNextQuestion.FlatAppearance.BorderSize = 2;
            this.btnNextQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnNextQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.White;
            this.btnNextQuestion.Location = new System.Drawing.Point(591, 93);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(150, 48);
            this.btnNextQuestion.TabIndex = 10;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // prgBarHealth
            // 
            this.prgBarHealth.Location = new System.Drawing.Point(42, 199);
            this.prgBarHealth.Name = "prgBarHealth";
            this.prgBarHealth.Size = new System.Drawing.Size(328, 44);
            this.prgBarHealth.TabIndex = 11;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Teal;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(21, 434);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(720, 38);
            this.lblMsg.TabIndex = 12;
            this.lblMsg.Text = "Messages";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxQDifficulty
            // 
            this.cbxQDifficulty.BackColor = System.Drawing.Color.Teal;
            this.cbxQDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbxQDifficulty.ForeColor = System.Drawing.Color.White;
            this.cbxQDifficulty.FormattingEnabled = true;
            this.cbxQDifficulty.Location = new System.Drawing.Point(12, 108);
            this.cbxQDifficulty.Name = "cbxQDifficulty";
            this.cbxQDifficulty.Size = new System.Drawing.Size(164, 24);
            this.cbxQDifficulty.TabIndex = 14;
            // 
            // cbxQType
            // 
            this.cbxQType.BackColor = System.Drawing.Color.Teal;
            this.cbxQType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbxQType.ForeColor = System.Drawing.Color.White;
            this.cbxQType.FormattingEnabled = true;
            this.cbxQType.Location = new System.Drawing.Point(12, 81);
            this.cbxQType.Name = "cbxQType";
            this.cbxQType.Size = new System.Drawing.Size(164, 24);
            this.cbxQType.TabIndex = 13;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(12, 46);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(158, 13);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "Select Type and Difficulty:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(762, 24);
            this.menu.TabIndex = 16;
            this.menu.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BackColor = System.Drawing.Color.Teal;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.Black;
            this.lblTimeLeft.Location = new System.Drawing.Point(341, 96);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(87, 37);
            this.lblTimeLeft.TabIndex = 17;
            this.lblTimeLeft.Text = "0";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgBarMana
            // 
            this.prgBarMana.Location = new System.Drawing.Point(395, 199);
            this.prgBarMana.Name = "prgBarMana";
            this.prgBarMana.Size = new System.Drawing.Size(328, 44);
            this.prgBarMana.TabIndex = 18;
            // 
            // groupBoxPowers
            // 
            this.groupBoxPowers.Controls.Add(this.picSkipDisabled);
            this.groupBoxPowers.Controls.Add(this.picFiftyDisabled);
            this.groupBoxPowers.Controls.Add(this.picRevealDisabled);
            this.groupBoxPowers.Controls.Add(this.picSkip);
            this.groupBoxPowers.Controls.Add(this.picFifty);
            this.groupBoxPowers.Controls.Add(this.picReveal);
            this.groupBoxPowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBoxPowers.ForeColor = System.Drawing.Color.White;
            this.groupBoxPowers.Location = new System.Drawing.Point(507, 27);
            this.groupBoxPowers.Name = "groupBoxPowers";
            this.groupBoxPowers.Size = new System.Drawing.Size(234, 60);
            this.groupBoxPowers.TabIndex = 19;
            this.groupBoxPowers.TabStop = false;
            this.groupBoxPowers.Text = "Powers";
            // 
            // picSkipDisabled
            // 
            this.picSkipDisabled.BackColor = System.Drawing.Color.Transparent;
            this.picSkipDisabled.Image = ((System.Drawing.Image)(resources.GetObject("picSkipDisabled.Image")));
            this.picSkipDisabled.Location = new System.Drawing.Point(176, 19);
            this.picSkipDisabled.Name = "picSkipDisabled";
            this.picSkipDisabled.Size = new System.Drawing.Size(52, 35);
            this.picSkipDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSkipDisabled.TabIndex = 5;
            this.picSkipDisabled.TabStop = false;
            // 
            // picFiftyDisabled
            // 
            this.picFiftyDisabled.BackColor = System.Drawing.Color.Transparent;
            this.picFiftyDisabled.Image = ((System.Drawing.Image)(resources.GetObject("picFiftyDisabled.Image")));
            this.picFiftyDisabled.Location = new System.Drawing.Point(105, 19);
            this.picFiftyDisabled.Name = "picFiftyDisabled";
            this.picFiftyDisabled.Size = new System.Drawing.Size(53, 35);
            this.picFiftyDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFiftyDisabled.TabIndex = 4;
            this.picFiftyDisabled.TabStop = false;
            // 
            // picRevealDisabled
            // 
            this.picRevealDisabled.BackColor = System.Drawing.Color.Transparent;
            this.picRevealDisabled.Image = ((System.Drawing.Image)(resources.GetObject("picRevealDisabled.Image")));
            this.picRevealDisabled.Location = new System.Drawing.Point(35, 19);
            this.picRevealDisabled.Name = "picRevealDisabled";
            this.picRevealDisabled.Size = new System.Drawing.Size(54, 35);
            this.picRevealDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRevealDisabled.TabIndex = 3;
            this.picRevealDisabled.TabStop = false;
            // 
            // picSkip
            // 
            this.picSkip.Image = ((System.Drawing.Image)(resources.GetObject("picSkip.Image")));
            this.picSkip.Location = new System.Drawing.Point(182, 19);
            this.picSkip.Name = "picSkip";
            this.picSkip.Size = new System.Drawing.Size(46, 35);
            this.picSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSkip.TabIndex = 2;
            this.picSkip.TabStop = false;
            this.tooltipSkip.SetToolTip(this.picSkip, "Skips current question. You lose no life, but you gain no points...\r\nCosts 60 man" +
        "a.");
            this.picSkip.Click += new System.EventHandler(this.picSkip_Click);
            // 
            // picFifty
            // 
            this.picFifty.Image = ((System.Drawing.Image)(resources.GetObject("picFifty.Image")));
            this.picFifty.Location = new System.Drawing.Point(112, 19);
            this.picFifty.Name = "picFifty";
            this.picFifty.Size = new System.Drawing.Size(46, 35);
            this.picFifty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFifty.TabIndex = 1;
            this.picFifty.TabStop = false;
            this.tooltipFifty.SetToolTip(this.picFifty, "Leaves only two answers. One is right, one is not. Choose wisely.\r\nCosts 40 mana." +
        "");
            this.picFifty.Click += new System.EventHandler(this.picFifty_Click);
            // 
            // picReveal
            // 
            this.picReveal.Image = ((System.Drawing.Image)(resources.GetObject("picReveal.Image")));
            this.picReveal.Location = new System.Drawing.Point(43, 19);
            this.picReveal.Name = "picReveal";
            this.picReveal.Size = new System.Drawing.Size(46, 35);
            this.picReveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReveal.TabIndex = 0;
            this.picReveal.TabStop = false;
            this.tooltipReveal.SetToolTip(this.picReveal, "Reveals the answer. Costs 80 mana");
            this.picReveal.Click += new System.EventHandler(this.picReveal_Click);
            // 
            // tooltipReveal
            // 
            this.tooltipReveal.ToolTipTitle = "Clarity";
            // 
            // tooltipFifty
            // 
            this.tooltipFifty.ToolTipTitle = "50/50";
            // 
            // tooltipSkip
            // 
            this.tooltipSkip.ToolTipTitle = "Skip";
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(6, 17);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(80, 20);
            this.lblHealth.TabIndex = 22;
            this.lblHealth.Text = "5000/5000";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMana
            // 
            this.lblMana.BackColor = System.Drawing.Color.Transparent;
            this.lblMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMana.ForeColor = System.Drawing.Color.White;
            this.lblMana.Location = new System.Drawing.Point(6, 17);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(70, 20);
            this.lblMana.TabIndex = 23;
            this.lblMana.Text = "100/100";
            this.lblMana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHealth);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 40);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Health";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMana);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(637, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 40);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mana";
            // 
            // timerForChecks
            // 
            this.timerForChecks.Tick += new System.EventHandler(this.timerForChecks_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(762, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPowers);
            this.Controls.Add(this.prgBarMana);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cbxQDifficulty);
            this.Controls.Add(this.cbxQType);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.prgBarHealth);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Text = "Question Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBoxPowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSkipDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiftyDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevealDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFifty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReveal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.ProgressBar prgBarHealth;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox cbxQDifficulty;
        private System.Windows.Forms.ComboBox cbxQType;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.ProgressBar prgBarMana;
        private System.Windows.Forms.GroupBox groupBoxPowers;
        private System.Windows.Forms.PictureBox picSkip;
        private System.Windows.Forms.PictureBox picFifty;
        private System.Windows.Forms.PictureBox picReveal;
        private System.Windows.Forms.ToolTip tooltipReveal;
        private System.Windows.Forms.ToolTip tooltipFifty;
        private System.Windows.Forms.ToolTip tooltipSkip;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picRevealDisabled;
        private System.Windows.Forms.PictureBox picSkipDisabled;
        private System.Windows.Forms.PictureBox picFiftyDisabled;
        private System.Windows.Forms.Timer timerForChecks;
    }
}