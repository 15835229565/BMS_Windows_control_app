using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Peak.Can.Basic;
using TPCANHandle = System.Byte;

namespace PCANBasicExample
{
    public partial class Form_BMS_Config : Form

    {

        #region Structures
        /// <summary>
        /// Message Status structure used to show CAN Messages
        /// in a ListView
        /// </summary>
        private class MessageStatus
        {
            private TPCANMsg m_Msg;
            private TPCANTimestamp m_TimeStamp;
            private TPCANTimestamp m_oldTimeStamp;
            private int m_iIndex;
            private int m_Count;
            private bool m_bShowPeriod;
            private bool m_bWasChanged;

            public MessageStatus(TPCANMsg canMsg, TPCANTimestamp canTimestamp, int listIndex)
            {
                m_Msg = canMsg;
                m_TimeStamp = canTimestamp;
                m_oldTimeStamp = canTimestamp;
                m_iIndex = listIndex;
                m_Count = 1;
                m_bShowPeriod = true;
                m_bWasChanged = false;
            }

            public void Update(TPCANMsg canMsg, TPCANTimestamp canTimestamp)
            {
                m_Msg = canMsg;
                m_oldTimeStamp = m_TimeStamp;
                m_TimeStamp = canTimestamp;
                m_bWasChanged = true;
                m_Count += 1;
            }

            public TPCANMsg CANMsg
            {
                get { return m_Msg; }
            }

            public TPCANTimestamp Timestamp
            {
                get { return m_TimeStamp; }
            }

            public int Position
            {
                get { return m_iIndex; }
            }

            public string TypeString
            {
                get { return GetMsgTypeString(); }
            }

            public string IdString
            {
                get { return GetIdString(); }
            }

            public string DataString
            {
                get { return GetDataString(); }
            }

            public int Count
            {
                get { return m_Count; }
            }

            public bool ShowingPeriod
            {
                get { return m_bShowPeriod; }
                set
                {
                    if (m_bShowPeriod ^ value)
                    {
                        m_bShowPeriod = value;
                        m_bWasChanged = true;
                    }
                }
            }

            public bool MarkedAsUpdated
            {
                get { return m_bWasChanged; }
                set { m_bWasChanged = value; }
            }

            public string TimeString
            {
                get { return GetTimeString(); }
            }

            private string GetTimeString()
            {
                double fTime;

                fTime = m_TimeStamp.millis + (m_TimeStamp.micros / 1000.0);
                if (m_bShowPeriod)
                    fTime -= (m_oldTimeStamp.millis + (m_oldTimeStamp.micros / 1000.0));
                return fTime.ToString("F1");
            }

            private string GetDataString()
            {
                string strTemp;

                strTemp = "";

                if ((m_Msg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_RTR) == TPCANMessageType.PCAN_MESSAGE_RTR)
                    return "Remote Request";
                else
                    for (int i = 0; i < m_Msg.LEN; i++)
                        strTemp += string.Format("{0:X2} ", m_Msg.DATA[i]);

                return strTemp;
            }

            private string GetIdString()
            {
                // We format the ID of the message and show it
                //
                if ((m_Msg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_EXTENDED) == TPCANMessageType.PCAN_MESSAGE_EXTENDED)
                    return string.Format("{0:X8}h", m_Msg.ID);
                else
                    return string.Format("{0:X3}h", m_Msg.ID);
            }

            private string GetMsgTypeString()
            {
                string strTemp;

                if ((m_Msg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_EXTENDED) == TPCANMessageType.PCAN_MESSAGE_EXTENDED)
                    strTemp = "EXTENDED";
                else
                    strTemp = "STANDARD";

                if ((m_Msg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_RTR) == TPCANMessageType.PCAN_MESSAGE_RTR)
                    strTemp += "/RTR";

                return strTemp;
            }

        }
        #endregion
        #region Delegates
        /// <summary>
        /// Read-Delegate Handler
        /// </summary>
        private delegate void ReadDelegateHandler();
        #endregion

        #region Members
        /// <summary>
        /// Saves the handle of a PCAN hardware
        /// </summary>
        private TPCANHandle m_PcanHandle;
        /// <summary>
        /// Saves the baudrate register for a conenction
        /// </summary>
        //private TPCANBaudrate m_Baudrate;
        /// <summary>
        /// Saves the type of a non-plug-and-play hardware
        /// </summary>
       // private TPCANType m_HwType;
        /// <summary>
        /// Stores the status of received messages for its display
        /// </summary>
        private System.Collections.ArrayList m_LastMsgsList;
        /// <summary>
        /// Read Delegate for calling the function "ReadMessages"
        /// </summary>
        private ReadDelegateHandler m_ReadDelegate;
        /// <summary>
        /// Receive-Event
        /// </summary>
        private System.Threading.AutoResetEvent m_ReceiveEvent;
        /// <summary>
        /// Thread for message reading (using events)
        /// </summary>
        private System.Threading.Thread m_ReadThread;
        /// <summary>
        /// Handles of the current available PCAN-Hardware
        /// </summary>
        

        //gloabal variables
        List<Byte> listOfDetectedBms = new List<Byte>();


        





        private TPCANHandle[] m_HandlesArray;
        #endregion
        #region Help functions
        /// <summary>
        /// Initialization of PCAN-Basic components
        /// </summary>

        private void InitializeBasicComponents()
        {

            // Creates the list for received messages
            //
            m_LastMsgsList = new System.Collections.ArrayList();
            // Creates the delegate used for message reading
            //
            m_ReadDelegate = new ReadDelegateHandler(ReadMessages);

            // Creates the event used for signalize incomming messages 
            //
            m_ReceiveEvent = new System.Threading.AutoResetEvent(false);
            // Creates an array with all possible PCAN-Channels
            //
            m_HandlesArray = new TPCANHandle[] 
            { 
                PCANBasic.PCAN_ISABUS1,
                PCANBasic.PCAN_ISABUS2,
                PCANBasic.PCAN_ISABUS3,
                PCANBasic.PCAN_ISABUS4,
                PCANBasic.PCAN_ISABUS5,
                PCANBasic.PCAN_ISABUS6,
                PCANBasic.PCAN_ISABUS7,
                PCANBasic.PCAN_ISABUS8,
                PCANBasic.PCAN_DNGBUS1,
                PCANBasic.PCAN_PCIBUS1,
                PCANBasic.PCAN_PCIBUS2,
                PCANBasic.PCAN_PCIBUS3,
                PCANBasic.PCAN_PCIBUS4,
                PCANBasic.PCAN_PCIBUS5,
                PCANBasic.PCAN_PCIBUS6,
                PCANBasic.PCAN_PCIBUS7,
                PCANBasic.PCAN_PCIBUS8,
                PCANBasic.PCAN_USBBUS1,
                PCANBasic.PCAN_USBBUS2,
                PCANBasic.PCAN_USBBUS3,
                PCANBasic.PCAN_USBBUS4,
                PCANBasic.PCAN_USBBUS5,
                PCANBasic.PCAN_USBBUS6,
                PCANBasic.PCAN_USBBUS7,
                PCANBasic.PCAN_USBBUS8,
                PCANBasic.PCAN_PCCBUS1,
                PCANBasic.PCAN_PCCBUS2
            };


            // Prepares the PCAN-Basic's debug-Log file
            //
            ConfigureLogFile();
        }

        /// <summary>
        /// Configures the Debug-Log file of PCAN-Basic
        /// </summary>
        private void ConfigureLogFile()
        {
            UInt32 iBuffer;

            // Sets the mask to catch all events
            //
            iBuffer = PCANBasic.LOG_FUNCTION_ALL;

            // Configures the log file. 
            // NOTE: The Log capability is to be used with the NONEBUS Handle. Other handle than this will 
            // cause the function fail.
            //
            PCANBasic.SetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_LOG_CONFIGURE, ref iBuffer, sizeof(UInt32));
        }


        /// <summary>
        /// Help Function used to get an error as text
        /// </summary>
        /// <param name="error">Error code to be translated</param>
        /// <returns>A text with the translated error</returns>
        private string GetFormatedError(TPCANStatus error)
        {
            StringBuilder strTemp;

            // Creates a buffer big enough for a error-text
            //
            strTemp = new StringBuilder(256);
            // Gets the text using the GetErrorText API function
            // If the function success, the translated error is returned. If it fails,
            // a text describing the current error is returned.
            //
            if (PCANBasic.GetErrorText(error, 0, strTemp) != TPCANStatus.PCAN_ERROR_OK)
                return string.Format("An error occurred. Error-code's text ({0:X}) couldn't be retrieved", error);
            else
                return strTemp.ToString();
        }

        /// <summary>
        /// Includes a new line of text into the information Listview
        /// </summary>
        /// <param name="strMsg">Text to be included</param>
        private void IncludeTextMessage(string strMsg)
        {
            lbxInfo.Items.Add(strMsg);
            lbxInfo.SelectedIndex = lbxInfo.Items.Count - 1;
        }

        /// <summary>
        /// Gets the current status of the PCAN-Basic message filter
        /// </summary>
        /// <param name="status">Buffer to retrieve the filter status</param>
        /// <returns>If calling the function was successfull or not</returns>
        private bool GetFilterStatus(out uint status)
        {
            TPCANStatus stsResult;

            // Tries to get the sttaus of the filter for the current connected hardware
            //
            stsResult = PCANBasic.GetValue(m_PcanHandle, TPCANParameter.PCAN_MESSAGE_FILTER, out status, sizeof(UInt32));

            // If it fails, a error message is shown
            //
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
            {
                MessageBox.Show(GetFormatedError(stsResult));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Configures the data of all ComboBox components of the main-form
        /// </summary>

        /// <summary>
        /// Gets the formated text for a CPAN-Basic channel handle
        /// </summary>
        /// <param name="handle">PCAN-Basic Handle to format</param>
        /// <returns>The formatted text for a channel</returns>
        private string FormatChannelName(TPCANHandle handle)
        {
            TPCANDevice devDevice;
            byte byChannel;

            // Gets the owner device and channel for a 
            // PCAN-Basic handle
            //
            devDevice = (TPCANDevice)(handle >> 4);
            byChannel = (byte)(handle & 0xF);

            // Constructs the PCAN-Basic Channel name and return it
            //
            return string.Format("{0} {1} ({2:X2}h)", devDevice, byChannel, handle);
        }
        #endregion
        public Form_BMS_Config()
        {
            InitializeComponent();
            InitializeBasicComponents();
        }

        /// <summary>
        /// Display CAN messages in the Message-ListView
        /// </summary>
        private void DisplayMessages()
        {
            ListViewItem lviCurrentItem;

            lock (m_LastMsgsList.SyncRoot)
            {
                  foreach (MessageStatus msgStatus in m_LastMsgsList)
                  {
                      // Get the data to actualize
                      //
                      if (msgStatus.MarkedAsUpdated)
                      {
                          msgStatus.MarkedAsUpdated = false;
                          lviCurrentItem = lstMessages.Items[msgStatus.Position];

                          lviCurrentItem.SubItems[2].Text = msgStatus.CANMsg.LEN.ToString();
                          lviCurrentItem.SubItems[3].Text = msgStatus.DataString;
                          lviCurrentItem.SubItems[4].Text = msgStatus.Count.ToString();
                          lviCurrentItem.SubItems[5].Text = msgStatus.TimeString;

                         
                      }
                  }
            }
        }
        private void ReadMessages()
        {
            TPCANMsg CANMsg;
            TPCANTimestamp CANTimeStamp;
            TPCANStatus stsResult;

            // We read at least one time the queue looking for messages.
            // If a message is found, we look again trying to find more.
            // If the queue is empty or an error occurr, we get out from
            // the dowhile statement.

           do
            {
                // We execute the "Read" function of the PCANBasic                
                //
                stsResult = PCANBasic.Read(m_PcanHandle, out CANMsg, out CANTimeStamp);

                // A message was received
                // We process the message(s)
                //
                if (stsResult == TPCANStatus.PCAN_ERROR_OK)
                    ProcessMessage(CANMsg, CANTimeStamp);

            } while ((!Convert.ToBoolean(stsResult & TPCANStatus.PCAN_ERROR_QRCVEMPTY)));
            
       

            
        }

        /// <summary>
        /// Inserts a new entry for a new message in the Message-ListView
        /// </summary>
        /// <param name="newMsg">The messasge to be inserted</param>
        /// <param name="timeStamp">The Timesamp of the new message</param>
        private void InsertMsgEntry(TPCANMsg newMsg, TPCANTimestamp timeStamp)
        {
            MessageStatus msgStsCurrentMsg;
            ListViewItem lviCurrentItem;

            lock (m_LastMsgsList.SyncRoot)
            {
                // We add this status in the last message list
                //
                msgStsCurrentMsg = new MessageStatus(newMsg, timeStamp, lstMessages.Items.Count);
                m_LastMsgsList.Add(msgStsCurrentMsg);

                // Add the new ListView Item with the Type of the message
                //	
                lviCurrentItem = lstMessages.Items.Add(msgStsCurrentMsg.TypeString);
                // We set the ID of the message
                //
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.IdString);
                // We set the length of the Message
                //
                lviCurrentItem.SubItems.Add(newMsg.LEN.ToString());
                // We set the data of the message. 	
                //
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.DataString);
                // we set the message count message (this is the First, so count is 1)            
                //
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.Count.ToString());
                // Add time stamp information if needed
                //
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.TimeString);
            }
        }
        /// <summary>
        /// Processes a received message, in order to show it in the Message-ListView
        /// </summary>
        /// <param name="theMsg">The received PCAN-Basic message</param>
        /// <returns>True if the message must be created, false if it must be modified</returns>
        private void ProcessMessage(TPCANMsg theMsg, TPCANTimestamp itsTimeStamp)
        {
            // We search if a message (Same ID and Type) is 
            // already received or if this is a new message
            //
            lock (m_LastMsgsList.SyncRoot)
            {
               
                foreach (MessageStatus msg in m_LastMsgsList)
                {
                    
                    if ((msg.CANMsg.ID == theMsg.ID) && (msg.CANMsg.MSGTYPE == theMsg.MSGTYPE))
                    {
                        //id we need to parse
                        byte[] CanId = BitConverter.GetBytes(msg.CANMsg.ID);
                       byte MasterUnitId =0;
                       if(boxBmsReadId.Text!=""){
                            MasterUnitId = (byte)((Convert.ToUInt16(boxBmsReadId.Text)));
                        }
                       
                        //check if we allready evaluated this BMS ID
                        var pos = listOfDetectedBms.Find(item => item == CanId[1]);
                        if (pos==0)
                        {
                            listOfDetectedBms.Add(CanId[1]);
                        }
                        boxNumberOfPacks.Text = listOfDetectedBms.Count.ToString();
                        boxDetectedPacks.Text ="";
                        foreach(var DetectedBms in listOfDetectedBms)
                        {
                            boxDetectedPacks.Text += DetectedBms.ToString();
                        }
                         



                        //if we are not reading right master remove all the values
                        if (CanId[3] == 0x18 && CanId[1] == MasterUnitId)
                        {
                            //show value group box
                            groupDataFromBms.Visible = true;
                            label23.Visible = false;

                            
                            //PARSE status message
                            if (CanId[0] == 0x10)
                            {
                                byte statusByte0 = msg.CANMsg.DATA[0];
                                byte statusByte1 = msg.CANMsg.DATA[1];
                                byte Temperature1 = msg.CANMsg.DATA[2];
                                byte Temperature2 = msg.CANMsg.DATA[3];
                                byte Temperature3 = msg.CANMsg.DATA[4];
                                byte Temperature4 = msg.CANMsg.DATA[5];

                                boxTemp1.Text = Temperature1.ToString();
                                boxTemp2.Text = Temperature2.ToString();
                                boxTemp3.Text = Temperature3.ToString();
                                boxTemp4.Text = Temperature4.ToString();

                                //invididual cells
                                if (IsBitSet(statusByte0, 6)) boxStatus0b6.BackColor = Color.Green;
                                else boxStatus0b6.BackColor = Color.Red;
                                if (IsBitSet(statusByte0, 0)) boxStatus0b5.BackColor = Color.Green;
                                else boxStatus0b5.BackColor = Color.Red;
                                if (IsBitSet(statusByte0, 1)) boxStatus0b4.BackColor = Color.Green;
                                else boxStatus0b4.BackColor = Color.Red;
                                if (IsBitSet(statusByte0, 2)) boxStatus0b3.BackColor = Color.Green;
                                else boxStatus0b3.BackColor = Color.Red;
                                if (IsBitSet(statusByte0, 3)) boxStatus0b2.BackColor = Color.Green;
                                else boxStatus0b2.BackColor = Color.Red;
                                if (IsBitSet(statusByte0, 4)) boxStatus0b1.BackColor = Color.Green;
                                else boxStatus0b1.BackColor = Color.Red;
                                if (IsBitSet(statusByte0, 5)) boxStatus0b0.BackColor = Color.Green;
                                else boxStatus0b0.BackColor = Color.Red;

                                //master status
                                if (IsBitSet(statusByte1, 0)) boxStatus1b0.BackColor = Color.Green; //all full
                                else boxStatus1b0.BackColor = Color.Gray;
                                if (IsBitSet(statusByte1, 1)) boxStatus1b1.BackColor = Color.Green; //one full
                                else boxStatus1b1.BackColor = Color.Gray;
                                if (IsBitSet(statusByte1, 2)) boxStatus1b2.BackColor = Color.Orange; //empty
                                else boxStatus1b2.BackColor = Color.Gray;
                                if (IsBitSet(statusByte1, 3)) boxStatus1b3.BackColor = Color.Red; //cut-off
                                else boxStatus1b3.BackColor = Color.Gray;
                                if (IsBitSet(statusByte1, 4)) boxStatus1b4.BackColor = Color.Red; //overvoltage
                                else boxStatus1b4.BackColor = Color.Gray;




                            }
                            //voltages
                            if (CanId[0] == 0x11)
                            {
                                
                                textBox0.Text = ((float)msg.CANMsg.DATA[0] / 100 + 2).ToString();
                                if (msg.CANMsg.DATA[0] == 0xff) textBox0.Text = "xxx";
                                textBox1.Text = ((float)msg.CANMsg.DATA[1] / 100 + 2).ToString();
                                if (msg.CANMsg.DATA[1] == 0xff) textBox1.Text = "xxx"; 
                                textBox2.Text = ((float)msg.CANMsg.DATA[2] / 100 + 2).ToString();
                                if (msg.CANMsg.DATA[2] == 0xff) textBox2.Text = "xxx";
                                textBox3.Text = ((float)msg.CANMsg.DATA[3] / 100 + 2).ToString();
                                if (msg.CANMsg.DATA[3] == 0xff) textBox3.Text = "xxx";
                                textBox4.Text = ((float)msg.CANMsg.DATA[4] / 100 + 2).ToString();
                                if (msg.CANMsg.DATA[4] == 0xff) textBox4.Text = "xxx";
                                textBox5.Text = ((float)msg.CANMsg.DATA[5] / 100 + 2).ToString();
                                if (msg.CANMsg.DATA[5] == 0xff) textBox5.Text = "xxx";
                                
                            }

                            //balancing
                            if (CanId[0] == 0x12)
                            {

                                BoxPWM1.Text = msg.CANMsg.DATA[0].ToString();
                                if (msg.CANMsg.DATA[0] > 0) BoxPWM1.BackColor = Color.Green;
                                else BoxPWM1.BackColor = Color.LightGray;
                                BoxPWM2.Text = msg.CANMsg.DATA[1].ToString();
                                if (msg.CANMsg.DATA[1] > 0) BoxPWM2.BackColor = Color.Green;
                                else BoxPWM2.BackColor = Color.LightGray;
                                BoxPWM3.Text = msg.CANMsg.DATA[2].ToString();
                                if (msg.CANMsg.DATA[2] > 0) BoxPWM3.BackColor = Color.Green;
                                else BoxPWM3.BackColor = Color.LightGray;
                                BoxPWM4.Text = msg.CANMsg.DATA[3].ToString();
                                if (msg.CANMsg.DATA[3] > 0) BoxPWM4.BackColor = Color.Green;
                                else BoxPWM4.BackColor = Color.LightGray;
                                BoxPWM5.Text = msg.CANMsg.DATA[4].ToString();
                                if (msg.CANMsg.DATA[4] > 0) BoxPWM5.BackColor = Color.Green;
                                else BoxPWM5.BackColor = Color.LightGray;
                                BoxPWM6.Text = msg.CANMsg.DATA[5].ToString();
                                if (msg.CANMsg.DATA[5] > 0) BoxPWM6.BackColor = Color.Green;
                                else BoxPWM6.BackColor = Color.LightGray;


                            }
                            //Max voltage
                            if (CanId[0] == 0x13)
                            {
                                boxMaxV1.Text = ((float)msg.CANMsg.DATA[0] / 100 + 2).ToString();
                                boxMaxV2.Text = ((float)msg.CANMsg.DATA[1] / 100 + 2).ToString();
                                boxMaxV3.Text = ((float)msg.CANMsg.DATA[2] / 100 + 2).ToString();
                                boxMaxV4.Text = ((float)msg.CANMsg.DATA[3] / 100 + 2).ToString();
                                boxMaxV5.Text = ((float)msg.CANMsg.DATA[4] / 100 + 2).ToString();
                                boxMaxV6.Text = ((float)msg.CANMsg.DATA[5] / 100 + 2).ToString();
                            }
                            //Min voltage
                            if (CanId[0] == 0x14)
                            {
                                boxMinV1.Text = ((float)msg.CANMsg.DATA[0] / 100 + 2).ToString();
                                boxMinV2.Text = ((float)msg.CANMsg.DATA[1] / 100 + 2).ToString();
                                boxMinV3.Text = ((float)msg.CANMsg.DATA[2] / 100 + 2).ToString();
                                boxMinV4.Text = ((float)msg.CANMsg.DATA[3] / 100 + 2).ToString();
                                boxMinV5.Text = ((float)msg.CANMsg.DATA[4] / 100 + 2).ToString();
                                boxMinV6.Text = ((float)msg.CANMsg.DATA[5] / 100 + 2).ToString();
                            }
                            //Max balancing (PWM)
                            if (CanId[0] == 0x15)
                            {
                                boxMaxPwm1.Text = msg.CANMsg.DATA[0].ToString();
                                boxMaxPwm2.Text = msg.CANMsg.DATA[1].ToString();
                                boxMaxPwm3.Text = msg.CANMsg.DATA[2].ToString();
                                boxMaxPwm4.Text = msg.CANMsg.DATA[3].ToString();
                                boxMaxPwm5.Text = msg.CANMsg.DATA[4].ToString();
                                boxMaxPwm6.Text = msg.CANMsg.DATA[5].ToString();
                            }
                            


                        }
                        else{

                            groupDataFromBms.Visible = false;
                            label23.Visible = true;
                           
                        }
                        // Modify the message and exit
                        //
                        msg.Update(theMsg, itsTimeStamp);
                        return;
                    }
                }
                // Message not found. It will created
                //
                InsertMsgEntry(theMsg, itsTimeStamp);
            }
        }  


        /// <summary>
        /// Configures the PCAN-Trace file for a PCAN-Basic Channel
        /// </summary>
        private void ConfigureTraceFile()
        {
            UInt32 iBuffer;
            TPCANStatus stsResult;

            // Configure the maximum size of a trace file to 5 megabytes
            //
            iBuffer = 5;
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_TRACE_SIZE, ref iBuffer, sizeof(UInt32));
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                IncludeTextMessage(GetFormatedError(stsResult));

            // Configure the way how trace files are created: 
            // * Standard name is used
            // * Existing file is ovewritten, 
            // * Only one file is created.
            // * Recording stopts when the file size reaches 5 megabytes.
            //
            iBuffer = PCANBasic.TRACE_FILE_SINGLE | PCANBasic.TRACE_FILE_OVERWRITE;
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_TRACE_CONFIGURE, ref iBuffer, sizeof(UInt32));
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                IncludeTextMessage(GetFormatedError(stsResult));
        }





        /*
        The handle of a PCAN Channel (see TPCANHandle).  
        Btr0Btr1  The speed for the communication (BTR0BTR1 code).  
        HwType  The type of hardware and operation mode (see TPCANMode).  
        IOPort  The I/O address for the parallel port.  
        Interrupt  Interrupt number of the parallel port 
        */
        public void Btn_connectCAN_Click(object sender, EventArgs e)
        {

            TPCANStatus stsResult;

       
            //CAN/LIN0 
            m_PcanHandle = Convert.ToByte("51", 16);
            stsResult = PCANBasic.Initialize(
                    m_PcanHandle,
                    TPCANBaudrate.PCAN_BAUD_250K);
            //250kbs
            /*if(appCANbaudrate.SelectedIndex==0){
                stsResult = PCANBasic.Initialize(
                         m_PcanHandle,
                         TPCANBaudrate.PCAN_BAUD_250K);
            }else {
                stsResult = PCANBasic.Initialize(
                         m_PcanHandle,
                         TPCANBaudrate.PCAN_BAUD_500K);
           
            }*/
                 
            
      
      


           if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                MessageBox.Show(GetFormatedError(stsResult));
            else
                // Prepares the PCAN-Basic's PCAN-Trace file
                //
                //ConfigureTraceFile();
                // Display messages in grid
                //
                tmrDisplay.Enabled = true;
                tmrRead.Enabled = true;
                btnSaveSettings.Enabled = true;
                btnReleseCAN.Enabled = true;
                Btn_connectCAN.Enabled = false;
                boxBmsReadId.Enabled = true;

                IncludeTextMessage("CAN connected");
            // Sets the connection status of the main-form
            //
            //SetConnectionStatus(stsResult == TPCANStatus.PCAN_ERROR_OK);
             
        }

        private void tmrDisplay_Tick(object sender, EventArgs e)
        {
            DisplayMessages();
        }


        private void tmrRead_Tick(object sender, EventArgs e)
        {
            // Checks if in the receive-queue are currently messages for read
            // 
            ReadMessages();
        }

        
        public void btnReleseCAN_Click(object sender, EventArgs e)
        {
            // Releases a current connected PCAN-Basic channel
            //
            PCANBasic.Uninitialize(m_PcanHandle);
            tmrRead.Enabled = false;

            
            if (m_ReadThread != null)
            {
                m_ReadThread.Abort();
                m_ReadThread.Join();
                m_ReadThread = null;
            }
            btnSaveSettings.Enabled = false;
            btnReleseCAN.Enabled = false;
            boxBmsReadId.Enabled = false;
            Btn_connectCAN.Enabled = true;
            

            // Sets the connection status of the main-form
            //
            // SetConnectionStatus(false);
        }




        private void tmrAccuSend_Tick(object sender, EventArgs e)
        {
            //we are only sending messages if button "connect CAN" is pressed (disabled)
            //if(Btn_connectCAN.Enabled==false) SendMessages();

        }


      


       
        


     
        bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }
        int SetBit(byte b, int pos)
        {
            return b|(1 << pos);
        }
        
        int UnsetBit(int value, int index)
        {
            return value & ~(1 << index);
        }

     

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

            TPCANMsg CANMsg;
            TPCANStatus stsResult;
            CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];


            //get ID from BOX
            byte MasterUnitId,NewMasterId = 0;
            try
            {
                MasterUnitId = (byte)((Convert.ToUInt16(MasterID.Text)));
                NewMasterId = (byte)((Convert.ToUInt16(boxNewMasterId.Text)));
                
            }
            catch {
                MessageBox.Show("Wrong ID. Please fill in value 1-255");
                return;
            }


            //construct can ID
            byte[] bytes={0x18,0x00,MasterUnitId,0x00};
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            uint id = BitConverter.ToUInt32(bytes, 0);
            // If the system architecture is little-endian (that is, little end first), 
            // reverse the byte array. 




            //////////////////////////////////////////// 
            //create and send settings message
            ////////////////////////////////////////////
            //Max avaliable current we read from textbox  -boxAvailCurrent
            
            CANMsg.ID = id;
            CANMsg.LEN =8;
            CANMsg.MSGTYPE = (TPCANMessageType.PCAN_MESSAGE_EXTENDED);
            CANMsg.DATA[0] = 0;  //CAN adress Hi
            CANMsg.DATA[1] = 0; //CAN address LO
            CANMsg.DATA[2] = (byte)boxBaudRate.SelectedIndex; //baudrate
            CANMsg.DATA[3] = NewMasterId; //ID
            CANMsg.DATA[4] = 0;
            CANMsg.DATA[5] = 0; 
            CANMsg.DATA[6] = 0;
            CANMsg.DATA[7] = 0;
            stsResult = PCANBasic.Write(m_PcanHandle, ref CANMsg);
            // The message was successfully sent
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                MessageBox.Show(GetFormatedError(stsResult));



        }

        private void Form_BMS_Load(object sender, EventArgs e)
        {
            boxBaudRate.SelectedIndex = 0;
        }








    }
}
