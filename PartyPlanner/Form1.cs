using System;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class partyForm : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public partyForm()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)peopleNum.Value, decorationChk.Checked, healthyChk.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            costBirthday.Text = birthdayParty.Cost.ToString("c");
        }

        private void DisplayDinnerPartyCost()
        {
            costBox.Text = dinnerParty.Cost.ToString("c");
        }

        private void peopleNum_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)peopleNum.Value;
            DisplayDinnerPartyCost();
        }

        private void decorationChk_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = decorationChk.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyChk_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyChk.Checked;
            DisplayDinnerPartyCost();
        }

        private void numBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
