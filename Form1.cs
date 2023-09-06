using System;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int minvalue = 100;
        int maxvalue = 0;
        double average = 0;
        int countpoint = 0;
        public Form1()
        {
            InitializeComponent();
             minvalue = 100;
             maxvalue = 0;
             average = 0;
             countpoint = 0;
        }
        string[] pause = { "1200", "4800", "2400", "9600", "38400", "57600", "14880" };

        private void lisPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[] listnamecom = SerialPort.GetPortNames();
            lisPort.Items.AddRange(listnamecom);
            lisBaul.Items.AddRange(pause);

            GraphPane grap = zedGraphControl1.GraphPane;
            grap.Title.Text = " Biểu đồ nhiệt độ ";
            grap.XAxis.Title.Text = "TIME";
            grap.YAxis.Title.Text = "DEGREE";

            RollingPointPairList list1 = new RollingPointPairList(60000);

            LineItem duongline1 = grap.AddCurve("DEGREE", list1, System.Drawing.Color.Blue, SymbolType.Circle);

            grap.XAxis.Scale.Min = 0;
            grap.XAxis.Scale.Max = 100;
            grap.XAxis.Scale.MinorStep = 1;
            grap.XAxis.Scale.MajorStep = 5;

            grap.YAxis.Scale.Min = 0;
            grap.YAxis.Scale.Max = 100;
            grap.YAxis.Scale.MinorStep = 1;
            grap.YAxis.Scale.MajorStep = 5;

            zedGraphControl1.AxisChange();
        }
        int tong = 0;
        public void draw(double line1)
        {
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            LineItem duongline1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (duongline1 == null)
                return;
            IPointListEdit list1 = duongline1.Points as IPointListEdit;
            if (list1 == null)
                return;
            list1.Add(tong, line1);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            tong += 2;


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                btnConnect.Text = "Connect";
            }
            else if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = lisPort.Text;
                serialPort1.BaudRate = int.Parse(lisBaul.Text);
                serialPort1.Open();
                btnConnect.Text = "Disconnect";

            }
        }

        private void btnNd_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = "";
            data = serialPort1.ReadLine ();
                 
            if (data.Length > 0)
            {
                Invoke(new MethodInvoker(() => txtnhietdo.Text = data + "°C"));
                try
                {
                    double datapoint = double.Parse(data);
                    Invoke(new MethodInvoker(() => draw(Convert.ToDouble(data))));
                    Invoke(new MethodInvoker(() =>
                    {
                        if (datapoint > maxvalue)
                        {
                            maxvalue = (int)datapoint;
                            txtMaxValue.Text = maxvalue.ToString();
                        }
                        if (datapoint < minvalue)
                        {
                           minvalue = (int)datapoint;
                           txtMinValue.Text = minvalue.ToString();
                        }
                        average = (average * countpoint + datapoint) / (countpoint + 1);
                        countpoint++;
                        double roundedNumber = Math.Round(average, 3);
                        txtAveValue.Text = roundedNumber.ToString();
                    }));

                }
                catch
                {

                }
                
            }         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        bool tb1 = true;
        private void btnLED1_Click(object sender, EventArgs e)
        {
            if (tb1 == true)
            {
                serialPort1.Write("a1?");
                btnLED1.Text = "ON";
                tb1 = false;
            }
            else
            {
                serialPort1.Write("a0?");
                btnLED1.Text = "OFF";
                tb1 = true;
            }
        }
        bool tb2 = true;
        private void btnLED2_Click(object sender, EventArgs e)
        {
            if (tb2 == true)
            {
                serialPort1.Write("b1?");
                btnLED2.Text = "ON";
                tb2 = false;
            }
            else
            {
                serialPort1.Write("b0?");
                btnLED2.Text = "OFF";
                tb2 = true;
            }
        }
        bool tb3 = true;
        private void btnLED3_Click(object sender, EventArgs e)
        {
            if (tb3 == true)
            {
                serialPort1.Write("c1?");
                btnLED3.Text = "ON";
                tb3 = false;
            }
            else
            {
                serialPort1.Write("c0?");
                btnLED3.Text = "OFF";
                tb3 = true;
            }
        }
        bool tb4 = true;
        private void btnLED4_Click(object sender, EventArgs e)
        {
            if (tb4 == true)
            {
                serialPort1.Write("d1?");
                btnLED4.Text = "ON";
                tb4 = false;
            }
            else
            {
                serialPort1.Write("d0?");
                btnLED4.Text = "OFF";
                tb4 = true;
            }
        }
        bool tb5 = true;
        private void btnLED5_Click(object sender, EventArgs e)
        {
            if (tb5 == true)
            {
                serialPort1.Write("e1?");
                btnLED5.Text = "ON";
                tb5 = false;
            }
            else
            {
                serialPort1.Write("e0?");
                btnLED5.Text = "OFF";
                tb5 = true;
            }
        }
        bool tb6 = true;
        private void btnLED6_Click(object sender, EventArgs e)
        {
            if (tb6 == true)
            {
                serialPort1.Write("f1?");
                btnLED6.Text = "ON";
                tb6 = false;
            }
            else
            {
                serialPort1.Write("f0?");
                btnLED6.Text = "OFF";
                tb6 = true;
            }
        }
        bool tb7 = true;
        private void btnLED7_Click(object sender, EventArgs e)
        {
            if (tb7 == true)
            {
                serialPort1.Write("g1?");
                btnLED7.Text = "ON";
                tb7 = false;
            }
            else
            {
                serialPort1.Write("g0?");
                btnLED7.Text = "OFF";
                tb7 = true;
            }
        }
        bool tb8 = true;
        private void btnLED8_Click(object sender, EventArgs e)
        {
            if (tb8 == true)
            {
                serialPort1.Write("h1?");
                btnLED8.Text = "ON";
                tb8 = false;
            }
            else
            {
                serialPort1.Write("h0?");
                btnLED8.Text = "OFF";
                tb8 = true;
            }
        }

        private void txtMinValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        bool start = true;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                serialPort1.Write("sp?");
                btnStart.Text = "START";
                pictureBox3.Image= global::WindowsFormsApp1.Properties.Resources.off;
                start = false;
            }
            else
            {
                serialPort1.Write("st?");
                btnStart.Text = "STOP";
                pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.on;
                start = true;


            }
        }




    }
}



