namespace Contact_Trace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt");
            file.WriteLine("Frist Name: " + textBox1.Text);
            file.WriteLine("Middle Name: " + textBox2.Text);
            file.WriteLine("Last Name: "+ textBox3.Text);
            file.Close();
        }
    }
}