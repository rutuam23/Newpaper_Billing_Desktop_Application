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
    public partial class FrmCustCalendarReport : Form
    {
        int NowMonth, NowYear;
        public static string static_day;
        public static int static_NowMonth, static_NowYear;

        public FrmCustCalendarReport()
        {
            InitializeComponent();
        }
        //ClassConnection objcls = new ClassConnection();
        //DataSet ds = new DataSet();
        //string sql;
        //DateTime CustDate;
        //int NowMonth, NowYear;
        //public static string static_day;
        //public static int static_NowMonth, static_NowYear;


        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
        string DelTime;
        DateTime CustDate;

        private bool btnPlanVaccationWasClicked = false;
        private object e;

        public object SelDays1 { get; private set; }
        public object DayName { get; private set; }

        private void FrmCustCalendarReport_Load(object sender, EventArgs e)
        {
            DateTime Nowtime = DateTime.Now;
            String Date = (string.Format("{0:MM/dd/yyyy }", Nowtime));
            NowMonth = Nowtime.Month;
            NowYear = Nowtime.Year;
            displayPresentYearCalendar();
            ClassConnection.DateEvenOdd = Convert.ToDateTime(static_NowMonth + "/" + static_NowYear);
            Calendar();
            DateTime date = DateTime.Today;
            Filldt();
        }


        public void Calendar()
        {
            sql = "select CDate from DeliveryStatus where Cmonth='" + NowMonth + "' and CustId = '" + ClassConnection.CustID + "' and CompanyId = '" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DateTime CustCalenDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                var CustCalDate = CustCalenDate;
                var CustCalDay = CustCalenDate.Day.ToString();
                var lastDayOfMonth = CustCalenDate.AddMonths(1).AddDays(-1);
                var CustlastCalDay = lastDayOfMonth.Day.ToString();
            }
        }

        //Fill All Data into gridview
        public void Filldt()
        {
            sql = "Select PaperStatus,CDate from DeliveryStatus where Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConnection.CustID + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            dgvCustCalendarReport.DataSource = ds.Tables[0];

            dgvCustCalendarReport.Columns[0].Width = 300;
            dgvCustCalendarReport.Columns[1].Width = 180;

            if (dgvCustCalendarReport.Rows.Count == 0)
            {

            }
            else
            {
                for (int i = 2; i < dgvCustCalendarReport.Columns.Count; i++)
                {

                    int total = 0;
                    for (int j = 0; j < dgvCustCalendarReport.Rows.Count - 1; j++)
                    {

                        total += Convert.ToInt32(dgvCustCalendarReport.Rows[j].Cells[i].Value);
                    }
                    dgvCustCalendarReport.Rows[dgvCustCalendarReport.Rows.Count - 1].Cells[0].Value = "GrandTotal";
                    dgvCustCalendarReport.Rows[dgvCustCalendarReport.Rows.Count - 1].Cells[1].Value = "";
                    dgvCustCalendarReport.Rows[dgvCustCalendarReport.Rows.Count - 1].Cells[i].Value = total;
                }
            }
        }

        private void btnPlanVaccation_Click(object sender, EventArgs e)
        {
            FrmPlanVaccation frmPlan = new FrmPlanVaccation(this);
            frmPlan.Show();
        }

        private void btnCloseNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CallNewsPaperAddFrm()
        {
            sql = "Select RegDate from CustomerProfiles where Id='" + ClassConnection.CustID + "'and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            ClassConnection.DateEvenOdd = Convert.ToDateTime(UserControlDays.static_day + "/" + static_NowMonth + "/" + static_NowYear);
            string AMonth = ClassConnection.DateEvenOdd.Month.ToString();
            DateTime Today = DateTime.Now;
            string BMonth = Today.Month.ToString();
            if (ClassConnection.DateEvenOdd >= CustDate)
            {
                if (AMonth == BMonth)
                {
                    if (Convert.ToDateTime(ClassConnection.DateEvenOdd) >= Today)
                    {
                        FrmDateWiseNewspaper frmD = new FrmDateWiseNewspaper(this);
                        frmD.Show();
                    }
                    else
                    {
                        MessageBox.Show("Can't Change Previous or Current Day Data");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Days are Not Available... ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Days are Not Available... ");
                return;
            }
        }

        public void ClearPresentYearCalendar()
        {
            daycontainer.Controls.Clear();
        }

        public void displayPresentYearCalendar()
        {
            var SelDays1 = "";
            string DayName = "";
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
            for (int j = 1; j <= Days; j++)
            {
                UserControlDays UCDays = new UserControlDays(this);
                UCDays.Days(j);
                //for (DateTime d = StartOfTheMonth; d <= EndOfTheMonth; d = d.AddDays(1))
                //    DayName = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(d.DayOfWeek);

                sql = "Select RegDate from CustomerProfiles where Id='" + ClassConnection.CustID + "'and CompanyId='" + ClassConnection.CompanyID + "'";
                    ds = objcls.fillDs(sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }
                    int CustD = CustDate.Day;
                    int CustM = CustDate.Month;
                    int CustY = CustDate.Year;
                    if (NowYear > CustY)
                    {
                        UCDays.BackColor = Color.LimeGreen;
                    }
                    if (NowMonth >= CustM && NowYear >= CustY)
                       {
                        UCDays.BackColor = Color.LimeGreen;
                        if (CustD <= j && CustM == NowMonth && CustY == NowYear)
                        {
                            UCDays.BackColor = Color.LimeGreen;
                            sql = "Select PaperStatus,Cday,Cmonth,Cyear,CDate from DeliveryStatus where Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConnection.CustID + "' and CompanyId='" + ClassConnection.CompanyID + "'";
                            DataSet ds1 = objcls.fillDs(sql);
                            if (ds1.Tables[0].Rows.Count != 0)
                            {
                                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                                {
                                    int Cday = Convert.ToInt32(ds1.Tables[0].Rows[i].ItemArray[1].ToString());

                                    //nonewspaper
                                    if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "nonewspaper")
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //Same month
                                if (CustM == NowMonth && CustY == NowYear)
                                {
                                UCDays.BackColor = Color.LimeGreen;
                                }
                                sql = "Select PaperStatus,Cday,Cmonth,Cyear,CDate from DeliveryStatus where Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConnection.CustID + "' and CompanyId='" + ClassConnection.CompanyID + "' order by CDate asc ";
                                DataSet ds = objcls.fillDs(sql);
                                if (ds1.Tables[0].Rows.Count != 0)
                                {
                                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                                    {
                                        int Cday = Convert.ToInt32(ds1.Tables[0].Rows[i].ItemArray[1].ToString());

                                        //nonewspaper
                                        if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "nonewspaper")
                                        {
                                            if (Cday == j)
                                            {
                                                daycontainer.Controls.Add(UCDays);
                                                UCDays.BackColor = Color.Red;
                                            }
                                            else
                                            {
                                                daycontainer.Controls.Add(UCDays);
                                                if (SelDays1 == DayName)
                                                {
                                                   UCDays.BackColor = Color.Aqua;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    else if (CustM == NowMonth && CustY == NowYear)
                    {
                        UCDays.BackColor = Color.WhiteSmoke;
                    }
                }

                daycontainer.Controls.Add(UCDays);
            }
            Filldt();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //panelCust.SendToBack();
            //panel1.BringToFront();
            //panel1.Visible = true;
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