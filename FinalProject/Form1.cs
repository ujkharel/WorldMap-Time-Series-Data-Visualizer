using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace FinalProject
{
    public partial class Form1 : Form
    {
        System.Random randomNumberGenerator = new Random();
        Font font = new System.Drawing.Font("Times New Roman", 8, FontStyle.Regular);

        public Form1()
        {
            InitializeComponent();
            
            //Initial Set up
            FinalProjectDataSet.CountryInfoDataTable SomeList = new FinalProjectDataSet.CountryInfoDataTable();
            FinalProjectDataSetTableAdapters.CountryInfoTableAdapter CountryTableAdapter = new FinalProjectDataSetTableAdapters.CountryInfoTableAdapter();
            SomeList = CountryTableAdapter.GetDisRegionBy();
            regionPull.DataSource = SomeList;
            regionPull.DisplayMember = "Region";
            regionPull.ValueMember = "Region";
            SomeList = CountryTableAdapter.GetVarList();
            variablePull.DataSource = SomeList;
            variablePull.DisplayMember = "Variable";
            variablePull.ValueMember = "Variable";
            

            //Initially, show GDPPerCapita for All Countries
            variablePull.Text = "GDPPerCapita";
            regionPull.Text = "All Countries";
            getItDone();
                        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItDone();;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItDone();
        }

        private void radius_CheckedChanged(object sender, EventArgs e)
        {
            getItDone();
        }

        private void showNames_CheckedChanged(object sender, EventArgs e)
        {
            getItDone();
        }

        private void showMissing_CheckedChanged(object sender, EventArgs e)
        {
            getItDone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yearSlider.Value == 2011)
            {
                yearSlider.Value = 1980;
            }
            timer1.Enabled = true;
            label1.Text = "" + yearSlider.Value;
        }

        
        void yearSlider_ValueChanged(object sender, EventArgs e)
        {
            getItDone();
        }

        public void getItDone()
        {

            label1.Text = "" + yearSlider.Value;
            string Reg = regionPull.Text;
            if (Reg == "All Countries")
            {
                Reg = "%";
            }

            DataTable DGV1 = new DataTable();
            DGV1.Columns.Add("Country", typeof(string));
            DGV1.Columns.Add(variablePull.Text, typeof(float));
            DGV1.Columns.Add("Latitude", typeof(float));
            DGV1.Columns.Add("Longitude", typeof(float));
            
            graph.BackgroundImage = null;

            int pw = graph.Width;
            int ph = graph.Height;

            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(graph.Width, graph.Height);
            System.Drawing.Graphics graphicsSurface = System.Drawing.Graphics.FromImage(bitmap);

            FinalProjectDataSet.CountryInfoDataTable CountryList = new FinalProjectDataSet.CountryInfoDataTable();
            FinalProjectDataSetTableAdapters.CountryInfoTableAdapter CountryTableAdpater = new FinalProjectDataSetTableAdapters.CountryInfoTableAdapter();

            double minx1 = -2;
            double maxx1 = 2;
            double miny1 = -1;
            double maxy1 = 1;

            if (Reg == "Northern America")
            {
                minx1 = -2;
                maxx1 = 0;
                miny1 = 0;
                maxy1 = 1;
            };

            if (Reg == "Caribbean")
            {
                minx1 = -1.12;
                maxx1 = -0.52;
                miny1 = 0.06;
                maxy1 = 0.36;
            };

            double minvar = 1000;
            double maxvar = 30;



            CountryList = CountryTableAdpater.GetAllInRegion(Reg, variablePull.Text);

            foreach (DataRow row in CountryList.Rows)
            {
                double gdc = Convert.ToDouble(row[9]);
                minvar = Math.Min(minvar, gdc);
                maxvar = Math.Max(maxvar, gdc);
            }

            double maxsize = 20 + 50 * (maxvar - minvar) * (maxvar - minvar) / (maxvar*maxvar);



            CountryList = CountryTableAdpater.GetDataBy(Reg, variablePull.Text, yearSlider.Value);
            int rowInd=0;
            foreach (DataRow row in CountryList.Rows)
            {
                DGV1.Rows.Add(row[0], row[9], row[5], row[4]);
                double x1 = Convert.ToDouble(row[5]);
                double y1 = Convert.ToDouble(row[4]);
                double gdc = Convert.ToDouble(row[9]);
                string nm = Convert.ToString(row[0]);
                x1 = (pw) * (x1 - minx1) / (maxx1 - minx1);
                y1 = ph - (ph * (y1 - miny1) / (maxy1 - miny1));
                //x1 = (pw-maxsize) * (x1 - minx1) / (maxx1 - minx1)+maxsize/2;
                //y1 = ph - (ph * (y1 - miny1) / (maxy1 - miny1));
                int x = (int)Math.Round(x1, 0);
                int y = (int)Math.Round(y1, 0);

                int rc = (int)row[6];
                int gc = (int)row[7];
                int bc = (int)row[8];
                System.Drawing.Color color = System.Drawing.Color.FromArgb(rc, gc, bc);
                Brush brush = new SolidBrush(color);
        

                double scale = Math.Sqrt(gdc / maxvar);
                if (area.Checked == true)
                {
                    scale = Math.Sqrt(scale);
                };
                

                int size = (int)Math.Round(scale * maxsize);
                x = x - size/2;
                y = y - size/2;

                graphicsSurface.FillEllipse(brush, x, y, size, size);
                
                int xLeg = x;
                int yLeg = y-8;
                
                //if (Reg != "%")
                if (showNames.Checked)
                {
                    graphicsSurface.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    //brush = new SolidBrush(Color.Black);
                    graphicsSurface.DrawString(nm, font, brush, xLeg, yLeg);
                }
                rowInd=rowInd+1;
            };
            //Data Missing
            if (showMissing.Checked)
            {
                CountryList = CountryTableAdpater.GetMissingData(Reg, variablePull.Text, yearSlider.Value);
                foreach (DataRow row in CountryList.Rows)
                {
                    string nm = Convert.ToString(row[0]);
                    double x1 = Convert.ToDouble(row[5]);
                    double y1 = Convert.ToDouble(row[4]);
                    x1 = (pw) * (x1 - minx1) / (maxx1 - minx1);
                    y1 = ph - (ph * (y1 - miny1) / (maxy1 - miny1));
                    //x1 = (pw - maxsize) * (x1 - minx1) / (maxx1 - minx1) + maxsize / 2;
                    //y1 = ph - (ph * (y1 - miny1) / (maxy1 - miny1));
                    int x = (int)Math.Round(x1, 0);
                    int y = (int)Math.Round(y1, 0);
                    int rc = (int)row[6];
                    int gc = (int)row[7];
                    int bc = (int)row[8];

                    System.Drawing.Color color = System.Drawing.Color.FromArgb(rc, gc, bc);
                    Brush brush = new SolidBrush(Color.Black);
                    //DGV2.Rows.Add(row[0]);
                    int size = 10;
                    graphicsSurface.FillRectangle(brush, x, y, size, size);
                    int xLeg = x;
                    int yLeg = y-8;
                    if (showNames.Checked)
                    {
                        graphicsSurface.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        //brush = new SolidBrush(Color.Black);
                        graphicsSurface.DrawString(nm, font, brush, xLeg, yLeg);
                    }
                };
            };
            //}
            graph.Image = bitmap;
            //string imageName = regionPull.Text + @".jpg";
            graph.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Visual Studio 2012\Projects\FinalProject\Maps\All Countries.jpg");
            graph.BackgroundImageLayout = ImageLayout.Stretch;

            if (regionPull.Text == "Northern America")
            {
                graph.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Visual Studio 2012\Projects\FinalProject\Maps\Northern America.jpg");
                graph.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (regionPull.Text == "Caribbean")
            {
                graph.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Visual Studio 2012\Projects\FinalProject\Maps\Caribbean.jpg");
                graph.BackgroundImageLayout = ImageLayout.Stretch;
            }
            graphicsSurface.Dispose();
            GDPLEData.DataSource = DGV1;
            //missingData.DataSource = DGV2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (yearSlider.Value == 2011)
            {
                //yearSlider.Value = 1980; 
                timer1.Enabled = false;
            }
            else
            yearSlider.Value = yearSlider.Value + 1;
            timer1.Interval = (int) delay.Value*100;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
