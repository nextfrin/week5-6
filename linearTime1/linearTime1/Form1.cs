namespace linearTime1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < numbers.Length; i++)
            {
                string a = numbers[i].ToString();
                label1.Text += " " + a;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
