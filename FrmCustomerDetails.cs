using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBillingApp
{
    public partial class FrmCustomerDetails : Form
    {
        public FrmCustomerDetails()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void FrmCustomerDetails_Load(object sender, EventArgs e)
        {
            fillRouteDetails();
            dgvRoute.Columns[1].Width = 250;
            dgvRoute.Columns[3].Width = 235;
            txtSearchCustomer.Focus();
            
        }

        public void fillRouteDetails()
        {
            sql = "Select RouteId,Route,Id,AgentName from AgentMasters where CompanyId='" + ClassConnection.CompanyID + "'"; 
            ds=objcls.fillDs(sql);
            dgvRoute.DataSource = ds.Tables[0];
            dgvRoute.Columns[0].Visible = false;
            dgvRoute.Columns[2].Visible = false;
        }
        public void FillCustomerDetails()
        {
            sql = "Select Id,CustomerName,MobileNo,Address,NewspaperName,CustomerStatus,Pin,NewspaperPlan from CustomerProfiles where Route='" + dgvRoute.SelectedCells[1].Value.ToString() + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvCustomer.DataSource = ds.Tables[0];
            dgvCustomer.Columns[0].Visible = false;
            dgvCustomer.Columns[1].Width = 190;
            dgvCustomer.Columns[2].Width = 130;
            dgvCustomer.Columns[3].Width = 130;
            dgvCustomer.Columns[4].Width = 130;
            dgvCustomer.Columns[5].Width = 130;
            dgvCustomer.Columns[6].Width = 130;
            dgvCustomer.Columns[7].Width = 130;
        }
        private void txtSearchRoute_TextChanged_1(object sender, EventArgs e)
        {
            sql = "Select RouteId,Route,Id,AgentName from AgentMasters where Route like '%" + txtSearchRoute.Text.Trim() + "%' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvRoute.DataSource = ds.Tables[0];
            dgvRoute.Columns[0].Visible = false;
            dgvRoute.Columns[2].Visible = false;
        }
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            sql = "Select Id,CustomerName,MobileNo,Address,NewspaperName,CustomerStatus,Pin,NewspaperPlan from CustomerProfiles where CustomerName like '%" + txtSearchCustomer.Text.Trim() + "%'and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvCustomer.DataSource = ds.Tables[0];
            dgvCustomer.Columns[0].Visible = false;
        }
        private void dgvRoute_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FillCustomerDetails();
            panelFront.SendToBack();
            panelFront.Visible = false;
            panelBack.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FrmCustCalendarReport frmCCR = new FrmCustCalendarReport();
            frmCCR.TopLevel = false;
            panelBack.Controls.Add(frmCCR);
            frmCCR.BringToFront();
            frmCCR.Show();
            //pcLoder.Visible = false;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ClassConnection.CustID = dgvCustomer.SelectedCells[0].Value.ToString();
            //FrmCustCalendarReport CalRep = new FrmCustCalendarReport();
            //CalRep.Show();
            //this.Hide();
            ////panelCust.SendToBack();
            ////panelFront.BringToFront();
            ////panelFront.Visible = true;
            ClassConnection.CustID = dgvCustomer.SelectedCells[0].Value.ToString();
            string custStatus = dgvCustomer.SelectedCells[5].Value.ToString();
            if (custStatus == "Active")
            {
                //pcLoder.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else if (custStatus == "Deactive")
            {
                MessageBox.Show("The Customer will be Deactiveted");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelCust.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCustomerDetails_Shown(object sender, EventArgs e)
        {
            txtSearchRoute.Focus();
        }
    }
}
