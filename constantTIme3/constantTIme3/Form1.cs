namespace constantTIme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fruits = { "Apple", "Banana", "Mango" };
            string fruit = fruits[0];
            string input = textBox1.Text;
            string inp = char.ToUpper(input[0]) + input[1..];
            if (string.Equals(input, fruit, StringComparison.OrdinalIgnoreCase)) {
                label2.Text = "CORRECT!";
            } else
            {
                label2.Text = "moron";
            }

        }
    }
}
