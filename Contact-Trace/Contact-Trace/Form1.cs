namespace Contact_Trace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int numlines = 0;
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

            //StreamWriter fullname = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt", true);
            //fullname.WriteLine(counter + ". " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text);
            //fullname.Close();
            //StreamWriter age = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingAgeOnly.txt", true);
            //age.WriteLine(counter + ". " + typeKita4.Text);
            //age.Close();
            //StreamWriter gender = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingGenderOnly.txt", true);
            //gender.WriteLine(counter + ". " + typeKita5.Text);
            //gender.Close();
            //StreamWriter maritalstatus = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingMaritalStatusOnly.txt", true);
            //maritalstatus.WriteLine(counter + ". " + typeKita6.Text);
            //maritalstatus.Close();
            //StreamWriter cellphone = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCellphoneNo.Only.txt", true);
            //cellphone.WriteLine(counter + ". " + typeKita7.Text);
            //cellphone.Close();
            //StreamWriter email = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingEmailOnly.txt", true);
            //email.WriteLine(counter + ". " + typeKita8.Text);
            //email.Close();
            //StreamWriter country = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCountryOnly.txt", true);
            //country.WriteLine(counter + ". " + typeKita9.Text);
            //country.Close();
            //StreamWriter region = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingRegionOnly.txt", true);
            //region.WriteLine(counter + ". " + typeKita10.Text);
            //region.Close();
            //StreamWriter city = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCityOnly.txt", true);
            //city.WriteLine(counter + ". " + typeKita11.Text);
            //city.Close();
            //StreamWriter zip = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingZipCodeOnly.txt", true);
            //zip.WriteLine(counter + ". " + typeKita12.Text);
            //zip.Close();
            //StreamWriter province = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingProvinceOnly.txt", true);
            //province.WriteLine(counter + ". " + typeKita13.Text);
            //province.Close();
            //StreamWriter barangay = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingBarangayOnly.txt", true);
            //barangay.WriteLine(counter + ". " + typeKita14.Text);
            //barangay.Close();
            //StreamWriter nationality = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingNationalityOnly.txt", true);
            //nationality.WriteLine(counter + ". " + typeKita15.Text);
            //nationality.Close();
            //StreamWriter religion = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingReligionOnly.txt", true);
            //religion.WriteLine(counter + ". " + typeKita16);
            //religion.Close();

            StreamWriter whole = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt", true);
            whole.WriteLine("-------" + "Contact No." + counter + "-------");
            whole.WriteLine("Full Name: " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text);
            whole.WriteLine("Age: " + typeKita4.Text);
            whole.WriteLine("Gender: " + typeKita5.Text);
            whole.WriteLine("Marital Status: " + typeKita6.Text);
            whole.WriteLine("Cellphone No.: " + typeKita7.Text);
            whole.WriteLine("Email: " + typeKita8.Text);
            whole.WriteLine("Location: " + typeKita14.Text + " " + typeKita11.Text + " " + typeKita13.Text + " " + typeKita10.Text + " " + typeKita9.Text + " " + typeKita12.Text);
            whole.WriteLine("Nationality: " + typeKita15.Text);
            whole.WriteLine("Religion: " + typeKita16.Text);
            whole.WriteLine("-------" + "End of Contact No." + counter + "-------");
            //StreamWriter whole = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt", true);
            //whole.WriteLine("-------" + "Contact No." + counter + "-------" + "\n" + "Full Name: " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text + "\n" +
            //    "Age: " + typeKita4.Text + "\n" + "Gender: " + typeKita5.Text, "\n" + "Marital Status: " + typeKita6.Text);

            whole.Close();
            MessageBox.Show("Thank you for submitting your info!", "Info Submitted!");
            reset();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader whole = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt");
                //{
                //    String line;
                //    while ((line = whole.ReadLine()) != null)
                //    {
                //        list.Add(line); // Add to list.
                //        MessageBox.Show(line, "Personal Information"); // Write to console.
                //    }    
                //}
                //while (!whole.EndOfStream)
                //{
                //    String line = whole.ReadLine();
                //    String[] dividers = line.Split('\n');
                //    foreach (var div in dividers)
                //    {
                //        MessageBox.Show(line + dividers);
                //    }
                //}
                //whole.Close();

            String line = whole.ReadToEnd();
            MessageBox.Show(line, "Form");
            whole.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //napindot po
        }

        private void typeKita5_TextChanged(object sender, EventArgs e)
        {
            //napindot po 
        }

        private void clickMeToo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
            while (!fullname.EndOfStream)
            {
                String line = fullname.ReadLine();
                MessageBox.Show(line, "Full Name");
            }
            fullname.Close();
        }

        private void clickMeToo3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
            while (!fullname.EndOfStream)
            {
                String line = fullname.ReadLine();
                MessageBox.Show(line, "Full Name");
            }
            fullname.Close();
        }

        private void clickMeToo4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
            while (!fullname.EndOfStream)
            {
                String line = fullname.ReadLine();
                MessageBox.Show(line, "Full Name");
            }
            fullname.Close();
        }

        private void clickMeToo5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader age = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingAgeOnly.txt");
            while (!age.EndOfStream)
            {
                String line = age.ReadLine();
                MessageBox.Show(line, "Full Name");
            }
            age.Close();
        }

        private void clickMeToo6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader gender = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingGenderOnly.txt");
            while (!gender.EndOfStream)
            {
                String line = gender.ReadLine();
                MessageBox.Show(line, "Full Name");
            }
            gender.Close();
        }

        private void clickMeToo7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader maritalstatus = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingMaritalStatusOnly.txt");
            while (!maritalstatus .EndOfStream)
            {
                String line = maritalstatus.ReadLine();
                MessageBox.Show(line, "Full Name");
            }
            maritalstatus.Close();
        }
    }
}