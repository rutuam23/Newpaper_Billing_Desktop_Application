using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBillingApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );

        private void lblNewAccount_Click(object sender, EventArgs e)
        {
            FrmRegistration FRMReg = new FrmRegistration();
            FRMReg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCompanyEmail.Text == "")
            {
                MessageBox.Show("Enter Company EmailID");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Company Password");
                return;
            }
            sql = "Select * from CompanyRegistrations where CEmail='" + txtCompanyEmail.Text.Trim() + "' and CompamyPassword='" + txtPassword.Text.Trim() + "'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                sql = "Select CompanyId from CompanyRegistrations where CEmail='" + txtCompanyEmail.Text.Trim() + "' and CompamyPassword='" + txtPassword.Text.Trim() + "'";
                ds = objcls.fillDs(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ClassConnection.CompanyID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                }

                MessageBox.Show("Login Successfully...");
                this.Hide();
                FrmNewDashboard FrmDash = new FrmNewDashboard();
                FrmDash.Show();
            }
            else
            {
                MessageBox.Show("Login Failed...");
            }
        }

        public void Clear()
        {
             txtCompanyEmail.ResetText();
             txtPassword.ResetText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCompanyEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtCompanyEmail.Focus();
        }
    }
}
