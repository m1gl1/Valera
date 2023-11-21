namespace Chernikov
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            int period;
            double percent;
            double profit;
            sum = System.Convert.ToDouble(textBox1.Text); 
            period = System.Convert.ToInt32(textBox2.Text);
            if (sum < 10000)
                percent = 3.5;
            else
                percent = 4.5;
            profit = sum * (percent / 100 / 12) * period;
            label3.Text =
            "Процентная ставка: " + percent.ToString("n") + "%\n" +
            "Доход: " + profit.ToString("c");
        }

    }
}
