using System;

namespace WebFormsProject
{
    public partial class FizzBuzz1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FizzBuzzButton_OnClick(object sender, EventArgs e)
        {
            string numAsString = numTextBox.Text;
            FizzBuzzAlgorithm fizzbuzz = new FizzBuzzAlgorithm(numAsString);
            string fizzbuzzString = fizzbuzz.GetFizzBuzz();

            FizzBuzzLabel.Text = fizzbuzzString;
            CleanUp();
        }

        private void CleanUp()
        {
            numTextBox.Text = "";
        }
    }
}