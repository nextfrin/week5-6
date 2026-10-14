namespace linearTime2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = { "Ana", "Ben", "Carlo", "David" };
            foreach (string name in names) { 
            if (name == textBox1.Text)
                {
                    label1.Text = "name found";
                } else
                {
                    label1.Text = "name not found";
                }
            }
        }
    }
}
