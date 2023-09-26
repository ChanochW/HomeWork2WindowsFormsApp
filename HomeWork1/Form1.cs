namespace HomeWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void handleClick(object sender, EventArgs e)
        {
            if (naturalBorn.Checked &&
                ageInput.Value >= 35 &&
                lengthOfResidencyInput.Value >= 14 &&
                prevTermsInput.Value < 2 &&
                !treasonous.Checked)
            {
                result.Text = "Yay! You are elilgible!";
                result.Visible = true;
            } else {
                result.Text = "You are ineligible.";
                result.Visible = true;
            }
        }
    }
}