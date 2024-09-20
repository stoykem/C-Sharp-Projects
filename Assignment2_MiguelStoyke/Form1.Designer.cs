namespace Assignment2_MiguelStoyke
{
    partial class TicTacToe
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
            components = new System.ComponentModel.Container();
            GameSetupBox = new GroupBox();
            Player2Symbol = new Label();
            Player2Text = new TextBox();
            Player2SymText = new TextBox();
            Player1Text = new TextBox();
            Player1SymText = new TextBox();
            Player1Symbol = new Label();
            Player2Name = new Label();
            Player1Name = new Label();
            GameStatsBox = new GroupBox();
            WinnerText = new TextBox();
            GameStatsList = new ListBox();
            Winner = new Label();
            GameAreaBox = new GroupBox();
            ContinueButton = new Button();
            ResetButton = new Button();
            StartButton = new Button();
            NextTurnText = new TextBox();
            NextTurn = new Label();
            three = new Button();
            six = new Button();
            one = new Button();
            eight = new Button();
            nine = new Button();
            four = new Button();
            two = new Button();
            seven = new Button();
            five = new Button();
            name1 = new ToolTip(components);
            sym1 = new ToolTip(components);
            sym2 = new ToolTip(components);
            name2 = new ToolTip(components);
            gameBoard = new ToolTip(components);
            Continue = new ToolTip(components);
            reset = new ToolTip(components);
            start = new ToolTip(components);
            next = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            GameSetupBox.SuspendLayout();
            GameStatsBox.SuspendLayout();
            GameAreaBox.SuspendLayout();
            SuspendLayout();
            // 
            // GameSetupBox
            // 
            GameSetupBox.Controls.Add(Player2Symbol);
            GameSetupBox.Controls.Add(Player2Text);
            GameSetupBox.Controls.Add(Player2SymText);
            GameSetupBox.Controls.Add(Player1Text);
            GameSetupBox.Controls.Add(Player1SymText);
            GameSetupBox.Controls.Add(Player1Symbol);
            GameSetupBox.Controls.Add(Player2Name);
            GameSetupBox.Controls.Add(Player1Name);
            GameSetupBox.Location = new Point(31, 24);
            GameSetupBox.Name = "GameSetupBox";
            GameSetupBox.Size = new Size(876, 143);
            GameSetupBox.TabIndex = 0;
            GameSetupBox.TabStop = false;
            GameSetupBox.Text = "Game Setup";
            // 
            // Player2Symbol
            // 
            Player2Symbol.AutoSize = true;
            Player2Symbol.Location = new Point(555, 91);
            Player2Symbol.Name = "Player2Symbol";
            Player2Symbol.Size = new Size(118, 20);
            Player2Symbol.TabIndex = 8;
            Player2Symbol.Text = "Player 2 Symbol:";
            // 
            // Player2Text
            // 
            Player2Text.Location = new Point(163, 84);
            Player2Text.Name = "Player2Text";
            Player2Text.Size = new Size(298, 27);
            Player2Text.TabIndex = 7;
            name2.SetToolTip(Player2Text, "Enter player 2's name");
            // 
            // Player2SymText
            // 
            Player2SymText.Location = new Point(712, 84);
            Player2SymText.Name = "Player2SymText";
            Player2SymText.Size = new Size(77, 27);
            Player2SymText.TabIndex = 6;
            sym2.SetToolTip(Player2SymText, "Enter player 2's player symbol");
            // 
            // Player1Text
            // 
            Player1Text.Location = new Point(163, 36);
            Player1Text.Name = "Player1Text";
            Player1Text.Size = new Size(298, 27);
            Player1Text.TabIndex = 5;
            name1.SetToolTip(Player1Text, "Enter player 1's name");
            // 
            // Player1SymText
            // 
            Player1SymText.Location = new Point(712, 36);
            Player1SymText.Name = "Player1SymText";
            Player1SymText.Size = new Size(77, 27);
            Player1SymText.TabIndex = 4;
            sym1.SetToolTip(Player1SymText, "Enter player 1's player symbol");
            // 
            // Player1Symbol
            // 
            Player1Symbol.AutoSize = true;
            Player1Symbol.Location = new Point(555, 43);
            Player1Symbol.Name = "Player1Symbol";
            Player1Symbol.Size = new Size(118, 20);
            Player1Symbol.TabIndex = 2;
            Player1Symbol.Text = "Player 1 Symbol:";
            // 
            // Player2Name
            // 
            Player2Name.AutoSize = true;
            Player2Name.Location = new Point(25, 91);
            Player2Name.Name = "Player2Name";
            Player2Name.Size = new Size(108, 20);
            Player2Name.TabIndex = 1;
            Player2Name.Text = "Player 2 Name:";
            // 
            // Player1Name
            // 
            Player1Name.AutoSize = true;
            Player1Name.Location = new Point(25, 43);
            Player1Name.Name = "Player1Name";
            Player1Name.Size = new Size(108, 20);
            Player1Name.TabIndex = 0;
            Player1Name.Text = "Player 1 Name:";
            // 
            // GameStatsBox
            // 
            GameStatsBox.Controls.Add(WinnerText);
            GameStatsBox.Controls.Add(GameStatsList);
            GameStatsBox.Controls.Add(Winner);
            GameStatsBox.Location = new Point(639, 201);
            GameStatsBox.Name = "GameStatsBox";
            GameStatsBox.Size = new Size(268, 412);
            GameStatsBox.TabIndex = 2;
            GameStatsBox.TabStop = false;
            GameStatsBox.Text = "Game Stats";
            // 
            // WinnerText
            // 
            WinnerText.Location = new Point(104, 366);
            WinnerText.Name = "WinnerText";
            WinnerText.ReadOnly = true;
            WinnerText.Size = new Size(149, 27);
            WinnerText.TabIndex = 15;
            toolTip1.SetToolTip(WinnerText, "The winner's name of the match will display here");
            // 
            // GameStatsList
            // 
            GameStatsList.FormattingEnabled = true;
            GameStatsList.ItemHeight = 20;
            GameStatsList.Location = new Point(19, 40);
            GameStatsList.Name = "GameStatsList";
            GameStatsList.Size = new Size(234, 304);
            GameStatsList.TabIndex = 0;
            // 
            // Winner
            // 
            Winner.AutoSize = true;
            Winner.Location = new Point(19, 373);
            Winner.Name = "Winner";
            Winner.Size = new Size(59, 20);
            Winner.TabIndex = 14;
            Winner.Text = "Winner:";
            // 
            // GameAreaBox
            // 
            GameAreaBox.Controls.Add(ContinueButton);
            GameAreaBox.Controls.Add(ResetButton);
            GameAreaBox.Controls.Add(StartButton);
            GameAreaBox.Controls.Add(NextTurnText);
            GameAreaBox.Controls.Add(NextTurn);
            GameAreaBox.Controls.Add(three);
            GameAreaBox.Controls.Add(six);
            GameAreaBox.Controls.Add(one);
            GameAreaBox.Controls.Add(eight);
            GameAreaBox.Controls.Add(nine);
            GameAreaBox.Controls.Add(four);
            GameAreaBox.Controls.Add(two);
            GameAreaBox.Controls.Add(seven);
            GameAreaBox.Controls.Add(five);
            GameAreaBox.Location = new Point(31, 201);
            GameAreaBox.Name = "GameAreaBox";
            GameAreaBox.Size = new Size(520, 412);
            GameAreaBox.TabIndex = 1;
            GameAreaBox.TabStop = false;
            GameAreaBox.Text = "Game Area";
            gameBoard.SetToolTip(GameAreaBox, "Game Board - click the squares when playing");
            // 
            // ContinueButton
            // 
            ContinueButton.Enabled = false;
            ContinueButton.Location = new Point(395, 133);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(94, 47);
            ContinueButton.TabIndex = 13;
            ContinueButton.Text = "Continue";
            Continue.SetToolTip(ContinueButton, "Press for a rematch");
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(395, 196);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 47);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "Reset";
            reset.SetToolTip(ResetButton, "Press to reset the player board");
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(395, 70);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 47);
            StartButton.TabIndex = 11;
            StartButton.Text = "Start";
            start.SetToolTip(StartButton, "Press to start a game");
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // NextTurnText
            // 
            NextTurnText.Location = new Point(151, 366);
            NextTurnText.Name = "NextTurnText";
            NextTurnText.ReadOnly = true;
            NextTurnText.Size = new Size(210, 27);
            NextTurnText.TabIndex = 10;
            next.SetToolTip(NextTurnText, "Will display the current player name's turn");
            // 
            // NextTurn
            // 
            NextTurn.AutoSize = true;
            NextTurn.Location = new Point(57, 373);
            NextTurn.Name = "NextTurn";
            NextTurn.Size = new Size(76, 20);
            NextTurn.TabIndex = 9;
            NextTurn.Text = "Next Turn:";
            // 
            // three
            // 
            three.BackColor = SystemColors.ActiveCaption;
            three.Location = new Point(253, 45);
            three.Name = "three";
            three.Size = new Size(108, 96);
            three.TabIndex = 8;
            three.UseVisualStyleBackColor = false;
            // 
            // six
            // 
            six.BackColor = SystemColors.ActiveCaption;
            six.Location = new Point(253, 147);
            six.Name = "six";
            six.Size = new Size(108, 96);
            six.TabIndex = 7;
            six.UseVisualStyleBackColor = false;
            // 
            // one
            // 
            one.BackColor = SystemColors.ActiveCaption;
            one.Location = new Point(25, 45);
            one.Name = "one";
            one.Size = new Size(108, 96);
            one.TabIndex = 6;
            one.UseVisualStyleBackColor = false;
            // 
            // eight
            // 
            eight.BackColor = SystemColors.ActiveCaption;
            eight.Location = new Point(139, 249);
            eight.Name = "eight";
            eight.Size = new Size(108, 96);
            eight.TabIndex = 5;
            eight.UseVisualStyleBackColor = false;
            // 
            // nine
            // 
            nine.BackColor = SystemColors.ActiveCaption;
            nine.Location = new Point(253, 249);
            nine.Name = "nine";
            nine.Size = new Size(108, 96);
            nine.TabIndex = 4;
            nine.UseVisualStyleBackColor = false;
            // 
            // four
            // 
            four.BackColor = SystemColors.ActiveCaption;
            four.Location = new Point(25, 147);
            four.Name = "four";
            four.Size = new Size(108, 96);
            four.TabIndex = 3;
            four.UseVisualStyleBackColor = false;
            // 
            // two
            // 
            two.BackColor = SystemColors.ActiveCaption;
            two.Location = new Point(139, 45);
            two.Name = "two";
            two.Size = new Size(108, 96);
            two.TabIndex = 2;
            two.UseVisualStyleBackColor = false;
            // 
            // seven
            // 
            seven.BackColor = SystemColors.ActiveCaption;
            seven.Location = new Point(25, 249);
            seven.Name = "seven";
            seven.Size = new Size(108, 96);
            seven.TabIndex = 1;
            seven.UseVisualStyleBackColor = false;
            // 
            // five
            // 
            five.BackColor = SystemColors.ActiveCaption;
            five.Location = new Point(139, 147);
            five.Name = "five";
            five.Size = new Size(108, 96);
            five.TabIndex = 0;
            five.UseVisualStyleBackColor = false;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(939, 643);
            Controls.Add(GameStatsBox);
            Controls.Add(GameAreaBox);
            Controls.Add(GameSetupBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            GameSetupBox.ResumeLayout(false);
            GameSetupBox.PerformLayout();
            GameStatsBox.ResumeLayout(false);
            GameStatsBox.PerformLayout();
            GameAreaBox.ResumeLayout(false);
            GameAreaBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GameSetupBox;
        private GroupBox GameStatsBox;
        private TextBox Player2Text;
        private TextBox Player2SymText;
        private TextBox Player1Text;
        private TextBox Player1SymText;
        private Label Player1Symbol;
        private Label Player2Name;
        private Label Player1Name;
        private Label Player2Symbol;
        private GroupBox GameAreaBox;
        private Button three;
        private Button six;
        private Button one;
        private Button eight;
        private Button nine;
        private Button four;
        private Button two;
        private Button seven;
        private Button five;
        private TextBox NextTurnText;
        private Label NextTurn;
        private Button ContinueButton;
        private Button ResetButton;
        private Button StartButton;
        private TextBox WinnerText;
        private ListBox GameStatsList;
        private Label Winner;
        private ToolTip name1;
        private ToolTip sym1;
        private ToolTip sym2;
        private ToolTip name2;
        private ToolTip gameBoard;
        private ToolTip Continue;
        private ToolTip reset;
        private ToolTip start;
        private ToolTip toolTip1;
        private ToolTip next;
    }
}