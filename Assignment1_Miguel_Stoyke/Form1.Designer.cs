namespace Assignment1_Miguel_Stoyke
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
            InputBox = new TextBox();
            VideoGameSales = new Label();
            DayNum = new Label();
            AverageGameSales = new TextBox();
            SalesList = new ListBox();
            EnterButton = new Button();
            ResetButton = new Button();
            Exit = new Button();
            TextTip = new ToolTip(components);
            ListTip = new ToolTip(components);
            OutputTip = new ToolTip(components);
            EnterTip = new ToolTip(components);
            ResetTip = new ToolTip(components);
            ExitTip = new ToolTip(components);
            InputTip = new ToolTip(components);
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.Location = new Point(214, 36);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(183, 27);
            InputBox.TabIndex = 0;
            TextTip.SetToolTip(InputBox, "Enter a the sales number for the day as a whole number.");
            InputTip.SetToolTip(InputBox, "Enter sales numbers here to be calculated as a weekly average.");
            // 
            // VideoGameSales
            // 
            VideoGameSales.AutoSize = true;
            VideoGameSales.Location = new Point(43, 36);
            VideoGameSales.Name = "VideoGameSales";
            VideoGameSales.Size = new Size(132, 20);
            VideoGameSales.TabIndex = 1;
            VideoGameSales.Text = "Video Game Sales:";
            // 
            // DayNum
            // 
            DayNum.AutoSize = true;
            DayNum.Location = new Point(474, 36);
            DayNum.Name = "DayNum";
            DayNum.Size = new Size(48, 20);
            DayNum.TabIndex = 2;
            DayNum.Text = "Day #";
            // 
            // AverageGameSales
            // 
            AverageGameSales.Location = new Point(43, 468);
            AverageGameSales.Name = "AverageGameSales";
            AverageGameSales.ReadOnly = true;
            AverageGameSales.Size = new Size(491, 27);
            AverageGameSales.TabIndex = 4;
            AverageGameSales.Text = "Average Video Game Sales: $";
            AverageGameSales.TextAlign = HorizontalAlignment.Center;
            OutputTip.SetToolTip(AverageGameSales, "The average calculation is shown here, as well as messages.");
            AverageGameSales.TextChanged += AverageGameSales_TextChanged;
            // 
            // SalesList
            // 
            SalesList.FormattingEnabled = true;
            SalesList.ItemHeight = 20;
            SalesList.Location = new Point(43, 97);
            SalesList.Name = "SalesList";
            SalesList.Size = new Size(491, 344);
            SalesList.TabIndex = 6;
            ListTip.SetToolTip(SalesList, "List of sales numbers to be calculated as an average.");
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(43, 529);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(94, 29);
            EnterButton.TabIndex = 7;
            EnterButton.Text = "&Enter";
            EnterTip.SetToolTip(EnterButton, "Press 'Alt+E', or click here to proceed with calculation.");
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(246, 529);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 8;
            ResetButton.Text = "&Reset";
            ResetTip.SetToolTip(ResetButton, "Press 'Alt+R' or click here to reset the calculation.");
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(440, 529);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 9;
            Exit.Text = "E&xit";
            ExitTip.SetToolTip(Exit, "Press 'Alt+X', or click here to exit the application.");
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 613);
            Controls.Add(Exit);
            Controls.Add(ResetButton);
            Controls.Add(EnterButton);
            Controls.Add(SalesList);
            Controls.Add(AverageGameSales);
            Controls.Add(DayNum);
            Controls.Add(VideoGameSales);
            Controls.Add(InputBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Average Weekly Video Games";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputBox;
        private Label VideoGameSales;
        private Label DayNum;
        private TextBox AverageGameSales;
        private ListBox SalesList;
        private Button EnterButton;
        private Button ResetButton;
        private Button Exit;
        private ToolTip TextTip;
        private ToolTip ListTip;
        private ToolTip OutputTip;
        private ToolTip EnterTip;
        private ToolTip ResetTip;
        private ToolTip ExitTip;
        private ToolTip InputTip;
    }
}