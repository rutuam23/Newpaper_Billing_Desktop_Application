namespace NewspaperBillingApp
{
    partial class FrmAddCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCustomer));
            this.panelAddCustomer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAddCustomers = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNewspaperRate = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCustPin = new System.Windows.Forms.TextBox();
            this.txtRouteId = new System.Windows.Forms.TextBox();
            this.dtpCustDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.dgvNewspaper = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Newspaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMonthYear = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNewspaper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustBalance = new System.Windows.Forms.TextBox();
            this.cmbCustStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnAddNewspaper = new System.Windows.Forms.Button();
            this.panelAddCustomer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewspaper)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddCustomer
            // 
            this.panelAddCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.panelAddCustomer.Controls.Add(this.panel5);
            this.panelAddCustomer.Controls.Add(this.panel2);
            this.panelAddCustomer.ForeColor = System.Drawing.Color.White;
            this.panelAddCustomer.Location = new System.Drawing.Point(1, 0);
            this.panelAddCustomer.Name = "panelAddCustomer";
            this.panelAddCustomer.Size = new System.Drawing.Size(1148, 720);
            this.panelAddCustomer.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1146, 40);
            this.panel5.TabIndex = 640;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(499, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Add Customer";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.dgvAddCustomers);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.txtNewspaperRate);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtCustPin);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnremove);
            this.panel2.Controls.Add(this.txtRouteId);
            this.panel2.Controls.Add(this.dtpCustDate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtRoute);
            this.panel2.Controls.Add(this.dgvNewspaper);
            this.panel2.Controls.Add(this.cmbMonthYear);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbAgent);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnAddNewspaper);
            this.panel2.Controls.Add(this.cmbNewspaper);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbDays);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCustAddress);
            this.panel2.Controls.Add(this.txtCustPhone);
            this.panel2.Controls.Add(this.txtCustBalance);
            this.panel2.Controls.Add(this.cmbCustStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCustName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtRemark);
            this.panel2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 677);
            this.panel2.TabIndex = 768;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvAddCustomers
            // 
            this.dgvAddCustomers.AllowUserToAddRows = false;
            this.dgvAddCustomers.AllowUserToDeleteRows = false;
            this.dgvAddCustomers.AllowUserToResizeColumns = false;
            this.dgvAddCustomers.AllowUserToResizeRows = false;
            this.dgvAddCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddCustomers.Location = new System.Drawing.Point(50, 322);
            this.dgvAddCustomers.Name = "dgvAddCustomers";
            this.dgvAddCustomers.RowHeadersVisible = false;
            this.dgvAddCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddCustomers.Size = new System.Drawing.Size(1045, 271);
            this.dgvAddCustomers.TabIndex = 797;
            this.dgvAddCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddCustomers_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(591, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 18);
            this.label15.TabIndex = 796;
            this.label15.Text = "Remark";
            // 
            // txtNewspaperRate
            // 
            this.txtNewspaperRate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewspaperRate.Location = new System.Drawing.Point(16, 39);
            this.txtNewspaperRate.Name = "txtNewspaperRate";
            this.txtNewspaperRate.Size = new System.Drawing.Size(13, 23);
            this.txtNewspaperRate.TabIndex = 791;
            this.txtNewspaperRate.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(10, 25);
            this.txtID.TabIndex = 794;
            this.txtID.Visible = false;
            // 
            // txtCustPin
            // 
            this.txtCustPin.Location = new System.Drawing.Point(9, 13);
            this.txtCustPin.Name = "txtCustPin";
            this.txtCustPin.Size = new System.Drawing.Size(20, 25);
            this.txtCustPin.TabIndex = 792;
            this.txtCustPin.Visible = false;
            // 
            // txtRouteId
            // 
            this.txtRouteId.Location = new System.Drawing.Point(1088, 91);
            this.txtRouteId.Name = "txtRouteId";
            this.txtRouteId.Size = new System.Drawing.Size(20, 25);
            this.txtRouteId.TabIndex = 793;
            this.txtRouteId.Visible = false;
            // 
            // dtpCustDate
            // 
            this.dtpCustDate.Location = new System.Drawing.Point(756, 237);
            this.dtpCustDate.Name = "dtpCustDate";
            this.dtpCustDate.Size = new System.Drawing.Size(316, 25);
            this.dtpCustDate.TabIndex = 790;
            this.dtpCustDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpCustDate_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(590, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 789;
            this.label11.Text = "Customer Date";
            // 
            // txtRoute
            // 
            this.txtRoute.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoute.Location = new System.Drawing.Point(751, 92);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(321, 23);
            this.txtRoute.TabIndex = 788;
            this.txtRoute.Text = " ";
            this.txtRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoute_KeyDown);
            // 
            // dgvNewspaper
            // 
            this.dgvNewspaper.AllowUserToAddRows = false;
            this.dgvNewspaper.AllowUserToDeleteRows = false;
            this.dgvNewspaper.AllowUserToResizeRows = false;
            this.dgvNewspaper.BackgroundColor = System.Drawing.Color.White;
            this.dgvNewspaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewspaper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNewspaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewspaper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Newspaper,
            this.Day,
            this.Price});
            this.dgvNewspaper.Location = new System.Drawing.Point(204, 193);
            this.dgvNewspaper.Name = "dgvNewspaper";
            this.dgvNewspaper.RowHeadersVisible = false;
            this.dgvNewspaper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewspaper.Size = new System.Drawing.Size(321, 115);
            this.dgvNewspaper.TabIndex = 787;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.Visible = false;
            // 
            // Newspaper
            // 
            this.Newspaper.FillWeight = 120F;
            this.Newspaper.HeaderText = "Newspaper";
            this.Newspaper.Name = "Newspaper";
            this.Newspaper.Width = 120;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // cmbMonthYear
            // 
            this.cmbMonthYear.DisplayMember = "RouteName";
            this.cmbMonthYear.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonthYear.FormattingEnabled = true;
            this.cmbMonthYear.Items.AddRange(new object[] {
            "1 year",
            "6 month",
            "3 month",
            "1 month"});
            this.cmbMonthYear.Location = new System.Drawing.Point(751, 18);
            this.cmbMonthYear.Name = "cmbMonthYear";
            this.cmbMonthYear.Size = new System.Drawing.Size(321, 24);
            this.cmbMonthYear.TabIndex = 786;
            this.cmbMonthYear.ValueMember = "Id";
            this.cmbMonthYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMonthYear_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(590, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 785;
            this.label13.Text = "Month/Year";
            // 
            // cmbAgent
            // 
            this.cmbAgent.DisplayMember = "AgentName";
            this.cmbAgent.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(751, 55);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(321, 24);
            this.cmbAgent.TabIndex = 784;
            this.cmbAgent.ValueMember = "Id";
            this.cmbAgent.SelectedIndexChanged += new System.EventHandler(this.cmbAgent_SelectedIndexChanged);
            this.cmbAgent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAgent_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(590, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 783;
            this.label12.Text = "Enter Agent";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(123, 285);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(75, 23);
            this.txtAmount.TabIndex = 782;
            this.txtAmount.Text = " ";
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(65, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 781;
            this.label7.Text = "Amount";
            // 
            // cmbNewspaper
            // 
            this.cmbNewspaper.DisplayMember = "NewspaperName";
            this.cmbNewspaper.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewspaper.ForeColor = System.Drawing.Color.Black;
            this.cmbNewspaper.FormattingEnabled = true;
            this.cmbNewspaper.Location = new System.Drawing.Point(204, 159);
            this.cmbNewspaper.Name = "cmbNewspaper";
            this.cmbNewspaper.Size = new System.Drawing.Size(321, 24);
            this.cmbNewspaper.TabIndex = 779;
            this.cmbNewspaper.ValueMember = "Id";
            this.cmbNewspaper.SelectedIndexChanged += new System.EventHandler(this.cmbNewspaper_SelectedIndexChanged);
            this.cmbNewspaper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNewspaper_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(65, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 778;
            this.label6.Text = "Newspaper";
            // 
            // cmbDays
            // 
            this.cmbDays.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDays.DisplayMember = "RouteName";
            this.cmbDays.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDays.ForeColor = System.Drawing.Color.Black;
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "All Days",
            "Monday",
            "Tuesday",
            "Wednesday",
            "thursday",
            "friday",
            "Saturday",
            "Sunday"});
            this.cmbDays.Location = new System.Drawing.Point(204, 123);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(321, 24);
            this.cmbDays.TabIndex = 777;
            this.cmbDays.ValueMember = "Id";
            this.cmbDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDays_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(65, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 776;
            this.label5.Text = "Select Days";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCustAddress.Location = new System.Drawing.Point(204, 87);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(321, 23);
            this.txtCustAddress.TabIndex = 775;
            this.txtCustAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustAddress_KeyDown);
            this.txtCustAddress.Leave += new System.EventHandler(this.txtCustAddress_Leave);
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCustPhone.Location = new System.Drawing.Point(204, 55);
            this.txtCustPhone.MaxLength = 10;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(321, 23);
            this.txtCustPhone.TabIndex = 774;
            this.txtCustPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustPhone_KeyDown);
            this.txtCustPhone.Leave += new System.EventHandler(this.txtCustPhone_Leave);
            // 
            // txtCustBalance
            // 
            this.txtCustBalance.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustBalance.Location = new System.Drawing.Point(754, 201);
            this.txtCustBalance.Name = "txtCustBalance";
            this.txtCustBalance.Size = new System.Drawing.Size(318, 23);
            this.txtCustBalance.TabIndex = 773;
            this.txtCustBalance.Text = " 0";
            this.txtCustBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustBalance_KeyDown);
            // 
            // cmbCustStatus
            // 
            this.cmbCustStatus.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustStatus.FormattingEnabled = true;
            this.cmbCustStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cmbCustStatus.Location = new System.Drawing.Point(751, 164);
            this.cmbCustStatus.Name = "cmbCustStatus";
            this.cmbCustStatus.Size = new System.Drawing.Size(321, 24);
            this.cmbCustStatus.TabIndex = 772;
            this.cmbCustStatus.Text = "Select Status";
            this.cmbCustStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustStatus_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(588, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 18);
            this.label9.TabIndex = 768;
            this.label9.Text = "Customer OldBalance";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.ForeColor = System.Drawing.Color.Black;
            this.txtCustName.Location = new System.Drawing.Point(204, 20);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(321, 23);
            this.txtCustName.TabIndex = 770;
            this.txtCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustName_KeyDown);
            this.txtCustName.Leave += new System.EventHandler(this.txtCustName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 764;
            this.label2.Text = "Customer Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(590, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 767;
            this.label8.Text = "Customer Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 763;
            this.label1.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(65, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 765;
            this.label3.Text = "Customer Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(590, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 766;
            this.label4.Text = "Enter Route";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(751, 128);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(321, 23);
            this.txtRemark.TabIndex = 771;
            this.txtRemark.Text = " ";
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images__3_1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1098, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 637;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(843, 597);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 58);
            this.btnExport.TabIndex = 799;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(709, 597);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 58);
            this.btnPrint.TabIndex = 798;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(575, 599);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 58);
            this.btnDelete.TabIndex = 770;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(307, 599);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 58);
            this.btnEdit.TabIndex = 769;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(441, 599);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(119, 58);
            this.btnNew.TabIndex = 768;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(173, 598);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 58);
            this.btnAdd.TabIndex = 767;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnremove.BackgroundImage")));
            this.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Location = new System.Drawing.Point(556, 162);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(22, 21);
            this.btnremove.TabIndex = 795;
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnAddNewspaper
            // 
            this.btnAddNewspaper.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images__4_1;
            this.btnAddNewspaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewspaper.FlatAppearance.BorderSize = 0;
            this.btnAddNewspaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewspaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewspaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewspaper.Location = new System.Drawing.Point(529, 161);
            this.btnAddNewspaper.Name = "btnAddNewspaper";
            this.btnAddNewspaper.Size = new System.Drawing.Size(21, 21);
            this.btnAddNewspaper.TabIndex = 780;
            this.btnAddNewspaper.UseVisualStyleBackColor = true;
            this.btnAddNewspaper.Click += new System.EventHandler(this.btnAddNewspaper_Click);
            this.btnAddNewspaper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddNewspaper_KeyDown);
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1150, 721);
            this.Controls.Add(this.panelAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCustomer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCustomer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.Shown += new System.EventHandler(this.FrmAddCustomer_Shown);
            this.panelAddCustomer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewspaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpCustDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.DataGridView dgvNewspaper;
        private System.Windows.Forms.ComboBox cmbMonthYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddNewspaper;
        private System.Windows.Forms.ComboBox cmbNewspaper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustBalance;
        private System.Windows.Forms.ComboBox cmbCustStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtNewspaperRate;
        private System.Windows.Forms.TextBox txtCustPin;
        private System.Windows.Forms.TextBox txtRouteId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Newspaper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvAddCustomers;
    }
}