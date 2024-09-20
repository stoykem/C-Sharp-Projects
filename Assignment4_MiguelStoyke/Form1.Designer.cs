namespace Assignment4_MiguelStoyke
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CardBox = new GroupBox();
            AddCustButton = new Button();
            RankText = new TextBox();
            RankLabel = new Label();
            SuitLabel = new Label();
            SuitText = new TextBox();
            DrawBox = new GroupBox();
            CardsDealtLabel = new Label();
            DealButton = new Button();
            DrawText = new TextBox();
            DrawLabel = new Label();
            DeckBox = new GroupBox();
            DeckView = new ListView();
            ViewDeckButton = new Button();
            ShuffleButton = new Button();
            ResetButton = new Button();
            ExitButton = new Button();
            CardsDealtView = new ListView();
            suittexttip = new ToolTip(components);
            addcusttip = new ToolTip(components);
            ranktexttip = new ToolTip(components);
            dealbuttontip = new ToolTip(components);
            dealtcardstip = new ToolTip(components);
            drawtexttip = new ToolTip(components);
            viewdecktip = new ToolTip(components);
            shuffletip = new ToolTip(components);
            resettip = new ToolTip(components);
            exittip = new ToolTip(components);
            deckviewtip = new ToolTip(components);
            CardBox.SuspendLayout();
            DrawBox.SuspendLayout();
            DeckBox.SuspendLayout();
            SuspendLayout();
            // 
            // CardBox
            // 
            CardBox.Controls.Add(AddCustButton);
            CardBox.Controls.Add(RankText);
            CardBox.Controls.Add(RankLabel);
            CardBox.Controls.Add(SuitLabel);
            CardBox.Controls.Add(SuitText);
            CardBox.Location = new Point(12, 12);
            CardBox.Name = "CardBox";
            CardBox.Size = new Size(250, 125);
            CardBox.TabIndex = 0;
            CardBox.TabStop = false;
            CardBox.Text = "Card";
            // 
            // AddCustButton
            // 
            AddCustButton.Location = new Point(133, 45);
            AddCustButton.Name = "AddCustButton";
            AddCustButton.Size = new Size(111, 27);
            AddCustButton.TabIndex = 4;
            AddCustButton.Text = "&Add Custom";
            addcusttip.SetToolTip(AddCustButton, "Click here, Enter key, or Alt+A to add your custom card");
            AddCustButton.UseVisualStyleBackColor = true;
            AddCustButton.Click += AddCustButton_Click;
            // 
            // RankText
            // 
            RankText.Location = new Point(46, 57);
            RankText.Name = "RankText";
            RankText.Size = new Size(81, 27);
            RankText.TabIndex = 3;
            ranktexttip.SetToolTip(RankText, "Type the rank for the custom card");
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Location = new Point(6, 64);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(41, 20);
            RankLabel.TabIndex = 2;
            RankLabel.Text = "Rank";
            // 
            // SuitLabel
            // 
            SuitLabel.AutoSize = true;
            SuitLabel.Location = new Point(6, 29);
            SuitLabel.Name = "SuitLabel";
            SuitLabel.Size = new Size(34, 20);
            SuitLabel.TabIndex = 1;
            SuitLabel.Text = "Suit";
            // 
            // SuitText
            // 
            SuitText.Location = new Point(46, 29);
            SuitText.Name = "SuitText";
            SuitText.Size = new Size(81, 27);
            SuitText.TabIndex = 0;
            suittexttip.SetToolTip(SuitText, "Type the suit for the custom card");
            // 
            // DrawBox
            // 
            DrawBox.Controls.Add(CardsDealtLabel);
            DrawBox.Controls.Add(DealButton);
            DrawBox.Controls.Add(DrawText);
            DrawBox.Controls.Add(DrawLabel);
            DrawBox.Location = new Point(12, 143);
            DrawBox.Name = "DrawBox";
            DrawBox.Size = new Size(250, 194);
            DrawBox.TabIndex = 1;
            DrawBox.TabStop = false;
            // 
            // CardsDealtLabel
            // 
            CardsDealtLabel.AutoSize = true;
            CardsDealtLabel.Location = new Point(78, 55);
            CardsDealtLabel.Name = "CardsDealtLabel";
            CardsDealtLabel.Size = new Size(86, 20);
            CardsDealtLabel.TabIndex = 6;
            CardsDealtLabel.Text = "Cards Dealt";
            // 
            // DealButton
            // 
            DealButton.Location = new Point(133, 20);
            DealButton.Name = "DealButton";
            DealButton.Size = new Size(111, 27);
            DealButton.TabIndex = 5;
            DealButton.Text = "Deal";
            dealbuttontip.SetToolTip(DealButton, "Click here to draw the given amount of cards");
            DealButton.UseVisualStyleBackColor = true;
            DealButton.Click += DealButton_Click;
            // 
            // DrawText
            // 
            DrawText.Location = new Point(46, 20);
            DrawText.Name = "DrawText";
            DrawText.Size = new Size(81, 27);
            DrawText.TabIndex = 5;
            drawtexttip.SetToolTip(DrawText, "Enter the number of cards you want to draw from the current deck");
            // 
            // DrawLabel
            // 
            DrawLabel.AutoSize = true;
            DrawLabel.Location = new Point(3, 27);
            DrawLabel.Name = "DrawLabel";
            DrawLabel.Size = new Size(44, 20);
            DrawLabel.TabIndex = 0;
            DrawLabel.Text = "Draw";
            // 
            // DeckBox
            // 
            DeckBox.Controls.Add(DeckView);
            DeckBox.Location = new Point(277, 12);
            DeckBox.Name = "DeckBox";
            DeckBox.Size = new Size(367, 325);
            DeckBox.TabIndex = 2;
            DeckBox.TabStop = false;
            DeckBox.Text = "Deck";
            // 
            // DeckView
            // 
            DeckView.Location = new Point(18, 29);
            DeckView.Name = "DeckView";
            DeckView.Size = new Size(331, 281);
            DeckView.TabIndex = 7;
            deckviewtip.SetToolTip(DeckView, "All cards in the deck (including custom) will display here");
            DeckView.UseCompatibleStateImageBehavior = false;
            // 
            // ViewDeckButton
            // 
            ViewDeckButton.Location = new Point(650, 41);
            ViewDeckButton.Name = "ViewDeckButton";
            ViewDeckButton.Size = new Size(94, 29);
            ViewDeckButton.TabIndex = 3;
            ViewDeckButton.Text = "View Deck";
            viewdecktip.SetToolTip(ViewDeckButton, "Click here to view the current deck of cards");
            ViewDeckButton.UseVisualStyleBackColor = true;
            ViewDeckButton.Click += ViewDeckButton_Click;
            // 
            // ShuffleButton
            // 
            ShuffleButton.Location = new Point(650, 100);
            ShuffleButton.Name = "ShuffleButton";
            ShuffleButton.Size = new Size(94, 29);
            ShuffleButton.TabIndex = 4;
            ShuffleButton.Text = "Shuffle";
            shuffletip.SetToolTip(ShuffleButton, "Click here to shuffle the deck of cards in a random order");
            ShuffleButton.UseVisualStyleBackColor = true;
            ShuffleButton.Click += ShuffleButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(650, 161);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "&Reset";
            resettip.SetToolTip(ResetButton, "Click here, Escape key, or Alt+R to reset the application back with the original 52 cards");
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(650, 223);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "&Exit";
            exittip.SetToolTip(ExitButton, "Click here, the red X, or Alt+E to exit the application");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CardsDealtView
            // 
            CardsDealtView.Location = new Point(43, 221);
            CardsDealtView.Name = "CardsDealtView";
            CardsDealtView.Size = new Size(184, 101);
            CardsDealtView.TabIndex = 8;
            dealtcardstip.SetToolTip(CardsDealtView, "Dealt cards will be displayed here");
            CardsDealtView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 355);
            Controls.Add(CardsDealtView);
            Controls.Add(ExitButton);
            Controls.Add(ResetButton);
            Controls.Add(ShuffleButton);
            Controls.Add(ViewDeckButton);
            Controls.Add(DeckBox);
            Controls.Add(DrawBox);
            Controls.Add(CardBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deck Builder";
            CardBox.ResumeLayout(false);
            CardBox.PerformLayout();
            DrawBox.ResumeLayout(false);
            DrawBox.PerformLayout();
            DeckBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CardBox;
        private GroupBox DrawBox;
        private GroupBox DeckBox;
        private Button ViewDeckButton;
        private Button ShuffleButton;
        private Button ResetButton;
        private Button ExitButton;
        private Button AddCustButton;
        private TextBox RankText;
        private Label RankLabel;
        private Label SuitLabel;
        private TextBox SuitText;
        private Label CardsDealtLabel;
        private Button DealButton;
        private TextBox DrawText;
        private Label DrawLabel;
        private ListView DeckView;
        private ListView CardsDealtView;
        private ToolTip addcusttip;
        private ToolTip ranktexttip;
        private ToolTip suittexttip;
        private ToolTip dealbuttontip;
        private ToolTip drawtexttip;
        private ToolTip dealtcardstip;
        private ToolTip viewdecktip;
        private ToolTip shuffletip;
        private ToolTip resettip;
        private ToolTip exittip;
        private ToolTip deckviewtip;
    }
}