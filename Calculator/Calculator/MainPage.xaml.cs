using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblResult.IsVisible = false;
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            try
            {
                int fistNum = Convert.ToInt32(edtFirstNumber.Text);
                int secondNum = Convert.ToInt32(edtSecondNumber.Text);

                int result = fistNum + secondNum;

                lblResult.IsVisible = true;
                lblResult.Text = $"{fistNum} + {secondNum} = {result}";
                lblResult.TextColor = Color.Green;
            }
            catch (Exception exception)
            {
                lblResult.IsVisible = true;
                lblResult.TextColor = Color.Red;
                lblResult.Text = $"Invalid numbers! {exception.ToString()}";
            }
        }

        private void btnSubtract_Clicked(object sender, EventArgs e)
        {
            try
            {
                int fistNum = Convert.ToInt32(edtFirstNumber.Text);
                int secondNum = Convert.ToInt32(edtSecondNumber.Text);

                int result = fistNum - secondNum;
                lblResult.IsVisible = true;
                lblResult.Text = $"{fistNum} - {secondNum} = {result}";
                lblResult.TextColor = Color.Green;
            }
            catch (Exception exception)
            {
                lblResult.IsVisible = true;
                lblResult.TextColor = Color.Red;
                lblResult.Text = $"Invalid numbers! {exception.ToString()}";
            }
        }

        private void btnMultiply_Clicked(object sender, EventArgs e)
        {
            try
            {
                int fistNum = Convert.ToInt32(edtFirstNumber.Text);
                int secondNum = Convert.ToInt32(edtSecondNumber.Text);

                int result = fistNum * secondNum;

                lblResult.IsVisible = true;
                lblResult.Text = $"{fistNum} * {secondNum} = {result}";
                lblResult.TextColor = Color.Green;
            }
            catch (Exception exception)
            {
                lblResult.IsVisible = true;
                lblResult.TextColor = Color.Red;
                lblResult.Text = $"Invalid numbers! {exception.ToString()}";
            }
        }

        private void btnDivide_Clicked(object sender, EventArgs e)
        {
            try
            {
                int fistNum = Convert.ToInt32(edtFirstNumber.Text);
                int secondNum = Convert.ToInt32(edtSecondNumber.Text);

                int result = fistNum / secondNum;

                lblResult.IsVisible = true;
                lblResult.Text = $"{fistNum} / {secondNum} = {result}";
                lblResult.TextColor = Color.Green;
            }
            catch (Exception exception)
            {
                lblResult.IsVisible = true;
                lblResult.TextColor = Color.Red;
                lblResult.Text = $"Invalid numbers! {exception.ToString()}";
            }
        }
    }
}
