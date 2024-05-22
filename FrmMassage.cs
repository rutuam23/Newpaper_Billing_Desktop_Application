﻿using System;
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
    public partial class FrmMassage : Form
    {
        public FrmMassage()
        {
            InitializeComponent();
        }

        ClassConnection objcls = new ClassConnection();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GenerateBill();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //for GenerateBill
        public void GenerateBill()
        {
            double PRate = 0;
            double AllTotal = 0;
            double GrandTotal = 0;
            double Custday = 0;
            double TotalDaycal = 0;
            double CustOldBalance = 0;
            int CustCDay = 0;
            int CustMonth = 0;
            int CustYear = 0;
            string CurMon = "";

           // last Month
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year
            var FristDate = new DateTime(month.Year, month.Month, 1);
            int CDay = FristDate.Day;//Day
            int days = (DateTime.DaysInMonth(Cyear, CMonth));//days in month
            DateTime Today = DateTime.Now;

            ////Present Month
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
            sql = "Select * from Bills where Cmonth ='" + CurMon + "' and Cyear='" + Cyear + "' and CompanyId ='" + ClassConnection.CompanyID + "'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                MessageBox.Show("Bill Already Generated...");
            }
            else
            {
                MessageBox.Show("Do You Want To Generate Bill...");
                //get all Customer
                sql = "Select * from CustomerProfiles where CustomerStatus ='Active' and CompanyId ='" + ClassConnection.CompanyID + "'";
                ds = objcls.fillDs(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sql = "Select * from  DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "' and CompanyId='" + ClassConnection.CompanyID + "'";
                    int cnt = objcls.executescal(sql);
                    if (cnt != 0)
                    {
                        sql = "Select sum(ProductRate) from  DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "' and CompanyId='" + ClassConnection.CompanyID + "'";
                        int cntP = objcls.executescal(sql);
                        PRate = cntP;
                    }
                    else
                    {
                        PRate = 0;
                    }

                   // count total delivery days in month and year
                    sql = "Select COUNT(*) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CompanyId='" + ClassConnection.CompanyID + "'";
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

        }

    }
}
    //private void btnCancel_Click_1(object sender, EventArgs e)
    //{
    //    this.Close();
    //}



