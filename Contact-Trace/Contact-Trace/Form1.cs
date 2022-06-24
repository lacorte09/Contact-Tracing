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
            typeKita5.Text = "";
            typeKita6.Text = "";
            typeKita7.Text = "";
            typeKita8.Text = "";
            typeKita9.Text = "";
            typeKita10.Text = "";
            typeKita11.Text = "";
            typeKita12.Text = "";
            typeKita13.Text = "";
            typeKita14.Text = "";
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

            StreamWriter whole = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt", true);
            whole.WriteLine("-------" + "Contact No." + counter + "-------");
            whole.WriteLine("Full Name: " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text);
            whole.WriteLine("Age: " + typeKita4.Text);
            whole.WriteLine("Gender: " + typeKita5.Text);
            whole.WriteLine("Marital Status: " + typeKita6.Text);
            whole.WriteLine("Cellphone No.: " + typeKita7.Text);
            whole.WriteLine("Email: " + typeKita8.Text);
            whole.WriteLine("Location: " + typeKita14.Text + " " + typeKita11.Text + " " + typeKita13.Text + " " + typeKita10.Text + " " + typeKita9.Text + " " + typeKita12.Text);
            whole.WriteLine("-------" + "End of Contact No." + counter + "-------");
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
            String line = fullname.ReadToEnd();
            MessageBox.Show(line, " List of Full Name");        
            fullname.Close();
        }

        private void clickMeToo3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
            String line = fullname.ReadToEnd();
            MessageBox.Show(line, "List of Full Name");
            fullname.Close();
        }

        private void clickMeToo4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
            String line = fullname.ReadToEnd();
            MessageBox.Show(line, "List of Full Name");
            fullname.Close();
        }

        private void clickMeToo5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader age = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingAgeOnly.txt");
            String line = age.ReadToEnd();
            MessageBox.Show(line, "List of Age");
            age.Close();
        }

        private void clickMeToo6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader gender = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingGenderOnly.txt");
            String line = gender.ReadToEnd();
            MessageBox.Show(line, "List of Gender");
            gender.Close();
        }

        private void clickMeToo7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader maritalstatus = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingMaritalStatusOnly.txt");
            String line = maritalstatus.ReadToEnd();
            MessageBox.Show(line, "List of Marital Status");
            maritalstatus.Close();

        }

        private void clickMeToo8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader cellphone = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCellphoneNo.Only.txt");
            String line = cellphone.ReadToEnd();
            MessageBox.Show(line, "List of Cell Phone");
            cellphone.Close();
        }

        private void clickMeToo9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader email = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingEmailOnly.txt");
            String line = email.ReadToEnd();
            MessageBox.Show(line, "List of Email");
            email.Close();
        }
    

        private void clickMeToo10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader country = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCountryOnly.txt");
            String line = country.ReadToEnd();
            MessageBox.Show(line, "Country");
            country.Close();
        }

        private void clickMeToo11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader region = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingRegionOnly.txt");
            String line = region.ReadToEnd();
            MessageBox.Show(line, "Region");
            region.Close();
        }

        private void clickMeToo12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader city = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCityOnly.txt");
            String line = city.ReadToEnd();
            MessageBox.Show(line, "City");
            city.Close();
        }

        private void clickMeToo13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader zipcode = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingZipCodeOnly.txt");
            String line = zipcode.ReadToEnd();
            MessageBox.Show(line, "Zip Code");
            zipcode.Close();
        }

        private void clickMeToo14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader province = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingProvinceOnly.txt");
            String line = province.ReadToEnd();
            MessageBox.Show(line, "Province");
            province.Close();
        }

        private void clickMeToo15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader barangay = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingBarangayOnly.txt");
            String line = barangay.ReadToEnd();
            MessageBox.Show(line, "Barangay");
            barangay.Close();
        }
    }

}