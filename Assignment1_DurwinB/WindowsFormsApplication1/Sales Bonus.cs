/**
 * App name: Sales Bonus 
 * Programmer : Durwin Barcenas
 * Date : Sept 22, 2013
 * Description: This program will calculate the Sales Bonus 
 *              based on the employee's Working hours and Total Sales.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        // This method changes the labels from french to english when radio button is clicked 
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    
                    LangGbox.Text = "Language";
                    EmpNameLbl.Text = "Employee Name:";
                    EmpIdLbl.Text = "Employee ID:";
                    HrsWorkedLbl.Text = "Hours Worked:";
                    TotalSalesLbl.Text = "Total Sales:";
                    SalesBonusLbl.Text = "Sales Bonus:";
                    PrintBttn.Text = "Print";
                    NextBttn.Text = "Next";
                    CalcBttn.Text = "Calculate";
            }// end if
        }// end of method EnglsihRadioButton

        // This method changes the labels from english to french when button is clicked
        private void FrenchRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
           
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    LangGbox.Text = "Langue";
                    EmpNameLbl.Text = "Nom de l'employé:";
                    EmpIdLbl.Text = "Identifiant de l'employé:";
                    HrsWorkedLbl.Text = "Heures travaillées:";
                    TotalSalesLbl.Text = "Ventes totales:";
                    SalesBonusLbl.Text = "Bonus des ventes:";
                    PrintBttn.Text = "Imprimer";
                    NextBttn.Text = "Prochaine";
                    CalcBttn.Text = "Calculer";
            }// end if 
        }//end of method FrenchRadioBttn

        // This method will calculate the Sales Bonus with these steps : 
        //  Divide the Total Hours worked by 160, which will determine the percentage of hours worked.
        //  Multiply the Total Montlhly Sales by 0.02, which is the Total Bonus Amount.
        // Then Multiply the Percentage of Hours worked by Total Bonus Amount, which will result as the Sales Bonus. 
        private void CalcBttn_Click(object sender, EventArgs e)
        {
            // Converting the text inputed in the textbox to double 
            decimal inHoursWorked = Convert.ToDecimal(HrsWorkedTxtBox.Text);
            decimal inTotalSales = Convert.ToDecimal(TotalSalesTxtBox.Text);

            // formula for calculating the sales bonus
            decimal percHours = inHoursWorked / 160;
            decimal totalBonus = inTotalSales * 0.02m;
            decimal salesBonus = percHours * totalBonus;

            // validation for hours worked 
            if (inHoursWorked <= 160)
            {
                //Displays the answer to the Sales Bonus Textbox with two decimal places
                SalesBonusTxtBox.Text = "$" + Math.Round(salesBonus, 2);
            }
            else
            {
                MessageBox.Show(inHoursWorked + " hours worked is invalid, must be within 0 to 160 hours.");
            } 

            
        }

        // this method validates for numeric textbox only 
        // Disabling the other keys except numbers
        private void HrsWorkedTxtBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }// end if
        }

        // this method validates for numeric textbox only 
        // Disabling the other keys except numbers
        // and decimal point, that only alows 1 decimal point
        private void TotalSalesTxtBox_TextChanged(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
                 && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }// end if

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }// end if
        }// end of method TotalSalesTxtBox


        // this method calls another method ClearTextBoxes
        private void NextBttn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls); 
        }

        // this method is for clearing all text in textboxes whenever 
        //NextBttn_Click is being clicked 
        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox textBox = ctrl as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }// end if
                else {
                    ClearTextBoxes(ctrl.Controls); 
                }// end else
            }// end foreach
        }

        private void PrintBttn_Click(object sender, EventArgs e)
        {
            // Print the form on the printer 
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print(); 
        }// end of method ClearTextBoxes
    }
}
