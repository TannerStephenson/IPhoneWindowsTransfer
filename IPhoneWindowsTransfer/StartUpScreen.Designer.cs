using System;

namespace IPhoneWindowsTransfer
{
	partial class PhotoTool
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoTool));
            this.RetryBtn = new System.Windows.Forms.Button();
            this.IphonePictureDisconnected = new System.Windows.Forms.PictureBox();
            this.PlsConnect = new System.Windows.Forms.Label();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.ConnectedDisconnected = new System.Windows.Forms.Label();
            this.IphonePictureConnected = new System.Windows.Forms.PictureBox();
            this.TempBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IphonePictureDisconnected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IphonePictureConnected)).BeginInit();
            this.SuspendLayout();
            // 
            // RetryBtn
            // 
            this.RetryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RetryBtn.Location = new System.Drawing.Point(217, 353);
            this.RetryBtn.Name = "RetryBtn";
            this.RetryBtn.Size = new System.Drawing.Size(168, 51);
            this.RetryBtn.TabIndex = 1;
            this.RetryBtn.Text = "Retry";
            this.RetryBtn.UseVisualStyleBackColor = true;
            this.RetryBtn.Click += new System.EventHandler(this.RetryBtn_Click);
            // 
            // IphonePictureDisconnected
            // 
            this.IphonePictureDisconnected.Image = ((System.Drawing.Image)(resources.GetObject("IphonePictureDisconnected.Image")));
            this.IphonePictureDisconnected.Location = new System.Drawing.Point(313, 63);
            this.IphonePictureDisconnected.Name = "IphonePictureDisconnected";
            this.IphonePictureDisconnected.Size = new System.Drawing.Size(168, 268);
            this.IphonePictureDisconnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IphonePictureDisconnected.TabIndex = 2;
            this.IphonePictureDisconnected.TabStop = false;
            // 
            // PlsConnect
            // 
            this.PlsConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PlsConnect.Location = new System.Drawing.Point(174, 29);
            this.PlsConnect.Name = "PlsConnect";
            this.PlsConnect.Size = new System.Drawing.Size(512, 31);
            this.PlsConnect.TabIndex = 3;
            this.PlsConnect.Text = "Please connect your iPhone to your computer";
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ContinueBtn.Location = new System.Drawing.Point(407, 353);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(168, 51);
            this.ContinueBtn.TabIndex = 4;
            this.ContinueBtn.Text = "Continue...";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Status.Location = new System.Drawing.Point(267, 417);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(70, 24);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status: ";
            // 
            // ConnectedDisconnected
            // 
            this.ConnectedDisconnected.AutoSize = true;
            this.ConnectedDisconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ConnectedDisconnected.Location = new System.Drawing.Point(343, 417);
            this.ConnectedDisconnected.Name = "ConnectedDisconnected";
            this.ConnectedDisconnected.Size = new System.Drawing.Size(126, 24);
            this.ConnectedDisconnected.TabIndex = 6;
            this.ConnectedDisconnected.Text = "Disconnected";
            this.ConnectedDisconnected.Click += new System.EventHandler(this.ConnectedDisconnected_Click);
            // 
            // IphonePictureConnected
            // 
            this.IphonePictureConnected.Image = global::IPhoneWindowsTransfer.Properties.Resources.connectedIphone;
            this.IphonePictureConnected.Location = new System.Drawing.Point(313, 63);
            this.IphonePictureConnected.Name = "IphonePictureConnected";
            this.IphonePictureConnected.Size = new System.Drawing.Size(168, 268);
            this.IphonePictureConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IphonePictureConnected.TabIndex = 7;
            this.IphonePictureConnected.TabStop = false;
            // 
            // TempBtn
            // 
            this.TempBtn.Location = new System.Drawing.Point(630, 368);
            this.TempBtn.Name = "TempBtn";
            this.TempBtn.Size = new System.Drawing.Size(75, 23);
            this.TempBtn.TabIndex = 8;
            this.TempBtn.Text = "Temp skip";
            this.TempBtn.UseVisualStyleBackColor = true;
            this.TempBtn.Click += new System.EventHandler(this.TempBtn_Click);
            // 
            // PhotoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TempBtn);
            this.Controls.Add(this.IphonePictureConnected);
            this.Controls.Add(this.ConnectedDisconnected);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.PlsConnect);
            this.Controls.Add(this.IphonePictureDisconnected);
            this.Controls.Add(this.RetryBtn);
            this.Name = "PhotoTool";
            this.Text = "IPhone to Windows Transfer Tool";
            this.Load += new System.EventHandler(this.PhotoTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IphonePictureDisconnected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IphonePictureConnected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void ConnectedDisconnected_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion
		private System.Windows.Forms.Button RetryBtn;
		private System.Windows.Forms.PictureBox IphonePictureDisconnected;
		private System.Windows.Forms.Label PlsConnect;
		private System.Windows.Forms.Button ContinueBtn;
		private System.Windows.Forms.Label Status;
		private System.Windows.Forms.Label ConnectedDisconnected;
		private System.Windows.Forms.PictureBox IphonePictureConnected;
        private System.Windows.Forms.Button TempBtn;
    }
}

