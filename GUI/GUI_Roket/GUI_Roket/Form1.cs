using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace GUI_Roket
{
    public partial class GCS : Form
    {
        //Deklarasi
        private SerialPort myport;
        private DateTime kalender;
        private string data;
        private string data1;
        private string data2;
        private string data3;
        private int j;
        private string simpan;
        //private SerialDataReceivedEventHandler terima;

        public GCS()
        {
            InitializeComponent();
            button2.Enabled = false;
            //button3.Enabled = false;
            //button4.Enabled = false;
            //richTextBox2.Text = "Mencoba Koneksi kearduino !";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.PortName = Convert.ToString(comboBox1.Text);
            myport.BaudRate = Convert.ToInt32(comboBox2.Text);
            myport.DataReceived += terima;
            try
            {
                myport.Open();
            }
            catch (Exception)
            {
               // richTextBox2.Text = "Koneksi Arduino Gagal !";
            }
            button1.Enabled = false;
            //button2.Enabled = false;
            //button3.Enabled = true;
            //button4.Enabled = false;
        }

        void terima(object sender, SerialDataReceivedEventArgs e)
        {
            data = myport.ReadLine();
            this.Invoke(new EventHandler(display));
            j++;
        }
    }
}
