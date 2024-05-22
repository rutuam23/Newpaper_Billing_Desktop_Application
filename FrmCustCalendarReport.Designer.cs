namespace NewspaperBillingApp
{
    partial class FrmCustCalendarReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseNew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvCustCalendarReport = new System.Windows.Forms.DataGridView();
            this.btnPlanVaccation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustCalendarReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvCustCalendarReport);
            this.panel1.Controls.Add(this.btnPlanVaccation);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 721);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btnCloseNew);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 40);
            this.panel2.TabIndex = 640;
            // 
            // btnCloseNew
            // 
            this.btnCloseNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseNew.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseNew.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images__3_;
            this.btnCloseNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseNew.FlatAppearance.BorderSize = 0;
            this.btnCloseNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNew.Location = new System.Drawing.Point(1107, 7);
            this.btnCloseNew.Name = "btnCloseNew";
            this.btnCloseNew.Size = new System.Drawing.Size(32, 25);
            this.btnCloseNew.TabIndex = 638;
            this.btnCloseNew.UseVisualStyleBackColor = false;
            this.btnCloseNew.Click += new System.EventHandler(this.btnCloseNew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(480, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "News Bill Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.daycontainer);
            this.panel3.Location = new System.Drawing.Point(438, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 266);
            this.panel3.TabIndex = 87;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel9.Controls.Add(this.btnNextMonth);
            this.panel9.Controls.Add(this.lblDate);
            this.panel9.Controls.Add(this.btnPreviousMonth);
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(283, 34);
            this.panel9.TabIndex = 14;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.Location = new System.Drawing.Point(236, 6);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(36, 24);
            this.btnNextMonth.TabIndex = 6;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(74, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(133, 21);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Month Year";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.BackColor = System.Drawing.Color.DarkGray;
            this.btnPreviousMonth.Location = new System.Drawing.Point(6, 6);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(35, 24);
            this.btnPreviousMonth.TabIndex = 4;
            this.btnPreviousMonth.Text = "<";
            this.btnPreviousMonth.UseVisualStyleBackColor = false;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sun";
            // 
            // daycontainer
            // 
            this.daycontainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daycontainer.Location = new System.Drawing.Point(0, 74);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(285, 187);
            this.daycontainer.TabIndex = 5;
            // 
            // dgvCustCalendarReport
            // 
            this.dgvCustCalendarReport.AllowUserToAddRows = false;
            this.dgvCustCalendarReport.AllowUserToDeleteRows = false;
            this.dgvCustCalendarReport.AllowUserToResizeRows = false;
            this.dgvCustCalendarReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustCalendarReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustCalendarReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustCalendarReport.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustCalendarReport.Location = new System.Drawing.Point(340, 384);
            this.dgvCustCalendarReport.Name = "dgvCustCalendarReport";
            this.dgvCustCalendarReport.RowHeadersVisible = false;
            this.dgvCustCalendarReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustCalendarReport.Size = new System.Drawing.Size(485, 316);
            this.dgvCustCalendarReport.TabIndex = 86;
            // 
            // btnPlanVaccation
            // 
            this.btnPlanVaccation.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlanVaccation.BackgroundImage = global::NewspaperBillingApp.Properties.Resources.images_removebg_preview1;
            this.btnPlanVaccation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlanVaccation.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPlanVaccation.FlatAppearance.BorderSize = 0;
            this.btnPlanVaccation.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPlanVaccation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnPlanVaccation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanVaccation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanVaccation.ForeColor = System.Drawing.Color.White;
            this.btnPlanVaccation.Location = new System.Drawing.Point(489, 315);
            this.btnPlanVaccation.Name = "btnPlanVaccation";
            this.btnPlanVaccation.Size = new System.Drawing.Size(188, 67);
            this.btnPlanVaccation.TabIndex = 85;
            this.btnPlanVaccation.Text = "Plan Vaccation";
            this.btnPlanVaccation.UseVisualStyleBackColor = false;
            this.btnPlanVaccation.Click += new System.EventHandler(this.btnPlanVaccation_Click);
            // 
            // FrmCustCalendarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 721);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustCalendarReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustCalendarReport";
            this.Load += new System.EventHandler(this.FrmCustCalendarReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustCalendarReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustCalendarReport;
        private System.Windows.Forms.Button btnPlanVaccation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCloseNew;
    }
}