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
    public partial class FrmNewDashboard : Form
    {
        public FrmNewDashboard()
        {
            InitializeComponent();
        }
        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql = "";
        int cnt;
        double TotlAmt = 0;
        double PaidAmt = 0;
        double Balance = 0;


        private void FrmNewDashboard_Load(object sender, EventArgs e)
        {
            lblcomanyName.TextAlign = ContentAlignment.MiddleLeft;
            SelectCompanyName();
            ActiveCust();
            DeactiveCust();
            TotalAmt();
            PaidAmount();
            BalanceAmount();
        }

        public void SelectCompanyName()
        {
            sql = "select CompanyName from CompanyRegistrations where CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lblcomanyName.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                //lblCompanyAdd.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            }
        }

        public void ActiveCust()
        {
            sql = "Select Count(*) from CustomerProfiles Where CompanyId='" + ClassConnection.CompanyID + "' and CustomerStatus ='Active'";
            cnt = objcls.executescal(sql);
            lblActiveCust.Text = Convert.ToString(cnt);
        }
        public void DeactiveCust()
        {
            sql = "Select Count(*) from CustomerProfiles Where CompanyId='" + ClassConnection.CompanyID + "' and CustomerStatus='Deactive'";
            cnt = objcls.executescal(sql);
            lblDeactiveCust.Text = Convert.ToString(cnt);
        }
       
        public void PaidAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);
            int pcnt;
            sql = "Select count(PaidAmt) from Bills Where CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
            int cntp = objcls.executescal(sql);
            if (cntp != 0)
            {
                sql = "Select Sum(cast(PaidAmt as float)) from Bills Where CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
                pcnt = objcls.executescal(sql);
            }
            else

            {
                pcnt = 0;
            }

            lblPaidAmt.Text = Convert.ToString(pcnt);
        }

        public void BalanceAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);
            int Bcnt;
            sql = "Select count(Balance) from Bills Where CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
            int cntp = objcls.executescal(sql);
            if (cntp != 0)
            {
                sql = "Select Sum(cast(Balance as float)) from Bills Where CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
                Bcnt = objcls.executescal(sql);
            }
            else
            {
                Bcnt = 0;
            }

            lblBalanceAmt.Text = Convert.ToString(Bcnt);
        }

        public void TotalAmt()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);
            //int gcnt;
            sql = "Select count(GrandTotal) from Bills Where CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                sql = "Select Sum(cast(GrandTotal as float)) from Bills Where CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
                TotlAmt = objcls.executescal(sql);
                //TotlAmt = objcls.executescal(sql);
            }
            else
            {
                TotlAmt = 0;
            }
            lblTotalAmt.Text = Convert.ToString(TotlAmt);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewspaper_Click(object sender, EventArgs e)
        {
            FrmAddNewspaper frmAM = new FrmAddNewspaper();
            frmAM.TopLevel = false;
            dashpanel.Controls.Add(frmAM);
            frmAM.BringToFront();
            frmAM.Show();

            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmAddNewspaper")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    FrmAddNewspaper BM = new FrmAddNewspaper();
            //    BM.Show();
            //}

        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            FrmAddAgent frmAG = new FrmAddAgent();
            frmAG.TopLevel = false;
            dashpanel.Controls.Add(frmAG);
            frmAG.BringToFront();
            frmAG.Show();

            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmAddAgent")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    FrmAddAgent BM = new FrmAddAgent();
            //    BM.Show();
            //}
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmCM = new FrmAddCustomer();
            frmCM.TopLevel = false;
            dashpanel.Controls.Add(frmCM);
            frmCM.BringToFront();
            frmCM.Show();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmAddCustomer")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    FrmAddCustomer BM = new FrmAddCustomer();
            //    BM.Show();
            //}
        }

        private void btnCustomerlist_Click(object sender, EventArgs e)
        {
            FrmCustomerDetails frmCD = new FrmCustomerDetails();
            frmCD.TopLevel = false;
            dashpanel.Controls.Add(frmCD);
            frmCD.BringToFront();
            frmCD.Show();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmCustomerDetails")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    FrmCustomerDetails BM = new FrmCustomerDetails();
            //    BM.Show();
            //}
        }

        private void btnBillGenerate_Click(object sender, EventArgs e)
        {
            FrmMassage frmCD = new FrmMassage();
            frmCD.TopLevel = false;
            dashpanel.Controls.Add(frmCD);
            frmCD.BringToFront();
            frmCD.Show();
        }

        public void GenerateBill()
        {
            double AllTotal = 0;
            double GrandTotal = 0;
            double Custday = 0;
            double TotalDaycal = 0;
            double CustOldBalance = 0;
            int CustCDay = 0;
            int CustMonth = 0;
            int CustYear = 0;
            string CurMon = "";

            //last Month
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year
            var FristDate = new DateTime(month.Year, month.Month, 1);
            int CDay = FristDate.Day;//Day
            int days = (DateTime.DaysInMonth(Cyear, CMonth));//days in month
            DateTime Today = DateTime.Now;

            //Present Month
            //DateTime Today = DateTime.Now;
            //int CMonth = Today.Month;//month
            //int Cyear = Today.Year;//year
            //var FristDate = new DateTime(Today.Year, Today.Month, 1);
            //int CDay = FristDate.Day;//Day
            //int days = (DateTime.DaysInMonth(Cyear, CMonth));//days in month

            if (CMonth == 1)
            {
                CurMon = "January";
            }
            else if (CMonth == 2)
            {
                CurMon = "February";
            }
            else if (CMonth == 3)
            {
                CurMon = "March";
            }
            else if (CMonth == 4)
            {
                CurMon = "April";
            }
            else if (CMonth == 5)
            {
                CurMon = "May";
            }
            else if (CMonth == 6)
            {
                CurMon = "June";
            }
            else if (CMonth == 7)
            {
                CurMon = "July";
            }
            else if (CMonth == 8)
            {
                CurMon = "August";
            }
            else if (CMonth == 9)
            {
                CurMon = "September";
            }
            else if (CMonth == 10)
            {
                CurMon = "October";
            }
            else if (CMonth == 11)
            {
                CurMon = "November";
            }
            else if (CMonth == 12)
            {
                CurMon = "December";
                Cyear--;//if we generate 12 month bill in 1 month(2023)
            }
            //sql = "Select * from Bills where Cmonth ='" + CurMon + "' and Cyear='" + Cyear + "' and CompanyId ='" + ClassConn.Companyid + "'";
            //cnt = objcls.executescal(sql);
            //if (cnt != 0)
            //{
            //    MessageBox.Show("Bill Already Generated...");
            //}
            //else
            //{
            MessageBox.Show("Do You Want To Generate Bill...");
            //get all Customer
            sql = "Select * from CustomerProfiles where CustomerStatus ='Active' and CompanyId ='" + ClassConnection.CompanyID + "' and Cmonth<='" + CMonth + "' and Cyear<='" + Cyear + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //string SelectedDays = ds.Tables[0].Rows[i].ItemArray[24].ToString();
                //if (SelectedDays != "")
                //{
                //  //  sql = "SELECT Split("SelectedDays",',') AS SplitString";
                //    sql = "SELECT SelectedDays FROM CustomerProfiles (SelectedDays='" + SelectedDays+"',',')";
                //    objcls.execute(sql);
                //}
                //count total delivery days in month and year
                sql = "Select COUNT(*) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CompanyId='" + ClassConnection.CompanyID + "'";
                cnt = objcls.executescal(sql);

                DateTime CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[14].ToString());
                CustCDay = CustDate.Day;//Day
                CustMonth = CustDate.Month;
                CustYear = CustDate.Year;

                //Customer Newspaperrate
                double NewsPaperRate = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[5].ToString());

                //Customer Datewise
                if (CMonth == CustMonth && Cyear == CustYear)
                {
                    var CusttotalDays = (CustDate.Date - FristDate.Date).TotalDays;
                    Custday = Convert.ToInt32(CusttotalDays);
                    double MianCustDay = days - Custday;
                    double CustDay = MianCustDay - cnt;
                    TotalDaycal = CustDay * NewsPaperRate;
                }
                //FullMonth Datewise
                else
                {
                    double Totalday = days - cnt;
                    TotalDaycal = Totalday * NewsPaperRate;
                }

                //Customer OldBalance
                string sqlOld = "Select OldBalance from  CustomerProfiles where Id='" + ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "' and CompanyId='" + ClassConnection.CompanyID + "'";
                DataSet dsOld = objcls.fillDs(sqlOld);
                for (int k = 0; k < dsOld.Tables[0].Rows.Count; k++)
                {
                    if (dsOld.Tables[0].Rows[k].ItemArray[0].ToString() == "")
                    {
                        CustOldBalance = 0;
                    }
                    else
                    {
                        CustOldBalance = Convert.ToDouble(dsOld.Tables[0].Rows[k].ItemArray[0].ToString());
                    }
                }
                GrandTotal = TotalDaycal + CustOldBalance;

                sql = "INSERT into Bills(CustId,CustomerName,MobileNo,Address,NewspaperName,NewspaperRate,NewspaperPlan,AgentName,AgentID,Cyear,Cmonth,CustomerStatus,OldBalance,Pin,CDate,TotalAmt,Balance,GrandTotal,PaymentStatus,NewspaperQty,CompanyId)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[4].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[5].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[16].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString().Trim() + "','0','" + Cyear + "','" + CurMon + "','" + ds.Tables[0].Rows[i].ItemArray[12].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[13].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[15].ToString().Trim() + "','" + string.Format("{0:dd/MM/yyyy }", Today) + "','" + TotalDaycal + "','0','" + GrandTotal + "','0','" + ds.Tables[0].Rows[i].ItemArray[17].ToString().Trim() + "','" + ClassConnection.CompanyID + "')";
                objcls.execute(sql);
            }
            MessageBox.Show("Bill Generated Successfully");
        }

        private void btnBillPay_Click(object sender, EventArgs e)
        {
            FrmBillPay frmBP = new FrmBillPay();
            frmBP.TopLevel = false;
            dashpanel.Controls.Add(frmBP);
            frmBP.BringToFront();
            frmBP.Show();
            ////bool IsOpen = false;
            ////foreach (Form f in Application.OpenForms)
            ////{
            ////    if (f.Text == "FrmBillPay")
            ////    {
            ////        IsOpen = true;
            ////        f.Focus();
            ////        break;
            ////    }
            ////}
            ////if (IsOpen == false)
            ////{
            ////    FrmBillPay BM = new FrmBillPay();
            ////    BM.Show();
            ////}
        }
    

        private void btnBillhistory_Click(object sender, EventArgs e)
        {
            FrmPaymentHistory frmPH = new FrmPaymentHistory();
            frmPH.TopLevel = false;
            dashpanel.Controls.Add(frmPH);
            frmPH.BringToFront();
            frmPH.Show();
            ////bool IsOpen = false;
            ////foreach (Form f in Application.OpenForms)
            ////{
            ////    if (f.Text == "FrmPaymentHistory")
            ////    {
            ////        IsOpen = true;
            ////        f.Focus();
            ////        break;
            ////    }
            ////}
            ////if (IsOpen == false)
            ////{
            ////    FrmPaymentHistory BM = new FrmPaymentHistory();
            ////    BM.Show();
            ////}
        }

        private void pnlActive_Click(object sender, EventArgs e)
        {
            FrmDetailsList objDL = new FrmDetailsList("pnlActive");
            objDL.TopLevel = false;
            dashpanel.Controls.Add(objDL);
            objDL.BringToFront();
            objDL.Show();
        }

        private void pnlDeactive_Click(object sender, EventArgs e)
        {
            FrmDetailsList objDL = new FrmDetailsList("pnlDeactive");
            objDL.TopLevel = false;
            dashpanel.Controls.Add(objDL);
            objDL.BringToFront();
            objDL.Show();
        }

        private void pnlTotalAmt_Click(object sender, EventArgs e)
        {
            FrmDetailsList objDL = new FrmDetailsList("pnlTotalAmt");
            objDL.TopLevel = false;
            dashpanel.Controls.Add(objDL);
            objDL.BringToFront();
            objDL.Show();
        }

        private void pnlPaidAmt_Click(object sender, EventArgs e)
        {
            FrmDetailsList objDL = new FrmDetailsList("pnlPaidAmt");
            objDL.TopLevel = false;
            dashpanel.Controls.Add(objDL);
            objDL.BringToFront();
            objDL.Show();
        }

        private void pnlBalanceAmt_Click(object sender, EventArgs e)
        {
            FrmDetailsList objDL = new FrmDetailsList("pnlBalanceAmt");
            objDL.TopLevel = false;
            dashpanel.Controls.Add(objDL);
            objDL.BringToFront();
            objDL.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            FrmNewDashboard frmND = new FrmNewDashboard();
            frmND.Visible = true;
            frmND.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimaise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ActiveCust();
            DeactiveCust();
            PaidAmount();
            BalanceAmount();
            TotalAmt();

        }

        private void lblTotalAmt_Click(object sender, EventArgs e)
        {

        }

        private void pnlTotalAmt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=-SgQOSAFukU");
        }
    }
 }

