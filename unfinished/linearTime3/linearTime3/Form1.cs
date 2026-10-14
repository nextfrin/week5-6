namespace linearTime3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 0 };
            int total = 0;
            numbers = numbers.Append(Convert.ToInt32(textBox1.Text)).ToArray();
            // no idea how this works

            foreach (int number in numbers)
            {
                total = total + number;
            }

            label1.Text = "=  " + total;
            textBox1.Text = "0";
        }
    }
}
