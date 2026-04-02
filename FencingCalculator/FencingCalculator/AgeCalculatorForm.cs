using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FencingCalculator
{
    public partial class AgeCalculatorForm : Form
    {
        public AgeCalculatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dtpDOB.Value;
            DateTime today = DateTime.Today;

            int years = today.Year - birthDate.Year;
            int months = today.Month - birthDate.Month;
            int days = today.Day - birthDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(today.Year, today.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            DateTime nextBirthday = birthDate.AddYears(years + 1);

            int daysLeft = (nextBirthday - today).Days;

            lblAgeResult.Text =
                "Your Age: " + years + " Years, " +
                months + " Months, " +
                days + " Days\n" +
                "Next Birthday in: " + daysLeft + " Days 🎂";
        }
    }
}
