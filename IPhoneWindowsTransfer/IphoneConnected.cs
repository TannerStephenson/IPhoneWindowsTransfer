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




        //Add later radio button for deleting photos when done.




		string picturesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

		public IphoneConnected()
		{
			InitializeComponent();
			CurrentPathLabel.Text = picturesFolder;
		}



        private void IphoneConnected_Load(object sender, EventArgs e)
        {
            CurrentDirectoryLoadImgs();
        }

        private void CurrentDirectoryLoadImgs()
        {

            CurrentDirectoryPanel.Controls.Clear();
            CurrentDirectoryPanel.AutoScroll = true;

            // Get all image files in the specified folder
            string[] imageFiles = Directory.GetFiles(picturesFolder, "*.jpg");

            int maxImagesToLoad = 20;
            int numLoaded = 0;

            // Create a PictureBox control for each image file and add it to the FlowLayoutPanel
            foreach (string imageFile in imageFiles)
            {
                if (numLoaded >= maxImagesToLoad)
                {
                    break;
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                using (var stream = new MemoryStream(File.ReadAllBytes(imageFile)))
                {
                    pictureBox.Image = Image.FromStream(stream);
                }
                CurrentDirectoryPanel.Controls.Add(pictureBox);

                numLoaded++;
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
                CurrentDirectoryLoadImgs();
            }
        }
	}
}
