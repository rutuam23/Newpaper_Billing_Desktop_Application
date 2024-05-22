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
    public partial class FrmDateWiseNewspaper : Form
    {
        FrmCustCalendarReport FCCR;
        public FrmDateWiseNewspaper(FrmCustCalendarReport CCR)
        {
            InitializeComponent();
            this.FCCR = CCR;
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;

        private void btnOk_Click(object sender, EventArgs e)
        {
            ClassConnection.DateEvenOdd = Convert.ToDateTime(UserControlDays.static_day + "/" + FrmCustCalendarReport.static_NowMonth + "/" + FrmCustCalendarReport.static_NowYear);
            DateTime CDate = ClassConnection.DateEvenOdd;
            string CDay = CDate.Day.ToString();
            string CMonth = CDate.Month.ToString();
            string Cyear = CDate.Year.ToString();
            DateTime Today = DateTime.Now;

            sql = "Delete from DeliveryStatus where  CDate = '" + string.Format("{0:dd/MM/yyyy}", CDate) + "'and CustId='" + ClassConnection.CustID + "' and CompanyId='" + ClassConnection.CompanyID + "'";
            objcls.execute(sql);
            sql = "Select * from CustomerProfiles where Id='" + ClassConnection.CustID + "'and CompanyId='" + ClassConnection.CompanyID + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, NewspaperName, NewspaperRate, NewspaperPlan, AgentName, AgentID, Cday, Cyear, Cmonth, PaperStatus,OldBalance,Pin, CDate,TotalAmt,NewspaperQty,CompanyId,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[4].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[5].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[16].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[7].ToString().Trim() + "','" + CDay + "','" + Cyear + "','" + CMonth + "','nonewspaper','" + ds.Tables[0].Rows[i].ItemArray[13].ToString().Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[15].ToString().Trim() + "','" + string.Format("{0:dd/MM/yyyy }", CDate).Trim() + "','" + ds.Tables[0].Rows[i].ItemArray[18].ToString().Trim() + "','0','" + ds.Tables[0].Rows[i].ItemArray[20].ToString().Trim() + "','" + string.Format("{0:yyyy/MM/dd }", Today).Trim() + "','" + string.Format("{0:yyyy/MM/dd }", Today).Trim() + "')";
                objcls.execute(sql);
            }
            //FCCR.ClearPresentYearCalendar();
            //MessageBox.Show("Inserted Successfully....");
            FCCR.displayPresentYearCalendar();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

