using Exercise3.Properties;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lion_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            string teamName = btn.Name;
            System.Drawing.Image teamImage = Properties.Resources.ResourceManager.GetObject(teamName) as System.Drawing.Image;
            pic.Image = teamImage;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLunar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lunar lunar = new Lunar();
            lunar.Show();
        }
    }
}
