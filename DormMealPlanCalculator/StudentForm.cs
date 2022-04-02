using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormMealPlanCalculator
{
    public partial class StudentForm : Form
    {
        TotalForm total = new TotalForm();
        double dormCost = 0;
        double mealPlanCost = 0;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dormSelected();
                mealPlanSelected();
                calculateTotal();
                total.ShowDialog();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please select a Dorm & Meal Plan to continue.");
            } 
        }

        private void dormSelected()
        {
            if (allenHallRadioButton.Checked)
            { 
                total.selectedDromLabel.Text = allenHallRadioButton.Text;
                dormCost = 1500;
            }
            else if (pikeHallRadioButton.Checked)
            {
                total.selectedDromLabel.Text = pikeHallRadioButton.Text;
                dormCost = 1600;
            }
            else if (farthingHallRadioButton.Checked)
            {
                total.selectedDromLabel.Text = farthingHallRadioButton.Text;
                dormCost = 1800;
            }
            else if (universitySuitesRadioButton.Checked)
            {
                total.selectedDromLabel.Text = universitySuitesRadioButton.Text;
                dormCost = 2500;
            }

            if (dormCost == 0)
            {
                throw new ArgumentException();
            }

        }

        private void mealPlanSelected()
        {
            if (sevenMealRadioButton.Checked)
            {
                total.selectedMealPlanLabel.Text = sevenMealRadioButton.Text;
                mealPlanCost = 600;
            }
            else if (fourteenMealsRadioButton.Checked)
            {
                total.selectedMealPlanLabel.Text = fourteenMealsRadioButton.Text;
                mealPlanCost = 1200;
            }
            else if (unlimitedRadioButton.Checked)
            {
                total.selectedMealPlanLabel.Text = unlimitedRadioButton.Text;
                mealPlanCost = 1700;
            }

            if (mealPlanCost == 0)
            {
                throw new ArgumentException();
            }
        }

        private void calculateTotal()
        {
            var totalCost = dormCost + mealPlanCost;
            var output = "Total Cost Per Semester: $" + totalCost;
            total.totalLabel.Text = output;
        }
    }
}
