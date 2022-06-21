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
            typeKita1.Text = "";
            typeKita2.Text = "";
            typeKita3.Text = "";
            typeKita4.Text = "";
            typeKita7.Text = "";
            typeKita8.Text = "";
            typeKita15.Text = "";
            typeKita11.Text = "";
            typeKita14.Text = "";
            typeKita13.Text = "";
            typeKita10.Text = "";
            typeKita5.Text = "";
            typeKita6.Text = "";
            typeKita9.Text = "";
            typeKita12.Text = "";
            typeKita16.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            StreamWriter fullname = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\FullName.txt", true);
            fullname.WriteLine("Contact No." + counter + ":" + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text);
            fullname.Close();
            StreamWriter whole = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\WholeForm.txt", true);
            whole.WriteLine("-------" + "Contact No." + counter + "-------");
            whole.WriteLine("First Name: " + typeKita1.Text);
            whole.WriteLine("Middle Name: " + typeKita2.Text);
            whole.WriteLine("Last name: " + typeKita3.Text);
            whole.WriteLine("Age: " + typeKita4.Text);
            whole.WriteLine("Gender: " + typeKita5.Text);
            whole.WriteLine("Marital Status: " + typeKita6.Text);
            whole.WriteLine("Contact No.: " + typeKita7.Text);
            whole.WriteLine("Email: " + typeKita8.Text);
            whole.WriteLine("Country: " + typeKita9.Text);
            whole.WriteLine("Zip Code: " + typeKita12.Text);
            whole.WriteLine("Region: " + typeKita10.Text);
            whole.WriteLine("Province: " + typeKita13.Text);
            whole.WriteLine("City: " + typeKita11.Text);
            whole.WriteLine("Barangay: " + typeKita14.Text);
            whole.WriteLine("Nationality: " + typeKita15.Text);
            whole.WriteLine("Religion: " + typeKita16.Text);
            whole.WriteLine("-------" + "End of Contact No." + counter + "-------");
            whole.Close();
            MessageBox.Show("Thank you for submitting your info!", "Info Submitted!");
            reset();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracing.txt");
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                MessageBox.Show(line, "Personal Information");
            }
            reader.Close();

            //String line = reader.ReadToEnd();
            //MessageBox.Show(line, "Form");
            //reader.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //napindot po
        }
    }
}