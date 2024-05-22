using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBillingApp
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
       
        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            filldt();
            FillNewspaper();
            FillAgent();
            txtCustPin.Text=GenerateNewRandom();
            Clear();
            btnEdit.Enabled = false;

            dgvAddCustomers.Columns[0].Visible = false;
            dgvAddCustomers.Columns[7].Visible = false;
            dgvAddCustomers.Columns[9].Visible = false;
            dgvAddCustomers.Columns[10].Visible = false;
            dgvAddCustomers.Columns[15].Visible = false;
            dgvAddCustomers.Columns[16].Visible = false;
            dgvAddCustomers.Columns[17].Visible = false;
            dgvAddCustomers.Columns[18].Visible = false;
            dgvAddCustomers.Columns[19].Visible = false;
            dgvAddCustomers.Columns[20].Visible = false;
            dgvAddCustomers.Columns[22].Visible = false;
            dgvAddCustomers.Columns[23].Visible = false;
           
        }

        public static string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;
        }

        public void FillNewspaper()
        {
            sql = "Select NewspaperName from NewspaperMasters where CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            cmbNewspaper.DataSource = ds.Tables[0];
            cmbNewspaper.SelectedIndex = -1;
            dgvNewspaper.Columns[0].Visible = false;
        }

        public void FillNewspaperWiseRate()
        {
            sql = "Select Rate from NewspaperMasters where NewspaperName='" + cmbNewspaper.Text.Trim() + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                double Rate = Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[0].ToString()));
                txtNewspaperRate.Text = Convert.ToString(Rate);
            }
        }

        public void FillAgent()
        {
            sql = "Select Id,AgentName from AgentMasters where CompanyId='" + ClassConnection.CompanyID + "'";
            ds=objcls.fillDs(sql);
            cmbAgent.DataSource = ds.Tables[0];
            cmbAgent.SelectedIndex = -1;
        }
        public void FillAgentWiseRoute()
        {
            sql = "Select RouteId,Route from AgentMasters where AgentName='" + cmbAgent.Text+"'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtRouteId.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                txtRoute.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            }
        }

        public void ClearNewspaperGrid()
        {
            cmbNewspaper.ResetText();
            cmbDays.ResetText();
            txtNewspaperRate.ResetText();
        }

        public void CalNewspaperTotal()
        {
            decimal sum = 0;
            for (int i = 0; i <= dgvNewspaper.Rows.Count - 1; i++)
            {
                sum = sum + Convert.ToDecimal(dgvNewspaper.Rows[i].Cells[3].Value.ToString());
            }
            txtAmount.Text = sum.ToString();
        }

        public void filldt()
        {
            sql = "select * from CustomerProfiles where CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvAddCustomers.DataSource = ds.Tables[0];
            dgvAddCustomers.Columns[1].Width = 150;
            dgvAddCustomers.Columns[3].Width = 130;
            dgvAddCustomers.Columns[4].Width = 130;
            dgvAddCustomers.Columns[5].Width = 130;
            dgvAddCustomers.Columns[6].Width = 100;
            dgvAddCustomers.Columns[8].Width = 80;
            dgvAddCustomers.Columns[11].Width = 80;
            dgvAddCustomers.Columns[12].Width = 140;
            dgvAddCustomers.Columns[14].Width = 80;
        }

        private void cmbNewspaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNewspaperWiseRate();

        }
        private void cmbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAgentWiseRoute();
        }

        public void Clear()
        {
            txtID.ResetText();
            txtCustName.ResetText();
            txtCustPhone.ResetText();
            txtCustAddress.ResetText();
            txtNewspaperRate.ResetText();
            cmbNewspaper.ResetText();
            dgvNewspaper.Rows.Clear();
            cmbDays.ResetText();
            txtAmount.ResetText();
            cmbMonthYear.ResetText();
            cmbAgent.ResetText();
            txtRoute.ResetText();
            txtRouteId.ResetText();
            txtRemark.ResetText();
            cmbCustStatus.ResetText();
            txtCustBalance.ResetText();
            dtpCustDate.ResetText();
        }


        private void btnAddNewspaper_Click(object sender, EventArgs e)
        {
            if (cmbDays.Text=="")
            {
                MessageBox.Show("Select a Days..");
                return;
            }
            if (cmbNewspaper.Text == "")
            {
                MessageBox.Show("Select a Newspaper..");
                return;
            }
            if (txtNewspaperRate.Text == "")
            {
                MessageBox.Show("Enter Rate..");
                return;
            }
            Boolean found=false;
            for (int i = 0; i <dgvNewspaper.Rows.Count; i++)
            {
                if (dgvNewspaper.Rows[dgvNewspaper.Rows.Count - 1].Cells[1].Value == cmbNewspaper.Text)
                {
                    found = true;
                    MessageBox.Show("Row already exists");
                    break;
                }
            }
            if (!found)
            {
                dgvNewspaper.Rows.Add();
                dgvNewspaper.Rows[dgvNewspaper.Rows.Count - 1].Cells[0].Value = (dgvNewspaper.Rows.Count - 1) + 1;
                dgvNewspaper.Rows[dgvNewspaper.Rows.Count - 1].Cells[1].Value = cmbNewspaper.Text;
                dgvNewspaper.Rows[dgvNewspaper.Rows.Count - 1].Cells[2].Value = cmbDays.Text;
                dgvNewspaper.Rows[dgvNewspaper.Rows.Count - 1].Cells[3].Value = txtNewspaperRate.Text;
                CalNewspaperTotal();
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            dgvNewspaper.Rows.RemoveAt(dgvNewspaper.CurrentRow.Index);

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string NewspaperName = "";
            string NewspaperRate = "";
            int NewspaperQty = 0;
            string MultipleNewspaper = "";
            string SelectedDays = "";

            if (txtCustName.Text == "")
            {
                MessageBox.Show("Enter Customer Name");
                return;
            }
            if (txtCustPhone.Text == "")
            {
                MessageBox.Show("Enter Customer Phone");
                return;
            }
            if (txtCustAddress.Text == "")
            {
                MessageBox.Show("Enter Customer Addresss");
                return;
            }
            if (cmbDays.Text == "")
            {
                MessageBox.Show("Select Days");
                return;
            }
            if (cmbNewspaper.Text == "")
            {
                MessageBox.Show("Select Newspaper");
                return;
            }
            if (cmbMonthYear.Text == "")
            {
                MessageBox.Show("Select Month/Year");
                return;
            }
            if (cmbAgent.Text == "")
            {
                MessageBox.Show("Select Agent");
                return;
            }
            if (cmbCustStatus.Text == "")
            {
                MessageBox.Show("Select Status");
                return;
            }

            string CustDate = string.Format("{0:dd/MM/yyyy}", dtpCustDate.Value.ToString());
            DateTime datevalue = Convert.ToDateTime(CustDate);
            string CDay = datevalue.Day.ToString();
            string CMonth = datevalue.Month.ToString();
            string Cyear = datevalue.Year.ToString();

            for (int i = 0; i < dgvNewspaper.Rows.Count; i++)
            {
                 NewspaperQty = dgvNewspaper.Rows.Count;

                if (NewspaperName == "")
                {
                    NewspaperName = dgvNewspaper.Rows[i].Cells[1].Value.ToString();
                }
                else
                {
                    NewspaperName = NewspaperName + "," + dgvNewspaper.Rows[i].Cells[1].Value.ToString();
                }
                if (NewspaperRate == "")
                {
                    NewspaperRate = dgvNewspaper.Rows[i].Cells[3].Value.ToString();
                }
                else
                {
                    NewspaperRate = NewspaperRate + "," + dgvNewspaper.Rows[i].Cells[3].Value.ToString();
                }
                if(MultipleNewspaper=="")
                {
                    MultipleNewspaper = dgvNewspaper.Rows[i].Cells[2].Value.ToString()+"-"+ dgvNewspaper.Rows[i].Cells[1].Value.ToString()+"-"+ dgvNewspaper.Rows[i].Cells[3].Value.ToString();
                }
                else
                {
                    MultipleNewspaper = MultipleNewspaper + "," + dgvNewspaper.Rows[i].Cells[2].Value.ToString() + "-" + dgvNewspaper.Rows[i].Cells[1].Value.ToString() + "-" + dgvNewspaper.Rows[i].Cells[3].Value.ToString();
                }
                if (SelectedDays == "")
                {
                    SelectedDays = dgvNewspaper.Rows[i].Cells[2].Value.ToString();
                }
                else
                {
                    SelectedDays = SelectedDays + "," + dgvNewspaper.Rows[i].Cells[2].Value.ToString();
                }
            }

            sql = "Insert into CustomerProfiles(CustomerName,MobileNo,Address,NewspaperName,NewspaperRate,AgentName,AgentID,Cday,Cmonth,Cyear,CustomerStatus,OldBalance,RegDate,Pin,NewspaperPlan,NewspaperQty,TotalAmt,MultiNewspaperName,CompanyId,Route,RouteId,SelectedDays)values('" + txtCustName.Text.Trim() + "','" + txtCustPhone.Text.Trim() + "','" + txtCustAddress.Text.Trim() + "','" + NewspaperName + "','" + NewspaperRate + "','" + cmbAgent.Text.Trim() + "','" + cmbAgent.SelectedValue.ToString() + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + cmbCustStatus.Text.Trim() + "','" + txtCustBalance.Text.Trim() + "','" + dtpCustDate.Text.Trim() + "','" + txtCustPin.Text.Trim() + "','" + cmbMonthYear.Text.Trim() + "','"+ NewspaperQty + "','" + txtAmount.Text.Trim() + "','" + MultipleNewspaper + "','" + ClassConnection.CompanyID + "','" + txtRoute.Text.Trim() + "','" + txtRouteId.Text.Trim() + "','" + SelectedDays + "')";
            objcls.execute(sql);
            MessageBox.Show("Add Customer Successfully...");
            filldt();
            Clear();
            txtCustName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string CustDate = string.Format("{0:dd/MM/yyyy}", dtpCustDate.Value.ToString());
            DateTime datevalue = Convert.ToDateTime(CustDate);
            string CDay = datevalue.Day.ToString();
            string CMonth = datevalue.Month.ToString();
            string Cyear = datevalue.Year.ToString();

            sql = "Update CustomerProfiles set CustomerName='" + txtCustName.Text.Trim() + "',MobileNo='" + txtCustPhone.Text.Trim() + "',Address='"+txtCustAddress.Text.Trim() + "',NewspaperName='"+cmbNewspaper.Text.Trim() + "',NewspaperRate='"+txtNewspaperRate.Text.Trim() + "',AgentName='"+cmbAgent.Text.Trim() + "',AgentID='"+cmbAgent.SelectedValue+ "',Remark='"+txtRemark.Text.Trim() + "',Cday='"+ CDay + "',Cmonth='"+CMonth+ "',Cyear='"+Cyear+ "',CustomerStatus='"+cmbCustStatus.Text.Trim() + "',OldBalance='"+txtCustBalance.Text.Trim() + "',RegDate='"+dtpCustDate.Text.Trim() + "',Pin='"+txtCustPin.Text.Trim() + "',NewspaperPlan='"+cmbMonthYear.Text.Trim() + "',TotalAmt='"+txtAmount.Text.Trim() + "',MultiNewspaperName='"+cmbDays.Text.Trim() + "',CompanyId='"+ClassConnection.CompanyID+ "',Route='"+txtRoute.Text.Trim() + "',RouteId='"+txtRouteId.Text.Trim() + "',SelectedDays='"+cmbDays.Text.Trim() + "' where  Id='" + txtID.Text.Trim() + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            objcls.execute(sql);
            MessageBox.Show("Updated Successfully....");
            filldt();
            Clear();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            txtCustName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "Delete from CustomerProfiles where Id='" + txtID.Text.Trim() + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            objcls.execute(sql);
            MessageBox.Show("Delete Successfully....");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustPhone.Focus();
            }
        }

        private void txtCustPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustAddress.Focus();
            }
        }

        private void txtCustAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDays.Focus();
            }
        }

        private void cmbDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbNewspaper.Focus();
            }
        }

        private void cmbNewspaper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewspaper.Focus();
            }
        }
        private void btnAddNewspaper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmount.Focus();
            }
        }
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbMonthYear.Focus();
            }
        }

        private void cmbMonthYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbAgent.Focus();
            }
        }

        private void cmbAgent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRoute.Focus();
            }
        }

        private void txtRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemark.Focus();
            }
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCustStatus.Focus();
            }
        }
        private void cmbCustStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustBalance.Focus();
            }
        }

        private void txtCustBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpCustDate.Focus();
            }
        }

        private void dtpCustDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void txtCustName_Leave(object sender, EventArgs e)
        {
            if(txtCustName.Text !="")
            {
                string text = txtCustName.Text;
                string firsletter = string.Join(" ", text.Split(' ').ToList().ConvertAll(RichTextBoxWordPunctuations => RichTextBoxWordPunctuations.Substring(0, 1).ToUpper() + RichTextBoxWordPunctuations.Substring(1)));
                txtCustName.Text = firsletter;
            }
        }

        private void txtCustAddress_Leave(object sender, EventArgs e)
        {
            if (txtCustAddress.Text != "")
            {
                string text = txtCustAddress.Text;
                string firsletter = string.Join(" ", text.Split(' ').ToList().ConvertAll(RichTextBoxWordPunctuations => RichTextBoxWordPunctuations.Substring(0, 1).ToUpper() + RichTextBoxWordPunctuations.Substring(1)));
                txtCustAddress.Text = firsletter;
            }
        }
        public void PhoneNoValidation()
        {
            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (pattern.IsMatch(txtCustPhone.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txtCustPhone.Focus();
            }
        }

        private void txtCustPhone_Leave(object sender, EventArgs e)
        {
            if (txtCustPhone.Text == "")
            {
            }
            else
            {
                PhoneNoValidation();
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            RDLCReport.FrmAddCustomer RDLCAC = new RDLCReport.FrmAddCustomer();
            RDLCAC.TopLevel = false;
            panelAddCustomer.Controls.Add(RDLCAC);
            RDLCAC.BringToFront();
            RDLCAC.Show();

            btnPrint.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            if (dgvAddCustomers.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvAddCustomers.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvAddCustomers.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvAddCustomers.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvAddCustomers.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvAddCustomers.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
            btnExport.Enabled = true;
        }

       
        private void dgvAddCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvAddCustomers.SelectedCells[0].Value.ToString();
            txtCustName.Text = dgvAddCustomers.SelectedCells[1].Value.ToString();
            txtCustPhone.Text = dgvAddCustomers.SelectedCells[2].Value.ToString();
            txtCustAddress.Text = dgvAddCustomers.SelectedCells[3].Value.ToString();
            cmbNewspaper.Text = dgvAddCustomers.SelectedCells[4].Value.ToString();
            cmbAgent.Text = dgvAddCustomers.SelectedCells[6].Value.ToString();
            txtRemark.Text = dgvAddCustomers.SelectedCells[8].Value.ToString();
            cmbCustStatus.Text = dgvAddCustomers.SelectedCells[12].Value.ToString();
            txtCustBalance.Text = dgvAddCustomers.SelectedCells[13].Value.ToString();
            dtpCustDate.Text = dgvAddCustomers.SelectedCells[14].Value.ToString();
            txtCustPin.Text = dgvAddCustomers.SelectedCells[15].Value.ToString();
            cmbMonthYear.Text = dgvAddCustomers.SelectedCells[16].Value.ToString();
            txtAmount.Text = dgvAddCustomers.SelectedCells[18].Value.ToString();
            txtRoute.Text = dgvAddCustomers.SelectedCells[21].Value.ToString();
            txtRouteId.Text = dgvAddCustomers.SelectedCells[22].Value.ToString();
            cmbDays.Text = dgvAddCustomers.SelectedCells[24].Value.ToString();

            string MultiNewspaperName = dgvAddCustomers.SelectedCells[19].Value.ToString();
            var Days = MultiNewspaperName.Split('-')[0];
            var News = MultiNewspaperName.Split('-')[1];
            var Rate = MultiNewspaperName.Split('-')[2];
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAddCustomer_Shown(object sender, EventArgs e)
        {
            txtCustName.Focus();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
