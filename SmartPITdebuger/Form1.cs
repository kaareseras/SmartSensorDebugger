//H1M6ou7DsmlWnpEBu4H7HPikmqWj32MWLweW3nw9Mljvbny3oG66Ko9JbgqF

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace SmartPITdebuger
{
    public partial class Form1 : Form
    {

        SerialPort _serialPort = new SerialPort();
        String RxString;
        String[] arrBaud = { "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200"};
        String[] arrCommands = { "SN read", "SN write", "FW version", "Set Mode", "Read Mode", "set pit status", "Read Pit status", "Set LED Status", "Set Blink status", "Set sensitivity", "Read sensitivity", "Set PIT-Direction", "Read PIT-Direction" };
        String[] arrRMS = { "RCS64", "SSDC", "PCLapCpunter" };
        String[] arrBoards = {"Nano", "UNO (SmartSensor)", "Mega" };

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Not connected";
            UpdatePortList();
            comboBoxSpeed.Items.AddRange(arrBaud);
            comboBoxSpeed.SelectedIndex = 5;

            comboBoxChooseCommand.Items.AddRange(arrCommands);
            comboBoxChooseCommand.SelectedIndex = 0;

            comboBoxRMS.Items.AddRange(arrRMS);
            comboBoxRMS.SelectedIndex = 0;

            comboBoxBoard.Items.AddRange(arrBoards);
            comboBoxBoard.SelectedIndex = 1;

        }   
        
        private void UpdatePortList()
        {
            comboBoxSerialports.Items.Clear();
            
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBoxSerialports.Items.Add(port);
            }

            if (comboBoxSerialports.Items.Count > 0) { comboBoxSerialports.SelectedIndex = 0; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePortList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSerialports.Text == "")
            {
                MessageBox.Show("Choose a port");
            }
            else
            {
                if (_serialPort.IsOpen == false)
                {
                    _serialPort = new SerialPort(comboBoxSerialports.Text, Convert.ToInt32(comboBoxSpeed.Text), Parity.None, 8, StopBits.One);
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    //_serialPort.BaudRate = Convert.ToInt32(comboBoxSpeed.Text);
                    _serialPort.Open();
                    buttonConnect.Text = "Disconnect";
                    toolStripStatusLabel1.Text = _serialPort.PortName.ToString() + " Connected at " + _serialPort.BaudRate.ToString() + " Baud";
                }
                else
                {
                    _serialPort.Close();
                    buttonConnect.Text = "Connect";
                    toolStripStatusLabel1.Text = "Not connected";
                }
            }
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the port is closed, don't try to send a character.
            if (!_serialPort.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.

            char[] buff = new char[1];

            // Load element 0 with the key character.
            buff[0] = e.KeyChar;

            // Send the one character buffer.
            _serialPort.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.

            e.Handled = true;
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            //RxString = _serialPort.ReadExisting();
            int i = _serialPort.ReadByte();
            RxString = i.ToString() + "  -   " + Convert.ToString(i, 2).PadLeft(8, '0') + "b" + (char)10;

            this.Invoke(new EventHandler(DisplayText));

            //RxString = _serialPort.ReadLine() ;

            //if (RxString.Substring(0, 12) == "ArduinoVbat:") { 
            //    //MessageBox.Show(RxString.Substring(13, 4)); 


            //    String URI = "http://scention.scentia.dk/Measures/MeasuresRegisterGet?datastream=8&Value=" + RxString.Substring(13, 4);

            //    WebClient webClient = new WebClient();
            //    Stream stream = webClient.OpenRead(URI);
            //    //String request = reader.ReadToEnd();

            //    stream.Close();
            //    webClient.Dispose();

            //}
            
            
            //File.AppendAllText(@"D:\ServerFolders\Dropbox\Scentia\Teknik\Sensorer\Log\MyLog.csv", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "," + RxString);

            //RxString += Environment.NewLine;



            //this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            textBoxRescv.AppendText(RxString);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen) _serialPort.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRescv.Text = "";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = !radioButton2.Checked;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = !radioButton3.Checked;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = !radioButton4.Checked;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = !radioButton5.Checked;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = !radioButton6.Checked;
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = !radioButton7.Checked;
        }
            
        private void radioButton8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = !radioButton8.Checked;
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                Int16 commandbyte = 0;
                Int16 databyte = 0;
                byte[] SendArr = { 0, 0 };

                switch (comboBoxChooseCommand.Text)
                {
                    case "SN read":
                        commandbyte = 1;
                        break;
                    case "SN write":
                        commandbyte = 2;
                        break;
                    case "FW version":
                        commandbyte = 3;
                        break;
                    case "Set Mode":
                        commandbyte = 14;
                        break;
                    case "Read Mode":
                        commandbyte = 5;
                        break;
                    case "set pit status":
                        commandbyte = 6;
                        break;
                    case "Read Pit status":
                        commandbyte = 7;
                        break;
                    case "Set LED Status":
                        commandbyte = 8;
                        break;
                    case "Set Blink status":
                        commandbyte = 9;
                        break;
                    case "Set sensitivity":
                        commandbyte = 10;
                        break;
                    case "Read sensitivity":
                        commandbyte = 11;
                        break;
                    case "Set PIT-Direction":
                        commandbyte = 12;
                        break;
                    case "Read PIT-Direction":
                        commandbyte = 13;
                        break;
                }

                databyte = 0;
                if (radioButton1.Checked) { databyte += 1; }
                if (radioButton2.Checked) { databyte += 2; }
                if (radioButton3.Checked) { databyte += 4; }
                if (radioButton4.Checked) { databyte += 8; }
                if (radioButton5.Checked) { databyte += 16; }
                if (radioButton6.Checked) { databyte += 32; }
                if (radioButton7.Checked) { databyte += 64; }
                if (radioButton8.Checked) { databyte += 128; }

                SendArr[0] = Convert.ToByte(commandbyte.ToString());
                SendArr[1] = Convert.ToByte(databyte.ToString());
                _serialPort.Write(SendArr, 0, SendArr.Length);

            }

            else
            {
                MessageBox.Show("No open connection");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.DtrEnable = true;
                System.Threading.Thread.Sleep(1000);
                _serialPort.DtrEnable = false;
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            Boolean serialWasOpen = false;
            if (_serialPort.IsOpen == true) {
                _serialPort.Close();
                serialWasOpen = true;
                //Thread.Sleep(2000);
            }
            
            
            string hexFile = "";
            if (comboBoxRMS.SelectedIndex == 0) {
                if (comboBoxBoard.SelectedIndex == 0) { hexFile = "RCS64nano.hex"; }
                if (comboBoxBoard.SelectedIndex == 1) { hexFile = "RCS64uno.hex"; }
                if (comboBoxBoard.SelectedIndex == 2) { hexFile = "RCS64mega.hex"; }
            }
            if (comboBoxRMS.SelectedIndex == 1)
            {
                if (comboBoxBoard.SelectedIndex == 0) { hexFile = "SSDCnano.hex"; }
                if (comboBoxBoard.SelectedIndex == 1) { hexFile = "SSDCuno.hex"; }
                if (comboBoxBoard.SelectedIndex == 2) { hexFile = "SSDCmega.hex"; }
            }
            if (comboBoxRMS.SelectedIndex == 2)
            {
                if (comboBoxBoard.SelectedIndex == 0) { hexFile = "PCLCnano.hex"; }
                if (comboBoxBoard.SelectedIndex == 1) { hexFile = "PCLCuno.hex"; }
                if (comboBoxBoard.SelectedIndex == 2) { hexFile = "PCLCmega.hex"; }
            }
            
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var iconPath = Path.Combine(outPutDirectory, "AVRDUDE\\avrdude.exe");
            string avrdude_path = new Uri(iconPath).LocalPath;

            hexFile = outPutDirectory + "\\AVRDUDE\\" + hexFile;
            hexFile = hexFile.Replace("file:\\", "");

            Process avrdude = new Process();
            avrdude.StartInfo.UseShellExecute = false;

            if (comboBoxBoard.SelectedIndex == 0)
            {
                avrdude.StartInfo.Arguments = String.Format("–C avrdude.conf -v -patmega328p -carduino -P\\\\.\\{0} -b 57600 -D -Uflash:w:{1}:i", comboBoxSerialports.Text, hexFile);
            }
            if (comboBoxBoard.SelectedIndex == 1)
            {
                avrdude.StartInfo.Arguments = String.Format("–C avrdude.conf -v -patmega328p -carduino -P\\\\.\\{0} -b 115200 -D -Uflash:w:{1}:i", comboBoxSerialports.Text, hexFile);
            }
            if (comboBoxBoard.SelectedIndex == 2)
            {
                avrdude.StartInfo.Arguments = String.Format("–C avrdude.conf -v -patmega2560 -cstkv2 -P\\\\.\\{0} -b 115200 -D -Uflash:w:{1}:i", comboBoxSerialports.Text, hexFile);
            }
            
            avrdude.StartInfo.FileName = avrdude_path;
            //avrdude.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //avrdude.StartInfo.CreateNoWindow = true;
            
            avrdude.Start();



            while (avrdude.HasExited == false) { }

            if (avrdude.ExitCode == 0) { MessageBox.Show("FW upgrade succesfull"); }
            else { MessageBox.Show("FW upgrade failed, check board/port"); }

            if (serialWasOpen == true) { _serialPort.Open(); }
        
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageFW_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRescv_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageConnect_Click(object sender, EventArgs e)
        {

        }



    }
}
