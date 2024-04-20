﻿namespace CustomerManagementApp
{
    partial class CustomerInfo
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
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.UpdateCutomerBtn = new System.Windows.Forms.Button();
            this.ViewCustomerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerPhnNum = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerListbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerIDtextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteCustomerbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(162, 611);
            this.AddCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(209, 103);
            this.AddCustomerBtn.TabIndex = 0;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // UpdateCutomerBtn
            // 
            this.UpdateCutomerBtn.Location = new System.Drawing.Point(421, 611);
            this.UpdateCutomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCutomerBtn.Name = "UpdateCutomerBtn";
            this.UpdateCutomerBtn.Size = new System.Drawing.Size(189, 94);
            this.UpdateCutomerBtn.TabIndex = 1;
            this.UpdateCutomerBtn.Text = "Update Customer";
            this.UpdateCutomerBtn.UseVisualStyleBackColor = true;
            this.UpdateCutomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // ViewCustomerBtn
            // 
            this.ViewCustomerBtn.Location = new System.Drawing.Point(412, 769);
            this.ViewCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCustomerBtn.Name = "ViewCustomerBtn";
            this.ViewCustomerBtn.Size = new System.Drawing.Size(198, 98);
            this.ViewCustomerBtn.TabIndex = 3;
            this.ViewCustomerBtn.Text = "View Customer";
            this.ViewCustomerBtn.UseVisualStyleBackColor = true;
            this.ViewCustomerBtn.Click += new System.EventHandler(this.ViewCustomerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(216, 152);
            this.customerName.Margin = new System.Windows.Forms.Padding(4);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(152, 31);
            this.customerName.TabIndex = 8;
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(216, 233);
            this.customerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(152, 31);
            this.customerAddress.TabIndex = 9;
            // 
            // customerPhnNum
            // 
            this.customerPhnNum.Location = new System.Drawing.Point(216, 304);
            this.customerPhnNum.Margin = new System.Windows.Forms.Padding(4);
            this.customerPhnNum.Name = "customerPhnNum";
            this.customerPhnNum.Size = new System.Drawing.Size(152, 31);
            this.customerPhnNum.TabIndex = 10;
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(216, 390);
            this.customerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(160, 31);
            this.customerEmail.TabIndex = 11;
            // 
            // customerListbox
            // 
            this.customerListbox.FormattingEnabled = true;
            this.customerListbox.ItemHeight = 25;
            this.customerListbox.Location = new System.Drawing.Point(904, 29);
            this.customerListbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerListbox.Name = "customerListbox";
            this.customerListbox.Size = new System.Drawing.Size(946, 579);
            this.customerListbox.TabIndex = 12;
            this.customerListbox.SelectedIndexChanged += new System.EventHandler(this.customerListbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerIDtextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customerPhnNum);
            this.groupBox1.Controls.Add(this.customerEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(44, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(756, 461);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CustomerInfo";
            // 
            // CustomerIDtextbox
            // 
            this.CustomerIDtextbox.Location = new System.Drawing.Point(216, 71);
            this.CustomerIDtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIDtextbox.Name = "CustomerIDtextbox";
            this.CustomerIDtextbox.Size = new System.Drawing.Size(160, 31);
            this.CustomerIDtextbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "customerID";
            // 
            // DeleteCustomerbtn
            // 
            this.DeleteCustomerbtn.Location = new System.Drawing.Point(163, 769);
            this.DeleteCustomerbtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomerbtn.Name = "DeleteCustomerbtn";
            this.DeleteCustomerbtn.Size = new System.Drawing.Size(208, 98);
            this.DeleteCustomerbtn.TabIndex = 14;
            this.DeleteCustomerbtn.Text = "Delete Customer";
            this.DeleteCustomerbtn.UseVisualStyleBackColor = true;
            this.DeleteCustomerbtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(898, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "CustomerList";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1312, 688);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(234, 108);
            this.exitbutton.TabIndex = 16;
            this.exitbutton.Text = "&Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CustomerManagementApp.Properties.Resources.customer_relationship_management_strategies;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1916, 965);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteCustomerbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerListbox);
            this.Controls.Add(this.UpdateCutomerBtn);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.ViewCustomerBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerInfo";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Button UpdateCutomerBtn;
        private System.Windows.Forms.Button ViewCustomerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerPhnNum;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.ListBox customerListbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteCustomerbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox CustomerIDtextbox;
        private System.Windows.Forms.Label label6;
    }
}

