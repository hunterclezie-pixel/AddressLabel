/*
Hunter Clezie 
Spring 2026
RCET2265
AddressLabel
github url: https://github.com/hunterclezie-pixel/AddressLabel.git
*/

// Todo:
/*
[] Text boxes for: First Name, Last Name, Street Address, City, State, Zip
[] Group all text box fields in a group box
[] Buttons: Display, Clear, Exit
[] Properly named controls (e.g., FirstNameTextBox, DisplayButton, etc.)
[] Display the formatted address in a label when the Display button is clicked
[] Clear all fields with the Clear button
[] Exit the application with the Exit button
*/
namespace AddressLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetDefaults()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
            AddressDisplayLabel.Text = "";
        }

        // Event handler for the Display button click event
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void AdressLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdressLabelGroup_Enter(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            AddressDisplayLabel.Text = FirstNameTextBox.Text + 
                "\n" + LastNameTextBox.Text +
                "\n" + AddressTextBox.Text + 
                "\n" + CityTextBox.Text + ", " + StateTextBox.Text + ", " + ZipCodeTextBox.Text;
        }
    }
}
