﻿using System;
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




        /* Add radio button for deleting photos when done.
         * Shift current dir to the right-> 
         * Graphic indicating we can only go from Iphone to computer and not vice versa?
         */




		string picturesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

		public IphoneConnected()
		{
			InitializeComponent();
			CurrentPathLabel.Text = picturesFolder;
		}



        private void IphoneConnected_Load(object sender, EventArgs e)
        {
            CurrentDirectoryLoadImgs();
            iPhoneDirectoryLoad();
        }



        //Loading directories here.


        private void iPhoneDirectoryLoad() 
        {
            string iphoneDriveLetter = null;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable && drive.VolumeLabel == "Apple iPhone")
                {
                    iphoneDriveLetter = drive.RootDirectory.FullName;
                    break;
                }
            }



            if (iphoneDriveLetter != null)
            {
                string dcimFolderPath = Path.Combine(iphoneDriveLetter, "DCIM");

                if (!Directory.Exists(dcimFolderPath)) return;

                string[] directories = Directory.GetDirectories(dcimFolderPath);

                // Create a Label control for each directory and add it to the FlowLayoutPanel
                foreach (string directory in directories)
                {
                    Label label = new Label();
                    label.Text = Path.GetFileName(directory);
                    CurrentDirectoryPanel.Controls.Add(label);
                }
            }
            

        }




        private void CurrentDirectoryLoadImgs()
        {

            CurrentDirectoryPanel.Controls.Clear();
            CurrentDirectoryPanel.AutoScroll = true;

            // Get all image files in the specified folder
            string[] imageFiles = Directory.GetFiles(picturesFolder, "*.jpg");
            // Use the array length for the max images to load.

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
