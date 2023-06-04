namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numBtn_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += ((Button)sender).Text;
        }

        private void btnHashTag_Click(object sender, EventArgs e)
        {
            string code = txtSecurityCode.Text;
            string groupName;
            DateTime now = DateTime.Now;
            switch (code)
            {
                case "1645":
                    groupName = "Technicians";
                    break;
                case "1689":
                    groupName = "Technicians";
                    break;
                case "8345":
                    groupName = "Custodians";
                    break;
                case "9998":
                    groupName = "Scientist";
                    break;
                case "1006":
                    groupName = "Scientist";
                    break;
                case "1008":
                    groupName = "Scientist";
                    break;
                default:
                    groupName = "Restricted Access!";
                    break;
            }
            string formattedDateTime = now.ToString("dd/MM/yyyy hh:mm:ss tt");
            string item = formattedDateTime + "\t" + groupName;
            lbxAccessLog.Items.Add(item);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
    }
}