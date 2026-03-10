/*
Hunter Clezie 
Spring 2026
RCET2265
AddressLabel
github url: https://github.com/hunterclezie-pixel/AddressLabel.git
*/

// Todo:
/*
[x] Text boxes for: First Name, Last Name, Street Address, City, State, Zip
[x] Group all text box fields in a group box
[x] Buttons: Display, Clear, Exit
[x] Properly named controls (e.g., FirstNameTextBox, DisplayButton, etc.)
[x] Display the formatted address in a label when the Display button is clicked
[x] Clear all fields with the Clear button
[x] Exit the application with the Exit button
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
            // Clear all text boxes and the display label
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
            // Close the application
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and the display label
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
            // Format the address and display it in the AddressDisplayLabel
            AddressDisplayLabel.Text = FirstNameTextBox.Text + " " 
                + LastNameTextBox.Text +
                "\n" + AddressTextBox.Text + 
                "\n" + CityTextBox.Text + ", " 
                + StateTextBox.Text + ", " 
                + ZipCodeTextBox.Text;
        }
    }
}
