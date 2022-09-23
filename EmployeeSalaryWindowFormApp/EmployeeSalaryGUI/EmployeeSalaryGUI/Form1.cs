using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button event handler
        /// 
        ///     1. Parse Rate & hours
        ///     2. Calculate overtime
        ///     3. Calculate Regular Pay
        ///     4. Total 
        ///     5. Display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hourlyRate = 0;          // hourly rate
            int hours = 0;                  // hours worked
            double overtimePay = 0;         // overtime pay
            double regularPay = 0;          // regular pay
            double totalPay = 0;            // total pay
            int tempHours = 0;              // temp hours storage

            // Parse values
            if(int.TryParse(txtHours.Text, out hours))
            {
                // Parse hourly rate
                if (double.TryParse(txtRate.Text, out hourlyRate))
                {
                    tempHours = hours;

                    // Overtime Salary
                    if (tempHours > 40)
                    {
                        overtimePay = (1.5 * hourlyRate) * (tempHours - 40);
                        tempHours = 40; 
                    }

                    // regular pay
                    regularPay = tempHours * hourlyRate;

                    // total pay
                    totalPay = overtimePay + regularPay;

                    // now display
                    lblHoursWorked.Text = hours.ToString();
                    lblHourlyRate.Text = hourlyRate.ToString("C02");
                    lblRegularPay.Text = regularPay.ToString("C02");
                    lblOvertimePay.Text = overtimePay.ToString("C02");
                    lblTotalPay.Text = totalPay.ToString("C02");

                    // clear inputs
                    txtHours.Text = "";
                    txtRate.Text = "";

                    txtHours.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid hourly rate entered");
                }
            }
            else
            {
                MessageBox.Show("Invalid hours entered");
            }
        }
    }
}
