using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC00323_thanhtm_Assignment2
{
    public partial class Bill : Form
    {
        string CustomerName;
        double lastMonthWater;
        double thisMonthWater;
        double Consumpition;
        double Watermoney;
        public Bill(string customerName, double lastMonthWater, double thisMonthWater,
            double Consumption, double Watermoney)
        {
            InitializeComponent();
            this.CustomerName = customerName;
            this.lastMonthWater = lastMonthWater;
            this.thisMonthWater = thisMonthWater;
            this.Consumpition = Consumption;
            this.Watermoney = Watermoney;

            lbNameOfCustomer.Text = customerName;
            lbWatermoney.Text = Watermoney.ToString();
            lbLastMonthWater.Text = lastMonthWater.ToString();
            lbThisMonthwater.Text = thisMonthWater.ToString();
            lbConsumption.Text = Consumption.ToString();
        }
    }
}
