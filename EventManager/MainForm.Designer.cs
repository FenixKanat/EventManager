namespace EventManager
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FeePerParticipant11 = new System.Windows.Forms.TextBox();
            this.CostPerParticipant11 = new System.Windows.Forms.TextBox();
            this.EventTitle11 = new System.Windows.Forms.TextBox();
            this.FeePerParticipant1 = new System.Windows.Forms.Label();
            this.CostPerParticipant1 = new System.Windows.Forms.Label();
            this.EventTitle1 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Country11 = new System.Windows.Forms.ComboBox();
            this.ZipCode11 = new System.Windows.Forms.TextBox();
            this.City11 = new System.Windows.Forms.TextBox();
            this.Street11 = new System.Windows.Forms.TextBox();
            this.LastName11 = new System.Windows.Forms.TextBox();
            this.FirstName11 = new System.Windows.Forms.TextBox();
            this.Country1 = new System.Windows.Forms.Label();
            this.ZipCode1 = new System.Windows.Forms.Label();
            this.City1 = new System.Windows.Forms.Label();
            this.Street1 = new System.Windows.Forms.Label();
            this.LastName1 = new System.Windows.Forms.Label();
            this.FirstName1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Deficit11 = new System.Windows.Forms.Label();
            this.TotalFees11 = new System.Windows.Forms.Label();
            this.TotalCost11 = new System.Windows.Forms.Label();
            this.NumberOfParticipants11 = new System.Windows.Forms.Label();
            this.Deficit1 = new System.Windows.Forms.Label();
            this.TotalFees1 = new System.Windows.Forms.Label();
            this.TotalCost1 = new System.Windows.Forms.Label();
            this.NumberOfParticipants1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ParticipantLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FeePerParticipant11);
            this.groupBox1.Controls.Add(this.CostPerParticipant11);
            this.groupBox1.Controls.Add(this.EventTitle11);
            this.groupBox1.Controls.Add(this.FeePerParticipant1);
            this.groupBox1.Controls.Add(this.CostPerParticipant1);
            this.groupBox1.Controls.Add(this.EventTitle1);
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Event";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FeePerParticipant11
            // 
            this.FeePerParticipant11.Location = new System.Drawing.Point(333, 141);
            this.FeePerParticipant11.Name = "FeePerParticipant11";
            this.FeePerParticipant11.Size = new System.Drawing.Size(111, 33);
            this.FeePerParticipant11.TabIndex = 6;
            // 
            // CostPerParticipant11
            // 
            this.CostPerParticipant11.Location = new System.Drawing.Point(333, 90);
            this.CostPerParticipant11.Name = "CostPerParticipant11";
            this.CostPerParticipant11.Size = new System.Drawing.Size(111, 33);
            this.CostPerParticipant11.TabIndex = 5;
            // 
            // EventTitle11
            // 
            this.EventTitle11.Location = new System.Drawing.Point(149, 39);
            this.EventTitle11.Name = "EventTitle11";
            this.EventTitle11.Size = new System.Drawing.Size(295, 33);
            this.EventTitle11.TabIndex = 4;
            this.EventTitle11.TextChanged += new System.EventHandler(this.EventTitle11_TextChanged);
            // 
            // FeePerParticipant1
            // 
            this.FeePerParticipant1.Location = new System.Drawing.Point(7, 141);
            this.FeePerParticipant1.Name = "FeePerParticipant1";
            this.FeePerParticipant1.Size = new System.Drawing.Size(111, 24);
            this.FeePerParticipant1.TabIndex = 3;
            this.FeePerParticipant1.Text = "Fee Per Participant";
            // 
            // CostPerParticipant1
            // 
            this.CostPerParticipant1.Location = new System.Drawing.Point(8, 90);
            this.CostPerParticipant1.Name = "CostPerParticipant1";
            this.CostPerParticipant1.Size = new System.Drawing.Size(111, 24);
            this.CostPerParticipant1.TabIndex = 2;
            this.CostPerParticipant1.Text = "Cost Per Participant";
            // 
            // EventTitle1
            // 
            this.EventTitle1.Location = new System.Drawing.Point(8, 39);
            this.EventTitle1.Name = "EventTitle1";
            this.EventTitle1.Size = new System.Drawing.Size(111, 24);
            this.EventTitle1.TabIndex = 1;
            this.EventTitle1.Text = "Event Title";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(333, 186);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(111, 38);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Country11);
            this.groupBox2.Controls.Add(this.ZipCode11);
            this.groupBox2.Controls.Add(this.City11);
            this.groupBox2.Controls.Add(this.Street11);
            this.groupBox2.Controls.Add(this.LastName11);
            this.groupBox2.Controls.Add(this.FirstName11);
            this.groupBox2.Controls.Add(this.Country1);
            this.groupBox2.Controls.Add(this.ZipCode1);
            this.groupBox2.Controls.Add(this.City1);
            this.groupBox2.Controls.Add(this.Street1);
            this.groupBox2.Controls.Add(this.LastName1);
            this.groupBox2.Controls.Add(this.FirstName1);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Participant";
            // 
            // Country11
            // 
            this.Country11.FormattingEnabled = true;
            this.Country11.Location = new System.Drawing.Point(311, 242);
            this.Country11.Name = "Country11";
            this.Country11.Size = new System.Drawing.Size(111, 29);
            this.Country11.TabIndex = 13;
            // 
            // ZipCode11
            // 
            this.ZipCode11.Location = new System.Drawing.Point(311, 203);
            this.ZipCode11.Name = "ZipCode11";
            this.ZipCode11.Size = new System.Drawing.Size(111, 33);
            this.ZipCode11.TabIndex = 11;
            // 
            // City11
            // 
            this.City11.Location = new System.Drawing.Point(311, 162);
            this.City11.Name = "City11";
            this.City11.Size = new System.Drawing.Size(111, 33);
            this.City11.TabIndex = 10;
            // 
            // Street11
            // 
            this.Street11.Location = new System.Drawing.Point(311, 122);
            this.Street11.Name = "Street11";
            this.Street11.Size = new System.Drawing.Size(111, 33);
            this.Street11.TabIndex = 9;
            // 
            // LastName11
            // 
            this.LastName11.Location = new System.Drawing.Point(311, 77);
            this.LastName11.Name = "LastName11";
            this.LastName11.Size = new System.Drawing.Size(111, 33);
            this.LastName11.TabIndex = 8;
            // 
            // FirstName11
            // 
            this.FirstName11.Location = new System.Drawing.Point(311, 33);
            this.FirstName11.Name = "FirstName11";
            this.FirstName11.Size = new System.Drawing.Size(111, 33);
            this.FirstName11.TabIndex = 7;
            // 
            // Country1
            // 
            this.Country1.Location = new System.Drawing.Point(23, 251);
            this.Country1.Name = "Country1";
            this.Country1.Size = new System.Drawing.Size(111, 24);
            this.Country1.TabIndex = 6;
            this.Country1.Text = "Country";
            // 
            // ZipCode1
            // 
            this.ZipCode1.Location = new System.Drawing.Point(23, 209);
            this.ZipCode1.Name = "ZipCode1";
            this.ZipCode1.Size = new System.Drawing.Size(111, 24);
            this.ZipCode1.TabIndex = 5;
            this.ZipCode1.Text = "Zip Code";
            // 
            // City1
            // 
            this.City1.Location = new System.Drawing.Point(23, 168);
            this.City1.Name = "City1";
            this.City1.Size = new System.Drawing.Size(111, 24);
            this.City1.TabIndex = 4;
            this.City1.Text = "City";
            // 
            // Street1
            // 
            this.Street1.Location = new System.Drawing.Point(23, 128);
            this.Street1.Name = "Street1";
            this.Street1.Size = new System.Drawing.Size(111, 24);
            this.Street1.TabIndex = 3;
            this.Street1.Text = "Street";
            // 
            // LastName1
            // 
            this.LastName1.Location = new System.Drawing.Point(23, 83);
            this.LastName1.Name = "LastName1";
            this.LastName1.Size = new System.Drawing.Size(111, 24);
            this.LastName1.TabIndex = 2;
            this.LastName1.Text = "Last Name";
            // 
            // FirstName1
            // 
            this.FirstName1.Location = new System.Drawing.Point(23, 39);
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.Size = new System.Drawing.Size(111, 24);
            this.FirstName1.TabIndex = 1;
            this.FirstName1.Text = "First Name";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(311, 279);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 38);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Deficit11);
            this.groupBox3.Controls.Add(this.TotalFees11);
            this.groupBox3.Controls.Add(this.TotalCost11);
            this.groupBox3.Controls.Add(this.NumberOfParticipants11);
            this.groupBox3.Controls.Add(this.Deficit1);
            this.groupBox3.Controls.Add(this.TotalFees1);
            this.groupBox3.Controls.Add(this.TotalCost1);
            this.groupBox3.Controls.Add(this.NumberOfParticipants1);
            this.groupBox3.Location = new System.Drawing.Point(527, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 240);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Economy";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Deficit11
            // 
            this.Deficit11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Deficit11.Location = new System.Drawing.Point(491, 196);
            this.Deficit11.Name = "Deficit11";
            this.Deficit11.Size = new System.Drawing.Size(111, 24);
            this.Deficit11.TabIndex = 7;
            this.Deficit11.Text = "label4";
            this.Deficit11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalFees11
            // 
            this.TotalFees11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalFees11.Location = new System.Drawing.Point(491, 147);
            this.TotalFees11.Name = "TotalFees11";
            this.TotalFees11.Size = new System.Drawing.Size(111, 24);
            this.TotalFees11.TabIndex = 6;
            this.TotalFees11.Text = "label3";
            this.TotalFees11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCost11
            // 
            this.TotalCost11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost11.Location = new System.Drawing.Point(491, 102);
            this.TotalCost11.Name = "TotalCost11";
            this.TotalCost11.Size = new System.Drawing.Size(111, 24);
            this.TotalCost11.TabIndex = 5;
            this.TotalCost11.Text = "label2";
            this.TotalCost11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfParticipants11
            // 
            this.NumberOfParticipants11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumberOfParticipants11.Location = new System.Drawing.Point(491, 45);
            this.NumberOfParticipants11.Name = "NumberOfParticipants11";
            this.NumberOfParticipants11.Size = new System.Drawing.Size(111, 24);
            this.NumberOfParticipants11.TabIndex = 4;
            this.NumberOfParticipants11.Text = "label1";
            this.NumberOfParticipants11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deficit1
            // 
            this.Deficit1.Location = new System.Drawing.Point(35, 194);
            this.Deficit1.Name = "Deficit1";
            this.Deficit1.Size = new System.Drawing.Size(111, 24);
            this.Deficit1.TabIndex = 3;
            this.Deficit1.Text = "Deficit";
            // 
            // TotalFees1
            // 
            this.TotalFees1.Location = new System.Drawing.Point(35, 148);
            this.TotalFees1.Name = "TotalFees1";
            this.TotalFees1.Size = new System.Drawing.Size(111, 24);
            this.TotalFees1.TabIndex = 2;
            this.TotalFees1.Text = "Total Fees";
            // 
            // TotalCost1
            // 
            this.TotalCost1.Location = new System.Drawing.Point(35, 102);
            this.TotalCost1.Name = "TotalCost1";
            this.TotalCost1.Size = new System.Drawing.Size(111, 24);
            this.TotalCost1.TabIndex = 1;
            this.TotalCost1.Text = "Total Cost";
            // 
            // NumberOfParticipants1
            // 
            this.NumberOfParticipants1.Location = new System.Drawing.Point(35, 46);
            this.NumberOfParticipants1.Name = "NumberOfParticipants1";
            this.NumberOfParticipants1.Size = new System.Drawing.Size(242, 43);
            this.NumberOfParticipants1.TabIndex = 0;
            this.NumberOfParticipants1.Text = "Number Of Participants";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 21;
            this.listBox.Location = new System.Drawing.Point(527, 36);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(666, 235);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(613, 293);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(111, 38);
            this.ChangeBtn.TabIndex = 4;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(941, 293);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(111, 38);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ParticipantLbl
            // 
            this.ParticipantLbl.Location = new System.Drawing.Point(523, 9);
            this.ParticipantLbl.Name = "ParticipantLbl";
            this.ParticipantLbl.Size = new System.Drawing.Size(111, 24);
            this.ParticipantLbl.TabIndex = 6;
            this.ParticipantLbl.Text = "Participant";
            // 
            // AddressLbl
            // 
            this.AddressLbl.Location = new System.Drawing.Point(666, 9);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(111, 24);
            this.AddressLbl.TabIndex = 7;
            this.AddressLbl.Text = "Address";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 605);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.ParticipantLbl);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label FeePerParticipant1;
        private System.Windows.Forms.Label CostPerParticipant1;
        private System.Windows.Forms.Label EventTitle1;
        private System.Windows.Forms.Label Country1;
        private System.Windows.Forms.Label ZipCode1;
        private System.Windows.Forms.Label City1;
        private System.Windows.Forms.Label Street1;
        private System.Windows.Forms.Label LastName1;
        private System.Windows.Forms.Label FirstName1;
        private System.Windows.Forms.Label Deficit1;
        private System.Windows.Forms.Label TotalFees1;
        private System.Windows.Forms.Label TotalCost1;
        private System.Windows.Forms.Label NumberOfParticipants1;
        private System.Windows.Forms.Label ParticipantLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox FeePerParticipant11;
        private System.Windows.Forms.TextBox CostPerParticipant11;
        private System.Windows.Forms.TextBox EventTitle11;
        private System.Windows.Forms.TextBox ZipCode11;
        private System.Windows.Forms.TextBox City11;
        private System.Windows.Forms.TextBox Street11;
        private System.Windows.Forms.TextBox LastName11;
        private System.Windows.Forms.TextBox FirstName11;
        private System.Windows.Forms.Label Deficit11;
        private System.Windows.Forms.Label TotalFees11;
        private System.Windows.Forms.Label TotalCost11;
        private System.Windows.Forms.Label NumberOfParticipants11;
        private System.Windows.Forms.ComboBox Country11;
    }
}

