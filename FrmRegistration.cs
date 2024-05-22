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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            txtCompanyID.Text = GenCompanyID(5);
        }

        public static string GenCompanyID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void Clear()
        {
            txtCompanyName.ResetText();
            txtMobileNo.ResetText();
            txtAddress.ResetText();
            txtPassword.ResetText();
            txtEmailID.ResetText();
            txtCity.ResetText();
            txtCompanySName.ResetText();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("Enter Company Name");
            }
            else if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Enter Mobile No.");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address");
            }
            else if (txtEmailID.Text == "")
            {
                MessageBox.Show("Enter EmailID");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Enter City");
            }
            else if (txtCompanySName.Text == "")
            {
                MessageBox.Show("Enter Company Short Name");
            }

            DateTime Today = DateTime.Now;
            string CDate = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", Today);
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string Time = DateTime.Now.ToLongTimeString();
            int year = Today.Year;

            var AddMonth = Today.AddMonths(6).AddDays(1);
            string SubSciptEndDate = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", AddMonth);
            var FinancialStartDt = "01" + "-" + "04" + "-" + year;
            var FinancialEndDt = "31" + "-" + "03" + "-" + (year + 1);
            var FinancialYear = (year + "-" + (year + 1));

            sql = "Insert into CompanyRegistrations(CompanyId,CompanyName,Address,CMobileno,CEmail,FinancialYear,FinancialStartDt,FinancialEndDt,City,CompamyShortName,IsCancled,SubscriptionStatus,Cdate,SubscriptionEndDate,Ctime,CompamyPassword)values('" + txtCompanyName.Text.Substring(0, 3) + txtCompanyID.Text.Trim() + "','" + txtCompanyName.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtMobileNo.Text.Trim() + "','" + txtEmailID.Text.Trim() + "','" + FinancialYear.Trim() + "','" + FinancialStartDt.Trim() + "','" + FinancialEndDt.Trim() + "','" + txtCity.Text.Trim() + "','" + txtCompanySName.Text.Trim() + "','0','Free','" + CDate.Trim() + "','" + SubSciptEndDate.Trim() + "','" + Time.Trim() + "','" + txtPassword.Text.Trim() + "')";
            objcls.execute(sql);
            MessageBox.Show("Registred Successfully...");
            this.Hide();
            //FrmNewDashboard objfrm = new FrmNewDashboard();
            //objfrm.ShowDialog();
            txtCompanyName.Focus();
        }

        public void PhoneNoValidation()
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


        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            txtCompanyID.ResetText();
            txtCompanyID.Text = GenCompanyID(5);
            txtCompanyName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtMobileNo.Focus();
            }
        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtEmailID.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtCity.Focus();
            }
        }

        private void txtEmailID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtCompanySName.Focus();
            }
        }

        private void txtCompanySName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.Focus();
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo.Text == "")
            {
            }
            else
            {
                PhoneNoValidation();
            }
        }
        
    //private void txtCompanyName_Leave(object sender, EventArgs e)
    //{
    //    if (txtCompanyName.Text != "")
    //    {
    //        string text = txtCompanyName.Text;
    //        string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
    //        txtCompanyName.Text = firstletterofeachstring;
    //    }
    //}

    private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                string text = txtAddress.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtAddress.Text = firstletterofeachstring;
            }
        }

        private void FrmRegistration_Shown(object sender, EventArgs e)
        {
            txtCompanyName.Focus();
        }
    }
}
