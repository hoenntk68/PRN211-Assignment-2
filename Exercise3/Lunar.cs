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

namespace Exercise3
{
    public partial class Lunar : Form
    {
        public Lunar()
        {
            InitializeComponent();
        }

        private void btnViewLunar_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(calendarYear.Text);
            lunarYear.Text = GetLunarYear(year) + "";
        }

        private int GetLunarYear(int year)
        {
            ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
            DateTime temp = new DateTime(year, 1, 1);
            int lunarYear = calendar.GetYear(temp);
            return lunarYear;
        }

        private void btnExitLunar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Lunar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
