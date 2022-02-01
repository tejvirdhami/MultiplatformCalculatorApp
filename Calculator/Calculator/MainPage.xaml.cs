using System;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double firstValue = Convert.ToDouble(edtFirstNumber.Text);
                Double secondValue = Convert.ToDouble(edtSecondNumber.Text);

                Double result = firstValue + secondValue;

                Button btn = (Button)sender;

                switch (btn.Text)
                {
                    case "-":
                        result = firstValue - secondValue;
                        break;

                    case "*":
                        result = firstValue * secondValue;
                        break;

                    case "/":
                        result = firstValue / secondValue;
                        break;

                    default:
                        break;
                }
                lblResult.Text = $"Result is\n{result}";
                lblResult.TextColor = Color.Green;
            }
            catch (Exception exception)
            {
                lblResult.Text = exception.ToString();
                lblResult.TextColor = Color.Red;
            }
        }

        private void btnCalculateUsingObj_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double firstValue = Convert.ToDouble(edtFirstNumber.Text);
                Double secondValue = Convert.ToDouble(edtSecondNumber.Text);

                Double result = firstValue + secondValue;

                var btn = (Button)sender;

                if (btn == btnSubtract)
                {
                    result = firstValue - secondValue;
                }
                else if (btn == btnMultiply)
                {
                    result = firstValue * secondValue;
                }
                else if (btn == btnDivide)
                {
                    result = firstValue / secondValue;
                }
                else
                {
                    result = firstValue + secondValue;
                }

                lblResult.Text = $"Result is\n{result}";
                lblResult.TextColor = Color.Green;
            }
            catch (Exception exception)
            {
                lblResult.Text = exception.ToString();
                lblResult.TextColor = Color.Red;
            }
        }

        private void edtNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblResult.Text = "Result goes here";
            lblResult.TextColor = Color.Gray;
        }
    }
}