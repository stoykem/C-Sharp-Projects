namespace Assignment3_MiguelStoyke
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
            CustomerInfo = new Label();
            FirstName = new Label();
            LastName = new Label();
            Phone = new Label();
            CarInfo = new Label();
            Make = new Label();
            Model = new Label();
            Year = new Label();
            Colour = new Label();
            Services = new Label();
            Cost = new Label();
            FNameText = new TextBox();
            LNameText = new TextBox();
            PhoneText = new TextBox();
            ModelText = new TextBox();
            ColourText = new TextBox();
            MakeDrop = new ComboBox();
            YearDrop = new ComboBox();
            CostText = new TextBox();
            CarServiceSummary = new Label();
            AddButton = new Button();
            NewButton = new Button();
            UpdateButton = new Button();
            RemoveButton = new Button();
            RemoveAllButton = new Button();
            ExitButton = new Button();
            Summary = new ListView();
            EOilChange = new CheckBox();
            TOilChange = new CheckBox();
            AFilterChange = new CheckBox();
            first_name = new ToolTip(components);
            last_name = new ToolTip(components);
            phone_ = new ToolTip(components);
            make_ = new ToolTip(components);
            model_ = new ToolTip(components);
            year_ = new ToolTip(components);
            colour_ = new ToolTip(components);
            t_oil_change = new ToolTip(components);
            a_filter_change = new ToolTip(components);
            oil_change = new ToolTip(components);
            cost_ = new ToolTip(components);
            new_ = new ToolTip(components);
            update_ = new ToolTip(components);
            remove_ = new ToolTip(components);
            remove_all = new ToolTip(components);
            exit_ = new ToolTip(components);
            add_ = new ToolTip(components);
            list_view = new ToolTip(components);
            SuspendLayout();
            // 
            // CustomerInfo
            // 
            CustomerInfo.AutoSize = true;
            CustomerInfo.Location = new Point(51, 20);
            CustomerInfo.Name = "CustomerInfo";
            CustomerInfo.Size = new Size(157, 20);
            CustomerInfo.TabIndex = 0;
            CustomerInfo.Text = "Customer Information:";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(54, 50);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(83, 20);
            FirstName.TabIndex = 1;
            FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(54, 95);
            LastName.Name = "LastName";
            LastName.Size = new Size(82, 20);
            LastName.TabIndex = 2;
            LastName.Text = "Last Name:";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(54, 142);
            Phone.Name = "Phone";
            Phone.Size = new Size(53, 20);
            Phone.TabIndex = 3;
            Phone.Text = "Phone:";
            // 
            // CarInfo
            // 
            CarInfo.AutoSize = true;
            CarInfo.Location = new Point(51, 199);
            CarInfo.Name = "CarInfo";
            CarInfo.Size = new Size(116, 20);
            CarInfo.TabIndex = 4;
            CarInfo.Text = "Car Information:";
            // 
            // Make
            // 
            Make.AutoSize = true;
            Make.Location = new Point(54, 230);
            Make.Name = "Make";
            Make.Size = new Size(48, 20);
            Make.TabIndex = 5;
            Make.Text = "Make:";
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Location = new Point(54, 279);
            Model.Name = "Model";
            Model.Size = new Size(55, 20);
            Model.TabIndex = 6;
            Model.Text = "Model:";
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(54, 326);
            Year.Name = "Year";
            Year.Size = new Size(40, 20);
            Year.TabIndex = 7;
            Year.Text = "Year:";
            // 
            // Colour
            // 
            Colour.AutoSize = true;
            Colour.Location = new Point(54, 374);
            Colour.Name = "Colour";
            Colour.Size = new Size(56, 20);
            Colour.TabIndex = 8;
            Colour.Text = "Colour:";
            // 
            // Services
            // 
            Services.AutoSize = true;
            Services.Location = new Point(54, 431);
            Services.Name = "Services";
            Services.Size = new Size(65, 20);
            Services.TabIndex = 9;
            Services.Text = "Services:";
            // 
            // Cost
            // 
            Cost.AutoSize = true;
            Cost.Location = new Point(54, 551);
            Cost.Name = "Cost";
            Cost.Size = new Size(41, 20);
            Cost.TabIndex = 10;
            Cost.Text = "Cost:";
            // 
            // FNameText
            // 
            FNameText.Location = new Point(160, 43);
            FNameText.Name = "FNameText";
            FNameText.Size = new Size(191, 27);
            FNameText.TabIndex = 11;
            first_name.SetToolTip(FNameText, "Enter customer's first name");
            // 
            // LNameText
            // 
            LNameText.Location = new Point(160, 88);
            LNameText.Name = "LNameText";
            LNameText.Size = new Size(191, 27);
            LNameText.TabIndex = 12;
            last_name.SetToolTip(LNameText, "Enter customer's last name");
            // 
            // PhoneText
            // 
            PhoneText.Location = new Point(160, 135);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(191, 27);
            PhoneText.TabIndex = 13;
            phone_.SetToolTip(PhoneText, "Enter customer's phone number (10 digits)");
            // 
            // ModelText
            // 
            ModelText.Location = new Point(160, 272);
            ModelText.Name = "ModelText";
            ModelText.Size = new Size(191, 27);
            ModelText.TabIndex = 14;
            model_.SetToolTip(ModelText, "Enter the car's model name");
            // 
            // ColourText
            // 
            ColourText.Location = new Point(160, 367);
            ColourText.Name = "ColourText";
            ColourText.Size = new Size(191, 27);
            ColourText.TabIndex = 15;
            colour_.SetToolTip(ColourText, "Enter the car's colour");
            // 
            // MakeDrop
            // 
            MakeDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            MakeDrop.FormattingEnabled = true;
            MakeDrop.Items.AddRange(new object[] { "Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Fiat", "Ford", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Pagani", "Polestar", "Porsche", "Ram", "Rivian", "Rolls-Royce", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            MakeDrop.Location = new Point(160, 222);
            MakeDrop.Name = "MakeDrop";
            MakeDrop.Size = new Size(191, 28);
            MakeDrop.TabIndex = 16;
            make_.SetToolTip(MakeDrop, "Select the car's manufacturer");
            // 
            // YearDrop
            // 
            YearDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            YearDrop.FormattingEnabled = true;
            YearDrop.Items.AddRange(new object[] { "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            YearDrop.Location = new Point(160, 318);
            YearDrop.Name = "YearDrop";
            YearDrop.Size = new Size(191, 28);
            YearDrop.TabIndex = 17;
            year_.SetToolTip(YearDrop, "Select the car's year of manufacture");
            // 
            // CostText
            // 
            CostText.Location = new Point(160, 544);
            CostText.Name = "CostText";
            CostText.ReadOnly = true;
            CostText.Size = new Size(392, 27);
            CostText.TabIndex = 21;
            cost_.SetToolTip(CostText, "System messages, and total service cost will display here");
            // 
            // CarServiceSummary
            // 
            CarServiceSummary.AutoSize = true;
            CarServiceSummary.Location = new Point(401, 20);
            CarServiceSummary.Name = "CarServiceSummary";
            CarServiceSummary.Size = new Size(151, 20);
            CarServiceSummary.TabIndex = 22;
            CarServiceSummary.Text = "Car Service Summary:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(51, 612);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 23;
            AddButton.Text = "&Add";
            add_.SetToolTip(AddButton, "Press here, Alt+A, or Enter to add a new car service");
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(175, 612);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(94, 29);
            NewButton.TabIndex = 24;
            NewButton.Text = "&New";
            new_.SetToolTip(NewButton, "Press here, Alt+N, or Escape to create a new service");
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(303, 612);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 25;
            UpdateButton.Text = "Update";
            update_.SetToolTip(UpdateButton, "Select a service record, modify values, and then click here to update a current service");
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(430, 612);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(94, 29);
            RemoveButton.TabIndex = 26;
            RemoveButton.Text = "Remove";
            remove_.SetToolTip(RemoveButton, "Select a service record, then click here to remove the service");
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Location = new Point(562, 612);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(94, 29);
            RemoveAllButton.TabIndex = 27;
            RemoveAllButton.Text = "Remove All";
            remove_all.SetToolTip(RemoveAllButton, "Click here to remove all service records");
            RemoveAllButton.UseVisualStyleBackColor = true;
            RemoveAllButton.Click += RemoveAllButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(690, 612);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "&Exit";
            exit_.SetToolTip(ExitButton, "Press here, Alt+E, or the red X to exit the application");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Summary
            // 
            Summary.FullRowSelect = true;
            Summary.GridLines = true;
            Summary.Location = new Point(401, 43);
            Summary.Name = "Summary";
            Summary.Size = new Size(1097, 351);
            Summary.TabIndex = 30;
            Summary.UseCompatibleStateImageBehavior = false;
            Summary.SelectedIndexChanged += Summary_SelectedIndexChanged;
            // 
            // EOilChange
            // 
            EOilChange.AutoSize = true;
            EOilChange.Location = new Point(160, 430);
            EOilChange.Name = "EOilChange";
            EOilChange.Size = new Size(153, 24);
            EOilChange.TabIndex = 31;
            EOilChange.Text = "Engine Oil Change";
            oil_change.SetToolTip(EOilChange, "Select if customer wants an oil change");
            EOilChange.UseVisualStyleBackColor = true;
            // 
            // TOilChange
            // 
            TOilChange.AutoSize = true;
            TOilChange.Location = new Point(160, 460);
            TOilChange.Name = "TOilChange";
            TOilChange.Size = new Size(192, 24);
            TOilChange.TabIndex = 32;
            TOilChange.Text = "Transmission Oil Change";
            t_oil_change.SetToolTip(TOilChange, "Select if customer wants a transmission oil change");
            TOilChange.UseVisualStyleBackColor = true;
            // 
            // AFilterChange
            // 
            AFilterChange.AutoSize = true;
            AFilterChange.Location = new Point(160, 490);
            AFilterChange.Name = "AFilterChange";
            AFilterChange.Size = new Size(141, 24);
            AFilterChange.TabIndex = 33;
            AFilterChange.Text = "Air Filter Change";
            a_filter_change.SetToolTip(AFilterChange, "Select if customer wants an air filter change");
            AFilterChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 663);
            Controls.Add(AFilterChange);
            Controls.Add(TOilChange);
            Controls.Add(EOilChange);
            Controls.Add(Summary);
            Controls.Add(ExitButton);
            Controls.Add(RemoveAllButton);
            Controls.Add(RemoveButton);
            Controls.Add(UpdateButton);
            Controls.Add(NewButton);
            Controls.Add(AddButton);
            Controls.Add(CarServiceSummary);
            Controls.Add(CostText);
            Controls.Add(YearDrop);
            Controls.Add(MakeDrop);
            Controls.Add(ColourText);
            Controls.Add(ModelText);
            Controls.Add(PhoneText);
            Controls.Add(LNameText);
            Controls.Add(FNameText);
            Controls.Add(Cost);
            Controls.Add(Services);
            Controls.Add(Colour);
            Controls.Add(Year);
            Controls.Add(Model);
            Controls.Add(Make);
            Controls.Add(CarInfo);
            Controls.Add(Phone);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(CustomerInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Service Shop";
            list_view.SetToolTip(this, "Created car service records will be displayed here");
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CustomerInfo;
        private Label FirstName;
        private Label LastName;
        private Label Phone;
        private Label CarInfo;
        private Label Make;
        private Label Model;
        private Label Year;
        private Label Colour;
        private Label Services;
        private Label Cost;
        private TextBox FNameText;
        private TextBox LNameText;
        private TextBox PhoneText;
        private TextBox ModelText;
        private TextBox ColourText;
        private ComboBox MakeDrop;
        private ComboBox YearDrop;
        private TextBox CostText;
        private Label CarServiceSummary;
        private Button AddButton;
        private Button NewButton;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button RemoveAllButton;
        private Button ExitButton;
        private ListView Summary;
        private CheckBox EOilChange;
        private CheckBox TOilChange;
        private CheckBox AFilterChange;
        private ToolTip first_name;
        private ToolTip last_name;
        private ToolTip phone_;
        private ToolTip make_;
        private ToolTip model_;
        private ToolTip year_;
        private ToolTip colour_;
        private ToolTip t_oil_change;
        private ToolTip a_filter_change;
        private ToolTip oil_change;
        private ToolTip cost_;
        private ToolTip new_;
        private ToolTip update_;
        private ToolTip remove_;
        private ToolTip remove_all;
        private ToolTip exit_;
        private ToolTip add_;
        private ToolTip list_view;
    }
}