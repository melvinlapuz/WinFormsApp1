namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpin.Text = txtpin.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtpin.Text == "0000")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                if (txtpin.Text.Length > 3)
                {
                    MessageBox.Show("Incorrect Password");
                    
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpin.MaxLength = 4;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(txtpin.Text.Length > 0)
            {
                txtpin.Text = txtpin.Text.Remove(txtpin.Text.Length - 1, 1);
            }
        }
    }
}
