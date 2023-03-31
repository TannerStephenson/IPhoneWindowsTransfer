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

namespace IPhoneWindowsTransfer
{
	public partial class PhotoTool : Form
	{
		private bool connected = false;
		public PhotoTool()
		{
			InitializeComponent();
			ContinueBtn.Enabled = connected;
		}

		private void RetryBtn_Click(object sender, EventArgs e)
		{
			if (connected == false) {
				connected = IsIPhoneConnected();
			}
			if (connected == true){
				ContinueBtn.Enabled = true;
				ConnectedDisconnected.Text = "Connected";
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void ContinueBtn_Click(object sender, EventArgs e)
		{
			if (connected == false) {
				ContinueBtn.Enabled = false;
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

	}

}
