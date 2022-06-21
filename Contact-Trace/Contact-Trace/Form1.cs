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

            StreamWriter fullname = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt", true);
            fullname.WriteLine(counter + ". " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text);
            fullname.Close();
            StreamWriter age = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingAgeOnly.txt", true);
            age.WriteLine(counter + ". " + typeKita4.Text);
            age.Close();
            StreamWriter gender = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingGenderOnly.txt", true);
            gender.WriteLine(counter + ". " + typeKita5.Text);
            gender.Close();
            StreamWriter maritalstatus = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingMaritalStatusOnly.txt", true);
            maritalstatus.WriteLine(counter + ". " + typeKita6.Text);
            maritalstatus.Close();
            StreamWriter cellphone = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCellphoneNo.Only.txt", true);
            cellphone.WriteLine(counter + ". " + typeKita7.Text);
            cellphone.Close();
            StreamWriter email = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingEmailOnly.txt", true);
            email.WriteLine(counter + ". " + typeKita8.Text);
            email.Close();
            StreamWriter country = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCountryOnly.txt", true);
            country.WriteLine(counter + ". " + typeKita9.Text);
            country.Close();
            StreamWriter region = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingRegionOnly.txt", true);
            region.WriteLine(counter + ". " + typeKita10.Text);
            region.Close();
            StreamWriter city = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCityOnly.txt", true);
            city.WriteLine(counter + ". " + typeKita11.Text);
            city.Close();   
            StreamWriter zip = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingZipCodeOnly.txt", true);
            zip.WriteLine(counter + ". " + typeKita12.Text);
            zip.Close();    
            StreamWriter province = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingProvinceOnly.txt", true);
            province.WriteLine(counter + ". " + typeKita13.Text);
            province.Close();
            StreamWriter barangay = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingBarangayOnly.txt", true);
            barangay.WriteLine(counter + ". " + typeKita14.Text);
            barangay.Close();
            StreamWriter nationality = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingNationalityOnly.txt", true);
            nationality.WriteLine(counter + ". " + typeKita15.Text);
            nationality.Close();
            StreamWriter religion = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingReligionOnly.txt", true);
            religion.WriteLine(counter + ". " + typeKita16);
            religion.Close();
            StreamWriter whole = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt", true);
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
            StreamReader reader = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt");
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

        private void typeKita5_TextChanged(object sender, EventArgs e)
        {
            //napindot po 
        }
    }
}