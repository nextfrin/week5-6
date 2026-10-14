namespace constantTime2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ten = 10;
            int twnety = 20;
            int sum = ten + twnety;
            //code above was accidentally multiplying instead of adding
            label2.Text = sum.ToString();
        }
    }
}
