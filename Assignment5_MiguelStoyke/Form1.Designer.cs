namespace Assignment5_MiguelStoyke
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FormMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            recordToolStripMenuItem = new ToolStripMenuItem();
            updateRecordToolStripMenuItem = new ToolStripMenuItem();
            deleteRecordToolStripMenuItem = new ToolStripMenuItem();
            deleteAllRecordsToolStripMenuItem = new ToolStripMenuItem();
            loadRecordsToServerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            readHelpToolStripMenuItem = new ToolStripMenuItem();
            technicalSupportsToolStripMenuItem = new ToolStripMenuItem();
            aboutDCRegistrationAppToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            StuInfoBox = new GroupBox();
            HighSchoolCombo = new ComboBox();
            AdmissionTestCombo = new ComboBox();
            HSchoolGradeLabel = new Label();
            AdmissionTestScoreLabel = new Label();
            EmailText = new TextBox();
            SINText = new TextBox();
            EmailLabel = new Label();
            SINLabel = new Label();
            LNameText = new TextBox();
            LNameLabel = new Label();
            FNameText = new TextBox();
            FNameLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            CheckButton = new Button();
            AvailProgramsBox = new GroupBox();
            TotalCostNumLabel = new Label();
            StudyPeriodNumLabel = new Label();
            ProgramsCombo = new ComboBox();
            CampLocCombo = new ComboBox();
            TotalCostLabel = new Label();
            StudyPeriodLabel = new Label();
            ProgramsLabel = new Label();
            CampLocationLabel = new Label();
            RegisterButton = new Button();
            StudentView = new DataGridView();
            DeleteButton = new Button();
            UpdateButton = new Button();
            LoadButton = new Button();
            RemoveAllButton = new Button();
            SINLabel2 = new Label();
            SINCombo = new ComboBox();
            ExitButton = new Button();
            FormMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            StuInfoBox.SuspendLayout();
            AvailProgramsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentView).BeginInit();
            SuspendLayout();
            // 
            // FormMenu
            // 
            FormMenu.ImageScalingSize = new Size(20, 20);
            FormMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            FormMenu.Location = new Point(0, 0);
            FormMenu.Name = "FormMenu";
            FormMenu.Size = new Size(1192, 28);
            FormMenu.TabIndex = 0;
            FormMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, recordToolStripMenuItem, deleteAllRecordsToolStripMenuItem, loadRecordsToServerToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(245, 26);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // recordToolStripMenuItem
            // 
            recordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateRecordToolStripMenuItem, deleteRecordToolStripMenuItem });
            recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            recordToolStripMenuItem.Size = new Size(245, 26);
            recordToolStripMenuItem.Text = "Record";
            // 
            // updateRecordToolStripMenuItem
            // 
            updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            updateRecordToolStripMenuItem.Size = new Size(192, 26);
            updateRecordToolStripMenuItem.Text = "Update Record";
            updateRecordToolStripMenuItem.Click += updateRecordToolStripMenuItem_Click;
            // 
            // deleteRecordToolStripMenuItem
            // 
            deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            deleteRecordToolStripMenuItem.Size = new Size(192, 26);
            deleteRecordToolStripMenuItem.Text = "Delete Record";
            deleteRecordToolStripMenuItem.Click += deleteRecordToolStripMenuItem_Click;
            // 
            // deleteAllRecordsToolStripMenuItem
            // 
            deleteAllRecordsToolStripMenuItem.Name = "deleteAllRecordsToolStripMenuItem";
            deleteAllRecordsToolStripMenuItem.Size = new Size(245, 26);
            deleteAllRecordsToolStripMenuItem.Text = "Delete All Records";
            deleteAllRecordsToolStripMenuItem.Click += deleteAllRecordsToolStripMenuItem_Click;
            // 
            // loadRecordsToServerToolStripMenuItem
            // 
            loadRecordsToServerToolStripMenuItem.Name = "loadRecordsToServerToolStripMenuItem";
            loadRecordsToServerToolStripMenuItem.Size = new Size(245, 26);
            loadRecordsToServerToolStripMenuItem.Text = "Load Records to Server";
            loadRecordsToServerToolStripMenuItem.Click += loadRecordsToServerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(245, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { readHelpToolStripMenuItem, technicalSupportsToolStripMenuItem, aboutDCRegistrationAppToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // readHelpToolStripMenuItem
            // 
            readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            readHelpToolStripMenuItem.Size = new Size(275, 26);
            readHelpToolStripMenuItem.Text = "Read Help";
            // 
            // technicalSupportsToolStripMenuItem
            // 
            technicalSupportsToolStripMenuItem.Name = "technicalSupportsToolStripMenuItem";
            technicalSupportsToolStripMenuItem.Size = new Size(275, 26);
            technicalSupportsToolStripMenuItem.Text = "Technical Supports";
            technicalSupportsToolStripMenuItem.Click += technicalSupportsToolStripMenuItem_Click;
            // 
            // aboutDCRegistrationAppToolStripMenuItem
            // 
            aboutDCRegistrationAppToolStripMenuItem.Name = "aboutDCRegistrationAppToolStripMenuItem";
            aboutDCRegistrationAppToolStripMenuItem.Size = new Size(275, 26);
            aboutDCRegistrationAppToolStripMenuItem.Text = "About DC-Registration App";
            aboutDCRegistrationAppToolStripMenuItem.Click += aboutDCRegistrationAppToolStripMenuItem_Click;
            // 
            // StuInfoBox
            // 
            StuInfoBox.Controls.Add(HighSchoolCombo);
            StuInfoBox.Controls.Add(AdmissionTestCombo);
            StuInfoBox.Controls.Add(HSchoolGradeLabel);
            StuInfoBox.Controls.Add(AdmissionTestScoreLabel);
            StuInfoBox.Controls.Add(EmailText);
            StuInfoBox.Controls.Add(SINText);
            StuInfoBox.Controls.Add(EmailLabel);
            StuInfoBox.Controls.Add(SINLabel);
            StuInfoBox.Controls.Add(LNameText);
            StuInfoBox.Controls.Add(LNameLabel);
            StuInfoBox.Controls.Add(FNameText);
            StuInfoBox.Controls.Add(FNameLabel);
            StuInfoBox.Location = new Point(31, 31);
            StuInfoBox.Name = "StuInfoBox";
            StuInfoBox.Size = new Size(1134, 100);
            StuInfoBox.TabIndex = 1;
            StuInfoBox.TabStop = false;
            StuInfoBox.Text = "Student Information";
            // 
            // HighSchoolCombo
            // 
            HighSchoolCombo.FormattingEnabled = true;
            HighSchoolCombo.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90" });
            HighSchoolCombo.Location = new Point(1007, 55);
            HighSchoolCombo.Name = "HighSchoolCombo";
            HighSchoolCombo.Size = new Size(109, 28);
            HighSchoolCombo.TabIndex = 12;
            // 
            // AdmissionTestCombo
            // 
            AdmissionTestCombo.FormattingEnabled = true;
            AdmissionTestCombo.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90" });
            AdmissionTestCombo.Location = new Point(1007, 21);
            AdmissionTestCombo.Name = "AdmissionTestCombo";
            AdmissionTestCombo.Size = new Size(109, 28);
            AdmissionTestCombo.TabIndex = 11;
            // 
            // HSchoolGradeLabel
            // 
            HSchoolGradeLabel.AutoSize = true;
            HSchoolGradeLabel.Location = new Point(838, 59);
            HSchoolGradeLabel.Name = "HSchoolGradeLabel";
            HSchoolGradeLabel.Size = new Size(134, 20);
            HSchoolGradeLabel.TabIndex = 10;
            HSchoolGradeLabel.Text = "High School Grade";
            // 
            // AdmissionTestScoreLabel
            // 
            AdmissionTestScoreLabel.AutoSize = true;
            AdmissionTestScoreLabel.Location = new Point(838, 24);
            AdmissionTestScoreLabel.Name = "AdmissionTestScoreLabel";
            AdmissionTestScoreLabel.Size = new Size(149, 20);
            AdmissionTestScoreLabel.TabIndex = 9;
            AdmissionTestScoreLabel.Text = "Admission Test Score";
            // 
            // EmailText
            // 
            EmailText.Location = new Point(450, 56);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(313, 27);
            EmailText.TabIndex = 8;
            // 
            // SINText
            // 
            SINText.Location = new Point(450, 22);
            SINText.Name = "SINText";
            SINText.Size = new Size(313, 27);
            SINText.TabIndex = 7;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(403, 57);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // SINLabel
            // 
            SINLabel.AutoSize = true;
            SINLabel.Location = new Point(403, 24);
            SINLabel.Name = "SINLabel";
            SINLabel.Size = new Size(32, 20);
            SINLabel.TabIndex = 4;
            SINLabel.Text = "SIN";
            // 
            // LNameText
            // 
            LNameText.Location = new Point(92, 57);
            LNameText.Name = "LNameText";
            LNameText.Size = new Size(231, 27);
            LNameText.TabIndex = 3;
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(7, 57);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(79, 20);
            LNameLabel.TabIndex = 2;
            LNameLabel.Text = "Last Name";
            // 
            // FNameText
            // 
            FNameText.Location = new Point(92, 24);
            FNameText.Name = "FNameText";
            FNameText.Size = new Size(231, 27);
            FNameText.TabIndex = 1;
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Location = new Point(6, 24);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(80, 20);
            FNameLabel.TabIndex = 0;
            FNameLabel.Text = "First Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(31, 137);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(136, 29);
            CheckButton.TabIndex = 3;
            CheckButton.Text = "&Check";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // AvailProgramsBox
            // 
            AvailProgramsBox.Controls.Add(TotalCostNumLabel);
            AvailProgramsBox.Controls.Add(StudyPeriodNumLabel);
            AvailProgramsBox.Controls.Add(ProgramsCombo);
            AvailProgramsBox.Controls.Add(CampLocCombo);
            AvailProgramsBox.Controls.Add(TotalCostLabel);
            AvailProgramsBox.Controls.Add(StudyPeriodLabel);
            AvailProgramsBox.Controls.Add(ProgramsLabel);
            AvailProgramsBox.Controls.Add(CampLocationLabel);
            AvailProgramsBox.Location = new Point(31, 172);
            AvailProgramsBox.Name = "AvailProgramsBox";
            AvailProgramsBox.Size = new Size(1134, 100);
            AvailProgramsBox.TabIndex = 4;
            AvailProgramsBox.TabStop = false;
            AvailProgramsBox.Text = "Available Programs";
            // 
            // TotalCostNumLabel
            // 
            TotalCostNumLabel.AutoSize = true;
            TotalCostNumLabel.Location = new Point(1011, 49);
            TotalCostNumLabel.Name = "TotalCostNumLabel";
            TotalCostNumLabel.Size = new Size(48, 20);
            TotalCostNumLabel.TabIndex = 13;
            TotalCostNumLabel.Text = "$ 0.00";
            // 
            // StudyPeriodNumLabel
            // 
            StudyPeriodNumLabel.AutoSize = true;
            StudyPeriodNumLabel.Location = new Point(911, 50);
            StudyPeriodNumLabel.Name = "StudyPeriodNumLabel";
            StudyPeriodNumLabel.Size = new Size(17, 20);
            StudyPeriodNumLabel.TabIndex = 5;
            StudyPeriodNumLabel.Text = "0";
            // 
            // ProgramsCombo
            // 
            ProgramsCombo.Enabled = false;
            ProgramsCombo.FormattingEnabled = true;
            ProgramsCombo.Location = new Point(485, 22);
            ProgramsCombo.Name = "ProgramsCombo";
            ProgramsCombo.Size = new Size(313, 28);
            ProgramsCombo.TabIndex = 12;
            ProgramsCombo.SelectedIndexChanged += ProgramsCombo_SelectedIndexChanged;
            // 
            // CampLocCombo
            // 
            CampLocCombo.DisplayMember = "Province";
            CampLocCombo.Enabled = false;
            CampLocCombo.FormattingEnabled = true;
            CampLocCombo.Location = new Point(135, 22);
            CampLocCombo.Name = "CampLocCombo";
            CampLocCombo.Size = new Size(231, 28);
            CampLocCombo.TabIndex = 11;
            CampLocCombo.SelectedIndexChanged += CampLocCombo_SelectedIndexChanged;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Location = new Point(997, 21);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(75, 20);
            TotalCostLabel.TabIndex = 10;
            TotalCostLabel.Text = "Total Cost";
            // 
            // StudyPeriodLabel
            // 
            StudyPeriodLabel.AutoSize = true;
            StudyPeriodLabel.Location = new Point(877, 21);
            StudyPeriodLabel.Name = "StudyPeriodLabel";
            StudyPeriodLabel.Size = new Size(92, 20);
            StudyPeriodLabel.TabIndex = 9;
            StudyPeriodLabel.Text = "Study Period";
            // 
            // ProgramsLabel
            // 
            ProgramsLabel.AutoSize = true;
            ProgramsLabel.Location = new Point(410, 24);
            ProgramsLabel.Name = "ProgramsLabel";
            ProgramsLabel.Size = new Size(72, 20);
            ProgramsLabel.TabIndex = 4;
            ProgramsLabel.Text = "Programs";
            // 
            // CampLocationLabel
            // 
            CampLocationLabel.AutoSize = true;
            CampLocationLabel.Location = new Point(6, 24);
            CampLocationLabel.Name = "CampLocationLabel";
            CampLocationLabel.Size = new Size(123, 20);
            CampLocationLabel.TabIndex = 0;
            CampLocationLabel.Text = "Campus Location";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(31, 278);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(136, 29);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "&Register Student";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // StudentView
            // 
            StudentView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            StudentView.DefaultCellStyle = dataGridViewCellStyle1;
            StudentView.Location = new Point(31, 313);
            StudentView.Name = "StudentView";
            StudentView.RightToLeft = RightToLeft.No;
            StudentView.RowHeadersWidth = 51;
            StudentView.RowTemplate.Height = 29;
            StudentView.Size = new Size(1134, 229);
            StudentView.TabIndex = 6;
            StudentView.SelectionChanged += StudentView_SelectionChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(31, 568);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(150, 29);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "&Delete Record";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(243, 568);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(150, 29);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "&Update Record";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(996, 568);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(170, 29);
            LoadButton.TabIndex = 10;
            LoadButton.Text = "&Load Records to Server";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Location = new Point(777, 568);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(170, 29);
            RemoveAllButton.TabIndex = 9;
            RemoveAllButton.Text = "Remove All Records";
            RemoveAllButton.UseVisualStyleBackColor = true;
            RemoveAllButton.Click += RemoveAllButton_Click;
            // 
            // SINLabel2
            // 
            SINLabel2.AutoSize = true;
            SINLabel2.Location = new Point(31, 623);
            SINLabel2.Name = "SINLabel2";
            SINLabel2.Size = new Size(32, 20);
            SINLabel2.TabIndex = 11;
            SINLabel2.Text = "SIN";
            // 
            // SINCombo
            // 
            SINCombo.FormattingEnabled = true;
            SINCombo.Location = new Point(83, 620);
            SINCombo.Name = "SINCombo";
            SINCombo.Size = new Size(310, 28);
            SINCombo.TabIndex = 12;
            SINCombo.SelectedIndexChanged += SINCombo_SelectedIndexChanged;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1072, 618);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 673);
            Controls.Add(ExitButton);
            Controls.Add(SINCombo);
            Controls.Add(SINLabel2);
            Controls.Add(LoadButton);
            Controls.Add(RemoveAllButton);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(StudentView);
            Controls.Add(RegisterButton);
            Controls.Add(AvailProgramsBox);
            Controls.Add(CheckButton);
            Controls.Add(StuInfoBox);
            Controls.Add(FormMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = FormMenu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DC Registration App";
            FormMenu.ResumeLayout(false);
            FormMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            StuInfoBox.ResumeLayout(false);
            StuInfoBox.PerformLayout();
            AvailProgramsBox.ResumeLayout(false);
            AvailProgramsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FormMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem recordToolStripMenuItem;
        private ToolStripMenuItem updateRecordToolStripMenuItem;
        private ToolStripMenuItem deleteRecordToolStripMenuItem;
        private ToolStripMenuItem deleteAllRecordsToolStripMenuItem;
        private ToolStripMenuItem loadRecordsToServerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private BindingSource bindingSource1;
        private ToolStripMenuItem readHelpToolStripMenuItem;
        private ToolStripMenuItem technicalSupportsToolStripMenuItem;
        private ToolStripMenuItem aboutDCRegistrationAppToolStripMenuItem;
        private GroupBox StuInfoBox;
        private TextBox LNameText;
        private Label LNameLabel;
        private TextBox FNameText;
        private Label FNameLabel;
        private Label EmailLabel;
        private Label SINLabel;
        private TextBox EmailText;
        private TextBox SINText;
        private ContextMenuStrip contextMenuStrip1;
        private Label HSchoolGradeLabel;
        private Label AdmissionTestScoreLabel;
        private ComboBox HighSchoolCombo;
        private ComboBox AdmissionTestCombo;
        private Button CheckButton;
        private GroupBox AvailProgramsBox;
        private ComboBox ProgramsCombo;
        private ComboBox CampLocCombo;
        private Label TotalCostLabel;
        private Label StudyPeriodLabel;
        private Label ProgramsLabel;
        private Label CampLocationLabel;
        private Label TotalCostNumLabel;
        private Label StudyPeriodNumLabel;
        private Button RegisterButton;
        private DataGridView StudentView;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button LoadButton;
        private Button RemoveAllButton;
        private Label SINLabel2;
        private ComboBox SINCombo;
        private Button ExitButton;
    }
}