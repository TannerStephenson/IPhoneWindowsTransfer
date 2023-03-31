using System;
using System.Management;
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
			ContinueBtn.Enabled = false;
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
			var query = "SELECT * FROM Win32_USBControllerDevice WHERE Dependent LIKE '%iPhone%' OR Dependent LIKE '%Portable Devices%'";
			Console.WriteLine("Query: " + query);

			try
			{
				var searcher = new ManagementObjectSearcher(query);
				foreach (var device in searcher.Get())
				{
					var deviceName = (string)device.GetPropertyValue("Dependent");
					if (deviceName.Contains("iPhone"))
					{
						return true;
					}
				}
			}
			catch (ManagementException ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			return false;
		}

	}

}
