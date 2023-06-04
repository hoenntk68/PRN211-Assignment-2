namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void GetPay()
        {
            string name = txtName.Text;
            if (name.Length > 0)
            {
                int total = 0;
                if (chkClean.Checked)
                {
                    total += 100;
                }
                if (chkWhitening.Checked)
                {
                    total += 1200;
                }
                if (chkXRay.Checked)
                {
                    total += 200;
                }
                total += (int)(numFilling.Value) * 80;
                total *= 1000;
                txtTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please enter customer name.");
            }

        }
    }
}