using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountUppercase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        //Calculates number of uppercase letter
        protected void calculateUpperCaseButton_Click(object sender, EventArgs e)
        {
            int numberOfUpperCase = 0;
            
            if (IsValid)
            {
                UserInputTextBox.Enabled = false;
                ClearTextBoxButton.Visible = true;
                CalculateUpperCaseButton.Visible = false;
                
            foreach (char var in UserInputTextBox.Text) {

                if(Char.IsUpper(var)){
                    numberOfUpperCase++;
                }
           }
           UpperCaseMessageLiteral.Text = numberOfUpperCase.ToString();
           UpperCaseMessage.Visible = true;
           }    
       }
        
        //Clears textbox
        protected void clearTextBoxButton_Click(object sender, EventArgs e)
        {
            UserInputTextBox.Text = String.Empty;
            UserInputTextBox.Enabled = true;
            ClearTextBoxButton.Visible = false;
            CalculateUpperCaseButton.Visible = true; 

        }
    }
}