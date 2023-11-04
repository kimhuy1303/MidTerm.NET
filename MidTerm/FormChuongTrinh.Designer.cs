namespace MidTerm
{
    partial class FormChuongTrinh
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
            menuStrip1 = new MenuStrip();
            LogoutTool = new ToolStripMenuItem();
            managementTool = new ToolStripMenuItem();
            pnLeft = new Panel();
            panel4 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            cbLocation = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pnFuel = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            pnFeature = new FlowLayoutPanel();
            lblFeatureCar = new Label();
            panel1 = new Panel();
            pnCar = new FlowLayoutPanel();
            lblCategoryCar = new Label();
            lblHeading = new Label();
            pnRight = new Panel();
            btnReset = new Button();
            btnDatXe = new Button();
            groupBox1 = new GroupBox();
            cbGender = new ComboBox();
            txtAddress = new TextBox();
            label9 = new Label();
            txtPhoneNum = new TextBox();
            label8 = new Label();
            txtCCCD = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip1.SuspendLayout();
            pnLeft.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnRight.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { LogoutTool, managementTool });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1216, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // LogoutTool
            // 
            LogoutTool.Name = "LogoutTool";
            LogoutTool.Size = new Size(73, 20);
            LogoutTool.Text = "Đăng xuất";
            LogoutTool.Click += LogoutTool_Click;
            // 
            // managementTool
            // 
            managementTool.Name = "managementTool";
            managementTool.Size = new Size(60, 20);
            managementTool.Text = "Quản lý";
            managementTool.Click += managementTool_Click;
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(panel4);
            pnLeft.Controls.Add(panel3);
            pnLeft.Controls.Add(panel2);
            pnLeft.Controls.Add(panel1);
            pnLeft.Location = new Point(12, 65);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(688, 559);
            pnLeft.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(cbLocation);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(24, 432);
            panel4.Name = "panel4";
            panel4.Size = new Size(642, 122);
            panel4.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(404, 66);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(189, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // cbLocation
            // 
            cbLocation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLocation.FormattingEnabled = true;
            cbLocation.Location = new Point(125, 10);
            cbLocation.Name = "cbLocation";
            cbLocation.Size = new Size(189, 26);
            cbLocation.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(125, 66);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 69);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 6;
            label4.Text = "Ngày nhận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(325, 69);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 5;
            label3.Text = "Ngày trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 13);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 4;
            label2.Text = "Điểm đến";
            // 
            // panel3
            // 
            panel3.Controls.Add(pnFuel);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(24, 358);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 74);
            panel3.TabIndex = 4;
            // 
            // pnFuel
            // 
            pnFuel.Location = new Point(27, 32);
            pnFuel.Name = "pnFuel";
            pnFuel.Size = new Size(603, 33);
            pnFuel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 10);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 2;
            label1.Text = "Nhiên liệu";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnFeature);
            panel2.Controls.Add(lblFeatureCar);
            panel2.Location = new Point(24, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 144);
            panel2.TabIndex = 3;
            // 
            // pnFeature
            // 
            pnFeature.Location = new Point(27, 32);
            pnFeature.Name = "pnFeature";
            pnFeature.Size = new Size(603, 104);
            pnFeature.TabIndex = 2;
            // 
            // lblFeatureCar
            // 
            lblFeatureCar.AutoSize = true;
            lblFeatureCar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFeatureCar.Location = new Point(22, 10);
            lblFeatureCar.Name = "lblFeatureCar";
            lblFeatureCar.Size = new Size(86, 19);
            lblFeatureCar.TabIndex = 0;
            lblFeatureCar.Text = "Tính năng";
            // 
            // panel1
            // 
            panel1.Controls.Add(pnCar);
            panel1.Controls.Add(lblCategoryCar);
            panel1.Location = new Point(24, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 205);
            panel1.TabIndex = 2;
            // 
            // pnCar
            // 
            pnCar.AutoScroll = true;
            pnCar.Location = new Point(22, 26);
            pnCar.Name = "pnCar";
            pnCar.Size = new Size(608, 176);
            pnCar.TabIndex = 1;
            // 
            // lblCategoryCar
            // 
            lblCategoryCar.AutoSize = true;
            lblCategoryCar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoryCar.Location = new Point(27, 4);
            lblCategoryCar.Name = "lblCategoryCar";
            lblCategoryCar.Size = new Size(64, 19);
            lblCategoryCar.TabIndex = 0;
            lblCategoryCar.Text = "Loại xe";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = Color.Red;
            lblHeading.Location = new Point(496, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(275, 29);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Phần mềm cho thuê xe";
            // 
            // pnRight
            // 
            pnRight.Controls.Add(btnReset);
            pnRight.Controls.Add(btnDatXe);
            pnRight.Controls.Add(groupBox1);
            pnRight.Location = new Point(717, 65);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(487, 559);
            pnRight.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Red;
            btnReset.Location = new Point(299, 482);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 61);
            btnReset.TabIndex = 16;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDatXe
            // 
            btnDatXe.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatXe.ForeColor = Color.Blue;
            btnDatXe.Location = new Point(83, 482);
            btnDatXe.Name = "btnDatXe";
            btnDatXe.Size = new Size(131, 61);
            btnDatXe.TabIndex = 15;
            btnDatXe.Text = "Đặt xe";
            btnDatXe.UseVisualStyleBackColor = true;
            btnDatXe.Click += btnDatXe_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhoneNum);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 309);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(130, 103);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(105, 26);
            cbGender.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(130, 265);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(316, 26);
            txtAddress.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 267);
            label9.Name = "label9";
            label9.Size = new Size(57, 18);
            label9.TabIndex = 8;
            label9.Text = "Địa chỉ";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNum.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNum.Location = new Point(130, 209);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(316, 26);
            txtPhoneNum.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 211);
            label8.Name = "label8";
            label8.Size = new Size(100, 18);
            label8.TabIndex = 6;
            label8.Text = "Số điện thoại";
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(130, 158);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(316, 26);
            txtCCCD.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(130, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 26);
            txtName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 160);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 2;
            label7.Text = "CCCD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 103);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 1;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 46);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 0;
            label5.Text = "Họ và tên";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // FormChuongTrinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 636);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            Controls.Add(menuStrip1);
            Controls.Add(lblHeading);
            MainMenuStrip = menuStrip1;
            Name = "FormChuongTrinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý thuê xe";
            FormClosed += FormChuongTrinh_FormClosed;
            Load += FormChuongTrinh_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnLeft.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnRight.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem LogoutTool;
        private Panel pnLeft;
        private Label lblCategoryCar;
        private Panel pnRight;
        private Panel panel2;
        private Label lblFeatureCar;
        private Panel panel1;
        private Label lblHeading;
        private Panel panel4;
        private ComboBox cbLocation;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private FlowLayoutPanel pnFeature;
        private FlowLayoutPanel pnFuel;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtCCCD;
        private Label label7;
        private Label label6;
        private TextBox txtName;
        private ComboBox cbGender;
        private TextBox txtAddress;
        private Label label9;
        private TextBox txtPhoneNum;
        private Label label8;
        private Button btnReset;
        private Button btnDatXe;
        private FlowLayoutPanel pnCar;
        public ToolStripMenuItem managementTool;
    }
}