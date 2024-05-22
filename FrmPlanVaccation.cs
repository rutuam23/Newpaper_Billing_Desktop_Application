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
    public partial class FrmPlanVaccation : Form
    {
        int NowDay, NowMonth, NowYear;
        public static string static_day;
        public static int static_NowMonth, static_NowYear;

        FrmCustCalendarReport FMS;
        public FrmPlanVaccation(FrmCustCalendarReport CCR)
        {
            InitializeComponent();
            this.FMS = CCR;
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
        DateTime CustDate;
        private bool btnfromdateWasClicked = false;
        private bool btnToDateWasClicked = false;

        private void FrmPlanVaccation_Load(object sender, EventArgs e)
        {
            DateTime Nowtime = DateTime.Now;
            NowMonth = Nowtime.Month;
            NowYear = Nowtime.Year;
            displayPresentYearCalendar();
        }

        private void btnfromDate_Click(object sender, EventArgs e)
        {
            btnToDateWasClicked = false;
            btnfromdateWasClicked = true;
            panelFront.SendToBack();
            panelFront.Visible = false;
            panelBack.Visible = true;
        }

        private void btnToDate_Click(object sender, EventArgs e)
        {
            btnfromdateWasClicked = false;
            btnToDateWasClicked = true;
            panelFront.SendToBack();
            panelFront.Visible = false;
            panelBack.Visible = true;
        }

        public void SelectDate()
        {
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
            CheckDate();
        }

        public void CheckDate()
        {
            sql = "Select RegDate from CustomerProfiles where Id='" + ClassConnection.CustID + "'and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            if (btnfromdateWasClicked == true)
            {
                DateTime Today = DateTime.Today;

                //String Date = string.Format("{0:MM/dd/yyyy }", Today);
             
                DateTime FromSelectDate = Convert.ToDateTime(UserControlPlanVacc.static_day + "/" + FrmCustCalendarReport.static_NowMonth + "/" + FrmCustCalendarReport.static_NowYear);

                if (FromSelectDate >= CustDate)
                {
                    if (FromSelectDate >= Today)
                    {
                        lblFrom.Text = Convert.ToString(string.Format("{0:dd/MM/yyyy}", FromSelectDate));
                    }
                    else
                    {
                        MessageBox.Show("Can't Change Previous or Current Day Data");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Date are not Available...");
                }
            }
            else if (btnToDateWasClicked == true)
            {
                DateTime Today = DateTime.Now;
                DateTime ToSelectDate = Convert.ToDateTime(UserControlPlanVacc.static_day + "/" + FrmCustCalendarReport.static_NowMonth + "/" + FrmCustCalendarReport.static_NowYear);

                if (ToSelectDate >= CustDate)
                {
                    if (ToSelectDate >= Today)
                    {
                        lblTo.Text = Convert.ToString(string.Format("{0:dd/MM/yyyy}", ToSelectDate));
                    }
                    else
                    {
                        MessageBox.Show("Can't Change Previous or Current Day Data");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Date are not Available...");
                }
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void btnCanceldate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkDate_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //pcloader.Visible = true;
           
            try
            {
                if (lblFrom.Text == "" && lblTo.Text == "")
                {
                    MessageBox.Show("Please select date...");
                }
                else
                {
                    DateTime DTPFrom = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy }", lblFrom.Text));
                    DateTime DTPTo = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy }", lblTo.Text));

                    for (DateTime dtm = DTPFrom; dtm <= DTPTo; dtm = dtm.AddDays(1))
                    {
                        int CDay = Convert.ToInt32(dtm.Day.ToString());
                        string CMonth = dtm.Month.ToString();
                        string Cyear = dtm.Year.ToString();

                        sql = "DELETE FROM DeliveryStatus WHERE CDate='" + string.Format("{0:dd/MM/yyyy }", dtm) + "' and  CustId='" + ClassConnection.CustID + "' and CompanyId='" + ClassConnection.CompanyID + "' ";
                        objcls.execute(sql);

                        sql = "Select * from CustomerProfiles where Id='" + ClassConnection.CustID + "'";
                        ds = objcls.fillDs(sql);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, NewspaperName, NewspaperRate, NewspaperPlan, AgentName, AgentID, Cday, Cyear, Cmonth, PaperStatus,OldBalance,Pin, CDate,TotalAmt,NewspaperQty,CompanyId,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[4].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[5].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[16].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[7].ToString().Trim() + "','" + CDay + "','" + Cyear + "','" + CMonth + "','nonewspaper','" + ds.Tables[0].Rows[i].ItemArray[13].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[15].ToString().Trim() + "','" + string.Format("{0:dd/MM/yyyy }", dtm).Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[18].ToString().Trim() + "','0','" + ds.Tables[0].Rows[i].ItemArray[20].ToString().Trim() + "','" + string.Format("{0:yyyy/MM/dd }", dtm).Trim() + "','" + string.Format("{0:yyyy/MM/dd }", DTPTo).Trim() + "')";
                            objcls.execute(sql);
                        }
                    }
                    FMS.ClearPresentYearCalendar();
                    //MessageBox.Show("Inserted Successfully....");
                }
                FMS.displayPresentYearCalendar();
            }

            catch { }
            this.Hide();
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayPresentYearCalendar()
        {
            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(NowMonth);
            lblDate.Text = MonthName + "" + NowYear;

            static_NowMonth = NowMonth;
            static_NowYear = NowYear;

            DateTime StartOfTheMonth = new DateTime(NowYear, NowMonth, 1);
            int Days = DateTime.DaysInMonth(NowYear, NowMonth);
            int DayInWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DayInWeek; i++)
            {
                UserControlBlank UCBlank = new UserControlBlank();
                daycontainer.Controls.Add(UCBlank);
            }
            for (int i = 1; i <= Days; i++)
            {
                UserControlPlanVacc UCDays = new UserControlPlanVacc(this);
                UCDays.Days(i);
                daycontainer.Controls.Add(UCDays);
            }
        }
  
        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            NowMonth--;
            if (NowMonth >= 1)
            {
                daycontainer.Controls.Clear();
                displayPresentYearCalendar();
            }
            else
            {
                NowMonth = 13;
                NowYear--;
            }
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            NowMonth++;
            if (NowMonth <= 12)
            {
                daycontainer.Controls.Clear();
                displayPresentYearCalendar();
            }
            else
            {
                NowMonth = 0;
                NowYear++;
            }
        }
    }
}
