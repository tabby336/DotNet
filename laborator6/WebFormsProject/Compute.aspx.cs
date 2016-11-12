using System;

namespace WebFormsProject
{
    public partial class Compute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ComputeButton_OnClick(object sender, EventArgs e)
        {
            string numOne = textNum1.Text;
            string numTwo = textNum2.Text;
            string numThree = textNum3.Text;

            ComputeAlgorithm computeSum = new ComputeAlgorithm(numOne, numTwo, numThree);

            resultLabel.Text = computeSum.ComputeSum().ToString();

            CleanUp();
        }

        private void CleanUp()
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textNum3.Text = "";
        }
    }
}