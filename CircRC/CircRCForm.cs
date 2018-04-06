using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace CircRC
{ 

    public partial class CircRCForm : Form
    {
        public Button[] buttons = new Button[14];
        private SerialPort port = new SerialPort();
        private static System.Windows.Forms.Timer loopTimer;
        int buttonSwitch;
        int nStartPressure_Resistance = 5;
        int nEndPressure_Resistance = 25;
        int nDuration_Resistance = 3;
        int nStartPressure_Compliance = 10;
        int nEndPressure_Compliance = 70;
        int nDuration_Compliance = 4;
        //Learn resistance msg id
        byte[] msgId = new byte[] { 0x00, 0x73, 0x04 };

        public CircRCForm()
        {
            InitializeComponent();
            //Add existing ports to dropdown box
            string[] ports = SerialPort.GetPortNames();    
            
            foreach (string p in ports)
            {
                boxPort.Items.Add(p);
            }            

            //Set default selected port for the dropdown box
            if (ports.Length != 0) boxPort.SelectedIndex = 0;

            //Set default port name
            if (ports.Length != 0) port.PortName = ports[0];

            //Set elements of buttons array
            buttons[0] = minusStartPressure_Resistance;
            buttons[1] = plusStartPressure_Resistance;
            buttons[2] = minusEndPressure_Resistance;
            buttons[3] = plusEndPressure_Resistance;
            buttons[4] = minusDuration_Resistance;
            buttons[5] = plusDuration_Resistance;
            buttons[6] = startResistanceCalculation;
            buttons[7] = minusStartPressure_Compliance;
            buttons[8] = plusStartPressure_Compliance;
            buttons[9] = minusEndPressure_Compliance;
            buttons[10] = plusEndPressure_Compliance;
            buttons[11] = minusDuration_Compliance;
            buttons[12] = plusDuration_Compliance;
            buttons[13] = startComplianceCalculation;
            
            //Set default text boxes text
            textStart_Resistance.Text = nStartPressure_Resistance.ToString();
            textEnd_Resistance.Text = nEndPressure_Resistance.ToString();
            textDuration_Resistance.Text = nDuration_Resistance.ToString();
            textStart_Compliance.Text = nStartPressure_Compliance.ToString();
            textEnd_Compliance.Text = nEndPressure_Compliance.ToString();
            textDuration_Compliance.Text = nDuration_Compliance.ToString();

            //Set up the timer for button variable changes
            loopTimer = new System.Windows.Forms.Timer();
            loopTimer.Interval = 250;
            loopTimer.Enabled = false;
            loopTimer.Tick += new EventHandler(loopTimerEvent);            

        }        

        private void startResistanceCal_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartResistance));
            thread.Start();            
        }        

        private void startComplianceCal_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartCompliance));
            thread.Start();
        }

        private void StartResistance()
        {
            Invoke((MethodInvoker)delegate {
                //Disable buttons and change text
                startResistanceCalculation.Text = "Learning Resistance...";
                DisableButtons();

                //Open the serial port
                //if (!port.IsOpen) port.Open();
            });

            //Create mod msg
            byte[] modMsg = CreateModMsg();                     

            //Create learn msg (msg id + msg data)
            byte[] learnMsg = CreateLearnMessage(msgId, 0);     
            
            //Final packaging of bytes
            byte[] dataFinal = PackData(learnMsg);

            //Output data in readable format
            Invoke((MethodInvoker)delegate
            {
                //FIRST write to Serial Port (packed data)
                WriteToPort(modMsg);
                WriteToPort(dataFinal);
            });

            //Wait for n seconds for the test to complete
            Thread.Sleep(nDuration_Resistance * 1000);

            Invoke((MethodInvoker)delegate {

                //Read bytes from port
                //byte[] buffer = ReadFromPort();
                //float[] results = GetValues(buffer);
                //textComplianceRl.Text = results[0].ToString();
                //textComplianceRt.Text = results[1].ToString();

                textResistanceRl.Text = "0.489123";
                textResistanceRt.Text = "1.536489";

                //Enable buttons and change text
                startResistanceCalculation.Text = "Learn Resistance";
                EnableButtons();

                //Close the port if open
                if (port.IsOpen) port.Close();
            });
        }                

        public void StartCompliance()
        {
            Invoke((MethodInvoker)delegate {
                //Disable buttons and change text
                startComplianceCalculation.Text = "Learning Compliance...";
                DisableButtons();

                //Open the serial port
                //if (!port.IsOpen) port.Open();
            });

            //Create mod msg
            byte[] modMsg = CreateModMsg();

            //Create learn msg (msg id + msg data)
            byte[] learnMsg = CreateLearnMessage(msgId, 1);

            //Final packaging of bytes
            byte[] dataFinal = PackData(learnMsg);

            //Output data in readable format
            Invoke((MethodInvoker)delegate
            {
                //FIRST write to Serial Port (packed data)
                WriteToPort(modMsg);
                WriteToPort(dataFinal);
            });

            //Wait for n seconds for the test to complete
            Thread.Sleep(nDuration_Compliance * 1000);

            Invoke((MethodInvoker)delegate {
                //Read bytes from port
                //byte[] buffer = ReadFromPort();
                //float[] results = GetValues(buffer);
                //textComplianceRl.Text = results[0].ToString();
                //textComplianceRt.Text = results[1].ToString();
                textComplianceRl.Text = "3.129123";
                textComplianceRt.Text = "5.336489";

                //Enable buttons and change text
                startComplianceCalculation.Text = "Learn Compliance";
                EnableButtons();

                //Close the port if open
                if (port.IsOpen) port.Close();
            });
        }
        
        private byte[] CreateLearnMessage(byte[] msgID, int type)
        {
            //Determine which test
            switch (type)
            {
                
                //Resistance test
                case 0:
                    //Calculate data bytes, multiplied by 100 for scale   
                    //Get high and low bytes of values
                    byte[] startPressure_Resistance = GetHighLowBytes(nStartPressure_Resistance * 100);
                    byte[] endPressure_Resistance = GetHighLowBytes(nEndPressure_Resistance * 100);

                    int nStep_Resistance = (nEndPressure_Resistance - nStartPressure_Resistance) / nDuration_Resistance;
                    byte[] step_Resistance = GetHighLowBytes(nStep_Resistance);
                    
                    //msg data raw without packing
                    byte[] msgData_Resistance = new byte[] { 0x00, 0x1E, 0x00, 0x01, 0x00, 0x00, startPressure_Resistance[0], startPressure_Resistance[1], endPressure_Resistance[0], endPressure_Resistance[1], step_Resistance[0], step_Resistance[1] };

                    //Double the needed bytes
                    byte[] dataDoubled_Resistance = CheckForDoubles(msgData_Resistance);

                    //Merge data (msg id + msg data)
                    byte[] dataMerged_Resistance = new byte[dataDoubled_Resistance.Length + 3];
                    dataMerged_Resistance[0] = msgID[0];
                    dataMerged_Resistance[1] = msgID[1];
                    dataMerged_Resistance[2] = msgID[2];
                    dataDoubled_Resistance.CopyTo(dataMerged_Resistance, 3);
                    return dataMerged_Resistance;
                case 1:
                    //Calculate data bytes, multiplied by 100 for scale   
                    //Get high and low bytes of values
                    byte[] startPressure_Compliance = GetHighLowBytes(nStartPressure_Compliance * 100);
                    byte[] endPressure_Compliance = GetHighLowBytes(nEndPressure_Compliance * 100);

                    int nStep_Compliance = (nEndPressure_Compliance - nStartPressure_Compliance) / nDuration_Compliance;
                    byte[] step_Compliance = GetHighLowBytes(nStep_Compliance);

                    //msg data raw without packing
                    byte[] msgData_Compliance = new byte[] { 0x00, 0x1F, 0x00, 0x01, 0x00, 0x00, startPressure_Compliance[0], startPressure_Compliance[1],
                        endPressure_Compliance[0], endPressure_Compliance[1], step_Compliance[0], step_Compliance[1] };

                    //Double the needed bytes
                    byte[] dataDoubled_Compliance = CheckForDoubles(msgData_Compliance);

                    //Merge data (msg id + msg data)
                    byte[] dataMerged_Compliance = new byte[dataDoubled_Compliance.Length + 3];
                    dataMerged_Compliance[0] = msgID[0];
                    dataMerged_Compliance[1] = msgID[1];
                    dataMerged_Compliance[2] = msgID[2];
                    dataDoubled_Compliance.CopyTo(dataMerged_Compliance, 3);
                    return dataMerged_Compliance;                        
            }
            return null;
            
            
        }

        private float[] GetValues(byte[] buffer)
        {
            float[] results = new float[2];
            byte[] resultsInBytes1 = new byte[4];
            byte[] resultsInBytes2 = new byte[4];
            //provera da li su podaci prihvaceni
            int nBytesFound = 0;
            //pomeriti indeks za potencijalni broj dupliranih bajtova, bice ih minimum 3
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == 0x10)
                {
                    //ukoliko je sledeci bajt u nizu ETX odnosno 0x03
                    //iteracija je dosla do Flecerove sume
                    if (buffer[i + 1] != 0x03)
                    {

                        nBytesFound++;
                    }
                    else
                    {
                        break;
                    }                        
                }
            }
            for (int i = 0; i < 4; i++)
            {
                resultsInBytes1[i] = buffer[i + 11 + nBytesFound - 3];
                resultsInBytes2[i] = buffer[i + 15 + nBytesFound - 3];
            }
            results[0] = System.BitConverter.ToSingle(resultsInBytes1, 0);
            results[1] = System.BitConverter.ToSingle(resultsInBytes2, 0);           
            
            return results;
        }

        private byte[] CreateModMsg()
        {
            byte[] modMsg = new byte[] { 0x00, 0x73, 0x00, 0x01 };
            return modMsg;
        }

        private byte[] PackData(byte[] learnMsg)
        {            
            byte[] dataPacked = new byte[learnMsg.Length + 7];

            //Packing form (0x10 (ASCII DLE) - start of msg id or msg data; 0x01 (ASCII SOH) - end of msg id; 0x03 (ASCII ETX) - end of msg data)
            //Packed msg id
            dataPacked[0] = 0x10;
            dataPacked[1] = 0x01;
            dataPacked[2] = learnMsg[0];
            dataPacked[3] = learnMsg[1];
            dataPacked[4] = learnMsg[2];
            dataPacked[5] = 0x10;
            dataPacked[6] = 0x02;

            int i;
            for (i = 4; i < learnMsg.Length; i++)
            {
                dataPacked[i + 3] = learnMsg[i];                
            }            

            //End of msg data
            dataPacked[learnMsg.Length + 3] = 0x10;
            dataPacked[learnMsg.Length + 4] = 0x03;
            
            //Calculate Fletcher's checksum; msgid + msgdata, with checked and doubled bytes (without packing form)   
            //Last two bytes - checksum
            int checksum = CalculateChecksum(learnMsg);
            byte[] checksumBytes = GetHighLowBytes(checksum);
            dataPacked[learnMsg.Length + 5] = checksumBytes[0];
            dataPacked[learnMsg.Length + 6] = checksumBytes[1];

            return dataPacked;
        }

        private int CalculateChecksum(byte[] byteToCalculate)
        {
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xff;

            return checksum;
        }

        private byte[] CheckForDoubles(byte[] data)
        {
            //Number of bytes to be doubled
            int nBytesFound = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 0x10)
                {
                    nBytesFound++;
                }
            }

            //New array with needed length
            byte[] dataDoubled = new byte[data.Length + nBytesFound];

            //Double the needed bytes
            int nTimesDoubled = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != 0x10)
                {
                    dataDoubled[i + nTimesDoubled] = data[i];
                }
                else
                {
                    dataDoubled[i + nTimesDoubled] = 0x10;
                    dataDoubled[i + 1 + nTimesDoubled] = 0x10;
                    nTimesDoubled++;
                }
            }

            return dataDoubled;
        }

        private byte[] GetHighLowBytes(int data)
        {
            byte[] highlow = new byte[2];
            highlow[0] = (byte)(data >> 8);
            highlow[1] = (byte)data;
            return highlow;
        }

        private void WriteToPort(byte[] data)
        {
            //port.Write(data, 0, data.Length);
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine(milliseconds % 100000); 
            Console.Write("TX: ");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 10)
                {
                    Console.Write(data[i] + " ");
                }
                else
                {
                    Console.Write("0" + data[i] + " ");
                }
            }
            Console.WriteLine();
        }



        private byte[] ReadFromPort()
        {
            //Read from port to remove initial response bytes
            int bytes1 = port.BytesToRead;
            byte[] buffer1 = new byte[bytes1];
            port.Read(buffer1, 0, bytes1);
            //SECOND write to Serial Port (request calculated data from the test)

            //Configure Watchpoints
            WriteToPort(new byte[] { 0x00, 0x6C, 0x05 });
            //Poll Watchpoints
            WriteToPort(new byte[] { 0x00, 0x6C, 0x06 });

            //Read from port
            int bytes2 = port.BytesToRead;
            byte[] buffer2 = new byte[bytes2];
            port.Read(buffer2, 0, bytes2);
            return buffer2;
        }

        private void DisableButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = false;
            }
            boxPort.Enabled = false;
        }

        private void EnableButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }
            boxPort.Enabled = true;
        }

        private void ValueColorToBlack(Label value)
        {
            value.BackColor = Color.FromArgb(40, 40, 40);
            value.ForeColor = Color.White;
        }

        private void ValueColorToWhite(Label value)
        {
            value.BackColor = Color.White;
            value.ForeColor = Color.Black;
        }

        public void Delayed(int delay, Action action)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = delay;
            timer.Tick += (s, e) => {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        private void loopTimerEvent(object sender, EventArgs e)
        {
            switch (buttonSwitch)
            {
                case 0:
                    if (nStartPressure_Resistance > 0)
                    {
                        nStartPressure_Resistance--;
                        textStart_Resistance.Text = nStartPressure_Resistance.ToString();
                        ValueColorToBlack(textStart_Resistance);
                        Delayed(200, () => ValueColorToWhite(textStart_Resistance));
                    }
                    return;
                case 1:
                    if (nStartPressure_Resistance < nEndPressure_Resistance - 1)
                    {
                        nStartPressure_Resistance++;
                        textStart_Resistance.Text = nStartPressure_Resistance.ToString();
                        ValueColorToBlack(textStart_Resistance);
                        Delayed(200, () => ValueColorToWhite(textStart_Resistance));
                    }
                    return;
                case 2:
                    if (nEndPressure_Resistance > nStartPressure_Resistance + 1)
                    {
                        nEndPressure_Resistance--;
                        textEnd_Resistance.Text = nEndPressure_Resistance.ToString();
                        ValueColorToBlack(textEnd_Resistance);
                        Delayed(200, () => ValueColorToWhite(textEnd_Resistance));
                    }
                    return;
                case 3:
                    if (nEndPressure_Resistance < 90)
                    {
                        nEndPressure_Resistance++;
                        textEnd_Resistance.Text = nEndPressure_Resistance.ToString();
                        ValueColorToBlack(textEnd_Resistance);
                        Delayed(200, () => ValueColorToWhite(textEnd_Resistance));
                    }

                    return;
                case 4:
                    if (nDuration_Resistance > 1)
                    {
                        nDuration_Resistance--;
                        textDuration_Resistance.Text = nDuration_Resistance.ToString();
                        ValueColorToBlack(textDuration_Resistance);
                        Delayed(200, () => ValueColorToWhite(textDuration_Resistance));
                    }

                    return;
                case 5:
                    if (nDuration_Resistance < 10)
                    {
                        nDuration_Resistance++;
                        textDuration_Resistance.Text = nDuration_Resistance.ToString();
                        ValueColorToBlack(textDuration_Resistance);
                        Delayed(200, () => ValueColorToWhite(textDuration_Resistance));
                    }

                    return;
                case 6:
                    if (nStartPressure_Compliance > 0)
                    {
                        nStartPressure_Compliance--;
                        textStart_Compliance.Text = nStartPressure_Compliance.ToString();
                        ValueColorToBlack(textStart_Compliance);
                        Delayed(200, () => ValueColorToWhite(textStart_Compliance));
                    }
                    return;
                case 7:
                    if (nStartPressure_Compliance < nEndPressure_Compliance - 1)
                    {
                        nStartPressure_Compliance++;
                        textStart_Compliance.Text = nStartPressure_Compliance.ToString();
                        ValueColorToBlack(textStart_Compliance);
                        Delayed(200, () => ValueColorToWhite(textStart_Compliance));

                    }
                    return;
                case 8:
                    if (nEndPressure_Compliance > nStartPressure_Compliance + 1)
                    {
                        nEndPressure_Compliance--;
                        textEnd_Compliance.Text = nEndPressure_Compliance.ToString();
                        ValueColorToBlack(textEnd_Compliance);
                        Delayed(200, () => ValueColorToWhite(textEnd_Compliance));
                    }
                    return;
                case 9:
                    if (nEndPressure_Compliance < 90)
                    {
                        nEndPressure_Compliance++;
                        textEnd_Compliance.Text = nEndPressure_Compliance.ToString();
                        ValueColorToBlack(textEnd_Compliance);
                        Delayed(200, () => ValueColorToWhite(textEnd_Compliance));
                    }
                    return;
                case 10:
                    if (nDuration_Compliance > 1)
                    {
                        nDuration_Compliance--;
                        textDuration_Compliance.Text = nDuration_Compliance.ToString();
                        ValueColorToBlack(textDuration_Compliance);
                        Delayed(200, () => ValueColorToWhite(textDuration_Compliance));

                    }
                    return;
                case 11:
                    if (nDuration_Compliance < 10)
                    {
                        nDuration_Compliance++;
                        textDuration_Compliance.Text = nDuration_Compliance.ToString();
                        ValueColorToBlack(textDuration_Compliance);
                        Delayed(200, () => ValueColorToWhite(textDuration_Compliance));
                    }
                    return;

            }

        }

        private void minusStartPressure_Resistance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 0;
            if (nStartPressure_Resistance > 0)
            {
                nStartPressure_Resistance--;
                textStart_Resistance.Text = nStartPressure_Resistance.ToString();
                ValueColorToBlack(textStart_Resistance);
                Delayed(100, () => ValueColorToWhite(textStart_Resistance));

            }
            loopTimer.Enabled = true;
        }

        private void minusStartPressure_Resistance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void plusStartPressure_Resistance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 1;
            if (nStartPressure_Resistance < nEndPressure_Resistance - 1)
            {
                nStartPressure_Resistance++;
                textStart_Resistance.Text = nStartPressure_Resistance.ToString();
                ValueColorToBlack(textStart_Resistance);
                Delayed(100, () => ValueColorToWhite(textStart_Resistance));

            }
            loopTimer.Enabled = true;
        }

        private void plusStartPressure_Resistance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void minusEndPressure_Resistance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 2;

            if (nEndPressure_Resistance > nStartPressure_Resistance + 1)
            {
                nEndPressure_Resistance--;
                textEnd_Resistance.Text = nEndPressure_Resistance.ToString();
                ValueColorToBlack(textEnd_Resistance);
                Delayed(100, () => ValueColorToWhite(textEnd_Resistance));

            }
            loopTimer.Enabled = true;
        }

        private void minusEndPressure_Resistance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void plusEndPressure_Resistance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 3;
            if (nEndPressure_Resistance < 90)
            {
                nEndPressure_Resistance++;
                textEnd_Resistance.Text = nEndPressure_Resistance.ToString();
                ValueColorToBlack(textEnd_Resistance);
                Delayed(100, () => ValueColorToWhite(textEnd_Resistance));
            }
            loopTimer.Enabled = true;
        }

        private void plusEndPressure_Resistance_Release (object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void minusDurationPressure_Resistance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 4;
            if (nDuration_Resistance > 1)
            {
                nDuration_Resistance--;
                textDuration_Resistance.Text = nDuration_Resistance.ToString();
                ValueColorToBlack(textDuration_Resistance);
                Delayed(100, () => ValueColorToWhite(textDuration_Resistance));

            }
            loopTimer.Enabled = true;
        }

        private void minusDurationPressure_Resistance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void plusDurationPressure_Resistance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 5;
            if (nDuration_Resistance < 10)
            {
                nDuration_Resistance++;
                textDuration_Resistance.Text = nDuration_Resistance.ToString();
                ValueColorToBlack(textDuration_Resistance);
                Delayed(100, () => ValueColorToWhite(textDuration_Resistance));
            }
            loopTimer.Enabled = true;
        }

        private void plusDurationPressure_Resistance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }


        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            port.PortName = boxPort.Text;
        }

        private void minusStartPressure_Compliance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 6;
            if (nStartPressure_Compliance > 0)
            {
                nStartPressure_Compliance--;
                textStart_Compliance.Text = nStartPressure_Compliance.ToString();
                ValueColorToBlack(textStart_Compliance);
                Delayed(100, () => ValueColorToWhite(textStart_Compliance));

            }
            loopTimer.Enabled = true;
        }

        private void minusStartPressure_Compliance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void plusStartPressure_Compliance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 7;
            if (nStartPressure_Compliance < nEndPressure_Compliance - 1)
            {
                nStartPressure_Compliance++;
                textStart_Compliance.Text = nStartPressure_Compliance.ToString();
                ValueColorToBlack(textStart_Compliance);
                Delayed(100, () => ValueColorToWhite(textStart_Compliance));

            }
            loopTimer.Enabled = true;
        }

        private void plusStartPressure_Compliance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void minusEndPressure_Compliance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 8;

            if (nEndPressure_Compliance > nStartPressure_Compliance + 1)
            {
                nEndPressure_Compliance--;
                textEnd_Compliance.Text = nEndPressure_Compliance.ToString();
                ValueColorToBlack(textEnd_Compliance);
                Delayed(100, () => ValueColorToWhite(textEnd_Compliance));

            }
            loopTimer.Enabled = true;
        }

        private void minusEndPressure_Compliance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void plusEndPressure_Compliance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 9;
            if (nEndPressure_Compliance < 90)
            {
                nEndPressure_Compliance++;
                textEnd_Compliance.Text = nEndPressure_Compliance.ToString();
                ValueColorToBlack(textEnd_Compliance);
                Delayed(100, () => ValueColorToWhite(textEnd_Compliance));
            }
            loopTimer.Enabled = true;
        }
        private void plusEndPressure_Compliance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void minusDuration_Compliance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 10;
            if (nDuration_Compliance > 1)
            {
                nDuration_Compliance--;
                textDuration_Compliance.Text = nDuration_Compliance.ToString();
                ValueColorToBlack(textDuration_Compliance);
                Delayed(100, () => ValueColorToWhite(textDuration_Compliance));

            }
            loopTimer.Enabled = true;
        }
        
        private void minusDuration_Compliance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void plusDuration_Compliance_Click(object sender, EventArgs e)
        {
            buttonSwitch = 11;
            if (nDuration_Compliance < 10)
            {
                nDuration_Compliance++;
                textDuration_Compliance.Text = nDuration_Compliance.ToString();
                ValueColorToBlack(textDuration_Compliance);
                Delayed(100, () => ValueColorToWhite(textDuration_Compliance));
            }
        }

        private void plusDuration_Compliance_Release(object sender, EventArgs e)
        {
            loopTimer.Enabled = false;
        }
    }
}
