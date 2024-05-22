namespace NewspaperBillingApp
{
    partial class FrmDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashbord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newspaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 767);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1324, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 35);
            this.btnClose.TabIndex = 633;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(110)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newspaperToolStripMenuItem,
            this.agentToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.customerListToolStripMenuItem,
            this.billGenerateToolStripMenuItem,
            this.billPayToolStripMenuItem,
            this.billHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newspaperToolStripMenuItem
            // 
            this.newspaperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.newspaperToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newspaperToolStripMenuItem.Name = "newspaperToolStripMenuItem";
            this.newspaperToolStripMenuItem.Size = new System.Drawing.Size(170, 37);
            this.newspaperToolStripMenuItem.Text = "Newspaper";
            this.newspaperToolStripMenuItem.Click += new System.EventHandler(this.newspaperToolStripMenuItem_Click);
            // 
            // agentToolStripMenuItem
            // 
            this.agentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agentToolStripMenuItem.Name = "agentToolStripMenuItem";
            this.agentToolStripMenuItem.Size = new System.Drawing.Size(104, 37);
            this.agentToolStripMenuItem.Text = "Agent";
            this.agentToolStripMenuItem.Click += new System.EventHandler(this.agentToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 37);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(211, 37);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // billGenerateToolStripMenuItem
            // 
            this.billGenerateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.billGenerateToolStripMenuItem.Name = "billGenerateToolStripMenuItem";
            this.billGenerateToolStripMenuItem.Size = new System.Drawing.Size(200, 37);
            this.billGenerateToolStripMenuItem.Text = "Bill Generate";
            this.billGenerateToolStripMenuItem.Click += new System.EventHandler(this.billGenerateToolStripMenuItem_Click);
            // 
            // billPayToolStripMenuItem
            // 
            this.billPayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.billPayToolStripMenuItem.Name = "billPayToolStripMenuItem";
            this.billPayToolStripMenuItem.Size = new System.Drawing.Size(130, 37);
            this.billPayToolStripMenuItem.Text = "Bill Pay";
            this.billPayToolStripMenuItem.Click += new System.EventHandler(this.billPayToolStripMenuItem_Click);
            // 
            // billHistoryToolStripMenuItem
            // 
            this.billHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.billHistoryToolStripMenuItem.Name = "billHistoryToolStripMenuItem";
            this.billHistoryToolStripMenuItem.Size = new System.Drawing.Size(178, 37);
            this.billHistoryToolStripMenuItem.Text = "Bill History";
            this.billHistoryToolStripMenuItem.Click += new System.EventHandler(this.billHistoryToolStripMenuItem_Click);
            // 
            // FrmDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDashbord";
            this.Text = "FrmDashbord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newspaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billGenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billPayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billHistoryToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
    }
}