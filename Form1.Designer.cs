namespace BC00323_thanhtm_Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            bntCaculation = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNumberOfPerson = new TextBox();
            label1 = new Label();
            cboTypeOfCustomer = new ComboBox();
            txtThisMonthWater = new TextBox();
            txtLastMonthWater = new TextBox();
            txtCustomerName = new TextBox();
            lvWaterBill = new ListView();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntCaculation);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumberOfPerson);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTypeOfCustomer);
            groupBox1.Controls.Add(txtThisMonthWater);
            groupBox1.Controls.Add(txtLastMonthWater);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 369);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caculation";
            // 
            // bntCaculation
            // 
            bntCaculation.Location = new Point(220, 309);
            bntCaculation.Name = "bntCaculation";
            bntCaculation.Size = new Size(111, 29);
            bntCaculation.TabIndex = 10;
            bntCaculation.Text = "Caculation Bill";
            bntCaculation.UseVisualStyleBackColor = true;
            bntCaculation.Click += bntCaculation_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 262);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 9;
            label5.Text = "This Month Water";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 195);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 8;
            label4.Text = "Last Month Water";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 133);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 7;
            label3.Text = "Number Of Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 69);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Type Of Customer";
            // 
            // txtNumberOfPerson
            // 
            txtNumberOfPerson.Enabled = false;
            txtNumberOfPerson.Location = new Point(85, 151);
            txtNumberOfPerson.Name = "txtNumberOfPerson";
            txtNumberOfPerson.Size = new Size(249, 23);
            txtNumberOfPerson.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 11);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Customer Name";
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            cboTypeOfCustomer.Location = new Point(84, 87);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(250, 23);
            cboTypeOfCustomer.TabIndex = 4;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged_1;
            // 
            // txtThisMonthWater
            // 
            txtThisMonthWater.Location = new Point(82, 280);
            txtThisMonthWater.Name = "txtThisMonthWater";
            txtThisMonthWater.Size = new Size(252, 23);
            txtThisMonthWater.TabIndex = 3;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.Location = new Point(82, 213);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.Size = new Size(252, 23);
            txtLastMonthWater.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(85, 29);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(249, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // lvWaterBill
            // 
            lvWaterBill.FullRowSelect = true;
            lvWaterBill.GridLines = true;
            lvWaterBill.Location = new Point(355, 57);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(484, 274);
            lvWaterBill.TabIndex = 1;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(414, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 450);
            Controls.Add(txtSearch);
            Controls.Add(lvWaterBill);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNumberOfPerson;
        private Label label1;
        private ComboBox cboTypeOfCustomer;
        private TextBox txtThisMonthWater;
        private TextBox txtLastMonthWater;
        private TextBox txtCustomerName;
        private Label label5;
        private ListView lvWaterBill;
        private TextBox txtSearch;
        private Button bntCaculation;
    }
}
