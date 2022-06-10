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
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt", true);
            counter++;
            file.WriteLine("Contact No." + counter);
            file.WriteLine("Firstt Name: " + textBox1.Text);
            file.WriteLine("Middle Name: " + textBox2.Text);
            file.WriteLine("Age: " + textBox4.Text);
            file.WriteLine("Gender: " + textBox12.Text);
            file.WriteLine("Marital Status: " + textBox13.Text);
            file.WriteLine("Contact No.: " + textBox5.Text);
            file.WriteLine("Email: " + textBox6.Text);
            file.WriteLine("Country: " + textBox14.Text);
            file.WriteLine("Zip Code: " + textBox15.Text);
            file.WriteLine("Region: " + textBox11.Text);
            file.WriteLine("Province: " + textBox10.Text);
            file.WriteLine("City: " + textBox8.Text);
            file.WriteLine("Barangay: " + textBox9.Text);
            file.WriteLine("Nationality: " + textBox7.Text);
            file.WriteLine("Religion: " + textBox16.Text);
            file.WriteLine("------------------------------------------------------------");
            file.Close();
            MessageBox.Show("Thank you for submitting your info!", "Info Submitted!");
            reset();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt");
            int line = 0;
            String[] contacts = new String[18];
            while (!reader.EndOfStream)
            {
                for (int i = 0; i < 18; i++)
                {
                    contacts[i] = reader.ReadLine();
                    MessageBox.Show(Text, contacts[i]);
                }
            }
            //static void Main(String[] args)
            //{
            //    String[] contacts = new String[18];
            //    StreamReader reader = new StreamReader(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt");
            //
            //    for (int i = 0; i < 18; i++)
            //    {
            //        contacts[i] = reader.ReadLine();
            //        String line = reader.ReadLine();
            //        MessageBox.Show(line);
            //    }
            //    reader.Close();
            //}
            //StreamReader reader = new StreamReader(@"C:\Users\dillon\O-O-P\Contact-Tracing\ContactTracing.txt");           
            //for (int i = 0; i < 17; i++)
            //{
            //    String line = reader.ReadLine();
            //    MessageBox.Show(line);
            //   if (line == null)
            //    {
            //        break;
            //    }
            //}

            //String line = reader.ReadToEnd();
            //MessageBox.Show(line);
            //reader.Close();           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}