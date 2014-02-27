using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FTDIChipList
{
    public partial class FTDIDevices : Form
    {
        public FTDIDevices()
        {
            InitializeComponent();
            PopulateDeviceList();
        }


        private void PopulateDeviceList()
        {
            DeviceList.Rows.Clear();
            DeviceList.ClearSelection();
            CopyToClipboardButton.Enabled = false;

            FTDI F = new FTDI();

            FTDI.FT_STATUS State = FTDI.FT_STATUS.FT_OK;

            uint DeviceCount = 0;

            State = F.GetNumberOfDevices(ref DeviceCount);
            if (State == FTDI.FT_STATUS.FT_OK)
            {
                if (DeviceCount > 0)
                {
                    FTDI.FT_DEVICE_INFO_NODE[] Devicelist = new FTDI.FT_DEVICE_INFO_NODE[DeviceCount];

                    State = F.GetDeviceList(Devicelist);
                    if (State == FTDI.FT_STATUS.FT_OK)
                    {


                        DeviceList.Rows.Clear();
                        foreach (FTDI.FT_DEVICE_INFO_NODE D in Devicelist)
                        {
                            int RowIndex = DeviceList.Rows.Add();
                            DeviceList.Rows[RowIndex].Tag = D;
                            DeviceList.Rows[RowIndex].Cells[DeviceListType.Name].Value = (D.Type == FTDI.FT_DEVICE.FT_DEVICE_232R ? "FT245R or FT232R" : D.Type.ToString());
                            DeviceList.Rows[RowIndex].Cells[DeviceListDescription.Name].Value = D.Description;
                            DeviceList.Rows[RowIndex].Cells[DeviceListSerial.Name].Value = D.SerialNumber;
                        }

                        CopyToClipboardButton.Enabled = true;

                    }
                    else
                    {
                        //Error when fetching device list
                        MessageBox.Show(this, "Could not fetch the list of connected devices", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //No devices found
                    MessageBox.Show(this, "No matching USB devices found", "No devices found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //Error when getting count of devices
                MessageBox.Show(this, "Could not get number of connected devices", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DeviceList.Rows.Clear();
            DeviceList.ClearSelection();
            this.Refresh();

            FTDI F = new FTDI();
            F.Rescan();

            F = null;

            PopulateDeviceList();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (DeviceList.SelectedRows.Count > 0)
            {
                string S = DeviceList.SelectedRows[0].Cells[DeviceListSerial.Name].Value.ToString();

                int RetryCnt = 0;
                bool Done = false;
                string ExceptionMsg = "";
                while (!Done && RetryCnt<5)
                {
                    try
                    {
                        System.Windows.Forms.Clipboard.SetText(S);
                        Done = true;
                        
                    }
                    catch (Exception E)
                    {
                        ExceptionMsg = E.Message;
                        RetryCnt++;
                        System.Threading.Thread.Sleep(300);
                    }

                }


                if (!Done)
                {
                    string Msg = string.Format("Could not copy the serial to the clipboard.\n\nThe following exception occured:\n{0}", ExceptionMsg);

                    string WindowText = getOpenClipboardWindowText();
                    if (!string.IsNullOrWhiteSpace(WindowText))
                    {
                        Msg += string.Format("\n\nClipboard is currently open for: {0}", WindowText);
                    }

                    MessageBox.Show(this, Msg, "Copy to clipboard failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(this, string.Format("Copied {0} to clipboard.", S), "Serial copied to clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("You must select a device before copying to serial to the clipboard.", "Select device");
            }
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetOpenClipboardWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(int hwnd, StringBuilder text, int count);

        private string getOpenClipboardWindowText()
        {
            IntPtr hwnd = GetOpenClipboardWindow();
            if (hwnd != IntPtr.Zero)
            {
                StringBuilder sb = new StringBuilder(501);
                GetWindowText(hwnd.ToInt32(), sb, 500);
                return sb.ToString();
                // example:
                // skype_plugin_core_proxy_window: 02490E80
            }
            else
            {
                return null;
            }
        }

    }
}
