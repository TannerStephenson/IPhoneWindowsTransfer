using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPhoneWindowsTransfer
{
	public partial class IphoneConnected : Form
	{
		string picturesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

		public IphoneConnected()
		{
			InitializeComponent();
			CurrentPathLabel.Text = picturesFolder;
		}

		private void IphoneConnected_Load(object sender, EventArgs e)
		{
			// Find the iPhone connected to the computer
			var searcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE '%USB\\VID_05AC&PID_12A8%'");
			ManagementObjectCollection collection = searcher.Get();

			string deviceId = "";
			foreach (var device in collection)
			{
				deviceId = (string)device.GetPropertyValue("DeviceID");
				if (deviceId.Contains("iPhone"))
					break;
				else
					deviceId = "";
			}

			if (deviceId != "")
			{
				// Get the photos from the iPhone
				var di = new DirectoryInfo(deviceId + "\\Internal Storage\\DCIM\\");
				var folders = di.GetDirectories("*.apple");
				List<string> photos = new List<string>();
				foreach (var folder in folders)
				{
					var files = folder.GetFiles("*.jpg");
					foreach (var file in files)
					{
						photos.Add(file.FullName);
					}
				}

				// Display the photos in a PictureBox control
				foreach (var photo in photos)
				{
					var pb = new PictureBox();
					pb.SizeMode = PictureBoxSizeMode.Zoom;
					pb.Image = Image.FromFile(photo);
					IphoneDisplay.Controls.Add(pb);
				}
			}
			else
			{
				MessageBox.Show("No iPhone found.");
			}
		}

		private void ChangeFolderBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
			DialogResult result = folderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				CurrentPathLabel.Text = folderBrowserDialog.SelectedPath;
				picturesFolder = CurrentPathLabel.Text;
			}

		}
	}
}
