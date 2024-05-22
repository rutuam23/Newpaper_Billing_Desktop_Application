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
    public partial class FrmPaymentHistory : Form
    {
        public FrmPaymentHistory()
        {
            InitializeComponent();
        }
        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;

        private void FrmPaymentHistory_Load(object sender, EventArgs e)
        {
            filldt();
            txtSearchCustomer.Focus();
            txtName.Focus();
            dgvPaymentlist.Columns[0].Visible = false;
            dgvPaymentlist.Columns[1].Visible = false;
           
        }
        public void filldt()
        {
            sql = "select CustId,CDate,CustomerName,MobileNo,Address,Cmonth,PaidAmt,GrandTotal,Balance from Bills where CompanyId='" + ClassConnection.CompanyID + "' and CustomerStatus='Active'";
            ds = objcls.fillDs(sql);
            dgvPaymentlist.DataSource = ds.Tables[0];
            dgvPaymentlist.Columns[2].Width = 150;
            dgvPaymentlist.Columns[3].Width = 100;
            dgvPaymentlist.Columns[4].Width = 100;
            dgvPaymentlist.Columns[5].Width = 100;
            dgvPaymentlist.Columns[6].Width = 100;
        }

        private void dgvPaymentlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelFront.Visible = false;
            panelFront.SendToBack();
            panelBack.BringToFront();
            panelBack.Visible = true;
            txtName.TabIndex = 0; ;
            txtName.Focus();
            txtCustId.Text = dgvPaymentlist.SelectedCells[0].Value.ToString();
            txtName.Text = dgvPaymentlist.SelectedCells[2].Value.ToString();
            txtNumber.Text = dgvPaymentlist.SelectedCells[3].Value.ToString();
            sql = "Select CustId,CDate,Cmonth,PaidAmt from Bills where CustId='" + txtCustId.Text.Trim() + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvPaymentDetails.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvPaymentDetails.Rows.Add();
                dgvPaymentDetails.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                dgvPaymentDetails.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                dgvPaymentDetails.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[3].ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
            this.Close();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            sql = "select CustId,CDate,CustomerName,MobileNo,Address,Cmonth,PaidAmt from Bills where CustomerName like '%" + txtSearchCustomer.Text.Trim() + "%'  and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvPaymentlist.DataSource = ds.Tables[0];
        }

        private void btnPrintAll_Click_1(object sender, EventArgs e)
        {
            btnPrintAll.Enabled = false;
            RDLCReport.FrmPaymentHistory RDLCAC = new RDLCReport.FrmPaymentHistory();
            RDLCAC.TopLevel = false;
            panelPaymentHistory.Controls.Add(RDLCAC);
            RDLCAC.BringToFront();
            RDLCAC.Show();

            btnPrintAll.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            if (dgvPaymentlist.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvPaymentlist.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvPaymentlist.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvPaymentlist.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPaymentlist.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvPaymentlist.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
            btnExport.Enabled = true;
        }

        private void FrmPaymentHistory_Shown(object sender, EventArgs e)
        {
            txtSearchCustomer.Focus();
        }
    }
}
