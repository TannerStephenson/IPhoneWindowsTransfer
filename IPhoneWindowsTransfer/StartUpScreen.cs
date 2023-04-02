using System;
using System.Management;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace IPhoneWindowsTransfer
{
	public partial class PhotoTool : Form
	{
		private bool connected = false;
		
		public PhotoTool()
		{
			InitializeComponent();
			ContinueBtn.Enabled = connected;
			IphonePictureConnected.Visible = false;
			ContinueBtn.PerformClick();
		}

		private void RetryBtn_Click(object sender, EventArgs e)
		{
			if (connected == false)
			{
				connected = IsIPhoneConnected();
			}
			if (connected == true)
			{
				ContinueBtn.Enabled = true;
				ConnectedDisconnected.Text = "Connected";
				IphonePictureDisconnected.Visible = false;
				IphonePictureConnected.Visible = true;
			}
		}



		private void ContinueBtn_Click(object sender, EventArgs e)
		{
			if (connected == false)
			{
				ContinueBtn.Enabled = false;
			}
			else
			{
				IphoneConnected newForm = new IphoneConnected();
				newForm.Show();
				this.Hide();
			}
		}

		public bool IsIPhoneConnected()
		{
			bool isIPhoneConnected = false;
			ManagementObjectCollection collection;

			using (var searcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE '%USB\\VID_05AC&PID_12A8%'"))
			collection = searcher.Get();

			foreach (var device in collection)
			{
				var deviceID = (string)device.GetPropertyValue("DeviceID");
				if (deviceID.Contains("USB\\VID_05AC&PID_12A8"))
				{
					isIPhoneConnected = true;
					break;
				}
			}

			return isIPhoneConnected;
		}

		private void PhotoTool_Load(object sender, EventArgs e)
		{

		}

        private void TempBtn_Click(object sender, EventArgs e)
        {
            IphoneConnected newForm = new IphoneConnected();
            newForm.Show();
            this.Hide();
        }
    }

}
