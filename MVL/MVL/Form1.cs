using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;


namespace MVL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] PortNames = SerialPort.GetPortNames(); 

            foreach (string portnumber in PortNames)
            {
                port_cbx.Items.Add(portnumber);         

            }
        }

        private void cycle_track_Scroll(object sender, EventArgs e)
        {
            switch (cycle_track.Value)
            {
                case 0:
                    cycle_lb.Text = "cycle : 10us (2px당 10us)";
                    break;
                case 1:
                    cycle_lb.Text = "cycle : 100us (2px당 100us)";
                    break;
                case 2:
                    cycle_lb.Text = "cycle : 1ms (2px당 1ms)";
                    break;
                case 3:
                    cycle_lb.Text = "cycle : 10ms (2px당 10ms)";
                    break;
                case 4:
                    cycle_lb.Text = "cycle : 100ms (2px당 100ms)";
                    break;
                case 5:
                    cycle_lb.Text = "cycle : 1s (2px당 1s)";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void baudlate_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(baudlate_cb.SelectedItem.ToString());
        }

        private void databits_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.DataBits = int.Parse(databits_cb.SelectedItem.ToString());
        }

        private void stopbits_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(stopbits_cb.SelectedIndex)
            {
                case 0: serialPort1.StopBits = StopBits.One; break;
                case 1: serialPort1.StopBits = StopBits.OnePointFive; break;
                case 2: serialPort1.StopBits = StopBits.Two; break;
            }
        }

        private void parity_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (parity_cb.SelectedIndex)
            {
                case 0: serialPort1.Parity = Parity.None; break;
                case 1: serialPort1.Parity = Parity.Odd; break;
                case 2: serialPort1.Parity = Parity.Even; break;
                case 3: serialPort1.Parity = Parity.Mark; break;
                case 4: serialPort1.Parity = Parity.Space; break;
            }
        }

        private void port_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = port_cbx.Text;
            serialPort1.Open();
        }

        private void connect_bt_Click(object sender, EventArgs e)
        {

            serialPort1.Write("X");

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(serialPort1.ReadChar() == 'X')
            {
                connect_lb.Text = "connected";
            }
            cycle_lb.Text = serialPort1.ReadLine();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
            Thread.Sleep(10);
            serialPort1.Write(port_tb.Text);
            Thread.Sleep(10);
            serialPort1.Write("N");
            Thread.Sleep(10);
            serialPort1.Write(pinnum_tb.Text);
            Thread.Sleep(10);
            serialPort1.Write("B");
            Thread.Sleep(10);
            serialPort1.Write(bits_cb.SelectedIndex.ToString()); 
            Thread.Sleep(10);
            serialPort1.Write("C");
            Thread.Sleep(10);
            serialPort1.Write(cycle_track.Value.ToString());
            Thread.Sleep(10);
            serialPort1.Write("E");
        }
    }
}
