namespace Combinations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int k = Convert.ToInt32(textBox2.Text);
                
                //MessageBox.Show("your result is: " + n.ToString());
                int nFact = 1;
                int kFact = 1;
                int dif = n - k;
                int difFact = 1;

                if (k < 0 || n < 0)
                {
                    label4.Text = "Error: please insert positive numbers";
                    label4.ForeColor = Color.Red;
                }
                else if(k > 12 || n > 12)
                {
                    label4.Text = "Error: please insert smaller numbers [max value is 12]";
                    label4.ForeColor = Color.Red;
                }

                else if (n >= k)
                {

                    for (int i = n; i >= 2; i--)
                        nFact = nFact * i;
                    for (int i = k; i >= 2; i--)
                        kFact = kFact * i;
                    for (int i = dif; i >= 2; i--)
                        difFact = difFact * i;

                    int result = nFact / (difFact * kFact);
                    //MessageBox.Show("The result is: " + result.ToString());
                    label4.Text = result.ToString();
                    label4.ForeColor = Color.Black;
                    
                    //n: 
                    label7.Text = n.ToString();
                    label15.Text = n.ToString();
                    label12.Text = n.ToString();
                    
                    //k:
                    label6.Text = k.ToString();
                    label11.Text = k.ToString();
                    label13.Text = k.ToString();
                    if (result > 0)
                        label21.Text = result.ToString();
                    else
                    {
                        label4.Text = "Error: This doesn't make any sense";
                        label4.ForeColor = Color.Red;
                    }



                }
                else { 
                    label4.Text = "Error: k should be smaller or equal with n";
                    label4.ForeColor = Color.Red;
            }


            }
            catch (Exception ex)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}