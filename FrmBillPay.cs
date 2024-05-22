using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBillingApp
{
    public partial class FrmBillPay : Form
    {
        public FrmBillPay()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
        
        private void FrmBillPay_Load(object sender, EventArgs e)
        {
            txtRecieptNo.Text = GenerateNewRandom();
            filldt();
            txtPaidAmt.Focus();
            dgvCustomerBillDetails.Columns[0].Visible = false;
            dgvCustomerBillDetails.Columns[3].Visible = false;
            dgvCustomerBillDetails.Columns[4].Visible = false;
            dgvCustomerBillDetails.Columns[5].Visible = false;
            dgvCustomerBillDetails.Columns[7].Visible = false;
        }

        public static string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 10000).ToString("D4");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;
        }
        public void filldt()
        {
            sql = "Select CustId,CustomerName,MobileNo,NewspaperName,Cmonth,Cyear,GrandTotal,CDate,OldBalance,PaidAmt,Balance from Bills where PaymentStatus=0 and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvCustomerBillDetails.DataSource = ds.Tables[0];

            dgvCustomerBillDetails.Columns[1].Width = 220;
            dgvCustomerBillDetails.Columns[2].Width = 120;
            dgvCustomerBillDetails.Columns[6].Width = 120;
            dgvCustomerBillDetails.Columns[8].Width = 120;
            dgvCustomerBillDetails.Columns[9].Width = 120;
            dgvCustomerBillDetails.Columns[10].Width = 120;
        }

        private void dgvCustomerBillDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelFront.Visible = false;
            panelFront.SendToBack();
            panelBack.BringToFront();
            panelBack.Visible = true;
            txtCustID.Text = dgvCustomerBillDetails.SelectedCells[0].Value.ToString();
            txtCustName.Text = dgvCustomerBillDetails.SelectedCells[1].Value.ToString();
            txtNewspaper.Text = dgvCustomerBillDetails.SelectedCells[2].Value.ToString();
            txtAbsents.Text = dgvCustomerBillDetails.SelectedCells[3].Value.ToString();
            txtCustMonth.Text = dgvCustomerBillDetails.SelectedCells[4].Value.ToString();
            txtCustYear.Text = dgvCustomerBillDetails.SelectedCells[5].Value.ToString();
            txtTotalAmt.Text = dgvCustomerBillDetails.SelectedCells[6].Value.ToString();
            dtpBillDate.Text = dgvCustomerBillDetails.SelectedCells[7].Value.ToString();
            txtPreBal.Text = dgvCustomerBillDetails.SelectedCells[8].Value.ToString();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Bills where CustomerName like '%" + txtSearchCustomer.Text.Trim() + "%' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvCustomerBillDetails.DataSource = ds.Tables[0];
        }

        public void Clear()
        {
            txtRecieptNo.ResetText();
            txtCustMonth.ResetText();
            txtCustID.ResetText();
            txtCustName.ResetText();
            txtNewspaper.ResetText();
            txtAbsents.ResetText();
            txtCustYear.ResetText();
            txtTotalAmt.Text = "0";
            txtPreBal.Text = "0";
            txtPaidAmt.Text = "0";
            txtBalAmt.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            btnPayNow.Enabled = false;

            sql = "Select count(*) from Bills where Cmonth ='" + txtCustMonth.Text.Trim() + "' and Cyear='" + txtCustYear.Text.Trim() + "' and CompanyId ='" + ClassConnection.CompanyID + "'and Id='" + txtCustID.Text.Trim() + "'and PaymentStatus='1'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                MessageBox.Show("Bill Already Paid...");
                return;
            }
            else
            {
                DateTime Today = DateTime.Now;
                sql = "Update Bills set PaymentStatus='1',PaidAmt='" + txtPaidAmt.Text.Trim() + "',Balance='" + txtBalAmt.Text.Trim() + "',PayDate='" + string.Format("{0:dd/MM/yyyy }", Today) + "' where CustId='" + txtCustID.Text.Trim() + "'and CompanyId='" + ClassConnection.CompanyID + "'and Cmonth='" + txtCustMonth.Text.Trim() + "'and Cyear='" + txtCustYear.Text.Trim() + "'";
                objcls.execute(sql);

                string sql1 = "Update CustomerProfiles set OldBalance='" + txtBalAmt.Text.Trim() + "' where Id='" + txtCustID.Text.Trim() + "'and CompanyId='" + ClassConnection.CompanyID + "'and Cyear='" + txtCustYear.Text.Trim() + "'";
                objcls.execute(sql1);
                MessageBox.Show("Bill Paid Successfully..");
            }
                filldt();
                Clear();
                btnPayNow.Enabled = true;
        }

        private void txtPaidAmt_TextChanged(object sender, EventArgs e)
        {
            //double PaidAmt;
            //double TotAmt = Convert.ToDouble(txtTotalAmt.Text);
            //if (txtPaidAmt.Text == "")
            //{
            //    PaidAmt = 0;
            //}
            //else
            //{
            //    PaidAmt = Convert.ToDouble(txtPaidAmt.Text);
            //}
            //double BalanceAmt = TotAmt - PaidAmt;
            //txtBalAmt.Text = Convert.ToString(BalanceAmt);

            double TotAmt = Convert.ToDouble(txtTotalAmt.Text);
            double PaidAmt = Convert.ToDouble(txtPaidAmt.Text);
            double BalanceAmt = TotAmt - PaidAmt;
            txtBalAmt.Text = Convert.ToString(BalanceAmt);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            btnPrintAll.Enabled = false;
            RDLCReport.FrmBillGenrated RDLCAC = new RDLCReport.FrmBillGenrated();
            RDLCAC.TopLevel = false;
            panelBack.Controls.Add(RDLCAC);
            RDLCAC.BringToFront();
            RDLCAC.Show();

            btnPrintAll.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvCustomerBillDetails.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvCustomerBillDetails.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvCustomerBillDetails.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvCustomerBillDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvCustomerBillDetails.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvCustomerBillDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }

        }

        private void FrmBillPay_Shown(object sender, EventArgs e)
        {
            txtSearchCustomer.Focus();
        }
    }
}
