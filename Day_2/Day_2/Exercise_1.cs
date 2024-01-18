namespace Day_2
{
    public partial class Exercise_1 : Form
    {
        public Exercise_1()
        {
            InitializeComponent();
        }

        public bool checkInfo()
        {
            float number1 , number2;
            if (string.IsNullOrEmpty(txtNumber1.Text) || float.TryParse(txtNumber1.Text, out number1) == false)
            {
                error.SetError(txtNumber1, "*");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumber2.Text) || float.TryParse(txtNumber1.Text, out number1) == false )
            {
                error.SetError(txtNumber2, "*");
                return false;
            }
            return true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                if (checkInfo())
                {
                    float number1 = float.Parse(txtNumber1.Text);
                    float number2 = float.Parse(txtNumber2.Text);
                    float answer = 0;

                    switch (button.Name)
                    {
                        case "btnPlus":
                            {
                                answer = number1 + number2;

                                break;
                            }
                        case "btnMinus":
                            {
                                answer = number1 - number2;
                                break;
                            }
                        case "btnMulti":
                            {
                                answer = number1 * number2;
                                break;
                            }
                        case "btnDivide":
                            {
                                if(number2 == 0)
                                {
                                    MessageBox.Show("Number 2 invalid !! ");
                                }
                                else
                                {
                                    answer = number1 / number2;
                                }
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    txtAnswer.Text = answer.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}