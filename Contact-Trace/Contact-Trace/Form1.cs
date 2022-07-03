using AForge.Video;
using AForge.Video.DirectShow;
using IronBarCode;
using QRCoder;

namespace Contact_Trace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        FilterInfoCollection collectMe;
        VideoCaptureDevice captureMe;
        
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
            String forms = "Full Name: " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text + "\n" + "Age: " + typeKita4.Text + "\n" + "Gender: " + typeKita5.Text + "\n" + "Marital Status: " + typeKita6.Text + "\n" + "Cellphone No.: " + typeKita7.Text + "\n" + "Email: " + typeKita8.Text + "\n" + "Location: " + typeKita14.Text + " " + typeKita11.Text + " " + typeKita13.Text + " " + typeKita10.Text + " " + typeKita9.Text + " " + typeKita12.Text; 
            QRCodeGenerator qrfname = new QRCodeGenerator();
            QRCodeData data = qrfname.CreateQrCode(forms, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(data);
            picMe3.Image = qRCode.GetGraphic(2);
            StreamWriter fullname = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt", true);
            fullname.WriteLine("Contact No." + counter + ": " + typeKita1.Text + " " + typeKita2.Text + " " + typeKita3.Text + " " + "(" + DateTime.Now + ")");
            fullname.Close();
            StreamWriter age = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingAgeOnly.txt", true);
            age.WriteLine("Contact No." + counter + ": " + typeKita4.Text + " " + "(" + DateTime.Now + ")");
            age.Close();
            StreamWriter gender = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingGenderOnly.txt", true);
            gender.WriteLine("Contact No." + counter + ": " + typeKita5.Text + " " + "(" + DateTime.Now + ")");
            gender.Close();
            StreamWriter maritalstatus = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingMaritalStatusOnly.txt", true);
            maritalstatus.WriteLine("Contact No." + counter + ": " + typeKita6.Text + " " + "(" + DateTime.Now + ")");
            maritalstatus.Close();
            StreamWriter cellphone = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCellphoneNo.Only.txt", true);
            cellphone.WriteLine("Contact No." + counter + ": " + typeKita7.Text + " " + "(" + DateTime.Now + ")");
            cellphone.Close();
            StreamWriter email = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingEmailOnly.txt", true);
            email.WriteLine("Contact No." + counter + ": " + typeKita8.Text + " " + "(" + DateTime.Now + ")");
            email.Close();
            StreamWriter country = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCountryOnly.txt", true);
            country.WriteLine("Contact No." + counter + ": " + typeKita9.Text + " " + "(" + DateTime.Now + ")");
            country.Close();
            StreamWriter region = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingRegionOnly.txt", true);
            region.WriteLine("Contact No." + counter + ": " + typeKita10.Text + " " + "(" + DateTime.Now + ")");
            region.Close();
            StreamWriter city = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCityOnly.txt", true);
            city.WriteLine("Contact No." + counter + ": " + typeKita11.Text + " " + "(" + DateTime.Now + ")");
            city.Close();
            StreamWriter zip = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingZipCodeOnly.txt", true);
            zip.WriteLine("Contact No." + counter + ": " + typeKita12.Text + " " + "(" + DateTime.Now + ")");
            zip.Close();
            StreamWriter province = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingProvinceOnly.txt", true);
            province.WriteLine("Contact No." + counter + ": " + typeKita13.Text + " " + "(" + DateTime.Now + ")");
            province.Close();
            StreamWriter barangay = new StreamWriter(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingBarangayOnly.txt", true);
            barangay.WriteLine("Contact No." + counter + ": " + typeKita14.Text + " " + "(" + DateTime.Now + ")");
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
            whole.WriteLine("Date and Time Filled: " + DateTime.Now);
            whole.WriteLine("-------" + "End of Contact No." + counter + "-------");
            whole.Close();
            MessageBox.Show("Thank you for submitting your info!", "Info Submitted!");
            reset();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader whole = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingWholeForm.txt");
                String line = whole.ReadToEnd();
                MessageBox.Show(line, "Form");
                whole.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }
        private void clickMeToo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
                String line = fullname.ReadToEnd();
                MessageBox.Show(line, " List of Contact's Full Name");
                fullname.Close();
            }     
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
            
        }

        private void clickMeToo3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
                String line = fullname.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Full Name");
                fullname.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader fullname = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingFullNameOnly.txt");
                String line = fullname.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Full Name");
                fullname.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }
        private void clickMeToo5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader age = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingAgeOnly.txt");
                String line = age.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Age");
                age.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader gender = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingGenderOnly.txt");
                String line = gender.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Gender");
                gender.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader maritalstatus = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingMaritalStatusOnly.txt");
                String line = maritalstatus.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Marital Status");
                maritalstatus.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }

        }

        private void clickMeToo8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader cellphone = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCellphoneNo.Only.txt");
                String line = cellphone.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Cellphone No.");
                cellphone.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader email = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingEmailOnly.txt");
                String line = email.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Email");
                email.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }
    
        private void clickMeToo10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader country = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCountryOnly.txt");
                String line = country.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Country");
                country.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet" , "Error");
            }
        }

        private void clickMeToo11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader region = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingRegionOnly.txt");
                String line = region.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Region");
                region.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader city = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingCityOnly.txt");
                String line = city.ReadToEnd();
                MessageBox.Show(line, "List of Contact's City");
                city.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader zipcode = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingZipCodeOnly.txt");
                String line = zipcode.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Zip Code");
                zipcode.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader province = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingProvinceOnly.txt");
                String line = province.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Province");
                province.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void clickMeToo15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamReader barangay = new StreamReader(@"C:\Users\valen\O-O-P\Contact-Tracing\ContactTracingBarangayOnly.txt");
                String line = barangay.ReadToEnd();
                MessageBox.Show(line, "List of Contact's Barangay");
                barangay.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Forms Yet", "Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(picMe2.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);
            if (result != null)
            {
                var qrResult = result.Text.Split(new char[] { '\n' , ',' });
                if (qrResult.Length == 14)
                {
                    typeKita1.Text = qrResult[0];
                    typeKita2.Text = qrResult[1];
                    typeKita3.Text = qrResult[2];
                    typeKita4.Text = qrResult[3];
                    typeKita5.Text = qrResult[4];
                    typeKita6.Text = qrResult[5];
                    typeKita7.Text = qrResult[6];
                    typeKita8.Text = qrResult[7];
                    typeKita9.Text = qrResult[12];
                    typeKita10.Text = qrResult[11];
                    typeKita11.Text = qrResult[9];
                    typeKita12.Text = qrResult[13];
                    typeKita13.Text = qrResult[10];
                    typeKita14.Text = qrResult[8];
                }
            }
            else
            {
                MessageBox.Show("Can't Read QR Code", "Please Try Again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            collectMe = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in collectMe)
                myCam1.Items.Add(filterInfo.Name);
            myCam1.SelectedIndex = 0;
        }

        private void clickMe3_Click(object sender, EventArgs e)
        {
            picMe2.Image = (Bitmap)picMe1.Image.Clone();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picMe1.Image = eventArgs.Frame.Clone() as Bitmap;
        }

        private void clickMe4_Click(object sender, EventArgs e)
        {
            captureMe= new VideoCaptureDevice(collectMe[myCam1.SelectedIndex].MonikerString);
            captureMe.NewFrame += CaptureDevice_NewFrame;
            captureMe.Start();
        }

    }
}