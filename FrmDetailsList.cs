using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBillingApp

{
    public partial class FrmDetailsList : Form
    {

        string formnm = "";

        public FrmDetailsList(string FormName)
        {
            InitializeComponent();
            formnm = FormName;
        }
        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;

        int cnt;

        private void FrmDetailsList_Load(object sender, EventArgs e)
        {
            FillData();
            //dgvActive.Columns[0].Visible = false;
            //dgvDeactive.Columns[0].Visible = false;
            //dgvPaidAmt.Columns[0].Visible = false;
            //dgvBalanceAmt.Columns[0].Visible = false;
            //dgvTotalAmt.Columns[0].Visible = false;
            
        }

        public void SelectActiveCust()
        {
            sql = "Select * from CustomerProfiles where CustomerStatus ='Active' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvActive.DataSource = ds.Tables[0];

            dgvActive.Columns[0].Visible = false;
            dgvActive.Columns[7].Visible = false;
            dgvActive.Columns[9].Visible = false;
            dgvActive.Columns[10].Visible = false;
            dgvActive.Columns[11].Visible = false;
            dgvActive.Columns[15].Visible = false;
            dgvActive.Columns[20].Visible = false;
            dgvActive.Columns[22].Visible = false;
            dgvActive.Columns[23].Visible = false;
        }
        public void SelectDeactiveCust()
        {
            sql = "Select * from CustomerProfiles where CustomerStatus ='Deactive' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvDeactive.DataSource = ds.Tables[0];

            dgvDeactive.Columns[0].Visible = false;
            dgvDeactive.Columns[7].Visible = false;
            dgvDeactive.Columns[9].Visible = false;
            dgvDeactive.Columns[10].Visible = false;
            dgvDeactive.Columns[11].Visible = false;
            dgvDeactive.Columns[15].Visible = false;
            dgvDeactive.Columns[20].Visible = false;
            dgvDeactive.Columns[22].Visible = false;
            dgvDeactive.Columns[23].Visible = false;
        }

        public void PaidAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);

            sql = "Select * from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvPaidAmt.DataSource = ds.Tables[0];

            dgvPaidAmt.Columns[0].Visible = false;
            dgvPaidAmt.Columns[1].Visible = false;
            dgvPaidAmt.Columns[7].Visible = false;
            dgvPaidAmt.Columns[9].Visible = false;
            dgvPaidAmt.Columns[10].Visible = false;
            dgvPaidAmt.Columns[11].Visible = false;
            dgvPaidAmt.Columns[15].Visible = false;
            dgvPaidAmt.Columns[20].Visible = false;
            dgvPaidAmt.Columns[22].Visible = false;
            dgvPaidAmt.Columns[23].Visible = false;
        }

        public void BalanceAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);

            sql = "Select * from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvBalanceAmt.DataSource = ds.Tables[0];

            dgvBalanceAmt.Columns[0].Visible = false;
            dgvBalanceAmt.Columns[1].Visible = false;
            dgvBalanceAmt.Columns[7].Visible = false;
            dgvBalanceAmt.Columns[9].Visible = false;
            dgvBalanceAmt.Columns[10].Visible = false;
            dgvBalanceAmt.Columns[11].Visible = false;
            dgvBalanceAmt.Columns[15].Visible = false;
            dgvBalanceAmt.Columns[20].Visible = false;
            dgvBalanceAmt.Columns[22].Visible = false;
            dgvBalanceAmt.Columns[23].Visible = false;
        }

        public void TotalAmt()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);

            sql = "Select * from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvTotalAmt.DataSource = ds.Tables[0];

            dgvTotalAmt.Columns[0].Visible = false;
            dgvTotalAmt.Columns[1].Visible = false;
            dgvTotalAmt.Columns[7].Visible = false;
            dgvTotalAmt.Columns[9].Visible = false;
            dgvTotalAmt.Columns[10].Visible = false;
            dgvTotalAmt.Columns[11].Visible = false;
            dgvTotalAmt.Columns[15].Visible = false;
            dgvTotalAmt.Columns[20].Visible = false;
            dgvTotalAmt.Columns[22].Visible = false;
            dgvTotalAmt.Columns[23].Visible = false;
        }


        public void FillData()
        {
            if (formnm == "pnlActive")
            {
                pnlActive.BringToFront();
                pnlActive.Visible = true;
                SelectActiveCust();
            }
           else if (formnm == "pnlDeactive")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.BringToFront();
                pnlDeactiveCust.Visible = true;
                SelectDeactiveCust();
            }
            else if (formnm == "pnlTotalAmt")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.SendToBack();
                pnlDeactiveCust.Visible = false;
                pnlTotalAmt.BringToFront();
                pnlTotalAmt.Visible = true;
                TotalAmt();
            }
            else if (formnm == "pnlPaidAmt")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.SendToBack();
                pnlDeactiveCust.Visible = false;
                pnlTotalAmt.SendToBack();
                pnlTotalAmt.Visible = false;
                PnlPaidAmount.BringToFront();
                PaidAmount();
            }

            else if (formnm == "pnlBalanceAmt")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.SendToBack();
                pnlDeactiveCust.Visible = false;
                pnlTotalAmt.SendToBack();
                pnlTotalAmt.Visible = false;
                PnlPaidAmount.SendToBack();
                PnlPaidAmount.Visible = false;
                PnlBalanceAmt.BringToFront();
                BalanceAmount();
            }       
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
