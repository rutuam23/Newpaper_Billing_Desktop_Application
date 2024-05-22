using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBillingApp
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;

        FrmCustCalendarReport FCCR;
        public UserControlDays(FrmCustCalendarReport CCR)
        {
            InitializeComponent();
            this.FCCR = CCR;
        }
        public void Days(int numday)
        {
            lblDays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            FCCR.CallNewsPaperAddFrm();
        }

        private void lblDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            FCCR.CallNewsPaperAddFrm();
        }
    }
}
