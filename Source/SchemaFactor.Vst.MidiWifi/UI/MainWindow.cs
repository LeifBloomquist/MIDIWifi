using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchemaFactor.Vst.MidiWifi
{
    /// Main GUI Window
    partial class MainWindow : UserControl  //  DoubleBufferedUserControl
    {        
        private Plugin _plugin = null;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        float ReceivePulse = 0f;

        /// <summary>
        /// Main Form Constructor.  Must be parameterless to avoid error CS0310.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            Thread t = new Thread(UDPListenThread);
            t.Start();
        }

        public void setPlugin(Plugin plugin)
        {
            _plugin = plugin;       
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Sets the timer interval to 50 milliseconds.
            myTimer.Tick += TimerEventProcessor;            
            myTimer.Interval = 50;
            myTimer.Start();
        }

        // This is the method to run when the timer is raised.
        // Animates the background of the textbox items.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
             if (_plugin == null) return;
            
             int red = (int)(ReceivePulse * 255);
             if (red > 255) red = 255;

             RX_LED.BackColor = Color.FromArgb(red, 0, 0);
             ReceivePulse *= 0.7f;
        }


        private void UDPListenThread()
        {
            byte[] data = null;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 5171);
            UdpClient newsock = new UdpClient(ipep);

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                data = newsock.Receive(ref sender);

                try
                {
                    this.Invoke(new Action(() => { Parse(sender, data); }));
                }
                catch (Exception)
                {
                    Application.Exit();
                }
            }
        }

        public void Parse(IPEndPoint sender, byte[] data)
        {
            ReceivePulse = 1.0f;

            DebugLabel.Text = Utilities.ByteArrayToString(data);

            if (data.Length != 30)
            {
                return;
            }

            if (data[0] != 0xB0)
            {
                return;
            }

            double AccelX = data[2] / 127d;
            double AccelY = data[5] / 127d;
            double AccelZ = data[8] / 127d;
            double AccelM = data[11] / 127d;
            double GyroX = data[14] / 127d;
            double GyroY = data[17] / 127d;
            double GyroZ = data[20] / 127d;
            double MagX = data[23] / 127d;
            double MagY = data[26] / 127d;
            double MagZ = data[29] / 127d;



        }

        /// <summary>
        /// Updates the UI
        /// </summary>
        public void ProcessIdle()
        {
            if (_plugin == null) return;
            _plugin.idleCount++;
        }

        // "About" Button
        private void AboutButton_Click(object sender, EventArgs e)
        {
            if (_plugin == null) return;

            AboutButton.ForeColor = Color.White;

            AboutForm about = new AboutForm(_plugin.ProductInfo.Vendor + "\n\n" +
                                            _plugin.ProductInfo.Product + "   " +
                              "Version: " + _plugin.ProductInfo.FormattedVersion + "");

            about.ShowDialog(this);

            AboutButton.ForeColor = Color.Black;
        }
    }
}
