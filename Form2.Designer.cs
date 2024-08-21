namespace BC00323_thanhtm_Assignment2
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbNameOfCustomer = new Label();
            lbLastMonthWater = new Label();
            lbThisMonthwater = new Label();
            lbConsumption = new Label();
            lbWatermoney = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(340, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Water Bill";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(172, 69);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 1;
            label2.Text = "Name Of Cusotmer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(172, 122);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Moth Water:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(172, 173);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 3;
            label4.Text = "This Month Water:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(174, 222);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 4;
            label5.Text = "Consumpion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(172, 271);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 5;
            label6.Text = "Water Money:";
            // 
            // lbNameOfCustomer
            // 
            lbNameOfCustomer.AutoSize = true;
            lbNameOfCustomer.Font = new Font("Segoe UI", 12F);
            lbNameOfCustomer.Location = new Point(326, 69);
            lbNameOfCustomer.Name = "lbNameOfCustomer";
            lbNameOfCustomer.Size = new Size(137, 21);
            lbNameOfCustomer.TabIndex = 6;
            lbNameOfCustomer.Text = "NameOfCustomer";
            // 
            // lbLastMonthWater
            // 
            lbLastMonthWater.AutoSize = true;
            lbLastMonthWater.Font = new Font("Segoe UI", 12F);
            lbLastMonthWater.Location = new Point(305, 122);
            lbLastMonthWater.Name = "lbLastMonthWater";
            lbLastMonthWater.Size = new Size(125, 21);
            lbLastMonthWater.TabIndex = 7;
            lbLastMonthWater.Text = "LastMonthWater";
            // 
            // lbThisMonthwater
            // 
            lbThisMonthwater.AutoSize = true;
            lbThisMonthwater.Font = new Font("Segoe UI", 12F);
            lbThisMonthwater.Location = new Point(314, 173);
            lbThisMonthwater.Name = "lbThisMonthwater";
            lbThisMonthwater.Size = new Size(125, 21);
            lbThisMonthwater.TabIndex = 8;
            lbThisMonthwater.Text = "ThisMonthWater";
            // 
            // lbConsumption
            // 
            lbConsumption.AutoSize = true;
            lbConsumption.Font = new Font("Segoe UI", 12F);
            lbConsumption.Location = new Point(282, 222);
            lbConsumption.Name = "lbConsumption";
            lbConsumption.Size = new Size(101, 21);
            lbConsumption.TabIndex = 9;
            lbConsumption.Text = "consumption";
            // 
            // lbWatermoney
            // 
            lbWatermoney.AutoSize = true;
            lbWatermoney.Font = new Font("Segoe UI", 12F);
            lbWatermoney.Location = new Point(284, 271);
            lbWatermoney.Name = "lbWatermoney";
            lbWatermoney.Size = new Size(99, 21);
            lbWatermoney.TabIndex = 10;
            lbWatermoney.Text = "WaterMoney";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbWatermoney);
            Controls.Add(lbConsumption);
            Controls.Add(lbThisMonthwater);
            Controls.Add(lbLastMonthWater);
            Controls.Add(lbNameOfCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bill";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbNameOfCustomer;
        private Label lbLastMonthWater;
        private Label lbThisMonthwater;
        private Label lbConsumption;
        private Label lbWatermoney;
    }
}