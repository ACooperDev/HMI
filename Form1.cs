using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Uses NuGet Microsoft.Web.WebView2
namespace HMI
{
    public partial class Form1 : Form
    {
        private Boolean canRun = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "1":
                    {
                        webView1.Size = new Size(Size.Width-35, Size.Height-100);
               
                        webView1.Visible = true;
                        webView2.Visible = false;
                        webView3.Visible = false;
                        webView4.Visible = false;
                        webView5.Visible = false;
                        webView6.Visible = false;

                        break;
                    }
                case "2":
                    {
                        webView1.Size = new Size((Size.Width - 35) / 2, Size.Height - 100);

                        webView2.Size = new Size((Size.Width - 35) / 2, Size.Height - 100);
                        webView2.Location = new Point(webView1.Location.X + webView1.Width, 50);
                        
                        webView1.Visible = true;
                        webView2.Visible = true;
                        webView3.Visible = false;
                        webView4.Visible = false;
                        webView5.Visible = false;
                        webView6.Visible = false;

                        break;
                    }
                case "3":
                    {
                        webView1.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100)/2);

                        webView2.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100)/2);
                        webView2.Location = new Point(webView1.Location.X + webView1.Width, 50);
                       
                        webView3.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100) / 2);
                        webView3.Location = new Point(webView1.Location.X, webView1.Location.Y + webView1.Height);
                       
                        webView1.Visible = true;
                        webView2.Visible = true;
                        webView3.Visible = true;
                        webView4.Visible = false;
                        webView5.Visible = false;
                        webView6.Visible = false;

                        break;
                    }
                case "4":
                    {
                        webView1.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100) / 2);

                        webView2.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100) / 2);
                        webView2.Location = new Point(webView1.Location.X + webView1.Width, 50);

                        webView3.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100) / 2);
                        webView3.Location = new Point(webView1.Location.X, webView1.Location.Y + webView1.Height);

                        webView4.Size = new Size((Size.Width - 35) / 2, (Size.Height - 100) / 2);
                        webView4.Location = new Point(webView1.Location.X + webView1.Width, webView1.Location.Y + webView1.Height);
                       
                        webView1.Visible = true;
                        webView2.Visible = true;
                        webView3.Visible = true;
                        webView4.Visible = true;
                        webView5.Visible = false;
                        webView6.Visible = false;

                        break;
                    }

                case "5":
                    {
                        webView1.Size = new Size((Size.Width - 35) / 3, (Size.Height - 100) / 2);

                        webView2.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView2.Location = new Point(webView1.Location.X + webView1.Width, 50);

                        webView3.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView3.Location = new Point(webView2.Location.X + webView2.Width, 50);

                        webView4.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView4.Location = new Point(webView1.Location.X, webView1.Location.Y + webView1.Height);

                        webView5.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView5.Location = new Point(webView2.Location.X, webView2.Location.Y + webView1.Height);

                        webView1.Visible = true;
                        webView2.Visible = true;
                        webView3.Visible = true;
                        webView4.Visible = true;
                        webView5.Visible = true;
                        webView6.Visible = false;

                        break;
                    }
                case "6":
                    {
                        webView1.Size = new Size((Size.Width - 35) / 3, (Size.Height - 100) / 2);

                        webView2.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView2.Location = new Point(webView1.Location.X + webView1.Width, 50);

                        webView3.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView3.Location = new Point(webView2.Location.X + webView2.Width, 50);

                        webView4.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView4.Location = new Point(webView1.Location.X, webView1.Location.Y + webView1.Height);

                        webView5.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView5.Location = new Point(webView2.Location.X, webView2.Location.Y + webView1.Height);

                        webView6.Size = new Size(webView1.Size.Width, webView1.Size.Height);
                        webView6.Location = new Point(webView2.Location.X + webView2.Width, webView3.Location.Y + webView2.Height);

                        webView1.Visible = true;
                        webView2.Visible = true;
                        webView3.Visible = true;
                        webView4.Visible = true;
                        webView5.Visible = true;
                        webView6.Visible = true;

                        break;
                    }
            }
        }
        private void loadWebPageiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
        }
        private void loadWebPageiniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            //if (canRun)
            if(true)
            {
                var fileContent = string.Empty;
                List<string> myList = new List<string>();
                string[] lines;
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "text files (*.txt)|*.txt)|MultiHMI files (*.ini)|*.ini|All files (*.*)|*.*";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var fileStream = openFileDialog.OpenFile();

                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                string line;

                                while ((line = reader.ReadLine()) != null)
                                {
                                    myList.Add(line);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                lines = myList.ToArray();

                try
                {
                    System.Uri myURI = new Uri(lines[0]);
                    webView1.Source = myURI;

                    myURI = new Uri(lines[1]);
                    webView2.Source = myURI;

                    myURI = new Uri(lines[2]);
                    webView3.Source = myURI;

                    myURI = new Uri(lines[3]);
                    webView4.Source = myURI;

                    myURI = new Uri(lines[4]);
                    webView5.Source = myURI;

                    myURI = new Uri(lines[5]);
                    webView6.Source = myURI;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Software Not Licensed.");
            }
        }
        private void webPageiniExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Place the full web URL of up to 6 camera, one per row, in the .ini file.");
        }
        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Set the size of the HMI." 
                + System.Environment.NewLine 
                + "2. Set the number of HMI's to display via File->Number of Displays"
                + System.Environment.NewLine
                + "3. Load the file containing your desired HMI's to display via File->Load WebPage.ini"
                + System.Environment.NewLine
                + "4. If the WebPage.ini file contains errors, HMI's beyond the error will not be displayed."
                );
        }
        private void testedHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ISE products"
                + System.Environment.NewLine
                + "ISVS (D900, L4000, 3800, 2800)"
                + System.Environment.NewLine
                + "Designer Web HMI"
                + System.Environment.NewLine
                + "DataMan products (280, 370)"
                );
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HMI.Validator myValidator = new HMI.Validator();

            if (myValidator.Check())
            {
                canRun = true;
            }
            else
            {
                MessageBox.Show("not valid");
                canRun = false;
            }
        }

        private void numberOfDisplaysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}