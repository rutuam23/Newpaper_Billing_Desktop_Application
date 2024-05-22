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
    public partial class FrmAddNewspaper : Form
    {
        public FrmAddNewspaper()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;

        private void FrmAddNewspaper_Load(object sender, EventArgs e)
        {
            FillDt();
            Clear();
            btnEdit.Enabled = false;
            dgvAddNewspaper.Columns[0].Visible = false;
            dgvAddNewspaper.Columns[1].Width = 310;
            dgvAddNewspaper.Columns[2].Width = 230;

            
        }

        public void FillDt()
        {
            sql = "Select Id,NewspaperName,Rate from NewspaperMasters where CompanyId='" + ClassConnection.CompanyID+"'";
            ds=objcls.fillDs(sql);
            dgvAddNewspaper.DataSource = ds.Tables[0];
            Clear();
        }

        public void Clear()
        {
            txtID.ResetText();
            txtNewspaper.ResetText();
            txtRate.ResetText();
        }

        private void dgvAddNewspaper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvAddNewspaper.SelectedCells[0].Value.ToString();
            txtNewspaper.Text = dgvAddNewspaper.SelectedCells[1].Value.ToString();
            txtRate.Text = dgvAddNewspaper.SelectedCells[2].Value.ToString();
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNewspaper.Text=="")
            {
                MessageBox.Show("Enter the Newspaper..");
                return;
            }
            if(txtRate.Text=="")
            {
                MessageBox.Show("Enter the Rate..");
                return;
            }
            sql = "Insert into NewspaperMasters(NewspaperName,Rate,CompanyId)values('" + txtNewspaper.Text.Trim() + "','"+txtRate.Text.Trim() + "','"+ClassConnection.CompanyID+"')";
            objcls.execute(sql);
            MessageBox.Show("Record Add Successfully...");
            FillDt();
            Clear();
            txtNewspaper.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sql = "Update NewspaperMasters set NewspaperName='" + txtNewspaper.Text.Trim() + "',Rate='" + txtRate.Text.Trim() + "' where  Id='" + txtID.Text.Trim() + "' and CompanyId='"+ClassConnection.CompanyID+"'";
            objcls.execute(sql);
            MessageBox.Show("Updated Successfully....");
            FillDt();
            Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            txtNewspaper.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewspaper_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtRate.Focus();
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void txtNewspaper_Leave(object sender, EventArgs e)
        {
            if (txtNewspaper.Text != "")
            {
                string text = txtNewspaper.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtNewspaper.Text = firstletterofeachstring;
            }

        }

        private void FrmAddNewspaper_Shown(object sender, EventArgs e)
        {
            txtNewspaper.Focus();
        }
    }
}
