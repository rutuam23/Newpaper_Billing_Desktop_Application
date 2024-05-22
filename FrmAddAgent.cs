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
    public partial class FrmAddAgent : Form
    {
        public FrmAddAgent()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
      
        private void FrmAddAgent_Load(object sender, EventArgs e)
        {
            txtPin.Text = GenerateNewRandom();
            MaxRouteID();
            filldt();
            btnEdit.Enabled = false;
            dgvAddAgent.Columns[0].Visible = false;
            dgvAddAgent.Columns[3].Visible = false;
            dgvAddAgent.Columns[7].Visible = false;
            dgvAddAgent.Columns[1].Width = 230;
            dgvAddAgent.Columns[2].Width = 130;
            dgvAddAgent.Columns[4].Width = 130;
            dgvAddAgent.Columns[5].Width = 100;
            dgvAddAgent.Columns[6].Width = 180;
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

        public void MaxRouteID()
        {
            try
            {
                sql = "select max(RouteId) + 1 from AgentMasters";
                int RouteId = (objcls.executescal(sql));
                txtRouteId.Text = RouteId.ToString();
            }
            catch { txtRouteId.Text = "1"; }
        }

        public void filldt()
        {
            sql = "Select Id,AgentName,MobileNo,Emailid,AgentStatus,Pin,Route,RouteId from AgentMasters where CompanyId='" + ClassConnection.CompanyID+"'";
            ds=objcls.fillDs(sql);
            dgvAddAgent.DataSource = ds.Tables[0];
            Clear();
        }

        public void Clear()
        {
            txtID.ResetText();
            txtAgentName.ResetText();
            txtMobileNo.ResetText();
            txtEmailID.ResetText();
            txtRoute.ResetText();
            txtRouteId.ResetText();
            cmbStatus.ResetText();
        }

        private void dgvAddAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvAddAgent.SelectedCells[0].Value.ToString();
            txtAgentName.Text = dgvAddAgent.SelectedCells[1].Value.ToString();
            txtMobileNo.Text = dgvAddAgent.SelectedCells[2].Value.ToString();
            txtEmailID.Text = dgvAddAgent.SelectedCells[3].Value.ToString();
            cmbStatus.Text = dgvAddAgent.SelectedCells[4].Value.ToString();
            txtPin.Text = dgvAddAgent.SelectedCells[5].Value.ToString();
            txtRoute.Text = dgvAddAgent.SelectedCells[6].Value.ToString();
            txtRouteId.Text = dgvAddAgent.SelectedCells[7].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAgentName.Text == "")
            {
                MessageBox.Show("Enter AgentName");
                return;
            }
            if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Enter MobileNo");
                return;
            }
            if (txtEmailID.Text == "")
            {
                MessageBox.Show("Enter EmailID");
                return;
            }
            if (txtRoute.Text == "")
            {
                MessageBox.Show("Enter Route");
                return;
            }
            if (cmbStatus.Text == "")
            {
                MessageBox.Show("select Status");
                return;
            }
            sql = "Insert into AgentMasters(AgentName,MobileNo,Emailid,AgentStatus,Pin,RouteId,Route,CompanyId)values('"+txtAgentName.Text.Trim()+"','"+txtMobileNo.Text.Trim() + "','"+txtEmailID.Text.Trim() + "','"+cmbStatus.Text.Trim()+ "','"+txtPin.Text.Trim() + "','"+txtRouteId.Text.Trim() + "','"+txtRoute.Text.Trim() + "','"+ClassConnection.CompanyID+"')";
            objcls.execute(sql);
            MessageBox.Show("Agent Add Successfully...");
            filldt();
            Clear();
            txtAgentName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sql = "Update AgentMasters set AgentName='"+ txtAgentName.Text.Trim() + "',MobileNo='"+ txtMobileNo.Text.Trim() + "',Emailid='" + txtEmailID.Text.Trim() + "',AgentStatus='" + cmbStatus.Text.Trim() + "',Route='" + txtRoute.Text.Trim() + "' where Id='"+txtID.Text.Trim() + "' and CompanyId='"+ClassConnection.CompanyID+"'";
            objcls.executescal(sql);
            MessageBox.Show("Update Successfully");
            filldt();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "Delete from AgentMasters where Id='" + txtID.Text.Trim() + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            objcls.executescal(sql);
            MessageBox.Show("Deleted successfully");
            filldt();
            Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            txtPin.Text = GenerateNewRandom();
            MaxRouteID();
            txtAgentName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAgentName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtMobileNo.Focus();
            }
        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmailID.Focus();
            }
        }

        private void txtEmailID_KeyDown(object sender, KeyEventArgs e)
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
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void txtAgentName_Leave(object sender, EventArgs e)
        {
            if (txtAgentName.Text != "")
            {
                string text = txtAgentName.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtAgentName.Text = firstletterofeachstring;
            }
        }

        public void mobaileNuValidation()
        {
            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (pattern.IsMatch(txtMobileNo.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txtMobileNo.Focus();
            }
        }
        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo.Text == "")
            {
            }
            else
            {
                mobaileNuValidation();
            }

        }

        private void txtRoute_Leave(object sender, EventArgs e)
        {
            if (txtRoute.Text != "")
            {
                string text = txtRoute.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtRoute.Text = firstletterofeachstring;
            }
        }

        private void FrmAddAgent_Shown(object sender, EventArgs e)
        {
            txtAgentName.Focus();
        }
    }
    }

