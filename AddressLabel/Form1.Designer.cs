namespace AddressLabel
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
            MailInfoGroupBox = new GroupBox();
            FirstNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            textBox1 = new TextBox();
            AdressLabel = new Label();
            textBox2 = new TextBox();
            CityLabel = new Label();
            textBox3 = new TextBox();
            StateLabel = new Label();
            textBox4 = new TextBox();
            ZipCodeLabel = new Label();
            textBox5 = new TextBox();
            DisplayButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            AdressLabelGroup = new GroupBox();
            AddressLabel = new Label();
            MailInfoGroupBox.SuspendLayout();
            AdressLabelGroup.SuspendLayout();
            SuspendLayout();
            // 
            // MailInfoGroupBox
            // 
            MailInfoGroupBox.Controls.Add(ZipCodeLabel);
            MailInfoGroupBox.Controls.Add(FirstNameTextBox);
            MailInfoGroupBox.Controls.Add(textBox5);
            MailInfoGroupBox.Controls.Add(FirstNameLabel);
            MailInfoGroupBox.Controls.Add(StateLabel);
            MailInfoGroupBox.Controls.Add(textBox1);
            MailInfoGroupBox.Controls.Add(LastNameLabel);
            MailInfoGroupBox.Controls.Add(textBox4);
            MailInfoGroupBox.Controls.Add(CityLabel);
            MailInfoGroupBox.Controls.Add(textBox2);
            MailInfoGroupBox.Controls.Add(textBox3);
            MailInfoGroupBox.Controls.Add(AdressLabel);
            MailInfoGroupBox.Location = new Point(25, 24);
            MailInfoGroupBox.Name = "MailInfoGroupBox";
            MailInfoGroupBox.Size = new Size(258, 387);
            MailInfoGroupBox.TabIndex = 0;
            MailInfoGroupBox.TabStop = false;
            MailInfoGroupBox.Text = "Mail Information";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(6, 61);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(194, 27);
            FirstNameTextBox.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(24, 38);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(26, 96);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 3;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(41, 149);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(53, 20);
            AdressLabel.TabIndex = 6;
            AdressLabel.Text = "Adress";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 5;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(47, 202);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 27);
            textBox3.TabIndex = 7;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(43, 256);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(43, 20);
            StateLabel.TabIndex = 10;
            StateLabel.Text = "State";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 27);
            textBox4.TabIndex = 9;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(33, 312);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(70, 20);
            ZipCodeLabel.TabIndex = 12;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 335);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(339, 358);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(106, 52);
            DisplayButton.TabIndex = 1;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(482, 358);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(106, 52);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(625, 359);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(106, 52);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // AdressLabelGroup
            // 
            AdressLabelGroup.Controls.Add(AddressLabel);
            AdressLabelGroup.Location = new Point(339, 24);
            AdressLabelGroup.Name = "AdressLabelGroup";
            AdressLabelGroup.Size = new Size(392, 328);
            AdressLabelGroup.TabIndex = 4;
            AdressLabelGroup.TabStop = false;
            AdressLabelGroup.Text = "Address Label";
            // 
            // AddressLabel
            // 
            AddressLabel.Location = new Point(6, 23);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(380, 302);
            AddressLabel.TabIndex = 0;
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
        private TextBox textBox1;
        private Label LastNameLabel;
        private Label AdressLabel;
        private TextBox textBox2;
        private Label CityLabel;
        private TextBox textBox3;
        private Label StateLabel;
        private TextBox textBox4;
        private Label ZipCodeLabel;
        private TextBox textBox5;
        private Button DisplayButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox AdressLabelGroup;
        private Label AddressLabel;
    }
}
