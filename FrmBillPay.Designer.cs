namespace NewspaperBillingApp
{
    partial class FrmBillPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillPay));
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomerBillDetails = new System.Windows.Forms.DataGridView();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustYear = new System.Windows.Forms.TextBox();
            this.txtCustMonth = new System.Windows.Forms.TextBox();
            this.txtAbsents = new System.Windows.Forms.TextBox();
            this.txtNewspaper = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtRecieptNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBalAmt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaidAmt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPreBal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            this.panelFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBillDetails)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBack.Controls.Add(this.panelFront);
            this.panelBack.Controls.Add(this.panel4);
            this.panelBack.Controls.Add(this.panel5);
            this.panelBack.Location = new System.Drawing.Point(2, 1);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1150, 719);
            this.panelBack.TabIndex = 640;
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelFront.Controls.Add(this.btnExport);
            this.panelFront.Controls.Add(this.label15);
            this.panelFront.Controls.Add(this.txtSearchCustomer);
            this.panelFront.Controls.Add(this.dgvCustomerBillDetails);
            this.panelFront.Controls.Add(this.btnPrintAll);
            this.panelFront.Controls.Add(this.panel8);
            this.panelFront.Location = new System.Drawing.Point(0, 0);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(1150, 718);
            this.panelFront.TabIndex = 638;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.Excel_removebg_preview;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(830, 76);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(49, 42);
            this.btnExport.TabIndex = 640;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(258, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 18);
            this.label15.TabIndex = 634;
            this.label15.Text = "Search Customer";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(392, 85);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(363, 22);
            this.txtSearchCustomer.TabIndex = 633;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // dgvCustomerBillDetails
            // 
            this.dgvCustomerBillDetails.AllowUserToAddRows = false;
            this.dgvCustomerBillDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerBillDetails.AllowUserToResizeRows = false;
            this.dgvCustomerBillDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerBillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomerBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerBillDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomerBillDetails.Location = new System.Drawing.Point(165, 136);
            this.dgvCustomerBillDetails.Name = "dgvCustomerBillDetails";
            this.dgvCustomerBillDetails.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerBillDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomerBillDetails.RowHeadersVisible = false;
            this.dgvCustomerBillDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerBillDetails.Size = new System.Drawing.Size(825, 543);
            this.dgvCustomerBillDetails.TabIndex = 632;
            this.dgvCustomerBillDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBillDetails_CellClick);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.BackgroundImage")));
            this.btnPrintAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintAll.FlatAppearance.BorderSize = 0;
            this.btnPrintAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Location = new System.Drawing.Point(771, 75);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(49, 42);
            this.btnPrintAll.TabIndex = 639;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.btnClose);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(0, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1148, 40);
            this.panel8.TabIndex = 631;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(457, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "Bill Generated Customers";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images__3_3;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1098, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 632;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnPayNow);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.txtBalAmt);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtPaidAmt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtPreBal);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtTotalAmt);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(171, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 648);
            this.panel4.TabIndex = 634;
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.Transparent;
            this.btnPayNow.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images_removebg_preview1;
            this.btnPayNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayNow.FlatAppearance.BorderSize = 0;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(332, 560);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(136, 52);
            this.btnPayNow.TabIndex = 639;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewspaperBillingApp.Properties.Resources.NewsPaperLogo;
            this.pictureBox1.Location = new System.Drawing.Point(260, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 638;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(413, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 28);
            this.label18.TabIndex = 637;
            this.label18.Text = "Bill";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(367, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 28);
            this.label19.TabIndex = 636;
            this.label19.Text = "Newspaper ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtCustID);
            this.panel3.Controls.Add(this.dtpBillDate);
            this.panel3.Controls.Add(this.txtCustYear);
            this.panel3.Controls.Add(this.txtCustMonth);
            this.panel3.Controls.Add(this.txtAbsents);
            this.panel3.Controls.Add(this.txtNewspaper);
            this.panel3.Controls.Add(this.txtCustName);
            this.panel3.Controls.Add(this.txtRecieptNo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(71, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 262);
            this.panel3.TabIndex = 635;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label20.Location = new System.Drawing.Point(281, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 23);
            this.label20.TabIndex = 639;
            this.label20.Text = "Monthly Bill";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(317, 120);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(38, 20);
            this.txtCustID.TabIndex = 638;
            this.txtCustID.Visible = false;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(434, 56);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(209, 20);
            this.dtpBillDate.TabIndex = 113;
            // 
            // txtCustYear
            // 
            this.txtCustYear.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustYear.Location = new System.Drawing.Point(434, 89);
            this.txtCustYear.Name = "txtCustYear";
            this.txtCustYear.Size = new System.Drawing.Size(209, 23);
            this.txtCustYear.TabIndex = 109;
            this.txtCustYear.Text = " ";
            // 
            // txtCustMonth
            // 
            this.txtCustMonth.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustMonth.Location = new System.Drawing.Point(102, 89);
            this.txtCustMonth.Name = "txtCustMonth";
            this.txtCustMonth.Size = new System.Drawing.Size(209, 23);
            this.txtCustMonth.TabIndex = 108;
            this.txtCustMonth.Text = " ";
            // 
            // txtAbsents
            // 
            this.txtAbsents.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbsents.Location = new System.Drawing.Point(102, 196);
            this.txtAbsents.Name = "txtAbsents";
            this.txtAbsents.Size = new System.Drawing.Size(209, 23);
            this.txtAbsents.TabIndex = 106;
            this.txtAbsents.Text = " ";
            // 
            // txtNewspaper
            // 
            this.txtNewspaper.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewspaper.Location = new System.Drawing.Point(102, 157);
            this.txtNewspaper.Name = "txtNewspaper";
            this.txtNewspaper.Size = new System.Drawing.Size(209, 23);
            this.txtNewspaper.TabIndex = 105;
            this.txtNewspaper.Text = " ";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(102, 124);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(209, 23);
            this.txtCustName.TabIndex = 104;
            this.txtCustName.Text = " ";
            // 
            // txtRecieptNo
            // 
            this.txtRecieptNo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecieptNo.Location = new System.Drawing.Point(102, 53);
            this.txtRecieptNo.Name = "txtRecieptNo";
            this.txtRecieptNo.Size = new System.Drawing.Size(209, 23);
            this.txtRecieptNo.TabIndex = 103;
            this.txtRecieptNo.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F);
            this.label8.Location = new System.Drawing.Point(357, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bill Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F);
            this.label7.Location = new System.Drawing.Point(359, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F);
            this.label6.Location = new System.Drawing.Point(18, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F);
            this.label5.Location = new System.Drawing.Point(18, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Absents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F);
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Newspaper";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F);
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cust Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 9.75F);
            this.label10.Location = new System.Drawing.Point(18, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Receipt No";
            // 
            // txtBalAmt
            // 
            this.txtBalAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalAmt.Location = new System.Drawing.Point(296, 510);
            this.txtBalAmt.Name = "txtBalAmt";
            this.txtBalAmt.Size = new System.Drawing.Size(294, 23);
            this.txtBalAmt.TabIndex = 114;
            this.txtBalAmt.Text = " ";
            this.txtBalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 9.75F);
            this.label13.Location = new System.Drawing.Point(165, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 113;
            this.label13.Text = "Balance Amount";
            // 
            // txtPaidAmt
            // 
            this.txtPaidAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmt.Location = new System.Drawing.Point(296, 472);
            this.txtPaidAmt.Name = "txtPaidAmt";
            this.txtPaidAmt.Size = new System.Drawing.Size(294, 23);
            this.txtPaidAmt.TabIndex = 112;
            this.txtPaidAmt.Text = " ";
            this.txtPaidAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidAmt.TextChanged += new System.EventHandler(this.txtPaidAmt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 9.75F);
            this.label12.Location = new System.Drawing.Point(165, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 111;
            this.label12.Text = "Paid Amount";
            // 
            // txtPreBal
            // 
            this.txtPreBal.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreBal.Location = new System.Drawing.Point(296, 432);
            this.txtPreBal.Name = "txtPreBal";
            this.txtPreBal.Size = new System.Drawing.Size(294, 23);
            this.txtPreBal.TabIndex = 110;
            this.txtPreBal.Text = " 0";
            this.txtPreBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 9.75F);
            this.label11.Location = new System.Drawing.Point(165, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 109;
            this.label11.Text = "Previous Balance";
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmt.Location = new System.Drawing.Point(296, 392);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Size = new System.Drawing.Size(294, 23);
            this.txtTotalAmt.TabIndex = 108;
            this.txtTotalAmt.Text = " ";
            this.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 9.75F);
            this.label14.Location = new System.Drawing.Point(165, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 107;
            this.label14.Text = "Total Amount";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1149, 40);
            this.panel5.TabIndex = 632;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images__2_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(34, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(27, 24);
            this.btnBack.TabIndex = 76;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(547, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 28);
            this.label21.TabIndex = 1;
            this.label21.Text = "Bill ";
            // 
            // FrmBillPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1153, 721);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillPay";
            this.Load += new System.EventHandler(this.FrmBillPay_Load);
            this.Shown += new System.EventHandler(this.FrmBillPay_Shown);
            this.panelBack.ResumeLayout(false);
            this.panelFront.ResumeLayout(false);
            this.panelFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBillDetails)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerBillDetails;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtCustYear;
        private System.Windows.Forms.TextBox txtCustMonth;
        private System.Windows.Forms.TextBox txtAbsents;
        private System.Windows.Forms.TextBox txtNewspaper;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtRecieptNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBalAmt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPaidAmt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPreBal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnExport;
    }
}