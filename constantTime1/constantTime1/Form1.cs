namespace constantTime1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = cbNumbers.SelectedIndex;
            int[] numbers = { 10, 20, 30, 40, 50 };
            string ans = Convert.ToString(numbers[value]);
            lblNumber.Text = "Selected number: " + ans;
        }
    }
}
