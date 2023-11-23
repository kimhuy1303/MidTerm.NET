namespace MidTerm
{
    partial class FormBillInfo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnSubmit = new Button();
            btnCancel = new Button();
            panel4 = new Panel();
            tbCost = new TextBox();
            tbTotalCost = new TextBox();
            tbDeposit = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            lblFeatures = new Label();
            label11 = new Label();
            dtpDropOffDate = new DateTimePicker();
            label10 = new Label();
            dtpPickUpDate = new DateTimePicker();
            tbDestination = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tbCarBrand = new TextBox();
            tbCarName = new TextBox();
            tbAddress = new TextBox();
            tbCCCD = new TextBox();
            tbPhoneNum = new TextBox();
            tbCustomerName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dtpDropOffDate);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dtpPickUpDate);
            panel1.Controls.Add(tbDestination);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbCarBrand);
            panel1.Controls.Add(tbCarName);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(tbCCCD);
            panel1.Controls.Add(tbPhoneNum);
            panel1.Controls.Add(tbCustomerName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 719);
            panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.Blue;
            btnSubmit.Location = new Point(458, 512);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 107);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(305, 512);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 107);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Trở lại";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbCost);
            panel4.Controls.Add(tbTotalCost);
            panel4.Controls.Add(tbDeposit);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(266, 367);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 139);
            panel4.TabIndex = 19;
            // 
            // tbCost
            // 
            tbCost.BorderStyle = BorderStyle.FixedSingle;
            tbCost.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCost.Location = new Point(152, 97);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(167, 29);
            tbCost.TabIndex = 24;
            // 
            // tbTotalCost
            // 
            tbTotalCost.BorderStyle = BorderStyle.FixedSingle;
            tbTotalCost.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTotalCost.Location = new Point(152, 53);
            tbTotalCost.Name = "tbTotalCost";
            tbTotalCost.Size = new Size(167, 29);
            tbTotalCost.TabIndex = 23;
            // 
            // tbDeposit
            // 
            tbDeposit.BorderStyle = BorderStyle.FixedSingle;
            tbDeposit.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDeposit.Location = new Point(152, 10);
            tbDeposit.Name = "tbDeposit";
            tbDeposit.Size = new Size(167, 29);
            tbDeposit.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(13, 99);
            label14.Name = "label14";
            label14.Size = new Size(107, 22);
            label14.TabIndex = 4;
            label14.Text = "Thành tiền :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(13, 53);
            label13.Name = "label13";
            label13.Size = new Size(111, 22);
            label13.TabIndex = 3;
            label13.Text = "Tổng cộng :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(13, 10);
            label12.Name = "label12";
            label12.Size = new Size(85, 22);
            label12.TabIndex = 2;
            label12.Text = "Đặt cọc :";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblFeatures);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(3, 367);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 253);
            panel3.TabIndex = 18;
            // 
            // lblFeatures
            // 
            lblFeatures.AutoSize = true;
            lblFeatures.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeatures.Location = new Point(14, 44);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Size = new Size(54, 17);
            lblFeatures.TabIndex = 1;
            lblFeatures.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(14, 10);
            label11.Name = "label11";
            label11.Size = new Size(129, 22);
            label11.TabIndex = 0;
            label11.Text = "Tính năng xe :";
            // 
            // dtpDropOffDate
            // 
            dtpDropOffDate.CustomFormat = "dd-MM-yyyy";
            dtpDropOffDate.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDropOffDate.Format = DateTimePickerFormat.Custom;
            dtpDropOffDate.Location = new Point(444, 332);
            dtpDropOffDate.Name = "dtpDropOffDate";
            dtpDropOffDate.Size = new Size(153, 29);
            dtpDropOffDate.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(311, 335);
            label10.Name = "label10";
            label10.Size = new Size(129, 22);
            label10.TabIndex = 16;
            label10.Text = "Ngày thuê xe :";
            // 
            // dtpPickUpDate
            // 
            dtpPickUpDate.CustomFormat = "dd-MM-yyyy";
            dtpPickUpDate.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPickUpDate.Format = DateTimePickerFormat.Custom;
            dtpPickUpDate.Location = new Point(152, 332);
            dtpPickUpDate.Name = "dtpPickUpDate";
            dtpPickUpDate.Size = new Size(153, 29);
            dtpPickUpDate.TabIndex = 15;
            // 
            // tbDestination
            // 
            tbDestination.BorderStyle = BorderStyle.FixedSingle;
            tbDestination.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDestination.Location = new Point(176, 287);
            tbDestination.Name = "tbDestination";
            tbDestination.Size = new Size(358, 29);
            tbDestination.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 335);
            label9.Name = "label9";
            label9.Size = new Size(129, 22);
            label9.TabIndex = 13;
            label9.Text = "Ngày thuê xe :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(17, 290);
            label8.Name = "label8";
            label8.Size = new Size(95, 22);
            label8.TabIndex = 12;
            label8.Text = "Địa điểm :";
            // 
            // tbCarBrand
            // 
            tbCarBrand.BorderStyle = BorderStyle.FixedSingle;
            tbCarBrand.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCarBrand.Location = new Point(176, 243);
            tbCarBrand.Name = "tbCarBrand";
            tbCarBrand.Size = new Size(167, 29);
            tbCarBrand.TabIndex = 11;
            // 
            // tbCarName
            // 
            tbCarName.BorderStyle = BorderStyle.FixedSingle;
            tbCarName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCarName.Location = new Point(176, 197);
            tbCarName.Name = "tbCarName";
            tbCarName.Size = new Size(167, 29);
            tbCarName.TabIndex = 10;
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbAddress.Location = new Point(176, 154);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(358, 29);
            tbAddress.TabIndex = 9;
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCCCD.Location = new Point(176, 108);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(167, 29);
            tbCCCD.TabIndex = 8;
            // 
            // tbPhoneNum
            // 
            tbPhoneNum.BorderStyle = BorderStyle.FixedSingle;
            tbPhoneNum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNum.Location = new Point(176, 70);
            tbPhoneNum.Name = "tbPhoneNum";
            tbPhoneNum.Size = new Size(167, 29);
            tbPhoneNum.TabIndex = 7;
            // 
            // tbCustomerName
            // 
            tbCustomerName.BorderStyle = BorderStyle.FixedSingle;
            tbCustomerName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCustomerName.Location = new Point(176, 26);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(358, 29);
            tbCustomerName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 243);
            label5.Name = "label5";
            label5.Size = new Size(94, 22);
            label5.TabIndex = 5;
            label5.Text = "Hãng xe : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(17, 197);
            label6.Name = "label6";
            label6.Size = new Size(122, 22);
            label6.TabIndex = 4;
            label6.Text = "Loại xe thuê :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 154);
            label7.Name = "label7";
            label7.Size = new Size(77, 22);
            label7.TabIndex = 3;
            label7.Text = "Địa chỉ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 110);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 2;
            label4.Text = "CCCD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 70);
            label3.Name = "label3";
            label3.Size = new Size(135, 22);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 28);
            label2.Name = "label2";
            label2.Size = new Size(153, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng :";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(10, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 67);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(167, 18);
            label1.Name = "label1";
            label1.Size = new Size(278, 34);
            label1.TabIndex = 1;
            label1.Text = "Xác Nhận Hóa Đơn";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormBillInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 712);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormBillInfo";
            Text = "BillInfoForm";
            FormClosed += FormBillInfo_FormClosed;
            Load += BillInfoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label9;
        private Label label8;
        private TextBox tbCarBrand;
        private TextBox tbCarName;
        private TextBox tbAddress;
        private TextBox tbCCCD;
        private TextBox tbPhoneNum;
        private TextBox tbCustomerName;
        private Button btnCancel;
        private Panel panel4;
        private Panel panel3;
        private DateTimePicker dtpDropOffDate;
        private Label label10;
        private DateTimePicker dtpPickUpDate;
        private TextBox tbDestination;
        private Button btnSubmit;
        private Label lblFeatures;
        private Label label11;
        private Label label12;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbCost;
        private TextBox tbTotalCost;
        private TextBox tbDeposit;
        private Label label14;
        private Label label13;
    }
}