using static BC00323_thanhtm_Assignment2.Form1;

namespace BC00323_thanhtm_Assignment2
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>();
        private const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();

        }
        private void bntCaculation_Click(object sender, EventArgs e)
        {
            // initialize variables.
            string customerName = txtCustomerName.Text.Trim();
            string typeOfCustomer = cboTypeOfCustomer.Text;
            int numberOfPerson = 0;
            double lastMonthWater = 0;
            double thismonthwater = 0;

            //Find common user errors when starting to enter information such as spaces,
            //omitting the number of family members if the customer selects the household type,
            //entering invalid water bill values ​​for last month and this month, etc.

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter your customer name", "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(typeOfCustomer))
            {
                MessageBox.Show("Please enter your type of customer", "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (typeOfCustomer.Equals("Household customer"))
            {
                if (!int.TryParse(txtNumberOfPerson.Text, out numberOfPerson) || numberOfPerson <= 0)
                {
                    MessageBox.Show("Number of Person must be positive for Household customer", "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtLastMonthWater.Text, out lastMonthWater) || lastMonthWater < 0)
            {
                MessageBox.Show("Last month water must be positive for Household customer.", "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtThisMonthWater.Text, out thismonthwater) || thismonthwater < 0)
            {
                MessageBox.Show("This month water meter should be a positive number.", "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (lastMonthWater > thismonthwater)
            {
                MessageBox.Show("This month water meter should be a positive number.", "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var waterbill = Calcution(typeOfCustomer, numberOfPerson, lastMonthWater, thismonthwater);
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWater.ToString());
            item.SubItems.Add(thismonthwater.ToString());
            item.SubItems.Add(waterbill.Item1.ToString());
            item.SubItems.Add(waterbill.Item2.ToString());
            lvWaterBill.Items.Add(item);

            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastmonthWaterMeter = lastMonthWater,
                ThisMonthWaterMeter = thismonthwater,
                Consumption = waterbill.Item1,
                Watermoney = waterbill.Item2,
            };
            invoices.Add(invoice);
        }
        private (double, double) Calcution(string typeOfCustomer, int numberOfPerson, double lastMonthwater, double thisMonthwater)
        {
            double consumpiton = thisMonthwater - lastMonthwater;
            double waterMoney = 0;
            //Use switch cases to classify customer types.
            switch (typeOfCustomer)

            {
                //For household customers, it is necessary to add a conditional sentence
                //to consider the amount of water used by each person according
                //to the prescribed quantity.
                case "Household customer":

                    double waterOfPerson = 0;
                    waterOfPerson = consumpiton / numberOfPerson;
                    if (waterOfPerson < 10)
                    {
                        double Rate = 5973;
                        waterMoney = (Rate + consumpiton);
                    }
                    else if (waterOfPerson >= 10 && waterOfPerson < 20)
                    {
                        double Rate = 7052;
                        waterMoney = (Rate * consumpiton);

                    }
                    else if (waterOfPerson >= 20 && waterOfPerson < 30)
                    {
                        double Rate = 8699;
                        waterMoney = (Rate * consumpiton);
                    }
                    else if (waterOfPerson >= 30)
                    {
                        double Rate = 15929;
                        waterMoney = (Rate * consumpiton);
                    }
                    break;
                case "Administration agency, public services":
                    {
                        double Rate = 9955;
                        waterMoney = (Rate * consumpiton);
                        break;
                    }
                case "Production units":
                    {
                        double Rate = 11615;
                        waterMoney = (Rate * consumpiton);
                    }
                    break;
                case "Business services":
                    {
                        double Rate = 22086;
                        waterMoney = (Rate * consumpiton);
                    }
                    break;
            }
            waterMoney += waterMoney * VAT;
            return (consumpiton, waterMoney);
        }
        public class Invoice
        {
            public string CustomerName { get; set; }
            public double LastmonthWaterMeter { get; set; }
            public double ThisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double Watermoney { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 100);
            lvWaterBill.Columns.Add("Last Month Mater", 100);
            lvWaterBill.Columns.Add("This Month Water", 100);
            lvWaterBill.Columns.Add("Amount Of Consumpiton", 100);
            lvWaterBill.Columns.Add("Total Water Bill", 100);
        }

        private void cboTypeOfCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string typeOfCustomer = cboTypeOfCustomer.Text;
            if (typeOfCustomer.Equals("Household customer"))
            {
                txtNumberOfPerson.Enabled = true;
            }
            else
            {
                txtNumberOfPerson.Enabled = false;
                txtNumberOfPerson.Text = "";
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            //create bool variable named foundreasult and set value to false
            //to check if customer entered correct name, blank and wrong name
            bool foundReasult = false;
            //Use if and foreach loops to iterate over the elements in the invoices array
            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastmonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.Watermoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundReasult = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName.Contains(search))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastmonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.Watermoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundReasult = true;
                    }
                }

            }
            if (!foundReasult)
            {
                ListViewItem item = new ListViewItem("No results Found");
                lvWaterBill.Items.Add(item);
            }
        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                int selectedIndex = lvWaterBill.SelectedItems[0].Index;
                if (selectedIndex >= 0 && selectedIndex < invoices.Count)
                {
                    Invoice invoice = invoices[selectedIndex];

                    Bill bill = new Bill(invoice.CustomerName, invoice.LastmonthWaterMeter,
                     invoice.ThisMonthWaterMeter, invoice.Consumption, invoice.Watermoney);
                    bill.Show();
                }
            }
        }
    }
}
