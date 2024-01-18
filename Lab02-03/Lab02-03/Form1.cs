namespace Lab02_03
{
    public partial class Form1 : Form
    {
        private const int NUMBERS_OF_SEATS = 32;
        long totalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public long getPrice(Button button)
        {
            int seat = int.Parse(button.Text);
            long price = 0;
            if (seat >= 1 && seat <= 8)
                price = 30000;
            else if (seat <= 16)
                price = 40000;
            else if (seat <= 24)
                price = 50000;
            else if (seat <= 32)
                price = 80000;
            return price;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            /*//totalPrice += totalPrice;*/
            foreach (var button in Controls.OfType<GroupBox>()
                   .SelectMany(groupBox => groupBox.Controls.OfType<Button>()))
            {
                if (button.BackColor == Color.Gray)
                {
                   /* //totalPrice += getPrice(button);*/
                    button.BackColor = Color.Yellow;
                }
            } 

            //*txtTotal.Text = totalPrice.ToString();*/
            btnCancel.Enabled = false;
        }

        private void btnChooseSeat(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == Color.Lime)
            {
                button.BackColor = Color.Gray;
                totalPrice += getPrice(button);
                txtTotal.Text = totalPrice.ToString();
            }
                
            else if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Lime;
                totalPrice -= getPrice(button);
                txtTotal.Text = totalPrice.ToString();
            }
                
            else if (button.BackColor == Color.Yellow)
                MessageBox.Show("Sold Out!!");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var button in Controls.OfType<GroupBox>()
                   .SelectMany(groupBox => groupBox.Controls.OfType<Button>()))
            {
                if (button.BackColor == Color.Gray)
                {
                    button.BackColor = Color.Lime;
                }
            }
            txtTotal.Text = "0";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("You Buy Ticket Complete ! \n" +
                    "Total : " + txtTotal.Text);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Are you sure you want to finish?");
                Application.Exit();
            }

        }
    }
}