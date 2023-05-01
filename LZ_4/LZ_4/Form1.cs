namespace LZ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double g;

            if (radioButtonV6.Checked)
            {
                var x = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);                
                
                if (x * b > 0.5 && x * b < 10)
                {
                    g = Math.Exp(F(x) - Math.Abs(b));
                } 
                else if (x * b > 0.1 && x * b < 0.5)
                {
                    g = Math.Sqrt(Math.Abs(F(x) - b));
                }
                else
                {
                    g = 2 * Math.Pow(F(x), 2);
                }

                textBox3.Text = $"G = {g}";
            }

            if (radioButtonV14.Checked)
            {
                var x = Convert.ToDouble(textBox1.Text);
                var y = Convert.ToDouble(textBox2.Text);
                var z = Convert.ToDouble(textBox4.Text);

                g = Math.Max(F(x) + y + z, x * y * z) / Math.Min(F(x) + y + z, x * y * z);

                textBox3.Text = $"G = {g}";
            }
        }

        private void radioButtonV6_CheckedChanged(object sender, EventArgs e)
        {
            FirstChange();

            label2.Text = "b =";            
            label3.Visible = false;            
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void radioButtonV14_CheckedChanged(object sender, EventArgs e)
        {
            FirstChange();

            label2.Text = "Y =";            
            label3.Visible = false;
            label5.Visible = true;
            textBox4.Visible = true;
        }

        private void FirstChange()
        {
            textBox3.Clear();

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }       

        private double F(double x)
        {
            if (radioButtonExp.Checked)
            {
                return Math.Exp(x);                
            }

            if (radioButtonXq.Checked)
            {
                return x * x;
            }

            if (radioButtonShX.Checked)
            {
                return (Math.Exp(x) - Math.Exp(-x)) / 2;
            }

            return 0;
        }
    }
}