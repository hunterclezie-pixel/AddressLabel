namespace AddressLabel
{
    partial class AddressLabel
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
            MailInfoGroupBox = new GroupBox();
            ZipCodeLabel = new Label();
            FirstNameTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            FirstNameLabel = new Label();
            StateLabel = new Label();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            StateTextBox = new TextBox();
            CityLabel = new Label();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            AddressLabel = new Label();
            DisplayButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            AdressLabelGroup = new GroupBox();
            AddressDisplayLabel = new Label();
            MailInfoGroupBox.SuspendLayout();
            AdressLabelGroup.SuspendLayout();
            SuspendLayout();
            // 
            // MailInfoGroupBox
            // 
            MailInfoGroupBox.Controls.Add(ZipCodeLabel);
            MailInfoGroupBox.Controls.Add(FirstNameTextBox);
            MailInfoGroupBox.Controls.Add(ZipCodeTextBox);
            MailInfoGroupBox.Controls.Add(FirstNameLabel);
            MailInfoGroupBox.Controls.Add(StateLabel);
            MailInfoGroupBox.Controls.Add(LastNameTextBox);
            MailInfoGroupBox.Controls.Add(LastNameLabel);
            MailInfoGroupBox.Controls.Add(StateTextBox);
            MailInfoGroupBox.Controls.Add(CityLabel);
            MailInfoGroupBox.Controls.Add(AddressTextBox);
            MailInfoGroupBox.Controls.Add(CityTextBox);
            MailInfoGroupBox.Controls.Add(AddressLabel);
            MailInfoGroupBox.Location = new Point(12, 24);
            MailInfoGroupBox.Name = "MailInfoGroupBox";
            MailInfoGroupBox.Size = new Size(365, 367);
            MailInfoGroupBox.TabIndex = 0;
            MailInfoGroupBox.TabStop = false;
            MailInfoGroupBox.Text = "Mail Information";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(6, 288);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(70, 20);
            ZipCodeLabel.TabIndex = 12;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(6, 46);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(194, 27);
            FirstNameTextBox.TabIndex = 1;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(6, 311);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(125, 27);
            ZipCodeTextBox.TabIndex = 6;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(6, 23);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(6, 235);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(43, 20);
            StateLabel.TabIndex = 10;
            StateLabel.Text = "State";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(6, 99);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(194, 27);
            LastNameTextBox.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(7, 76);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(6, 258);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(194, 27);
            StateTextBox.TabIndex = 5;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(7, 182);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(6, 152);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(194, 27);
            AddressTextBox.TabIndex = 3;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(6, 205);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(194, 27);
            CityTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(6, 129);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(62, 20);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Address";
            AddressLabel.Click += AdressLabel_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(402, 358);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(106, 52);
            DisplayButton.TabIndex = 7;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(537, 358);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(106, 52);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 358);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(106, 52);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AdressLabelGroup
            // 
            AdressLabelGroup.Controls.Add(AddressDisplayLabel);
            AdressLabelGroup.Location = new Point(396, 24);
            AdressLabelGroup.Name = "AdressLabelGroup";
            AdressLabelGroup.Size = new Size(392, 328);
            AdressLabelGroup.TabIndex = 4;
            AdressLabelGroup.TabStop = false;
            AdressLabelGroup.Text = "Address Display Label";
            AdressLabelGroup.Enter += AdressLabelGroup_Enter;
            // 
            // AddressDisplayLabel
            // 
            AddressDisplayLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressDisplayLabel.Location = new Point(6, 23);
            AddressDisplayLabel.Name = "AddressDisplayLabel";
            AddressDisplayLabel.Size = new Size(380, 302);
            AddressDisplayLabel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdressLabelGroup);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayButton);
            Controls.Add(MailInfoGroupBox);
            Name = "Form1";
            Text = "Form1";
            MailInfoGroupBox.ResumeLayout(false);
            MailInfoGroupBox.PerformLayout();
            AdressLabelGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MailInfoGroupBox;
        private TextBox FirstNameTextBox;
        private Label FirstNameLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private Label AddressLabel;
        private TextBox AddressTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label StateLabel;
        private TextBox StateTextBox;
        private Label ZipCodeLabel;
        private TextBox ZipCodeTextBox;
        private Button DisplayButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox AdressLabelGroup;
        private Label AddressDisplayLabel;
    }
}
