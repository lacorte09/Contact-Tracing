namespace Contact_Trace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt", true);
            counter++;
            file.WriteLine("Contact No." + counter);
            file.WriteLine("Firstt Name: " + textBox1.Text);
            file.WriteLine("Middle Name: " + textBox2.Text);
            file.WriteLine("Age: " + textBox4.Text);
            file.WriteLine("Contact No.: " + textBox5.Text);
            file.WriteLine("Email: " + textBox6.Text);
            file.WriteLine("------------------------------------------------------------");
            file.Close();
            MessageBox.Show("Thank you for submitting your info!", "Info Submitted!");
            reset();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt");
            foreach (String line in 
            {

            }

            //ring line = reader.ReadBlock();
           //essageBox.Show(line);
           //eader.Close();
            //hile (!reader.EndOfStream)
            //
            //   String line = reader.ReadToEnd();
            //  MessageBox.Show(line);
            //}
        }
    }
}