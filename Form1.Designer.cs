namespace Assignment2
{
    partial class DiceGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameInfoBox = new GroupBox();
            LNumLost = new Label();
            LNumWon = new Label();
            LNumPlay = new Label();
            LInfoLost = new Label();
            LInfoWon = new Label();
            LInfoPlayed = new Label();
            EnterNumLabel = new Label();
            EnterBox = new TextBox();
            RollButton = new Button();
            ResetButton = new Button();
            GameTable = new TableLayoutPanel();
            LGuess6 = new Label();
            LPrecent6 = new Label();
            LFreqNum6 = new Label();
            LFace6 = new Label();
            LGuess5 = new Label();
            LPrecent5 = new Label();
            LFreqNum5 = new Label();
            LFace5 = new Label();
            LGuess4 = new Label();
            LPrecent4 = new Label();
            LFreqNum4 = new Label();
            LFace4 = new Label();
            LGuess3 = new Label();
            LPrecent3 = new Label();
            LFreqNum3 = new Label();
            LFace3 = new Label();
            LGuess2 = new Label();
            LPrecent2 = new Label();
            LFreqNum2 = new Label();
            LFace2 = new Label();
            LGuess1 = new Label();
            LPercent1 = new Label();
            LFace1 = new Label();
            LNumOfTimesGuessed = new Label();
            LFace = new Label();
            LPercent = new Label();
            LFrequency = new Label();
            LFreqNum1 = new Label();
            pictureBox = new PictureBox();
            ErrorLable = new Label();
            GameInfoBox.SuspendLayout();
            GameTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // GameInfoBox
            // 
            GameInfoBox.Controls.Add(LNumLost);
            GameInfoBox.Controls.Add(LNumWon);
            GameInfoBox.Controls.Add(LNumPlay);
            GameInfoBox.Controls.Add(LInfoLost);
            GameInfoBox.Controls.Add(LInfoWon);
            GameInfoBox.Controls.Add(LInfoPlayed);
            GameInfoBox.Location = new Point(35, 28);
            GameInfoBox.Name = "GameInfoBox";
            GameInfoBox.Size = new Size(278, 211);
            GameInfoBox.TabIndex = 0;
            GameInfoBox.TabStop = false;
            GameInfoBox.Text = "Game Info";
            GameInfoBox.Enter += groupBox1_Enter;
            // 
            // LNumLost
            // 
            LNumLost.AutoSize = true;
            LNumLost.Location = new Point(211, 139);
            LNumLost.Name = "LNumLost";
            LNumLost.Size = new Size(17, 20);
            LNumLost.TabIndex = 5;
            LNumLost.Text = "0";
            // 
            // LNumWon
            // 
            LNumWon.AutoSize = true;
            LNumWon.Location = new Point(210, 95);
            LNumWon.Name = "LNumWon";
            LNumWon.Size = new Size(17, 20);
            LNumWon.TabIndex = 4;
            LNumWon.Text = "0";
            // 
            // LNumPlay
            // 
            LNumPlay.AutoSize = true;
            LNumPlay.Location = new Point(211, 46);
            LNumPlay.Name = "LNumPlay";
            LNumPlay.Size = new Size(17, 20);
            LNumPlay.TabIndex = 3;
            LNumPlay.Text = "0";
            // 
            // LInfoLost
            // 
            LInfoLost.AutoSize = true;
            LInfoLost.Location = new Point(29, 139);
            LInfoLost.Name = "LInfoLost";
            LInfoLost.Size = new Size(152, 20);
            LInfoLost.TabIndex = 2;
            LInfoLost.Text = "Number of times lost:";
            // 
            // LInfoWon
            // 
            LInfoWon.AutoSize = true;
            LInfoWon.Location = new Point(29, 95);
            LInfoWon.Name = "LInfoWon";
            LInfoWon.Size = new Size(162, 20);
            LInfoWon.TabIndex = 1;
            LInfoWon.Text = "Number of times Won: ";
            LInfoWon.Click += label31_Click;
            // 
            // LInfoPlayed
            // 
            LInfoPlayed.AutoSize = true;
            LInfoPlayed.Location = new Point(29, 46);
            LInfoPlayed.Name = "LInfoPlayed";
            LInfoPlayed.Size = new Size(172, 20);
            LInfoPlayed.TabIndex = 0;
            LInfoPlayed.Text = "Number of times Played:";
            // 
            // EnterNumLabel
            // 
            EnterNumLabel.AutoSize = true;
            EnterNumLabel.Location = new Point(143, 270);
            EnterNumLabel.Name = "EnterNumLabel";
            EnterNumLabel.Size = new Size(156, 20);
            EnterNumLabel.TabIndex = 1;
            EnterNumLabel.Text = "Enter your guess (1-6):";
            EnterNumLabel.Click += label1_Click;
            // 
            // EnterBox
            // 
            EnterBox.Location = new Point(309, 270);
            EnterBox.MaxLength = 1;
            EnterBox.Name = "EnterBox";
            EnterBox.Size = new Size(60, 27);
            EnterBox.TabIndex = 2;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(296, 329);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(94, 29);
            RollButton.TabIndex = 3;
            RollButton.Text = "Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += button1_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(296, 377);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // GameTable
            // 
            GameTable.Anchor = AnchorStyles.None;
            GameTable.BackColor = SystemColors.AppWorkspace;
            GameTable.ColumnCount = 4;
            GameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            GameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            GameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            GameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            GameTable.Controls.Add(LGuess6, 3, 6);
            GameTable.Controls.Add(LPrecent6, 2, 6);
            GameTable.Controls.Add(LFreqNum6, 1, 6);
            GameTable.Controls.Add(LFace6, 0, 6);
            GameTable.Controls.Add(LGuess5, 3, 5);
            GameTable.Controls.Add(LPrecent5, 2, 5);
            GameTable.Controls.Add(LFreqNum5, 1, 5);
            GameTable.Controls.Add(LFace5, 0, 5);
            GameTable.Controls.Add(LGuess4, 3, 4);
            GameTable.Controls.Add(LPrecent4, 2, 4);
            GameTable.Controls.Add(LFreqNum4, 1, 4);
            GameTable.Controls.Add(LFace4, 0, 4);
            GameTable.Controls.Add(LGuess3, 3, 3);
            GameTable.Controls.Add(LPrecent3, 2, 3);
            GameTable.Controls.Add(LFreqNum3, 1, 3);
            GameTable.Controls.Add(LFace3, 0, 3);
            GameTable.Controls.Add(LGuess2, 3, 2);
            GameTable.Controls.Add(LPrecent2, 2, 2);
            GameTable.Controls.Add(LFreqNum2, 1, 2);
            GameTable.Controls.Add(LFace2, 0, 2);
            GameTable.Controls.Add(LGuess1, 3, 1);
            GameTable.Controls.Add(LPercent1, 2, 1);
            GameTable.Controls.Add(LFace1, 0, 1);
            GameTable.Controls.Add(LNumOfTimesGuessed, 3, 0);
            GameTable.Controls.Add(LFace, 0, 0);
            GameTable.Controls.Add(LPercent, 2, 0);
            GameTable.Controls.Add(LFrequency, 1, 0);
            GameTable.Controls.Add(LFreqNum1, 1, 1);
            GameTable.Location = new Point(15, 443);
            GameTable.Name = "GameTable";
            GameTable.RowCount = 7;
            GameTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            GameTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            GameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            GameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            GameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            GameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            GameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            GameTable.Size = new Size(629, 191);
            GameTable.TabIndex = 5;
            GameTable.Paint += tableLayoutPanel1_Paint;
            // 
            // LGuess6
            // 
            LGuess6.Anchor = AnchorStyles.None;
            LGuess6.AutoSize = true;
            LGuess6.Location = new Point(510, 167);
            LGuess6.Name = "LGuess6";
            LGuess6.Size = new Size(17, 20);
            LGuess6.TabIndex = 27;
            LGuess6.Text = "0";
            // 
            // LPrecent6
            // 
            LPrecent6.Anchor = AnchorStyles.None;
            LPrecent6.AutoSize = true;
            LPrecent6.Location = new Point(305, 167);
            LPrecent6.Name = "LPrecent6";
            LPrecent6.Size = new Size(48, 20);
            LPrecent6.TabIndex = 26;
            LPrecent6.Text = "0.00%";
            // 
            // LFreqNum6
            // 
            LFreqNum6.Anchor = AnchorStyles.None;
            LFreqNum6.AutoSize = true;
            LFreqNum6.Location = new Point(179, 167);
            LFreqNum6.Name = "LFreqNum6";
            LFreqNum6.Size = new Size(17, 20);
            LFreqNum6.TabIndex = 25;
            LFreqNum6.Text = "0";
            // 
            // LFace6
            // 
            LFace6.Anchor = AnchorStyles.None;
            LFace6.AutoSize = true;
            LFace6.Location = new Point(54, 167);
            LFace6.Name = "LFace6";
            LFace6.Size = new Size(17, 20);
            LFace6.TabIndex = 24;
            LFace6.Text = "6";
            // 
            // LGuess5
            // 
            LGuess5.Anchor = AnchorStyles.None;
            LGuess5.AutoSize = true;
            LGuess5.Location = new Point(510, 141);
            LGuess5.Name = "LGuess5";
            LGuess5.Size = new Size(17, 20);
            LGuess5.TabIndex = 23;
            LGuess5.Text = "0";
            // 
            // LPrecent5
            // 
            LPrecent5.Anchor = AnchorStyles.None;
            LPrecent5.AutoSize = true;
            LPrecent5.Location = new Point(305, 141);
            LPrecent5.Name = "LPrecent5";
            LPrecent5.Size = new Size(48, 20);
            LPrecent5.TabIndex = 22;
            LPrecent5.Text = "0.00%";
            // 
            // LFreqNum5
            // 
            LFreqNum5.Anchor = AnchorStyles.None;
            LFreqNum5.AutoSize = true;
            LFreqNum5.Location = new Point(179, 141);
            LFreqNum5.Name = "LFreqNum5";
            LFreqNum5.Size = new Size(17, 20);
            LFreqNum5.TabIndex = 21;
            LFreqNum5.Text = "0";
            // 
            // LFace5
            // 
            LFace5.Anchor = AnchorStyles.None;
            LFace5.AutoSize = true;
            LFace5.Location = new Point(54, 141);
            LFace5.Name = "LFace5";
            LFace5.Size = new Size(17, 20);
            LFace5.TabIndex = 20;
            LFace5.Text = "5";
            // 
            // LGuess4
            // 
            LGuess4.Anchor = AnchorStyles.None;
            LGuess4.AutoSize = true;
            LGuess4.Location = new Point(510, 115);
            LGuess4.Name = "LGuess4";
            LGuess4.Size = new Size(17, 20);
            LGuess4.TabIndex = 19;
            LGuess4.Text = "0";
            // 
            // LPrecent4
            // 
            LPrecent4.Anchor = AnchorStyles.None;
            LPrecent4.AutoSize = true;
            LPrecent4.Location = new Point(305, 115);
            LPrecent4.Name = "LPrecent4";
            LPrecent4.Size = new Size(48, 20);
            LPrecent4.TabIndex = 18;
            LPrecent4.Text = "0.00%";
            // 
            // LFreqNum4
            // 
            LFreqNum4.Anchor = AnchorStyles.None;
            LFreqNum4.AutoSize = true;
            LFreqNum4.Location = new Point(179, 115);
            LFreqNum4.Name = "LFreqNum4";
            LFreqNum4.Size = new Size(17, 20);
            LFreqNum4.TabIndex = 17;
            LFreqNum4.Text = "0";
            // 
            // LFace4
            // 
            LFace4.Anchor = AnchorStyles.None;
            LFace4.AutoSize = true;
            LFace4.Location = new Point(54, 115);
            LFace4.Name = "LFace4";
            LFace4.Size = new Size(17, 20);
            LFace4.TabIndex = 16;
            LFace4.Text = "4";
            // 
            // LGuess3
            // 
            LGuess3.Anchor = AnchorStyles.None;
            LGuess3.AutoSize = true;
            LGuess3.Location = new Point(510, 89);
            LGuess3.Name = "LGuess3";
            LGuess3.Size = new Size(17, 20);
            LGuess3.TabIndex = 15;
            LGuess3.Text = "0";
            // 
            // LPrecent3
            // 
            LPrecent3.Anchor = AnchorStyles.None;
            LPrecent3.AutoSize = true;
            LPrecent3.Location = new Point(305, 89);
            LPrecent3.Name = "LPrecent3";
            LPrecent3.Size = new Size(48, 20);
            LPrecent3.TabIndex = 14;
            LPrecent3.Text = "0.00%";
            // 
            // LFreqNum3
            // 
            LFreqNum3.Anchor = AnchorStyles.None;
            LFreqNum3.AutoSize = true;
            LFreqNum3.Location = new Point(179, 89);
            LFreqNum3.Name = "LFreqNum3";
            LFreqNum3.Size = new Size(17, 20);
            LFreqNum3.TabIndex = 13;
            LFreqNum3.Text = "0";
            // 
            // LFace3
            // 
            LFace3.Anchor = AnchorStyles.None;
            LFace3.AutoSize = true;
            LFace3.Location = new Point(54, 89);
            LFace3.Name = "LFace3";
            LFace3.Size = new Size(17, 20);
            LFace3.TabIndex = 12;
            LFace3.Text = "3";
            // 
            // LGuess2
            // 
            LGuess2.Anchor = AnchorStyles.None;
            LGuess2.AutoSize = true;
            LGuess2.Location = new Point(510, 62);
            LGuess2.Name = "LGuess2";
            LGuess2.Size = new Size(17, 20);
            LGuess2.TabIndex = 11;
            LGuess2.Text = "0";
            // 
            // LPrecent2
            // 
            LPrecent2.Anchor = AnchorStyles.None;
            LPrecent2.AutoSize = true;
            LPrecent2.Location = new Point(305, 62);
            LPrecent2.Name = "LPrecent2";
            LPrecent2.Size = new Size(48, 20);
            LPrecent2.TabIndex = 10;
            LPrecent2.Text = "0.00%";
            // 
            // LFreqNum2
            // 
            LFreqNum2.Anchor = AnchorStyles.None;
            LFreqNum2.AutoSize = true;
            LFreqNum2.Location = new Point(179, 62);
            LFreqNum2.Name = "LFreqNum2";
            LFreqNum2.Size = new Size(17, 20);
            LFreqNum2.TabIndex = 9;
            LFreqNum2.Text = "0";
            // 
            // LFace2
            // 
            LFace2.Anchor = AnchorStyles.None;
            LFace2.AutoSize = true;
            LFace2.Location = new Point(54, 62);
            LFace2.Name = "LFace2";
            LFace2.Size = new Size(17, 20);
            LFace2.TabIndex = 8;
            LFace2.Text = "2";
            // 
            // LGuess1
            // 
            LGuess1.Anchor = AnchorStyles.None;
            LGuess1.AutoSize = true;
            LGuess1.Location = new Point(510, 33);
            LGuess1.Name = "LGuess1";
            LGuess1.Size = new Size(17, 20);
            LGuess1.TabIndex = 7;
            LGuess1.Text = "0";
            // 
            // LPercent1
            // 
            LPercent1.Anchor = AnchorStyles.None;
            LPercent1.AutoSize = true;
            LPercent1.Location = new Point(305, 33);
            LPercent1.Name = "LPercent1";
            LPercent1.Size = new Size(48, 20);
            LPercent1.TabIndex = 6;
            LPercent1.Text = "0.00%";
            // 
            // LFace1
            // 
            LFace1.Anchor = AnchorStyles.None;
            LFace1.AutoSize = true;
            LFace1.Location = new Point(54, 33);
            LFace1.Name = "LFace1";
            LFace1.Size = new Size(17, 20);
            LFace1.TabIndex = 4;
            LFace1.Text = "1";
            // 
            // LNumOfTimesGuessed
            // 
            LNumOfTimesGuessed.Anchor = AnchorStyles.None;
            LNumOfTimesGuessed.AutoSize = true;
            LNumOfTimesGuessed.Location = new Point(417, 4);
            LNumOfTimesGuessed.Name = "LNumOfTimesGuessed";
            LNumOfTimesGuessed.Size = new Size(203, 20);
            LNumOfTimesGuessed.TabIndex = 3;
            LNumOfTimesGuessed.Text = "NUMBER OF TIMES GUESSED";
            // 
            // LFace
            // 
            LFace.Anchor = AnchorStyles.None;
            LFace.AutoSize = true;
            LFace.Location = new Point(41, 4);
            LFace.Name = "LFace";
            LFace.Size = new Size(42, 20);
            LFace.TabIndex = 2;
            LFace.Text = "FACE";
            // 
            // LPercent
            // 
            LPercent.Anchor = AnchorStyles.None;
            LPercent.AutoSize = true;
            LPercent.Location = new Point(294, 4);
            LPercent.Name = "LPercent";
            LPercent.Size = new Size(70, 20);
            LPercent.TabIndex = 0;
            LPercent.Text = "PERCENT";
            // 
            // LFrequency
            // 
            LFrequency.Anchor = AnchorStyles.None;
            LFrequency.AutoSize = true;
            LFrequency.Location = new Point(142, 4);
            LFrequency.Name = "LFrequency";
            LFrequency.Size = new Size(90, 20);
            LFrequency.TabIndex = 1;
            LFrequency.Text = "FREQUENCY";
            // 
            // LFreqNum1
            // 
            LFreqNum1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LFreqNum1.AutoSize = true;
            LFreqNum1.Location = new Point(128, 33);
            LFreqNum1.Name = "LFreqNum1";
            LFreqNum1.Size = new Size(119, 20);
            LFreqNum1.TabIndex = 5;
            LFreqNum1.Text = "0";
            LFreqNum1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(52, 304);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(131, 102);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // ErrorLable
            // 
            ErrorLable.AutoSize = true;
            ErrorLable.ForeColor = Color.Red;
            ErrorLable.Location = new Point(489, 71);
            ErrorLable.Name = "ErrorLable";
            ErrorLable.Size = new Size(0, 20);
            ErrorLable.TabIndex = 7;
            // 
            // DiceGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 681);
            Controls.Add(ErrorLable);
            Controls.Add(pictureBox);
            Controls.Add(GameTable);
            Controls.Add(ResetButton);
            Controls.Add(RollButton);
            Controls.Add(EnterBox);
            Controls.Add(EnterNumLabel);
            Controls.Add(GameInfoBox);
            Name = "DiceGameForm";
            Text = "Die Guess Game";
            GameInfoBox.ResumeLayout(false);
            GameInfoBox.PerformLayout();
            GameTable.ResumeLayout(false);
            GameTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GameInfoBox;
        private Label EnterNumLabel;
        private TextBox EnterBox;
        private Button RollButton;
        private Button ResetButton;
        private TableLayoutPanel GameTable;
        private Label LPercent;
        private Label LGuess6;
        private Label LPrecent6;
        private Label LFreqNum6;
        private Label LFace6;
        private Label LGuess5;
        private Label LPrecent5;
        private Label LFreqNum5;
        private Label LFace5;
        private Label LGuess4;
        private Label LPrecent4;
        private Label LFreqNum4;
        private Label LFace4;
        private Label LGuess3;
        private Label LPrecent3;
        private Label LFreqNum3;
        private Label LFace3;
        private Label LGuess2;
        private Label LPrecent2;
        private Label LFreqNum2;
        private Label LFace2;
        private Label LGuess1;
        private Label LPercent1;
        private Label LFreqNum1;
        private Label LFace1;
        private Label LNumOfTimesGuessed;
        private Label LFace;
        private Label LFrequency;
        private PictureBox pictureBox;
        private Label LInfoPlayed;
        private Label LNumLost;
        private Label LNumWon;
        private Label LNumPlay;
        private Label LInfoLost;
        private Label LInfoWon;
        private Label ErrorLable;
    }
}
